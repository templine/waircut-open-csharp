using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000012 RID: 18
public class GClass4
{
	// Token: 0x06000186 RID: 390 RVA: 0x00008920 File Offset: 0x00006B20
	private byte[] method_0(string string_0, int int_0)
	{
		HashAlgorithm hashAlgorithm = new SHA1CryptoServiceProvider();
		byte[] bytes = Encoding.Unicode.GetBytes(string_0);
		return (byte[])Utils.CopyArray(hashAlgorithm.ComputeHash(bytes), new byte[checked(int_0 - 1 + 1)]);
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00008958 File Offset: 0x00006B58
	public GClass4(string string_0)
	{
		this.tripleDESCryptoServiceProvider_0 = new TripleDESCryptoServiceProvider();
		this.tripleDESCryptoServiceProvider_0.Key = this.method_0(string_0, this.tripleDESCryptoServiceProvider_0.KeySize / 8);
		this.tripleDESCryptoServiceProvider_0.IV = this.method_0("", this.tripleDESCryptoServiceProvider_0.BlockSize / 8);
	}

	// Token: 0x06000188 RID: 392 RVA: 0x000089B8 File Offset: 0x00006BB8
	public byte[] method_1(ref byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, this.tripleDESCryptoServiceProvider_0.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.FlushFinalBlock();
		return memoryStream.ToArray();
	}

	// Token: 0x06000189 RID: 393 RVA: 0x000089F8 File Offset: 0x00006BF8
	public byte[] method_2(ref byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, this.tripleDESCryptoServiceProvider_0.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.FlushFinalBlock();
		return memoryStream.ToArray();
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00008A38 File Offset: 0x00006C38
	public MemoryStream method_3(string string_0)
	{
		byte[] array = File.ReadAllBytes(string_0);
		return new MemoryStream(this.method_2(ref array));
	}

	// Token: 0x04000085 RID: 133
	private TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider_0;
}
