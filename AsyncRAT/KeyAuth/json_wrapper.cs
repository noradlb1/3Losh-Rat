using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000019 RID: 25
	public class json_wrapper
	{
		// Token: 0x060000DC RID: 220 RVA: 0x000026C6 File Offset: 0x000008C6
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000E300 File Offset: 0x0000C500
		public object string_to_object(string json)
		{
			object result;
			using (MemoryStream memoryStream = new MemoryStream(Encoding.Default.GetBytes(json)))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000026E3 File Offset: 0x000008E3
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x04000057 RID: 87
		private DataContractJsonSerializer serializer;

		// Token: 0x04000058 RID: 88
		private object current_object;
	}
}
