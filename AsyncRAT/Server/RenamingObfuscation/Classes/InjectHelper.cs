using System;
using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x02000036 RID: 54
	public static class InjectHelper
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x0001B278 File Offset: 0x00019478
		private static TypeDefUser Clone(TypeDef origin)
		{
			TypeDefUser typeDefUser = new TypeDefUser(origin.Namespace, origin.Name);
			typeDefUser.Attributes = origin.Attributes;
			if (origin.ClassLayout != null)
			{
				typeDefUser.ClassLayout = new ClassLayoutUser(origin.ClassLayout.PackingSize, origin.ClassSize);
			}
			foreach (GenericParam genericParam in origin.GenericParameters)
			{
				typeDefUser.GenericParameters.Add(new GenericParamUser(genericParam.Number, genericParam.Flags, "-"));
			}
			return typeDefUser;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0001B328 File Offset: 0x00019528
		private static MethodDefUser Clone(MethodDef origin)
		{
			MethodDefUser methodDefUser = new MethodDefUser(origin.Name, null, origin.ImplAttributes, origin.Attributes);
			foreach (GenericParam genericParam in origin.GenericParameters)
			{
				methodDefUser.GenericParameters.Add(new GenericParamUser(genericParam.Number, genericParam.Flags, "-"));
			}
			return methodDefUser;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000029B1 File Offset: 0x00000BB1
		private static FieldDefUser Clone(FieldDef origin)
		{
			return new FieldDefUser(origin.Name, null, origin.Attributes);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0001B3B0 File Offset: 0x000195B0
		private static TypeDef PopulateContext(TypeDef typeDef, InjectHelper.InjectContext ctx)
		{
			IDnlibDef dnlibDef;
			TypeDef typeDef2;
			if (!ctx.Map.TryGetValue(typeDef, out dnlibDef))
			{
				typeDef2 = InjectHelper.Clone(typeDef);
				ctx.Map[typeDef] = typeDef2;
			}
			else
			{
				typeDef2 = (TypeDef)dnlibDef;
			}
			foreach (TypeDef typeDef3 in typeDef.NestedTypes)
			{
				typeDef2.NestedTypes.Add(InjectHelper.PopulateContext(typeDef3, ctx));
			}
			foreach (MethodDef methodDef in typeDef.Methods)
			{
				typeDef2.Methods.Add((MethodDef)(ctx.Map[methodDef] = InjectHelper.Clone(methodDef)));
			}
			foreach (FieldDef fieldDef in typeDef.Fields)
			{
				typeDef2.Fields.Add((FieldDef)(ctx.Map[fieldDef] = InjectHelper.Clone(fieldDef)));
			}
			return typeDef2;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0001B504 File Offset: 0x00019704
		private static void CopyTypeDef(TypeDef typeDef, InjectHelper.InjectContext ctx)
		{
			TypeDef typeDef2 = (TypeDef)ctx.Map[typeDef];
			typeDef2.BaseType = ctx.Importer.Import(typeDef.BaseType);
			foreach (InterfaceImpl interfaceImpl in typeDef.Interfaces)
			{
				typeDef2.Interfaces.Add(new InterfaceImplUser(ctx.Importer.Import(interfaceImpl.Interface)));
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0001B59C File Offset: 0x0001979C
		private static void CopyMethodDef(MethodDef methodDef, InjectHelper.InjectContext ctx)
		{
			MethodDef methodDef2 = (MethodDef)ctx.Map[methodDef];
			methodDef2.Signature = ctx.Importer.Import(methodDef.Signature);
			methodDef2.Parameters.UpdateParameterTypes();
			if (methodDef.ImplMap != null)
			{
				methodDef2.ImplMap = new ImplMapUser(new ModuleRefUser(ctx.TargetModule, methodDef.ImplMap.Module.Name), methodDef.ImplMap.Name, methodDef.ImplMap.Attributes);
			}
			foreach (CustomAttribute customAttribute in methodDef.CustomAttributes)
			{
				methodDef2.CustomAttributes.Add(new CustomAttribute((ICustomAttributeType)ctx.Importer.Import(customAttribute.Constructor)));
			}
			if (methodDef.HasBody)
			{
				methodDef2.Body = new CilBody(methodDef.Body.InitLocals, new List<Instruction>(), new List<ExceptionHandler>(), new List<Local>());
				methodDef2.Body.MaxStack = methodDef.Body.MaxStack;
				Dictionary<object, object> bodyMap = new Dictionary<object, object>();
				foreach (Local local in methodDef.Body.Variables)
				{
					Local local2 = new Local(ctx.Importer.Import(local.Type));
					methodDef2.Body.Variables.Add(local2);
					local2.Name = local.Name;
					bodyMap[local] = local2;
				}
				foreach (Instruction instruction in methodDef.Body.Instructions)
				{
					Instruction instruction2 = new Instruction(instruction.OpCode, instruction.Operand);
					instruction2.SequencePoint = instruction.SequencePoint;
					if (instruction2.Operand is IType)
					{
						instruction2.Operand = ctx.Importer.Import((IType)instruction2.Operand);
					}
					else if (instruction2.Operand is IMethod)
					{
						instruction2.Operand = ctx.Importer.Import((IMethod)instruction2.Operand);
					}
					else if (instruction2.Operand is IField)
					{
						instruction2.Operand = ctx.Importer.Import((IField)instruction2.Operand);
					}
					methodDef2.Body.Instructions.Add(instruction2);
					bodyMap[instruction] = instruction2;
				}
				//Func<Instruction, Instruction> <>9__0;
				foreach (Instruction instruction3 in methodDef2.Body.Instructions)
				{
					if (instruction3.Operand != null && bodyMap.ContainsKey(instruction3.Operand))
					{
						instruction3.Operand = bodyMap[instruction3.Operand];
					}
					else if (instruction3.Operand is Instruction[])
					{
						Instruction instruction4 = instruction3;
						IEnumerable<Instruction> source = (Instruction[])instruction3.Operand;
						Func<Instruction, Instruction> selector;
						//if ((selector = <>9__0) == null)
						//{
						//	selector = (<>9__0 = ((Instruction target) => (Instruction)bodyMap[target]));
						//}
						//instruction4.Operand = source.Select(selector).ToArray<Instruction>();
					}
				}
				foreach (ExceptionHandler exceptionHandler in methodDef.Body.ExceptionHandlers)
				{
					methodDef2.Body.ExceptionHandlers.Add(new ExceptionHandler(exceptionHandler.HandlerType)
					{
						CatchType = ((exceptionHandler.CatchType == null) ? null : ctx.Importer.Import(exceptionHandler.CatchType)),
						TryStart = (Instruction)bodyMap[exceptionHandler.TryStart],
						TryEnd = (Instruction)bodyMap[exceptionHandler.TryEnd],
						HandlerStart = (Instruction)bodyMap[exceptionHandler.HandlerStart],
						HandlerEnd = (Instruction)bodyMap[exceptionHandler.HandlerEnd],
						FilterStart = ((exceptionHandler.FilterStart == null) ? null : ((Instruction)bodyMap[exceptionHandler.FilterStart]))
					});
				}
				methodDef2.Body.SimplifyMacros(methodDef2.Parameters);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0001BADC File Offset: 0x00019CDC
		private static void CopyFieldDef(FieldDef fieldDef, InjectHelper.InjectContext ctx)
		{
			((FieldDef)ctx.Map[fieldDef]).Signature = ctx.Importer.Import(fieldDef.Signature);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0001BB14 File Offset: 0x00019D14
		private static void Copy(TypeDef typeDef, InjectHelper.InjectContext ctx, bool copySelf)
		{
			if (copySelf)
			{
				InjectHelper.CopyTypeDef(typeDef, ctx);
			}
			foreach (TypeDef typeDef2 in typeDef.NestedTypes)
			{
				InjectHelper.Copy(typeDef2, ctx, true);
			}
			foreach (MethodDef methodDef in typeDef.Methods)
			{
				InjectHelper.CopyMethodDef(methodDef, ctx);
			}
			foreach (FieldDef fieldDef in typeDef.Fields)
			{
				InjectHelper.CopyFieldDef(fieldDef, ctx);
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0001BBE4 File Offset: 0x00019DE4
		public static TypeDef Inject(TypeDef typeDef, ModuleDef target)
		{
			InjectHelper.InjectContext injectContext = new InjectHelper.InjectContext(typeDef.Module, target);
			InjectHelper.PopulateContext(typeDef, injectContext);
			InjectHelper.Copy(typeDef, injectContext, true);
			return (TypeDef)injectContext.Map[typeDef];
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0001BC20 File Offset: 0x00019E20
		public static MethodDef Inject(MethodDef methodDef, ModuleDef target)
		{
			InjectHelper.InjectContext injectContext = new InjectHelper.InjectContext(methodDef.Module, target);
			injectContext.Map[methodDef] = InjectHelper.Clone(methodDef);
			InjectHelper.CopyMethodDef(methodDef, injectContext);
			return (MethodDef)injectContext.Map[methodDef];
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0001BC64 File Offset: 0x00019E64
		public static IEnumerable<IDnlibDef> Inject(TypeDef typeDef, TypeDef newType, ModuleDef target)
		{
			InjectHelper.InjectContext injectContext = new InjectHelper.InjectContext(typeDef.Module, target);
			injectContext.Map[typeDef] = newType;
			InjectHelper.PopulateContext(typeDef, injectContext);
			InjectHelper.Copy(typeDef, injectContext, false);
			return injectContext.Map.Values.Except(new TypeDef[]
			{
				newType
			});
		}

		// Token: 0x02000037 RID: 55
		public class ImportResolver
		{
			// Token: 0x060001C1 RID: 449 RVA: 0x000029C5 File Offset: 0x00000BC5
			public virtual TypeDef Resolve(TypeDef typeDef)
			{
				return null;
			}

			// Token: 0x060001C2 RID: 450 RVA: 0x000029C5 File Offset: 0x00000BC5
			public virtual MethodDef Resolve(MethodDef methodDef)
			{
				return null;
			}

			// Token: 0x060001C3 RID: 451 RVA: 0x000029C5 File Offset: 0x00000BC5
			public virtual FieldDef Resolve(FieldDef fieldDef)
			{
				return null;
			}
		}

		// Token: 0x02000038 RID: 56
		private class InjectContext : InjectHelper.ImportResolver
		{
			// Token: 0x060001C5 RID: 453 RVA: 0x000029C8 File Offset: 0x00000BC8
			public InjectContext(ModuleDef module, ModuleDef target)
			{
				this.OriginModule = module;
				this.TargetModule = target;
				this.importer = new Importer(target, ImporterOptions.TryToUseTypeDefs);
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060001C6 RID: 454 RVA: 0x000029F6 File Offset: 0x00000BF6
			public Importer Importer
			{
				get
				{
					return this.importer;
				}
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x000029FE File Offset: 0x00000BFE
			public override TypeDef Resolve(TypeDef typeDef)
			{
				if (this.Map.ContainsKey(typeDef))
				{
					return (TypeDef)this.Map[typeDef];
				}
				return null;
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x00002A21 File Offset: 0x00000C21
			public override MethodDef Resolve(MethodDef methodDef)
			{
				if (this.Map.ContainsKey(methodDef))
				{
					return (MethodDef)this.Map[methodDef];
				}
				return null;
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x00002A44 File Offset: 0x00000C44
			public override FieldDef Resolve(FieldDef fieldDef)
			{
				if (this.Map.ContainsKey(fieldDef))
				{
					return (FieldDef)this.Map[fieldDef];
				}
				return null;
			}

			// Token: 0x0400017E RID: 382
			public readonly Dictionary<IDnlibDef, IDnlibDef> Map = new Dictionary<IDnlibDef, IDnlibDef>();

			// Token: 0x0400017F RID: 383
			public readonly ModuleDef OriginModule;

			// Token: 0x04000180 RID: 384
			public readonly ModuleDef TargetModule;

			// Token: 0x04000181 RID: 385
			private readonly Importer importer;
		}
	}
}
