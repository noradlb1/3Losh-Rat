using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace KeyAuth
{
	// Token: 0x0200000D RID: 13
	public class api
	{
		// Token: 0x06000051 RID: 81 RVA: 0x0000CBE4 File Offset: 0x0000ADE4
		public api(string name, string ownerid, string secret, string version)
		{
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000CC48 File Offset: 0x0000AE48
		public void init()
		{
			string text = encryption.iv_key();
			api.enckey = text + "-" + this.secret;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "init";
			nameValueCollection["ver"] = this.version;
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = text;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string text2 = api.req(nameValueCollection);
			if (text2 == "KeyAuth_Invalid")
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				if (response_structure.newSession)
				{
					Thread.Sleep(100);
				}
				api.sessionid = response_structure.sessionid;
				this.initialized = true;
				return;
			}
			if (response_structure.message == "invalidver")
			{
				this.app_data.downloadLink = response_structure.download;
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002390 File Offset: 0x00000590
		public void CheckInit()
		{
			if (!this.initialized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000CD68 File Offset: 0x0000AF68
		public string expirydaysleft(string Type, int subscription)
		{
			this.CheckInit();
			DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			d = d.AddSeconds((double)long.Parse(this.user_data.subscriptions[subscription].expiry)).ToLocalTime();
			TimeSpan timeSpan = d - DateTime.Now;
			string a = Type.ToLower();
			if (a == "months")
			{
				return Convert.ToString(timeSpan.Days / 30);
			}
			if (a == "days")
			{
				return Convert.ToString(timeSpan.Days);
			}
			if (!(a == "hours"))
			{
				return null;
			}
			return Convert.ToString(timeSpan.Hours);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000CE20 File Offset: 0x0000B020
		public void register(string username, string pass, string key, string email = "")
		{
			this.CheckInit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "register";
			nameValueCollection["username"] = username;
			nameValueCollection["pass"] = pass;
			nameValueCollection["key"] = key;
			nameValueCollection["email"] = email;
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000CEF8 File Offset: 0x0000B0F8
		public void forgot(string username, string email)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "forgot";
			nameValueCollection["username"] = username;
			nameValueCollection["email"] = email;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000CF84 File Offset: 0x0000B184
		public void login(string username, string pass)
		{
			this.CheckInit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "login";
			nameValueCollection["username"] = username;
			nameValueCollection["pass"] = pass;
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000D040 File Offset: 0x0000B240
		public void logout()
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "logout";
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000D0B4 File Offset: 0x0000B2B4
		public void web_login()
		{
			this.CheckInit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			HttpListener httpListener;
			HttpListenerRequest request;
			HttpListenerResponse httpListenerResponse;
			for (;;)
			{
				httpListener = new HttpListener();
				string text = "handshake";
				text = "http://localhost:1337/" + text + "/";
				httpListener.Prefixes.Add(text);
				httpListener.Start();
				HttpListenerContext context = httpListener.GetContext();
				request = context.Request;
				httpListenerResponse = context.Response;
				httpListenerResponse.AddHeader("Access-Control-Allow-Methods", "GET, POST");
				httpListenerResponse.AddHeader("Access-Control-Allow-Origin", "*");
				httpListenerResponse.AddHeader("Via", "hugzho's big brain");
				httpListenerResponse.AddHeader("Location", "your kernel ;)");
				httpListenerResponse.AddHeader("Retry-After", "never lmao");
				httpListenerResponse.Headers.Add("Server", "\r\n\r\n");
				if (!(request.HttpMethod == "OPTIONS"))
				{
					break;
				}
				httpListenerResponse.StatusCode = 200;
				Thread.Sleep(1);
				httpListener.Stop();
			}
			httpListener.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
			httpListener.UnsafeConnectionNtlmAuthentication = true;
			httpListener.IgnoreWriteExceptions = true;
			string text2 = request.RawUrl.Replace("/handshake?user=", "").Replace("&token=", " ");
			string value2 = text2.Split(Array.Empty<char>())[0];
			string value3 = text2.Split(new char[]
			{
				' '
			})[1];
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "login";
			nameValueCollection["username"] = value2;
			nameValueCollection["token"] = value3;
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			bool flag = true;
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
				httpListenerResponse.StatusCode = 420;
				httpListenerResponse.StatusDescription = "SHEESH";
			}
			else
			{
				Console.WriteLine(response_structure.message);
				httpListenerResponse.StatusCode = 200;
				httpListenerResponse.StatusDescription = response_structure.message;
				flag = false;
			}
			byte[] bytes = Encoding.UTF8.GetBytes("Whats up?");
			httpListenerResponse.ContentLength64 = (long)bytes.Length;
			httpListenerResponse.OutputStream.Write(bytes, 0, bytes.Length);
			Thread.Sleep(1);
			httpListener.Stop();
			if (!flag)
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000D340 File Offset: 0x0000B540
		public void button(string button)
		{
			this.CheckInit();
			HttpListener httpListener = new HttpListener();
			string uriPrefix = "http://localhost:1337/" + button + "/";
			httpListener.Prefixes.Add(uriPrefix);
			httpListener.Start();
			HttpListenerContext context = httpListener.GetContext();
			HttpListenerRequest request = context.Request;
			HttpListenerResponse httpListenerResponse = context.Response;
			httpListenerResponse.AddHeader("Access-Control-Allow-Methods", "GET, POST");
			httpListenerResponse.AddHeader("Access-Control-Allow-Origin", "*");
			httpListenerResponse.AddHeader("Via", "hugzho's big brain");
			httpListenerResponse.AddHeader("Location", "your kernel ;)");
			httpListenerResponse.AddHeader("Retry-After", "never lmao");
			httpListenerResponse.Headers.Add("Server", "\r\n\r\n");
			httpListenerResponse.StatusCode = 420;
			httpListenerResponse.StatusDescription = "SHEESH";
			httpListener.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
			httpListener.UnsafeConnectionNtlmAuthentication = true;
			httpListener.IgnoreWriteExceptions = true;
			httpListener.Stop();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000D424 File Offset: 0x0000B624
		public void upgrade(string username, string key)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "upgrade";
			nameValueCollection["username"] = username;
			nameValueCollection["key"] = key;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			response_structure.success = false;
			this.load_response_struct(response_structure);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		public void license(string key)
		{
			this.CheckInit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "license";
			nameValueCollection["key"] = key;
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000D568 File Offset: 0x0000B768
		public void check()
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "check";
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000D5DC File Offset: 0x0000B7DC
		public void setvar(string var, string data)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "setvar";
			nameValueCollection["var"] = var;
			nameValueCollection["data"] = data;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure data2 = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000D668 File Offset: 0x0000B868
		public string getvar(string var)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "getvar";
			nameValueCollection["var"] = var;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.response;
			}
			return null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
		public void ban(string reason = null)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "ban";
			nameValueCollection["reason"] = reason;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000D778 File Offset: 0x0000B978
		public string var(string varid)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "var";
			nameValueCollection["varid"] = varid;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.message;
			}
			return null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000D808 File Offset: 0x0000BA08
		public List<api.users> fetchOnline()
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "fetchOnline";
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.users;
			}
			return null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000D88C File Offset: 0x0000BA8C
		public void fetchStats()
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "fetchStats";
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_app_data(response_structure.appinfo);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000D914 File Offset: 0x0000BB14
		public List<api.msg> chatget(string channelname)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "chatget";
			nameValueCollection["channel"] = channelname;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.messages;
			}
			return null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000D9A4 File Offset: 0x0000BBA4
		public bool chatsend(string msg, string channelname)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "chatsend";
			nameValueCollection["message"] = msg;
			nameValueCollection["channel"] = channelname;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000DA3C File Offset: 0x0000BC3C
		public bool checkblack()
		{
			this.CheckInit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "checkblacklist";
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000DAD8 File Offset: 0x0000BCD8
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "webhook";
			nameValueCollection["webid"] = webid;
			nameValueCollection["params"] = param;
			nameValueCollection["body"] = body;
			nameValueCollection["conttype"] = conttype;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return response_structure.response;
			}
			return null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000DB90 File Offset: 0x0000BD90
		public byte[] download(string fileid)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "file";
			nameValueCollection["fileid"] = fileid;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				return encryption.str_to_byte_arr(response_structure.contents);
			}
			return null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000DC28 File Offset: 0x0000BE28
		public void log(string message)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "log";
			nameValueCollection["pcuser"] = Environment.UserName;
			nameValueCollection["message"] = message;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			api.req(nameValueCollection);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000DCA4 File Offset: 0x0000BEA4
		public void changeUsername(string username)
		{
			this.CheckInit();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "changeUsername";
			nameValueCollection["newUsername"] = username;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			string json = api.req(nameValueCollection);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000DD24 File Offset: 0x0000BF24
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					result = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000DD94 File Offset: 0x0000BF94
		public static void error(string message)
		{
			string text = "Logs";
			string path = Path.Combine(text, "ErrorLogs.txt");
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			if (!File.Exists(path))
			{
				using (File.Create(path))
				{
					File.AppendAllText(path, DateTime.Now.ToString() + " > This is the start of your error logs file");
				}
			}
			File.AppendAllText(path, DateTime.Now.ToString() + " > " + message + Environment.NewLine);
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000DE70 File Offset: 0x0000C070
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Proxy = null;
					ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(api.smethod_0));
					Stopwatch stopwatch = new Stopwatch();
					stopwatch.Start();
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.2/", post_data);
					stopwatch.Stop();
					api.responseTime = stopwatch.ElapsedMilliseconds;
					//ServicePointManager.ServerCertificateValidationCallback = ((object <p0>, X509Certificate <p1>, X509Chain <p2>, SslPolicyErrors <p3>) => true);
					api.sigCheck(Encoding.Default.GetString(bytes), webClient.ResponseHeaders["signature"], post_data.Get(0));
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				if (((HttpWebResponse)ex.Response).StatusCode == (HttpStatusCode)429)
				{
					api.error("You're connecting too fast to loader, slow down.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000DF98 File Offset: 0x0000C198
		private static bool smethod_0(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			if ((!certificate.Issuer.Contains("Cloudflare Inc") && !certificate.Issuer.Contains("Google Trust Services") && !certificate.Issuer.Contains("Let's Encrypt")) || sslPolicyErrors != SslPolicyErrors.None)
			{
				api.error("SSL assertion fail, make sure you're not debugging Network. Disable internet firewall on router if possible. & echo: & echo If not, ask the developer of the program to use custom domains to fix this.");
				return false;
			}
			return true;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000DFEC File Offset: 0x0000C1EC
		private static void sigCheck(string resp, string signature, string type)
		{
			if (!(type == "log") && !(type == "file"))
			{
				try
				{
					if (!encryption.CheckStringsFixedTime(encryption.HashHMAC((type == "init") ? api.enckey.Substring(17, 64) : api.enckey, resp), signature))
					{
						api.error("Signature checksum failed. Request was tampered with or session ended most likely. & echo: & echo Response: " + resp);
						Environment.Exit(0);
					}
				}
				catch
				{
					api.error("Signature checksum failed. Request was tampered with or session ended most likely. & echo: & echo Response: " + resp);
					Environment.Exit(0);
				}
				return;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000E088 File Offset: 0x0000C288
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000E0EC File Offset: 0x0000C2EC
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000023AA File Offset: 0x000005AA
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x0400001D RID: 29
		public string name;

		// Token: 0x0400001E RID: 30
		public string ownerid;

		// Token: 0x0400001F RID: 31
		public string secret;

		// Token: 0x04000020 RID: 32
		public string version;

		// Token: 0x04000021 RID: 33
		public static long responseTime;

		// Token: 0x04000022 RID: 34
		private static string sessionid;

		// Token: 0x04000023 RID: 35
		private static string enckey;

		// Token: 0x04000024 RID: 36
		private bool initialized;

		// Token: 0x04000025 RID: 37
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x04000026 RID: 38
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x04000027 RID: 39
		public api.response_class response = new api.response_class();

		// Token: 0x04000028 RID: 40
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x0200000E RID: 14
		[DataContract]
		private class response_structure
		{
			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000073 RID: 115 RVA: 0x000023CE File Offset: 0x000005CE
			// (set) Token: 0x06000074 RID: 116 RVA: 0x000023D6 File Offset: 0x000005D6
			[DataMember]
			public bool success { get; set; }

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000075 RID: 117 RVA: 0x000023DF File Offset: 0x000005DF
			// (set) Token: 0x06000076 RID: 118 RVA: 0x000023E7 File Offset: 0x000005E7
			[DataMember]
			public bool newSession { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000077 RID: 119 RVA: 0x000023F0 File Offset: 0x000005F0
			// (set) Token: 0x06000078 RID: 120 RVA: 0x000023F8 File Offset: 0x000005F8
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000079 RID: 121 RVA: 0x00002401 File Offset: 0x00000601
			// (set) Token: 0x0600007A RID: 122 RVA: 0x00002409 File Offset: 0x00000609
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600007B RID: 123 RVA: 0x00002412 File Offset: 0x00000612
			// (set) Token: 0x0600007C RID: 124 RVA: 0x0000241A File Offset: 0x0000061A
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600007D RID: 125 RVA: 0x00002423 File Offset: 0x00000623
			// (set) Token: 0x0600007E RID: 126 RVA: 0x0000242B File Offset: 0x0000062B
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600007F RID: 127 RVA: 0x00002434 File Offset: 0x00000634
			// (set) Token: 0x06000080 RID: 128 RVA: 0x0000243C File Offset: 0x0000063C
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000081 RID: 129 RVA: 0x00002445 File Offset: 0x00000645
			// (set) Token: 0x06000082 RID: 130 RVA: 0x0000244D File Offset: 0x0000064D
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000083 RID: 131 RVA: 0x00002456 File Offset: 0x00000656
			// (set) Token: 0x06000084 RID: 132 RVA: 0x0000245E File Offset: 0x0000065E
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000085 RID: 133 RVA: 0x00002467 File Offset: 0x00000667
			// (set) Token: 0x06000086 RID: 134 RVA: 0x0000246F File Offset: 0x0000066F
			[DataMember]
			public List<api.msg> messages { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000087 RID: 135 RVA: 0x00002478 File Offset: 0x00000678
			// (set) Token: 0x06000088 RID: 136 RVA: 0x00002480 File Offset: 0x00000680
			[DataMember]
			public List<api.users> users { get; set; }
		}

		// Token: 0x0200000F RID: 15
		public class msg
		{
			// Token: 0x17000019 RID: 25
			// (get) Token: 0x0600008A RID: 138 RVA: 0x00002489 File Offset: 0x00000689
			// (set) Token: 0x0600008B RID: 139 RVA: 0x00002491 File Offset: 0x00000691
			public string message { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600008C RID: 140 RVA: 0x0000249A File Offset: 0x0000069A
			// (set) Token: 0x0600008D RID: 141 RVA: 0x000024A2 File Offset: 0x000006A2
			public string author { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600008E RID: 142 RVA: 0x000024AB File Offset: 0x000006AB
			// (set) Token: 0x0600008F RID: 143 RVA: 0x000024B3 File Offset: 0x000006B3
			public string timestamp { get; set; }
		}

		// Token: 0x02000010 RID: 16
		public class users
		{
			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000091 RID: 145 RVA: 0x000024BC File Offset: 0x000006BC
			// (set) Token: 0x06000092 RID: 146 RVA: 0x000024C4 File Offset: 0x000006C4
			public string credential { get; set; }
		}

		// Token: 0x02000011 RID: 17
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000094 RID: 148 RVA: 0x000024CD File Offset: 0x000006CD
			// (set) Token: 0x06000095 RID: 149 RVA: 0x000024D5 File Offset: 0x000006D5
			[DataMember]
			public string username { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000096 RID: 150 RVA: 0x000024DE File Offset: 0x000006DE
			// (set) Token: 0x06000097 RID: 151 RVA: 0x000024E6 File Offset: 0x000006E6
			[DataMember]
			public string ip { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000098 RID: 152 RVA: 0x000024EF File Offset: 0x000006EF
			// (set) Token: 0x06000099 RID: 153 RVA: 0x000024F7 File Offset: 0x000006F7
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600009A RID: 154 RVA: 0x00002500 File Offset: 0x00000700
			// (set) Token: 0x0600009B RID: 155 RVA: 0x00002508 File Offset: 0x00000708
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600009C RID: 156 RVA: 0x00002511 File Offset: 0x00000711
			// (set) Token: 0x0600009D RID: 157 RVA: 0x00002519 File Offset: 0x00000719
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600009E RID: 158 RVA: 0x00002522 File Offset: 0x00000722
			// (set) Token: 0x0600009F RID: 159 RVA: 0x0000252A File Offset: 0x0000072A
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000012 RID: 18
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002533 File Offset: 0x00000733
			// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000253B File Offset: 0x0000073B
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000A3 RID: 163 RVA: 0x00002544 File Offset: 0x00000744
			// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000254C File Offset: 0x0000074C
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002555 File Offset: 0x00000755
			// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000255D File Offset: 0x0000075D
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000A7 RID: 167 RVA: 0x00002566 File Offset: 0x00000766
			// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000256E File Offset: 0x0000076E
			[DataMember]
			public string version { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002577 File Offset: 0x00000777
			// (set) Token: 0x060000AA RID: 170 RVA: 0x0000257F File Offset: 0x0000077F
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060000AB RID: 171 RVA: 0x00002588 File Offset: 0x00000788
			// (set) Token: 0x060000AC RID: 172 RVA: 0x00002590 File Offset: 0x00000790
			[DataMember]
			public string downloadLink { get; set; }
		}

		// Token: 0x02000013 RID: 19
		public class app_data_class
		{
			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060000AE RID: 174 RVA: 0x00002599 File Offset: 0x00000799
			// (set) Token: 0x060000AF RID: 175 RVA: 0x000025A1 File Offset: 0x000007A1
			public string numUsers { get; set; }

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060000B0 RID: 176 RVA: 0x000025AA File Offset: 0x000007AA
			// (set) Token: 0x060000B1 RID: 177 RVA: 0x000025B2 File Offset: 0x000007B2
			public string numOnlineUsers { get; set; }

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x060000B2 RID: 178 RVA: 0x000025BB File Offset: 0x000007BB
			// (set) Token: 0x060000B3 RID: 179 RVA: 0x000025C3 File Offset: 0x000007C3
			public string numKeys { get; set; }

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x060000B4 RID: 180 RVA: 0x000025CC File Offset: 0x000007CC
			// (set) Token: 0x060000B5 RID: 181 RVA: 0x000025D4 File Offset: 0x000007D4
			public string version { get; set; }

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x060000B6 RID: 182 RVA: 0x000025DD File Offset: 0x000007DD
			// (set) Token: 0x060000B7 RID: 183 RVA: 0x000025E5 File Offset: 0x000007E5
			public string customerPanelLink { get; set; }

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x060000B8 RID: 184 RVA: 0x000025EE File Offset: 0x000007EE
			// (set) Token: 0x060000B9 RID: 185 RVA: 0x000025F6 File Offset: 0x000007F6
			public string downloadLink { get; set; }
		}

		// Token: 0x02000014 RID: 20
		public class user_data_class
		{
			// Token: 0x1700002F RID: 47
			// (get) Token: 0x060000BB RID: 187 RVA: 0x000025FF File Offset: 0x000007FF
			// (set) Token: 0x060000BC RID: 188 RVA: 0x00002607 File Offset: 0x00000807
			public string username { get; set; }

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x060000BD RID: 189 RVA: 0x00002610 File Offset: 0x00000810
			// (set) Token: 0x060000BE RID: 190 RVA: 0x00002618 File Offset: 0x00000818
			public string ip { get; set; }

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x060000BF RID: 191 RVA: 0x00002621 File Offset: 0x00000821
			// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002629 File Offset: 0x00000829
			public string hwid { get; set; }

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002632 File Offset: 0x00000832
			// (set) Token: 0x060000C2 RID: 194 RVA: 0x0000263A File Offset: 0x0000083A
			public string createdate { get; set; }

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002643 File Offset: 0x00000843
			// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000264B File Offset: 0x0000084B
			public string lastlogin { get; set; }

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002654 File Offset: 0x00000854
			// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000265C File Offset: 0x0000085C
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000015 RID: 21
		public class Data
		{
			// Token: 0x17000035 RID: 53
			// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002665 File Offset: 0x00000865
			// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000266D File Offset: 0x0000086D
			public string subscription { get; set; }

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060000CA RID: 202 RVA: 0x00002676 File Offset: 0x00000876
			// (set) Token: 0x060000CB RID: 203 RVA: 0x0000267E File Offset: 0x0000087E
			public string expiry { get; set; }

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060000CC RID: 204 RVA: 0x00002687 File Offset: 0x00000887
			// (set) Token: 0x060000CD RID: 205 RVA: 0x0000268F File Offset: 0x0000088F
			public string timeleft { get; set; }
		}

		// Token: 0x02000016 RID: 22
		public class response_class
		{
			// Token: 0x17000038 RID: 56
			// (get) Token: 0x060000CF RID: 207 RVA: 0x00002698 File Offset: 0x00000898
			// (set) Token: 0x060000D0 RID: 208 RVA: 0x000026A0 File Offset: 0x000008A0
			public bool success { get; set; }

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x060000D1 RID: 209 RVA: 0x000026A9 File Offset: 0x000008A9
			// (set) Token: 0x060000D2 RID: 210 RVA: 0x000026B1 File Offset: 0x000008B1
			public string message { get; set; }
		}
	}
}
