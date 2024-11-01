using System;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Extension;

namespace Server.Helper
{
	// Token: 0x0200004A RID: 74
	public static class CreateCertificate
	{
		// Token: 0x060002B4 RID: 692 RVA: 0x0001D7F0 File Offset: 0x0001B9F0
		public static X509Certificate2 CreateCertificateAuthority(string caName, int keyStrength)
		{
			SecureRandom random = new SecureRandom(new CryptoApiRandomGenerator());
			RsaKeyPairGenerator rsaKeyPairGenerator = new RsaKeyPairGenerator();
			rsaKeyPairGenerator.Init(new KeyGenerationParameters(random, keyStrength));
			AsymmetricCipherKeyPair asymmetricCipherKeyPair = rsaKeyPairGenerator.GenerateKeyPair();
			X509V3CertificateGenerator x509V3CertificateGenerator = new X509V3CertificateGenerator();
			X509Name x509Name = new X509Name("CN=" + caName);
			BigInteger serialNumber = BigInteger.ProbablePrime(120, random);
			x509V3CertificateGenerator.SetSerialNumber(serialNumber);
			x509V3CertificateGenerator.SetSubjectDN(x509Name);
			x509V3CertificateGenerator.SetIssuerDN(x509Name);
			x509V3CertificateGenerator.SetNotAfter(DateTime.MaxValue);
			x509V3CertificateGenerator.SetNotBefore(DateTime.UtcNow.Subtract(new TimeSpan(2, 0, 0, 0)));
			x509V3CertificateGenerator.SetPublicKey(asymmetricCipherKeyPair.Public);
			x509V3CertificateGenerator.AddExtension(X509Extensions.SubjectKeyIdentifier, false, new SubjectKeyIdentifierStructure(asymmetricCipherKeyPair.Public));
			x509V3CertificateGenerator.AddExtension(X509Extensions.BasicConstraints, true, new BasicConstraints(true));
			ISignatureFactory signatureCalculatorFactory = new Asn1SignatureFactory("SHA512WITHRSA", asymmetricCipherKeyPair.Private, random);
			return new X509Certificate2(DotNetUtilities.ToX509Certificate(x509V3CertificateGenerator.Generate(signatureCalculatorFactory)))
			{
				PrivateKey = DotNetUtilities.ToRSA(asymmetricCipherKeyPair.Private as RsaPrivateCrtKeyParameters)
			};
		}
	}
}
