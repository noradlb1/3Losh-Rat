using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server.Algorithm;

namespace Server.MessagePack
{
	// Token: 0x02000043 RID: 67
	public class MsgPack : IEnumerable
	{
		// Token: 0x06000277 RID: 631 RVA: 0x000037A7 File Offset: 0x000019A7
		private void SetName(string value)
		{
			this.name = value;
			this.lowerName = this.name.ToLower();
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0001C2E4 File Offset: 0x0001A4E4
		private void Clear()
		{
			for (int i = 0; i < this.children.Count; i++)
			{
				this.children[i].Clear();
			}
			this.children.Clear();
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0001C324 File Offset: 0x0001A524
		private MsgPack InnerAdd()
		{
			MsgPack msgPack = new MsgPack();
			msgPack.parent = this;
			this.children.Add(msgPack);
			return msgPack;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0001C34C File Offset: 0x0001A54C
		private int IndexOf(string name)
		{
			int num = -1;
			int result = -1;
			string text = name.ToLower();
			foreach (MsgPack msgPack in this.children)
			{
				num++;
				if (text.Equals(msgPack.lowerName))
				{
					result = num;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0001C3C0 File Offset: 0x0001A5C0
		public MsgPack FindObject(string name)
		{
			int num = this.IndexOf(name);
			if (num == -1)
			{
				return null;
			}
			return this.children[num];
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000037C1 File Offset: 0x000019C1
		private MsgPack InnerAddMapChild()
		{
			if (this.valueType != MsgPackType.Map)
			{
				this.Clear();
				this.valueType = MsgPackType.Map;
			}
			return this.InnerAdd();
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000037DF File Offset: 0x000019DF
		private MsgPack InnerAddArrayChild()
		{
			if (this.valueType != MsgPackType.Array)
			{
				this.Clear();
				this.valueType = MsgPackType.Array;
			}
			return this.InnerAdd();
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000037FD File Offset: 0x000019FD
		public MsgPack AddArrayChild()
		{
			return this.InnerAddArrayChild();
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0001C3E8 File Offset: 0x0001A5E8
		private void WriteMap(Stream ms)
		{
			int count = this.children.Count;
			if (count <= 15)
			{
				//byte value = 128 + (byte)count;
				//ms.WriteByte(value);
			}
			else if (count <= 65535)
			{
				ms.WriteByte(222);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes((short)count));
				ms.Write(array, 0, array.Length);
			}
			else
			{
				ms.WriteByte(223);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes(count));
				ms.Write(array, 0, array.Length);
			}
			for (int i = 0; i < count; i++)
			{
				WriteTools.WriteString(ms, this.children[i].name);
				this.children[i].Encode2Stream(ms);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0001C4AC File Offset: 0x0001A6AC
		private void WirteArray(Stream ms)
		{
			int count = this.children.Count;
			if (count <= 15)
			{
				//byte value = 144 + (byte)count;
				//ms.WriteByte(value);
			}
			else if (count <= 65535)
			{
				ms.WriteByte(220);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes((short)count));
				ms.Write(array, 0, array.Length);
			}
			else
			{
				ms.WriteByte(221);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes(count));
				ms.Write(array, 0, array.Length);
			}
			for (int i = 0; i < count; i++)
			{
				this.children[i].Encode2Stream(ms);
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00003805 File Offset: 0x00001A05
		public void SetAsInteger(long value)
		{
			this.innerValue = value;
			this.valueType = MsgPackType.Integer;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000381A File Offset: 0x00001A1A
		public void method_0(ulong value)
		{
			this.innerValue = value;
			this.valueType = MsgPackType.UInt64;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0001C558 File Offset: 0x0001A758
		public ulong method_1()
		{
			switch (this.valueType)
			{
			case MsgPackType.String:
				return ulong.Parse(this.innerValue.ToString().Trim());
			case MsgPackType.Integer:
				return Convert.ToUInt64((long)this.innerValue);
			case MsgPackType.UInt64:
				return (ulong)this.innerValue;
			case MsgPackType.Float:
				return Convert.ToUInt64((double)this.innerValue);
			case MsgPackType.Single:
				return Convert.ToUInt64((float)this.innerValue);
			case MsgPackType.DateTime:
				return Convert.ToUInt64((DateTime)this.innerValue);
			}
			return 0UL;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0001C604 File Offset: 0x0001A804
		public long GetAsInteger()
		{
			switch (this.valueType)
			{
			case MsgPackType.String:
				return long.Parse(this.innerValue.ToString().Trim());
			case MsgPackType.Integer:
				return (long)this.innerValue;
			case MsgPackType.UInt64:
				return Convert.ToInt64((long)this.innerValue);
			case MsgPackType.Float:
				return Convert.ToInt64((double)this.innerValue);
			case MsgPackType.Single:
				return Convert.ToInt64((float)this.innerValue);
			case MsgPackType.DateTime:
				return Convert.ToInt64((DateTime)this.innerValue);
			}
			return 0L;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0001C6B0 File Offset: 0x0001A8B0
		public double GetAsFloat()
		{
			switch (this.valueType)
			{
			case MsgPackType.String:
				return double.Parse((string)this.innerValue);
			case MsgPackType.Integer:
				return Convert.ToDouble((long)this.innerValue);
			case MsgPackType.Float:
				return (double)this.innerValue;
			case MsgPackType.Single:
				return (double)((float)this.innerValue);
			case MsgPackType.DateTime:
				return (double)Convert.ToInt64((DateTime)this.innerValue);
			}
			return 0.0;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000382F File Offset: 0x00001A2F
		public void SetAsBytes(byte[] value)
		{
			this.innerValue = value;
			this.valueType = MsgPackType.Binary;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0001C740 File Offset: 0x0001A940
		public byte[] GetAsBytes()
		{
			switch (this.valueType)
			{
			case MsgPackType.String:
				return BytesTools.GetUtf8Bytes(this.innerValue.ToString());
			case MsgPackType.Integer:
				return BitConverter.GetBytes((long)this.innerValue);
			case MsgPackType.Float:
				return BitConverter.GetBytes((double)this.innerValue);
			case MsgPackType.Single:
				return BitConverter.GetBytes((float)this.innerValue);
			case MsgPackType.DateTime:
				return BitConverter.GetBytes(((DateTime)this.innerValue).ToBinary());
			case MsgPackType.Binary:
				return (byte[])this.innerValue;
			}
			return new byte[0];
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00003840 File Offset: 0x00001A40
		public void Add(string key, string value)
		{
			MsgPack msgPack = this.InnerAddArrayChild();
			msgPack.name = key;
			msgPack.SetAsString(value);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00003855 File Offset: 0x00001A55
		public void Add(string key, int value)
		{
			MsgPack msgPack = this.InnerAddArrayChild();
			msgPack.name = key;
			msgPack.SetAsInteger((long)value);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0001C7F0 File Offset: 0x0001A9F0
		//public Task<bool> LoadFileAsBytes(string fileName)
		//{
		//	//MsgPack.<LoadFileAsBytes>d__26 <LoadFileAsBytes>d__;
		//	//<LoadFileAsBytes>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
		//	//<LoadFileAsBytes>d__.<>4__this = this;
		//	//<LoadFileAsBytes>d__.fileName = fileName;
		//	//<LoadFileAsBytes>d__.<>1__state = -1;
		//	//<LoadFileAsBytes>d__.<>t__builder.Start<MsgPack.<LoadFileAsBytes>d__26>(ref <LoadFileAsBytes>d__);
		//	//return <LoadFileAsBytes>d__.<>t__builder.Task;
		//}

		// Token: 0x0600028B RID: 651 RVA: 0x0001C83C File Offset: 0x0001AA3C
		//public Task<bool> SaveBytesToFile(string fileName)
		//{
		//	MsgPack.<SaveBytesToFile>d__27 <SaveBytesToFile>d__;
		//	<SaveBytesToFile>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
		//	<SaveBytesToFile>d__.<>4__this = this;
		//	<SaveBytesToFile>d__.fileName = fileName;
		//	<SaveBytesToFile>d__.<>1__state = -1;
		//	<SaveBytesToFile>d__.<>t__builder.Start<MsgPack.<SaveBytesToFile>d__27>(ref <SaveBytesToFile>d__);
		//	return <SaveBytesToFile>d__.<>t__builder.Task;
		//}

		// Token: 0x0600028C RID: 652 RVA: 0x0001C888 File Offset: 0x0001AA88
		public MsgPack ForcePathObject(string path)
		{
			MsgPack msgPack = this;
			string[] array = path.Trim().Split(new char[]
			{
				'.',
				'/',
				'\\'
			});
			if (array.Length == 0)
			{
				return null;
			}
			string text;
			if (array.Length > 1)
			{
				for (int i = 0; i < array.Length - 1; i++)
				{
					text = array[i];
					MsgPack msgPack2 = msgPack.FindObject(text);
					if (msgPack2 == null)
					{
						msgPack = msgPack.InnerAddMapChild();
						msgPack.SetName(text);
					}
					else
					{
						msgPack = msgPack2;
					}
				}
			}
			text = array[array.Length - 1];
			int num = msgPack.IndexOf(text);
			if (num > -1)
			{
				return msgPack.children[num];
			}
			msgPack = msgPack.InnerAddMapChild();
			msgPack.SetName(text);
			return msgPack;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000386B File Offset: 0x00001A6B
		public void SetAsNull()
		{
			this.Clear();
			this.innerValue = null;
			this.valueType = MsgPackType.Null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00003881 File Offset: 0x00001A81
		public void SetAsString(string value)
		{
			this.innerValue = value;
			this.valueType = MsgPackType.String;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00003891 File Offset: 0x00001A91
		public string GetAsString()
		{
			if (this.innerValue == null)
			{
				return "";
			}
			return this.innerValue.ToString();
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000038AC File Offset: 0x00001AAC
		public void SetAsBoolean(bool bVal)
		{
			this.valueType = MsgPackType.Boolean;
			this.innerValue = bVal;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000038C1 File Offset: 0x00001AC1
		public void SetAsSingle(float fVal)
		{
			this.valueType = MsgPackType.Single;
			this.innerValue = fVal;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000038D7 File Offset: 0x00001AD7
		public void SetAsFloat(double fVal)
		{
			this.valueType = MsgPackType.Float;
			this.innerValue = fVal;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0001C92C File Offset: 0x0001AB2C
		public void DecodeFromBytes(byte[] bytes)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				bytes = Zip.Decompress(bytes);
				memoryStream.Write(bytes, 0, bytes.Length);
				memoryStream.Position = 0L;
				this.DecodeFromStream(memoryStream);
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001C984 File Offset: 0x0001AB84
		public void DecodeFromFile(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open);
			this.DecodeFromStream(fileStream);
			fileStream.Dispose();
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0001C9A8 File Offset: 0x0001ABA8
		public void DecodeFromStream(Stream ms)
		{
			byte b = (byte)ms.ReadByte();
			if (b <= 127)
			{
				this.SetAsInteger((long)((ulong)b));
				return;
			}
			if (b >= 128 && b <= 143)
			{
				this.Clear();
				this.valueType = MsgPackType.Map;
				int num = (int)(b - 128);
				for (int i = 0; i < num; i++)
				{
					MsgPack msgPack = this.InnerAdd();
					msgPack.SetName(ReadTools.ReadString(ms));
					msgPack.DecodeFromStream(ms);
				}
				return;
			}
			if (b >= 144 && b <= 159)
			{
				this.Clear();
				this.valueType = MsgPackType.Array;
				int num = (int)(b - 144);
				for (int i = 0; i < num; i++)
				{
					this.InnerAdd().DecodeFromStream(ms);
				}
				return;
			}
			if (b >= 160 && b <= 191)
			{
				int num = (int)(b - 160);
				this.SetAsString(ReadTools.ReadString(ms, num));
				return;
			}
			if (b >= 224 && b <= 255)
			{
				this.SetAsInteger((long)((sbyte)b));
				return;
			}
			if (b == 192)
			{
				this.SetAsNull();
				return;
			}
			if (b == 193)
			{
				throw new Exception("(never used) type $c1");
			}
			if (b == 194)
			{
				this.SetAsBoolean(false);
				return;
			}
			if (b == 195)
			{
				this.SetAsBoolean(true);
				return;
			}
			if (b == 196)
			{
				int num = ms.ReadByte();
				byte[] array = new byte[num];
				ms.Read(array, 0, num);
				this.SetAsBytes(array);
				return;
			}
			if (b == 197)
			{
				byte[] array = new byte[2];
				ms.Read(array, 0, 2);
				array = BytesTools.SwapBytes(array);
				int num = (int)BitConverter.ToUInt16(array, 0);
				array = new byte[num];
				ms.Read(array, 0, num);
				this.SetAsBytes(array);
				return;
			}
			if (b == 198)
			{
				byte[] array = new byte[4];
				ms.Read(array, 0, 4);
				array = BytesTools.SwapBytes(array);
				int num = BitConverter.ToInt32(array, 0);
				array = new byte[num];
				ms.Read(array, 0, num);
				this.SetAsBytes(array);
				return;
			}
			if (b != 199 && b != 200)
			{
				if (b != 201)
				{
					if (b == 202)
					{
						byte[] array = new byte[4];
						ms.Read(array, 0, 4);
						array = BytesTools.SwapBytes(array);
						this.SetAsSingle(BitConverter.ToSingle(array, 0));
						return;
					}
					if (b == 203)
					{
						byte[] array = new byte[8];
						ms.Read(array, 0, 8);
						array = BytesTools.SwapBytes(array);
						this.SetAsFloat(BitConverter.ToDouble(array, 0));
						return;
					}
					if (b == 204)
					{
						b = (byte)ms.ReadByte();
						this.SetAsInteger((long)((ulong)b));
						return;
					}
					if (b == 205)
					{
						byte[] array = new byte[2];
						ms.Read(array, 0, 2);
						array = BytesTools.SwapBytes(array);
						this.SetAsInteger((long)((ulong)BitConverter.ToUInt16(array, 0)));
						return;
					}
					if (b == 206)
					{
						byte[] array = new byte[4];
						ms.Read(array, 0, 4);
						array = BytesTools.SwapBytes(array);
						this.SetAsInteger((long)((ulong)BitConverter.ToUInt32(array, 0)));
						return;
					}
					if (b == 207)
					{
						byte[] array = new byte[8];
						ms.Read(array, 0, 8);
						array = BytesTools.SwapBytes(array);
						this.method_0(BitConverter.ToUInt64(array, 0));
						return;
					}
					if (b == 220)
					{
						byte[] array = new byte[2];
						ms.Read(array, 0, 2);
						array = BytesTools.SwapBytes(array);
						int num = (int)BitConverter.ToInt16(array, 0);
						this.Clear();
						this.valueType = MsgPackType.Array;
						for (int i = 0; i < num; i++)
						{
							this.InnerAdd().DecodeFromStream(ms);
						}
						return;
					}
					if (b == 221)
					{
						byte[] array = new byte[4];
						ms.Read(array, 0, 4);
						array = BytesTools.SwapBytes(array);
						int num = (int)BitConverter.ToInt16(array, 0);
						this.Clear();
						this.valueType = MsgPackType.Array;
						for (int i = 0; i < num; i++)
						{
							this.InnerAdd().DecodeFromStream(ms);
						}
						return;
					}
					if (b == 217)
					{
						this.SetAsString(ReadTools.ReadString(b, ms));
						return;
					}
					if (b == 222)
					{
						byte[] array = new byte[2];
						ms.Read(array, 0, 2);
						array = BytesTools.SwapBytes(array);
						int num = (int)BitConverter.ToInt16(array, 0);
						this.Clear();
						this.valueType = MsgPackType.Map;
						for (int i = 0; i < num; i++)
						{
							MsgPack msgPack2 = this.InnerAdd();
							msgPack2.SetName(ReadTools.ReadString(ms));
							msgPack2.DecodeFromStream(ms);
						}
						return;
					}
					if (b == 222)
					{
						byte[] array = new byte[2];
						ms.Read(array, 0, 2);
						array = BytesTools.SwapBytes(array);
						int num = (int)BitConverter.ToInt16(array, 0);
						this.Clear();
						this.valueType = MsgPackType.Map;
						for (int i = 0; i < num; i++)
						{
							MsgPack msgPack3 = this.InnerAdd();
							msgPack3.SetName(ReadTools.ReadString(ms));
							msgPack3.DecodeFromStream(ms);
						}
						return;
					}
					if (b == 223)
					{
						byte[] array = new byte[4];
						ms.Read(array, 0, 4);
						array = BytesTools.SwapBytes(array);
						int num = BitConverter.ToInt32(array, 0);
						this.Clear();
						this.valueType = MsgPackType.Map;
						for (int i = 0; i < num; i++)
						{
							MsgPack msgPack4 = this.InnerAdd();
							msgPack4.SetName(ReadTools.ReadString(ms));
							msgPack4.DecodeFromStream(ms);
						}
						return;
					}
					if (b == 218)
					{
						this.SetAsString(ReadTools.ReadString(b, ms));
						return;
					}
					if (b == 219)
					{
						this.SetAsString(ReadTools.ReadString(b, ms));
						return;
					}
					if (b == 208)
					{
						this.SetAsInteger((long)((sbyte)ms.ReadByte()));
						return;
					}
					if (b == 209)
					{
						byte[] array = new byte[2];
						ms.Read(array, 0, 2);
						array = BytesTools.SwapBytes(array);
						this.SetAsInteger((long)BitConverter.ToInt16(array, 0));
						return;
					}
					if (b == 210)
					{
						byte[] array = new byte[4];
						ms.Read(array, 0, 4);
						array = BytesTools.SwapBytes(array);
						this.SetAsInteger((long)BitConverter.ToInt32(array, 0));
						return;
					}
					if (b == 211)
					{
						byte[] array = new byte[8];
						ms.Read(array, 0, 8);
						array = BytesTools.SwapBytes(array);
						this.SetAsInteger(BitConverter.ToInt64(array, 0));
					}
					return;
				}
			}
			throw new Exception("(ext8,ext16,ex32) type $c7,$c8,$c9");
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0001CF44 File Offset: 0x0001B144
		public byte[] Encode2Bytes()
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				this.Encode2Stream(memoryStream);
				byte[] array = new byte[memoryStream.Length];
				memoryStream.Position = 0L;
				memoryStream.Read(array, 0, (int)memoryStream.Length);
				result = Zip.Compress(array);
			}
			return result;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0001CFB0 File Offset: 0x0001B1B0
		public void Encode2Stream(Stream ms)
		{
			switch (this.valueType)
			{
			case MsgPackType.Unknown:
			case MsgPackType.Null:
				WriteTools.WriteNull(ms);
				return;
			case MsgPackType.Map:
				this.WriteMap(ms);
				return;
			case MsgPackType.Array:
				this.WirteArray(ms);
				return;
			case MsgPackType.String:
				WriteTools.WriteString(ms, (string)this.innerValue);
				return;
			case MsgPackType.Integer:
				WriteTools.WriteInteger(ms, (long)this.innerValue);
				return;
			case MsgPackType.UInt64:
				WriteTools.smethod_0(ms, (ulong)this.innerValue);
				return;
			case MsgPackType.Boolean:
				WriteTools.WriteBoolean(ms, (bool)this.innerValue);
				return;
			case MsgPackType.Float:
				WriteTools.WriteFloat(ms, (double)this.innerValue);
				return;
			case MsgPackType.Single:
				WriteTools.WriteFloat(ms, (double)((float)this.innerValue));
				return;
			case MsgPackType.DateTime:
				WriteTools.WriteInteger(ms, this.GetAsInteger());
				return;
			case MsgPackType.Binary:
				WriteTools.WriteBinary(ms, (byte[])this.innerValue);
				return;
			default:
				WriteTools.WriteNull(ms);
				return;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000298 RID: 664 RVA: 0x000038EC File Offset: 0x00001AEC
		// (set) Token: 0x06000299 RID: 665 RVA: 0x000038F4 File Offset: 0x00001AF4
		public string AsString
		{
			get
			{
				return this.GetAsString();
			}
			set
			{
				this.SetAsString(value);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000038FD File Offset: 0x00001AFD
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00003905 File Offset: 0x00001B05
		public long AsInteger
		{
			get
			{
				return this.GetAsInteger();
			}
			set
			{
				this.SetAsInteger(value);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000390E File Offset: 0x00001B0E
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00003916 File Offset: 0x00001B16
		public double AsFloat
		{
			get
			{
				return this.GetAsFloat();
			}
			set
			{
				this.SetAsFloat(value);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0001D0A4 File Offset: 0x0001B2A4
		public MsgPackArray AsArray
		{
			get
			{
				lock (this)
				{
					if (this.refAsArray == null)
					{
						this.refAsArray = new MsgPackArray(this, this.children);
					}
				}
				return this.refAsArray;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0000391F File Offset: 0x00001B1F
		public MsgPackType ValueType
		{
			get
			{
				return this.valueType;
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00003927 File Offset: 0x00001B27
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new MsgPackEnum(this.children);
		}

		// Token: 0x0400018E RID: 398
		private string name;

		// Token: 0x0400018F RID: 399
		private string lowerName;

		// Token: 0x04000190 RID: 400
		private object innerValue;

		// Token: 0x04000191 RID: 401
		private MsgPackType valueType;

		// Token: 0x04000192 RID: 402
		private MsgPack parent;

		// Token: 0x04000193 RID: 403
		private List<MsgPack> children = new List<MsgPack>();

		// Token: 0x04000194 RID: 404
		private MsgPackArray refAsArray;
	}
}
