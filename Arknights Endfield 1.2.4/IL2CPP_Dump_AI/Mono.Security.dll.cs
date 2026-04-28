// ========================================================
// Dumped by @desirepro
// Assembly: Mono.Security.dll
// Classes:  104
// Module:   GameAssembly.dll  base=0x7FFF30CA0000
// Date:     Apr 28 2026 09:05:59
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: <Module>
TYPE:  class
TOKEN: 0x2000001
SIZE:  0x1
FIELDS:
METHODS:
END_CLASS

CLASS: Locale
TYPE:  sealed class
TOKEN: 0x2000002
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0339AE90  token=0x6000001  System.String GetText(System.String msg)
  RVA=0x04275A04  token=0x6000002  System.String GetText(System.String fmt, System.Object[] args)
END_CLASS

CLASS: ContentInfo
TYPE:  class
TOKEN: 0x2000007
SIZE:  0x20
FIELDS:
  private           System.String                   contentType  // 0x10
  private           Mono.Security.ASN1              content  // 0x18
PROPERTIES:
  ASN1  get=0x09115038
  Content  get=0x01041090  set=0x022C3A90
  ContentType  get=0x020B7B20  set=0x0426FEE0
METHODS:
  RVA=0x09114D50  token=0x6000023  System.Void .ctor()
  RVA=0x09114E30  token=0x6000024  System.Void .ctor(System.String oid)
  RVA=0x09114DB8  token=0x6000025  System.Void .ctor(System.Byte[] data)
  RVA=0x09114E60  token=0x6000026  System.Void .ctor(Mono.Security.ASN1 asn1)
  RVA=0x09114CB4  token=0x600002C  Mono.Security.ASN1 GetASN1()
END_CLASS

CLASS: EncryptedData
TYPE:  class
TOKEN: 0x2000008
SIZE:  0x30
FIELDS:
  private           System.Byte                     _version  // 0x10
  private           Mono.Security.PKCS7.ContentInfo _content  // 0x18
  private           Mono.Security.PKCS7.ContentInfo _encryptionAlgorithm  // 0x20
  private           System.Byte[]                   _encrypted  // 0x28
PROPERTIES:
  EncryptionAlgorithm  get=0x03D4EB40
  EncryptedContent  get=0x09115DC8
METHODS:
  RVA=0x03D557C0  token=0x600002D  System.Void .ctor()
  RVA=0x091159A8  token=0x600002E  System.Void .ctor(Mono.Security.ASN1 asn1)
END_CLASS

CLASS: SignedData
TYPE:  class
TOKEN: 0x2000009
SIZE:  0x48
FIELDS:
  private           System.Byte                     version  // 0x10
  private           System.String                   hashAlgorithm  // 0x18
  private           Mono.Security.PKCS7.ContentInfo contentInfo  // 0x20
  private           Mono.Security.X509.X509CertificateCollectioncerts  // 0x28
  private           System.Collections.ArrayList    crls  // 0x30
  private           Mono.Security.PKCS7.SignerInfo  signerInfo  // 0x38
  private           System.Boolean                  mda  // 0x40
PROPERTIES:
  Certificates  get=0x03D4EAC0
  ContentInfo  get=0x03D4EB40
  HashName  set=0x0911DA6C
  SignerInfo  get=0x03D4E2A0
METHODS:
  RVA=0x0911D494  token=0x6000031  System.Void .ctor(Mono.Security.ASN1 asn1)
  RVA=0x0911D324  token=0x6000036  System.String OidToName(System.String oid)
END_CLASS

CLASS: SignerInfo
TYPE:  class
TOKEN: 0x200000A
SIZE:  0x50
FIELDS:
  private           System.Byte                     version  // 0x10
  private           System.String                   hashAlgorithm  // 0x18
  private           System.Collections.ArrayList    authenticatedAttributes  // 0x20
  private           System.Collections.ArrayList    unauthenticatedAttributes  // 0x28
  private           System.Byte[]                   signature  // 0x30
  private           System.String                   issuer  // 0x38
  private           System.Byte[]                   serial  // 0x40
  private           System.Byte[]                   ski  // 0x48
PROPERTIES:
  IssuerName  get=0x03D4E2A0
  SerialNumber  get=0x0911DF68
  AuthenticatedAttributes  get=0x03D4EB40
  HashName  get=0x01041090  set=0x022C3A90
  Signature  get=0x0911DFBC
  UnauthenticatedAttributes  get=0x03D4EAC0
  Version  get=0x011797F0
METHODS:
  RVA=0x0911DAA4  token=0x6000037  System.Void .ctor()
  RVA=0x0911DB38  token=0x6000038  System.Void .ctor(Mono.Security.ASN1 asn1)
END_CLASS

CLASS: DeriveBytes
TYPE:  class
TOKEN: 0x200000D
SIZE:  0x30
FIELDS:
  private   static  System.Byte[]                   keyDiversifier  // static @ 0x0
  private   static  System.Byte[]                   ivDiversifier  // static @ 0x8
  private   static  System.Byte[]                   macDiversifier  // static @ 0x10
  private           System.String                   _hashName  // 0x10
  private           System.Int32                    _iterations  // 0x18
  private           System.Byte[]                   _password  // 0x20
  private           System.Byte[]                   _salt  // 0x28
PROPERTIES:
  HashName  set=0x0426FEE0
  IterationCount  set=0x03D4E9C0
  Password  set=0x091157BC
  Salt  set=0x09115848
METHODS:
  RVA=0x0350B670  token=0x6000065  System.Void .ctor()
  RVA=0x0911508C  token=0x600006A  System.Void Adjust(System.Byte[] a, System.Int32 aOff, System.Byte[] b)
  RVA=0x09115278  token=0x600006B  System.Byte[] Derive(System.Byte[] diversifier, System.Int32 n)
  RVA=0x091151B4  token=0x600006C  System.Byte[] DeriveKey(System.Int32 size)
  RVA=0x09115150  token=0x600006D  System.Byte[] DeriveIV(System.Int32 size)
  RVA=0x09115214  token=0x600006E  System.Byte[] DeriveMAC(System.Int32 size)
  RVA=0x09115678  token=0x600006F  System.Void .cctor()
END_CLASS

CLASS: X509CrlEntry
TYPE:  class
TOKEN: 0x2000010
SIZE:  0x28
FIELDS:
  private           System.Byte[]                   sn  // 0x10
  private           System.DateTime                 revocationDate  // 0x18
  private           Mono.Security.X509.X509ExtensionCollectionextensions  // 0x20
PROPERTIES:
  SerialNumber  get=0x09123300
  RevocationDate  get=0x01041090
  Extensions  get=0x03D4EB40
METHODS:
  RVA=0x09123208  token=0x6000089  System.Void .ctor(Mono.Security.ASN1 entry)
END_CLASS

CLASS: X509CertificateEnumerator
TYPE:  class
TOKEN: 0x2000013
SIZE:  0x18
IMPLEMENTS: System.Collections.IEnumerator
FIELDS:
  private           System.Collections.IEnumerator  enumerator  // 0x10
PROPERTIES:
  Current  get=0x091209B8
  System.Collections.IEnumerator.Current  get=0x0912090C
METHODS:
  RVA=0x09120958  token=0x60000B5  System.Void .ctor(Mono.Security.X509.X509CertificateCollection mappings)
  RVA=0x09120878  token=0x60000B8  System.Boolean System.Collections.IEnumerator.MoveNext()
  RVA=0x091208C0  token=0x60000B9  System.Void System.Collections.IEnumerator.Reset()
  RVA=0x09120830  token=0x60000BA  System.Boolean MoveNext()
END_CLASS

CLASS: AttributeTypeAndValue
TYPE:  abstract class
TOKEN: 0x200001C
SIZE:  0x28
FIELDS:
  private           System.String                   oid  // 0x10
  private           System.String                   attrValue  // 0x18
  private           System.Int32                    upperBound  // 0x20
  private           System.Byte                     encoding  // 0x24
PROPERTIES:
  Value  set=0x09112180
METHODS:
  RVA=0x09112134  token=0x60000E8  System.Void .ctor(System.String oid, System.Int32 upperBound)
  RVA=0x0911215C  token=0x60000E9  System.Void .ctor(System.String oid, System.Int32 upperBound, System.Byte encoding)
  RVA=0x09111F5C  token=0x60000EB  Mono.Security.ASN1 GetASN1(System.Byte encoding)
  RVA=0x09111F50  token=0x60000EC  Mono.Security.ASN1 GetASN1()
  RVA=0x091120E0  token=0x60000ED  System.Byte SelectBestEncoding()
END_CLASS

CLASS: CommonName
TYPE:  class
TOKEN: 0x200001D
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x09114C70  token=0x60000EE  System.Void .ctor()
END_CLASS

CLASS: SerialNumber
TYPE:  class
TOKEN: 0x200001E
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x0911D2D8  token=0x60000EF  System.Void .ctor()
END_CLASS

CLASS: LocalityName
TYPE:  class
TOKEN: 0x200001F
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x09115EA4  token=0x60000F0  System.Void .ctor()
END_CLASS

CLASS: StateOrProvinceName
TYPE:  class
TOKEN: 0x2000020
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x0911E010  token=0x60000F1  System.Void .ctor()
END_CLASS

CLASS: OrganizationName
TYPE:  class
TOKEN: 0x2000021
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x09115EF8  token=0x60000F2  System.Void .ctor()
END_CLASS

CLASS: OrganizationalUnitName
TYPE:  class
TOKEN: 0x2000022
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x09115F3C  token=0x60000F3  System.Void .ctor()
END_CLASS

CLASS: EmailAddress
TYPE:  class
TOKEN: 0x2000023
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x0911595C  token=0x60000F4  System.Void .ctor()
END_CLASS

CLASS: DomainComponent
TYPE:  class
TOKEN: 0x2000024
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x09115910  token=0x60000F5  System.Void .ctor()
END_CLASS

CLASS: UserId
TYPE:  class
TOKEN: 0x2000025
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x0911E0DC  token=0x60000F6  System.Void .ctor()
END_CLASS

CLASS: Oid
TYPE:  class
TOKEN: 0x2000026
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x09115EE8  token=0x60000F7  System.Void .ctor(System.String oid)
END_CLASS

CLASS: Title
TYPE:  class
TOKEN: 0x2000027
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x0911E098  token=0x60000F8  System.Void .ctor()
END_CLASS

CLASS: CountryName
TYPE:  class
TOKEN: 0x2000028
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x09115040  token=0x60000F9  System.Void .ctor()
END_CLASS

CLASS: DnQualifier
TYPE:  class
TOKEN: 0x2000029
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x091158C4  token=0x60000FA  System.Void .ctor()
END_CLASS

CLASS: Surname
TYPE:  class
TOKEN: 0x200002A
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x0911E054  token=0x60000FB  System.Void .ctor()
END_CLASS

CLASS: GivenName
TYPE:  class
TOKEN: 0x200002B
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x09115E1C  token=0x60000FC  System.Void .ctor()
END_CLASS

CLASS: Initial
TYPE:  class
TOKEN: 0x200002C
SIZE:  0x28
EXTENDS: AttributeTypeAndValue
FIELDS:
METHODS:
  RVA=0x09115E60  token=0x60000FD  System.Void .ctor()
END_CLASS

CLASS: PrivateKeyInfo
TYPE:  class
TOKEN: 0x200004F
SIZE:  0x30
FIELDS:
  private           System.Int32                    _version  // 0x10
  private           System.String                   _algorithm  // 0x18
  private           System.Byte[]                   _key  // 0x20
  private           System.Collections.ArrayList    _list  // 0x28
PROPERTIES:
  Algorithm  get=0x01041090  set=0x022C3A90
  PrivateKey  get=0x091310F4  set=0x09131148
METHODS:
  RVA=0x0913105C  token=0x60001A6  System.Void .ctor()
  RVA=0x091310C4  token=0x60001A7  System.Void .ctor(System.Byte[] data)
  RVA=0x091304E4  token=0x60001AC  System.Void Decode(System.Byte[] data)
  RVA=0x09130B30  token=0x60001AD  System.Byte[] GetBytes()
  RVA=0x09130FB8  token=0x60001AE  System.Byte[] RemoveLeadingZero(System.Byte[] bigInt)
  RVA=0x09130F20  token=0x60001AF  System.Byte[] Normalize(System.Byte[] bigInt, System.Int32 length)
  RVA=0x0912FFCC  token=0x60001B0  System.Security.Cryptography.RSA DecodeRSA(System.Byte[] keypair)
  RVA=0x0913082C  token=0x60001B1  System.Byte[] Encode(System.Security.Cryptography.RSA rsa)
  RVA=0x0912FE9C  token=0x60001B2  System.Security.Cryptography.DSA DecodeDSA(System.Byte[] privateKey, System.Security.Cryptography.DSAParameters dsaParameters)
  RVA=0x091307E8  token=0x60001B3  System.Byte[] Encode(System.Security.Cryptography.DSA dsa)
  RVA=0x09130A28  token=0x60001B4  System.Byte[] Encode(System.Security.Cryptography.AsymmetricAlgorithm aa)
END_CLASS

CLASS: EncryptedPrivateKeyInfo
TYPE:  class
TOKEN: 0x2000050
SIZE:  0x30
FIELDS:
  private           System.String                   _algorithm  // 0x10
  private           System.Byte[]                   _salt  // 0x18
  private           System.Int32                    _iterations  // 0x20
  private           System.Byte[]                   _data  // 0x28
PROPERTIES:
  Algorithm  get=0x020B7B20  set=0x0426FEE0
  EncryptedData  get=0x0912A2F0  set=0x0912A3E0
  Salt  get=0x0912A344
  IterationCount  get=0x01003B50  set=0x0912A450
METHODS:
  RVA=0x0350B670  token=0x60001B5  System.Void .ctor()
  RVA=0x0912A2E8  token=0x60001B6  System.Void .ctor(System.Byte[] data)
  RVA=0x09129D08  token=0x60001BE  System.Void Decode(System.Byte[] data)
  RVA=0x0912A0E8  token=0x60001BF  System.Byte[] GetBytes()
END_CLASS

CLASS: KeyGeneratedEventHandler
TYPE:  sealed class
TOKEN: 0x2000052
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x06E7B27C  token=0x60001CD  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x02065C10  token=0x60001CE  System.Void Invoke(System.Object sender, System.EventArgs e)
END_CLASS

CLASS: Sign
TYPE:  sealed struct
TOKEN: 0x2000056
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Math.BigInteger.Sign       Negative  // const
  public    static  Mono.Math.BigInteger.Sign       Zero  // const
  public    static  Mono.Math.BigInteger.Sign       Positive  // const
METHODS:
END_CLASS

CLASS: ModulusRing
TYPE:  sealed class
TOKEN: 0x2000057
SIZE:  0x20
FIELDS:
  private           Mono.Math.BigInteger            mod  // 0x10
  private           Mono.Math.BigInteger            constant  // 0x18
METHODS:
  RVA=0x0912E3E4  token=0x600020D  System.Void .ctor(Mono.Math.BigInteger modulus)
  RVA=0x0912DC98  token=0x600020E  System.Void BarrettReduction(Mono.Math.BigInteger x)
  RVA=0x0912E0F0  token=0x600020F  Mono.Math.BigInteger Multiply(Mono.Math.BigInteger a, Mono.Math.BigInteger b)
  RVA=0x0912DF54  token=0x6000210  Mono.Math.BigInteger Difference(Mono.Math.BigInteger a, Mono.Math.BigInteger b)
  RVA=0x0912E2D0  token=0x6000211  Mono.Math.BigInteger Pow(Mono.Math.BigInteger a, Mono.Math.BigInteger k)
  RVA=0x0912E24C  token=0x6000212  Mono.Math.BigInteger Pow(System.UInt32 b, Mono.Math.BigInteger exp)
END_CLASS

CLASS: Kernel
TYPE:  sealed class
TOKEN: 0x2000058
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0912A4D4  token=0x6000213  Mono.Math.BigInteger AddSameSign(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  RVA=0x0912B298  token=0x6000214  Mono.Math.BigInteger Subtract(Mono.Math.BigInteger big, Mono.Math.BigInteger small)
  RVA=0x0912AB70  token=0x6000215  System.Void MinusEq(Mono.Math.BigInteger big, Mono.Math.BigInteger small)
  RVA=0x0912AEE0  token=0x6000216  System.Void PlusEq(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  RVA=0x0912A6A4  token=0x6000217  Mono.Math.BigInteger.Sign Compare(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  RVA=0x0912B22C  token=0x6000218  System.UInt32 SingleByteDivideInPlace(Mono.Math.BigInteger n, System.UInt32 d)
  RVA=0x0912A940  token=0x6000219  System.UInt32 DwordMod(Mono.Math.BigInteger n, System.UInt32 d)
  RVA=0x0912A7D8  token=0x600021A  Mono.Math.BigInteger[] DwordDivMod(Mono.Math.BigInteger n, System.UInt32 d)
  RVA=0x0912B980  token=0x600021B  Mono.Math.BigInteger[] multiByteDivide(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  RVA=0x0912A998  token=0x600021C  Mono.Math.BigInteger LeftShift(Mono.Math.BigInteger bi, System.Int32 n)
  RVA=0x0912B078  token=0x600021D  Mono.Math.BigInteger RightShift(Mono.Math.BigInteger bi, System.Int32 n)
  RVA=0x0912ADCC  token=0x600021E  System.Void Multiply(System.UInt32[] x, System.UInt32 xOffset, System.UInt32 xLen, System.UInt32[] y, System.UInt32 yOffset, System.UInt32 yLen, System.UInt32[] d, System.UInt32 dOffset)
  RVA=0x0912AC98  token=0x600021F  System.Void MultiplyMod2p32pmod(System.UInt32[] x, System.Int32 xOffset, System.Int32 xLen, System.UInt32[] y, System.Int32 yOffest, System.Int32 yLen, System.UInt32[] d, System.Int32 dOffset, System.Int32 mod)
  RVA=0x0912B444  token=0x6000220  System.UInt32 modInverse(Mono.Math.BigInteger bi, System.UInt32 modulus)
  RVA=0x0912B4F0  token=0x6000221  Mono.Math.BigInteger modInverse(Mono.Math.BigInteger bi, Mono.Math.BigInteger modulus)
END_CLASS

CLASS: __StaticArrayInitTypeSize=3
TYPE:  sealed struct
TOKEN: 0x200005F
SIZE:  0x13
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=9
TYPE:  sealed struct
TOKEN: 0x2000060
SIZE:  0x19
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=10
TYPE:  sealed struct
TOKEN: 0x2000061
SIZE:  0x1A
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=18
TYPE:  sealed struct
TOKEN: 0x2000062
SIZE:  0x22
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=20
TYPE:  sealed struct
TOKEN: 0x2000063
SIZE:  0x24
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=32
TYPE:  sealed struct
TOKEN: 0x2000064
SIZE:  0x30
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=48
TYPE:  sealed struct
TOKEN: 0x2000065
SIZE:  0x40
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=64
TYPE:  sealed struct
TOKEN: 0x2000066
SIZE:  0x50
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=256
TYPE:  sealed struct
TOKEN: 0x2000067
SIZE:  0x110
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=3132
TYPE:  sealed struct
TOKEN: 0x2000068
SIZE:  0xC4C
FIELDS:
METHODS:
END_CLASS

CLASS: <PrivateImplementationDetails>
TYPE:  sealed class
TOKEN: 0x200005E
SIZE:  0x10
FIELDS:
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64001D686DB504E20C792EAA07FE09224A45FF328E24A80072D04D16ABC5C2B5D2  // static @ 0x0
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=313225E3E48132FBDBE9B7C0C6C54D7C10A5DE12A105AA3E5DE2A0DC808BF245B7A5  // static @ 0x40
  private   static readonly System.Int64                    290C4A052C215D096172EB81AEE671FB3286E5C1DB5E73F96021FC09825DDB88  // static @ 0xc80
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=332D0830B8EE1D49A66F395C8EA80E02BFC07C2A12A8EA8C8B484AF02108A1950  // static @ 0xc88
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=335BF50EEF3270FD8CA09E66FC5B0481C5A151B14F6A634854E32F63633D49DCB  // static @ 0xc8b
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=33C0C410618682C4DF0474E034114CC8E562F05A512B521AC367571017BDFA75D  // static @ 0xc8e
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=344F5B1A2C48314502ACCBF186D1A2F9F7F176825898F32F1A2047B956194F174  // static @ 0xc91
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=484800FBFC4566EB02D1727A4B1C949CCBC7535C216A0766564C199308631B5DD6  // static @ 0xc94
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20533B8C444F951E83EFF7305E3807B66CE0005DE0A2D0A44873C130895A3BE6AA  // static @ 0xcc4
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=25655D0BF716B334D123E0088CFB3F8E2FEA17AF5025BB527F95EEB09BA978EA329  // static @ 0xcd8
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=359BE5A634187B8A57216EFF5371A47732C05744B1C1A0A6382A6D5622C9FFDCE  // static @ 0xdd8
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=325DF6E0E2761359D30A8275058E299FCC0381534545F55CF43E41983F5D4C9456  // static @ 0xddb
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=35F8C6B3C66B972606D85E7651F67ADBD02E8316876884674E8328FA710747E5B  // static @ 0xdfb
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1060C6ED13AF98DBFEEDA8F8197FFFCC349BB04395CC81DF0D477CBC57BF5B398B  // static @ 0xdfe
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1064B3E7D737AFF47D4C3BBD81D2D06D697DDD8EB60F29E13E4425D19D8BBCA1F7  // static @ 0xe08
  private   static readonly System.Int64                    6772A9B8BF207A3CFE6EE68769D6985B69522183F24A2A3D41BC3B4602953426  // static @ 0xe18
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9684312AFB7719E57993D2826FFBAF7EA965614F20F91D999FB19B01E21AA62E6  // static @ 0xe20
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=646AA56C4BCD208911792AD24C7681FEFB93BED51903AFC54860C9BD37E41E5A31  // static @ 0xe29
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3796E63069E193A008CB4E85573AA1FE53C5F4E58B42A7F61FD0EEE1D89B5120B  // static @ 0xe69
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=647C8975E1E60A5C8337F28EDF8C33C3B180360B7279644A9BC1AF3C51E6220BF5  // static @ 0xe6c
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3850D7367E4FB0766E2CBC3ACF5AB42B4E98348E58E5A789845D4FCCDB63D2AEE  // static @ 0xeac
  private   static readonly System.Int64                    992F16C986809AB68C7466CC3EC6F12B2506A962EA539753E5D84A2FB7FF8A24  // static @ 0xeb0
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=39A65C09A11757751BFED67A414E00B188DC4C7757FCB6CBD33A916DDE4A3D925  // static @ 0xeb8
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=189ACEFCC0C950280B64AB9E045E38C34ABF71EC70A0DC61B9C621C6BFB4F78047  // static @ 0xebb
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3B1E34F4A11EE411B83415EF0B252A0B2BBCFCAC2E592865E09C12E4252C93A75  // static @ 0xecd
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3C92FAD7F348A682E7D5B7E74C76B5D019174EE7BC87545B25A1FDD49FBCC2D0B  // static @ 0xed0
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3E17B8359E685992B0DE6242AAA24FCB7404173CBB7FF8646FF7D658139F41B5F  // static @ 0xed3
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64F83B332BE4E6A5A4B1C56AAF6DB52657DA495E149870057D8590AB9D7A6167AD  // static @ 0xed6
  private   static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3FB6D7301FFDCB5FBA5807A19B4F0606947897C1105240B6BBA815352DBBE2064  // static @ 0xf16
METHODS:
  RVA=0x056516CC  token=0x6000230  System.UInt32 ComputeStringHash(System.String s)
END_CLASS

CLASS: Mono.Math.BigInteger
TYPE:  class
TOKEN: 0x2000055
SIZE:  0x20
FIELDS:
  private           System.UInt32                   length  // 0x10
  private           System.UInt32[]                 data  // 0x18
  private   static readonly System.UInt32[]                 smallPrimes  // static @ 0x0
  private   static  System.Security.Cryptography.RandomNumberGeneratorrng  // static @ 0x8
PROPERTIES:
  Rng  get=0x0912913C
METHODS:
  RVA=0x09128D8C  token=0x60001E1  System.Void .ctor(Mono.Math.BigInteger.Sign sign, System.UInt32 len)
  RVA=0x09128CF4  token=0x60001E2  System.Void .ctor(Mono.Math.BigInteger bi)
  RVA=0x09129088  token=0x60001E3  System.Void .ctor(Mono.Math.BigInteger bi, System.UInt32 len)
  RVA=0x09128DEC  token=0x60001E4  System.Void .ctor(System.Byte[] inData)
  RVA=0x09129014  token=0x60001E5  System.Void .ctor(System.UInt32 ui)
  RVA=0x091293F4  token=0x60001E6  Mono.Math.BigInteger op_Implicit(System.UInt32 value)
  RVA=0x09129454  token=0x60001E7  Mono.Math.BigInteger op_Implicit(System.Int32 value)
  RVA=0x091291E4  token=0x60001E8  Mono.Math.BigInteger op_Addition(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  RVA=0x09129874  token=0x60001E9  Mono.Math.BigInteger op_Subtraction(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  RVA=0x09129650  token=0x60001EA  System.UInt32 op_Modulus(Mono.Math.BigInteger bi, System.UInt32 ui)
  RVA=0x09129624  token=0x60001EB  Mono.Math.BigInteger op_Modulus(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  RVA=0x091292AC  token=0x60001EC  Mono.Math.BigInteger op_Division(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  RVA=0x09129658  token=0x60001ED  Mono.Math.BigInteger op_Multiply(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  RVA=0x091295F0  token=0x60001EE  Mono.Math.BigInteger op_LeftShift(Mono.Math.BigInteger bi1, System.Int32 shiftVal)
  RVA=0x0912986C  token=0x60001EF  Mono.Math.BigInteger op_RightShift(Mono.Math.BigInteger bi1, System.Int32 shiftVal)
  RVA=0x091283DC  token=0x60001F1  Mono.Math.BigInteger GenerateRandom(System.Int32 bits, System.Security.Cryptography.RandomNumberGenerator rng)
  RVA=0x0912853C  token=0x60001F2  Mono.Math.BigInteger GenerateRandom(System.Int32 bits)
  RVA=0x091281E8  token=0x60001F3  System.Int32 BitCount()
  RVA=0x0912891C  token=0x60001F4  System.Boolean TestBit(System.Int32 bitNum)
  RVA=0x091288BC  token=0x60001F5  System.Void SetBit(System.UInt32 bitNum)
  RVA=0x091288C8  token=0x60001F6  System.Void SetBit(System.UInt32 bitNum, System.Boolean value)
  RVA=0x0912876C  token=0x60001F7  System.Int32 LowestSetBit()
  RVA=0x09128588  token=0x60001F8  System.Byte[] GetBytes()
  RVA=0x091292D8  token=0x60001F9  System.Boolean op_Equality(Mono.Math.BigInteger bi1, System.UInt32 ui)
  RVA=0x09129598  token=0x60001FA  System.Boolean op_Inequality(Mono.Math.BigInteger bi1, System.UInt32 ui)
  RVA=0x09129330  token=0x60001FB  System.Boolean op_Equality(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  RVA=0x09129504  token=0x60001FC  System.Boolean op_Inequality(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  RVA=0x091293DC  token=0x60001FD  System.Boolean op_GreaterThan(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  RVA=0x09129610  token=0x60001FE  System.Boolean op_LessThan(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  RVA=0x091293C4  token=0x60001FF  System.Boolean op_GreaterThanOrEqual(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  RVA=0x091295F8  token=0x6000200  System.Boolean op_LessThanOrEqual(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2)
  RVA=0x09128C0C  token=0x6000201  System.String ToString(System.UInt32 radix)
  RVA=0x091289BC  token=0x6000202  System.String ToString(System.UInt32 radix, System.String characterSet)
  RVA=0x09128870  token=0x6000203  System.Void Normalize()
  RVA=0x09128244  token=0x6000204  System.Void Clear()
  RVA=0x091286A0  token=0x6000205  System.Int32 GetHashCode()
  RVA=0x09128C58  token=0x6000206  System.String ToString()
  RVA=0x0912828C  token=0x6000207  System.Boolean Equals(System.Object o)
  RVA=0x091287E0  token=0x6000208  Mono.Math.BigInteger ModInverse(Mono.Math.BigInteger modulus)
  RVA=0x091287E8  token=0x6000209  Mono.Math.BigInteger ModPow(Mono.Math.BigInteger exp, Mono.Math.BigInteger n)
  RVA=0x0912836C  token=0x600020A  Mono.Math.BigInteger GeneratePseudoPrime(System.Int32 bits)
  RVA=0x091286E4  token=0x600020B  System.Void Incr2()
  RVA=0x09128C68  token=0x600020C  System.Void .cctor()
END_CLASS

CLASS: Mono.Math.Prime.ConfidenceFactor
TYPE:  sealed struct
TOKEN: 0x2000059
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Math.Prime.ConfidenceFactorExtraLow  // const
  public    static  Mono.Math.Prime.ConfidenceFactorLow  // const
  public    static  Mono.Math.Prime.ConfidenceFactorMedium  // const
  public    static  Mono.Math.Prime.ConfidenceFactorHigh  // const
  public    static  Mono.Math.Prime.ConfidenceFactorExtraHigh  // const
  public    static  Mono.Math.Prime.ConfidenceFactorProvable  // const
METHODS:
END_CLASS

CLASS: Mono.Math.Prime.PrimalityTest
TYPE:  sealed class
TOKEN: 0x200005A
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x0912F8D0  token=0x6000222  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x01165340  token=0x6000223  System.Boolean Invoke(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence)
END_CLASS

CLASS: Mono.Math.Prime.PrimalityTests
TYPE:  sealed class
TOKEN: 0x200005B
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0912F9F8  token=0x6000224  System.Int32 GetSPPRounds(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence)
  RVA=0x0912FBAC  token=0x6000225  System.Boolean RabinMillerTest(Mono.Math.BigInteger n, Mono.Math.Prime.ConfidenceFactor confidence)
END_CLASS

CLASS: Mono.Math.Prime.Generator.PrimeGeneratorBase
TYPE:  abstract class
TOKEN: 0x200005C
SIZE:  0x10
FIELDS:
PROPERTIES:
  Confidence  get=0x02102C70
  PrimalityTest  get=0x0912FE34
  TrialDivisionBounds  get=0x03D5D090
METHODS:
  RVA=-1  // abstract  token=0x6000229  Mono.Math.BigInteger GenerateNewPrime(System.Int32 bits)
  RVA=0x0350B670  token=0x600022A  System.Void .ctor()
END_CLASS

CLASS: Mono.Math.Prime.Generator.SequentialSearchPrimeGeneratorBase
TYPE:  class
TOKEN: 0x200005D
SIZE:  0x10
EXTENDS: Mono.Math.Prime.Generator.PrimeGeneratorBase
FIELDS:
METHODS:
  RVA=0x09133088  token=0x600022B  Mono.Math.BigInteger GenerateSearchBase(System.Int32 bits, System.Object context)
  RVA=0x0913307C  token=0x600022C  Mono.Math.BigInteger GenerateNewPrime(System.Int32 bits)
  RVA=0x09132E68  token=0x600022D  Mono.Math.BigInteger GenerateNewPrime(System.Int32 bits, System.Object context)
  RVA=0x0232EB60  token=0x600022E  System.Boolean IsPrimeAcceptable(Mono.Math.BigInteger bi, System.Object context)
  RVA=0x0350B670  token=0x600022F  System.Void .ctor()
END_CLASS

CLASS: Mono.Security.ASN1
TYPE:  class
TOKEN: 0x2000003
SIZE:  0x28
FIELDS:
  private           System.Byte                     m_nTag  // 0x10
  private           System.Byte[]                   m_aValue  // 0x18
  private           System.Collections.ArrayList    elist  // 0x20
PROPERTIES:
  Count  get=0x09111D64
  Tag  get=0x011797F0
  Length  get=0x08972AA4
  Value  get=0x09111E7C  set=0x09111EDC
  Item  get=0x09111D8C
METHODS:
  RVA=0x04275ADC  token=0x6000003  System.Void .ctor(System.Byte tag)
  RVA=0x02F73D00  token=0x6000004  System.Void .ctor(System.Byte tag, System.Byte[] data)
  RVA=0x09111BF4  token=0x6000005  System.Void .ctor(System.Byte[] data)
  RVA=0x091110A4  token=0x600000B  System.Boolean CompareArray(System.Byte[] array1, System.Byte[] array2)
  RVA=0x09111108  token=0x600000C  System.Boolean CompareValue(System.Byte[] value)
  RVA=0x0911100C  token=0x600000D  Mono.Security.ASN1 Add(Mono.Security.ASN1 asn1)
  RVA=0x09111450  token=0x600000E  System.Byte[] GetBytes()
  RVA=0x09111218  token=0x600000F  System.Void Decode(System.Byte[] asn1, System.Int32& anPos, System.Int32 anLength)
  RVA=0x09111118  token=0x6000010  System.Void DecodeTLV(System.Byte[] asn1, System.Int32& pos, System.Byte& tag, System.Int32& length, System.Byte[]& content)
  RVA=0x0911133C  token=0x6000012  Mono.Security.ASN1 Element(System.Int32 index, System.Byte anTag)
  RVA=0x091119CC  token=0x6000013  System.String ToString()
END_CLASS

CLASS: Mono.Security.ASN1Convert
TYPE:  static class
TOKEN: 0x2000004
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x091104D8  token=0x6000014  Mono.Security.ASN1 FromInt32(System.Int32 value)
  RVA=0x09110608  token=0x6000015  Mono.Security.ASN1 FromOid(System.String oid)
  RVA=0x091106E0  token=0x6000016  Mono.Security.ASN1 FromUnsignedBigInteger(System.Byte[] big)
  RVA=0x09110C84  token=0x6000017  System.Int32 ToInt32(Mono.Security.ASN1 asn1)
  RVA=0x09110DA8  token=0x6000018  System.String ToOid(Mono.Security.ASN1 asn1)
  RVA=0x091107FC  token=0x6000019  System.DateTime ToDateTime(Mono.Security.ASN1 time)
END_CLASS

CLASS: Mono.Security.BitConverterLE
TYPE:  sealed class
TOKEN: 0x2000005
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09112A74  token=0x600001A  System.Byte[] GetUIntBytes(System.Byte* bytes)
  RVA=0x09112B50  token=0x600001B  System.Byte[] GetULongBytes(System.Byte* bytes)
  RVA=0x09112A58  token=0x600001C  System.Byte[] GetBytes(System.Int32 value)
  RVA=0x09112A3C  token=0x600001D  System.Byte[] GetBytes(System.Int64 value)
  RVA=0x09112DF4  token=0x600001E  System.Void UShortFromBytes(System.Byte* dst, System.Byte[] src, System.Int32 startIndex)
  RVA=0x09112CFC  token=0x600001F  System.Void UIntFromBytes(System.Byte* dst, System.Byte[] src, System.Int32 startIndex)
  RVA=0x09112CAC  token=0x6000020  System.Int32 ToInt32(System.Byte[] value, System.Int32 startIndex)
  RVA=0x09112CD4  token=0x6000021  System.UInt16 ToUInt16(System.Byte[] value, System.Int32 startIndex)
  RVA=0x09112CAC  token=0x6000022  System.UInt32 ToUInt32(System.Byte[] value, System.Int32 startIndex)
END_CLASS

CLASS: Mono.Security.PKCS7
TYPE:  sealed class
TOKEN: 0x2000006
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: Mono.Security.Authenticode.AuthenticodeBase
TYPE:  class
TOKEN: 0x2000053
SIZE:  0x40
FIELDS:
  private           System.Byte[]                   fileblock  // 0x10
  private           System.IO.Stream                fs  // 0x18
  private           System.Int32                    blockNo  // 0x20
  private           System.Int32                    blockLength  // 0x24
  private           System.Int32                    peOffset  // 0x28
  private           System.Int32                    dirSecurityOffset  // 0x2c
  private           System.Int32                    dirSecuritySize  // 0x30
  private           System.Int32                    coffSymbolTableOffset  // 0x34
  private           System.Boolean                  pe64  // 0x38
PROPERTIES:
  PEOffset  get=0x09126834
METHODS:
  RVA=0x091267EC  token=0x60001CF  System.Void .ctor()
  RVA=0x09126390  token=0x60001D1  System.Void Open(System.String filename)
  RVA=0x09126430  token=0x60001D2  System.Void Open(System.Byte[] rawdata)
  RVA=0x09125E80  token=0x60001D3  System.Void Close()
  RVA=0x09126708  token=0x60001D4  System.Void ReadFirstBlock()
  RVA=0x091264C0  token=0x60001D5  System.Int32 ProcessFirstBlock()
  RVA=0x091262E0  token=0x60001D6  System.Byte[] GetSecurityEntry()
  RVA=0x09125EBC  token=0x60001D7  System.Byte[] GetHash(System.Security.Cryptography.HashAlgorithm hash)
END_CLASS

CLASS: Mono.Security.Authenticode.AuthenticodeDeformatter
TYPE:  class
TOKEN: 0x2000054
SIZE:  0x98
EXTENDS: Mono.Security.Authenticode.AuthenticodeBase
FIELDS:
  private           System.String                   filename  // 0x40
  private           System.Byte[]                   rawdata  // 0x48
  private           System.Byte[]                   hash  // 0x50
  private           Mono.Security.X509.X509CertificateCollectioncoll  // 0x58
  private           Mono.Security.ASN1              signedHash  // 0x60
  private           System.DateTime                 timestamp  // 0x68
  private           Mono.Security.X509.X509CertificatesigningCertificate  // 0x70
  private           System.Int32                    reason  // 0x78
  private           System.Boolean                  trustedRoot  // 0x7c
  private           System.Boolean                  trustedTimestampRoot  // 0x7d
  private           System.Byte[]                   entry  // 0x80
  private           Mono.Security.X509.X509Chain    signerChain  // 0x88
  private           Mono.Security.X509.X509Chain    timestampChain  // 0x90
PROPERTIES:
  RawData  set=0x091280FC
  SigningCertificate  get=0x03D4EB30
METHODS:
  RVA=0x09128020  token=0x60001D8  System.Void .ctor()
  RVA=0x091280CC  token=0x60001D9  System.Void .ctor(System.Byte[] rawData)
  RVA=0x09126858  token=0x60001DC  System.Boolean CheckSignature()
  RVA=0x09126B54  token=0x60001DD  System.Boolean CompareIssuerSerial(System.String issuer, System.Byte[] serial, Mono.Security.X509.X509Certificate x509)
  RVA=0x09127600  token=0x60001DE  System.Boolean VerifySignature(Mono.Security.PKCS7.SignedData sd, System.Byte[] calculatedMessageDigest, System.Security.Cryptography.HashAlgorithm ha)
  RVA=0x09126CF0  token=0x60001DF  System.Boolean VerifyCounterSignature(Mono.Security.PKCS7.SignerInfo cs, System.Byte[] signature)
  RVA=0x09126C14  token=0x60001E0  System.Void Reset()
END_CLASS

CLASS: Mono.Security.Cryptography.CryptoConvert
TYPE:  sealed class
TOKEN: 0x2000048
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x09129C18  token=0x600017F  System.String ToHex(System.Byte[] input)
  RVA=0x09129A40  token=0x6000180  System.Byte FromHexChar(System.Char c)
  RVA=0x09129AC8  token=0x6000181  System.Byte[] FromHex(System.String hex)
END_CLASS

CLASS: Mono.Security.Cryptography.MD2
TYPE:  abstract class
TOKEN: 0x2000049
SIZE:  0x28
EXTENDS: System.Security.Cryptography.HashAlgorithm
FIELDS:
METHODS:
  RVA=0x03D6E650  token=0x6000182  System.Void .ctor()
  RVA=0x0912C500  token=0x6000183  Mono.Security.Cryptography.MD2 Create()
END_CLASS

CLASS: Mono.Security.Cryptography.MD2Managed
TYPE:  class
TOKEN: 0x200004A
SIZE:  0x50
EXTENDS: Mono.Security.Cryptography.MD2
FIELDS:
  private           System.Byte[]                   state  // 0x28
  private           System.Byte[]                   checksum  // 0x30
  private           System.Byte[]                   buffer  // 0x38
  private           System.Int32                    count  // 0x40
  private           System.Byte[]                   x  // 0x48
  private   static readonly System.Byte[]                   PI_SUBST  // static @ 0x0
METHODS:
  RVA=0x0912C344  token=0x6000184  System.Byte[] Padding(System.Int32 nLength)
  RVA=0x0912C448  token=0x6000185  System.Void .ctor()
  RVA=0x0912C0A8  token=0x6000186  System.Void Initialize()
  RVA=0x0912BEFC  token=0x6000187  System.Void HashCore(System.Byte[] array, System.Int32 ibStart, System.Int32 cbSize)
  RVA=0x0912BFF8  token=0x6000188  System.Byte[] HashFinal()
  RVA=0x0912C104  token=0x6000189  System.Void MD2Transform(System.Byte[] state, System.Byte[] checksum, System.Byte[] block, System.Int32 index)
  RVA=0x0912C3BC  token=0x600018A  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.Cryptography.MD4
TYPE:  abstract class
TOKEN: 0x200004B
SIZE:  0x28
EXTENDS: System.Security.Cryptography.HashAlgorithm
FIELDS:
METHODS:
  RVA=0x03D6E650  token=0x600018B  System.Void .ctor()
  RVA=0x0912D840  token=0x600018C  Mono.Security.Cryptography.MD4 Create()
END_CLASS

CLASS: Mono.Security.Cryptography.MD4Managed
TYPE:  class
TOKEN: 0x200004C
SIZE:  0x50
EXTENDS: Mono.Security.Cryptography.MD4
FIELDS:
  private           System.UInt32[]                 state  // 0x28
  private           System.Byte[]                   buffer  // 0x30
  private           System.UInt32[]                 count  // 0x38
  private           System.UInt32[]                 x  // 0x40
  private           System.Byte[]                   digest  // 0x48
METHODS:
  RVA=0x0912D760  token=0x600018D  System.Void .ctor()
  RVA=0x0912C92C  token=0x600018E  System.Void Initialize()
  RVA=0x0912C6AC  token=0x600018F  System.Void HashCore(System.Byte[] array, System.Int32 ibStart, System.Int32 cbSize)
  RVA=0x0912C82C  token=0x6000190  System.Byte[] HashFinal()
  RVA=0x0912D704  token=0x6000191  System.Byte[] Padding(System.Int32 nLength)
  RVA=0x03D6E6A0  token=0x6000192  System.UInt32 F(System.UInt32 x, System.UInt32 y, System.UInt32 z)
  RVA=0x03D6E700  token=0x6000193  System.UInt32 G(System.UInt32 x, System.UInt32 y, System.UInt32 z)
  RVA=0x03D6E750  token=0x6000194  System.UInt32 H(System.UInt32 x, System.UInt32 y, System.UInt32 z)
  RVA=0x03D6E760  token=0x6000195  System.UInt32 ROL(System.UInt32 x, System.Byte n)
  RVA=0x03D6E660  token=0x6000196  System.Void FF(System.UInt32& a, System.UInt32 b, System.UInt32 c, System.UInt32 d, System.UInt32 x, System.Byte s)
  RVA=0x03D6E6B0  token=0x6000197  System.Void GG(System.UInt32& a, System.UInt32 b, System.UInt32 c, System.UInt32 d, System.UInt32 x, System.Byte s)
  RVA=0x03D6E710  token=0x6000198  System.Void HH(System.UInt32& a, System.UInt32 b, System.UInt32 c, System.UInt32 d, System.UInt32 x, System.Byte s)
  RVA=0x0912C5E8  token=0x6000199  System.Void Encode(System.Byte[] output, System.UInt32[] input)
  RVA=0x0912C550  token=0x600019A  System.Void Decode(System.UInt32[] output, System.Byte[] input, System.Int32 index)
  RVA=0x0912C9F8  token=0x600019B  System.Void MD4Transform(System.UInt32[] state, System.Byte[] block, System.Int32 index)
END_CLASS

CLASS: Mono.Security.Cryptography.PKCS1
TYPE:  sealed class
TOKEN: 0x200004D
SIZE:  0x10
FIELDS:
  private   static  System.Byte[]                   emptySHA1  // static @ 0x0
  private   static  System.Byte[]                   emptySHA256  // static @ 0x8
  private   static  System.Byte[]                   emptySHA384  // static @ 0x10
  private   static  System.Byte[]                   emptySHA512  // static @ 0x18
METHODS:
  RVA=0x0912EA24  token=0x600019C  System.Boolean Compare(System.Byte[] array1, System.Byte[] array2)
  RVA=0x0912F448  token=0x600019D  System.Byte[] I2OSP(System.Byte[] x, System.Int32 size)
  RVA=0x0912F4C8  token=0x600019E  System.Byte[] OS2IP(System.Byte[] x)
  RVA=0x031874E0  token=0x600019F  System.Byte[] RSAVP1(System.Security.Cryptography.RSA rsa, System.Byte[] s)
  RVA=0x0912F578  token=0x60001A0  System.Boolean Verify_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, System.Byte[] hashValue, System.Byte[] signature, System.Boolean tryNonStandardEncoding)
  RVA=0x0912EE18  token=0x60001A1  System.Byte[] Encode_v15(System.Security.Cryptography.HashAlgorithm hash, System.Byte[] hashValue, System.Int32 emLength)
  RVA=0x0912F130  token=0x60001A2  System.String HashNameFromOid(System.String oid, System.Boolean throwOnError)
  RVA=0x0912EDC8  token=0x60001A3  System.Security.Cryptography.HashAlgorithm CreateFromOid(System.String oid)
  RVA=0x0912EA88  token=0x60001A4  System.Security.Cryptography.HashAlgorithm CreateFromName(System.String name)
  RVA=0x0912F734  token=0x60001A5  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.Cryptography.PKCS8
TYPE:  sealed class
TOKEN: 0x200004E
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: Mono.Security.Cryptography.RSAManaged
TYPE:  class
TOKEN: 0x2000051
SIZE:  0x70
EXTENDS: System.Security.Cryptography.RSA
FIELDS:
  private           System.Boolean                  isCRTpossible  // 0x20
  private           System.Boolean                  keyBlinding  // 0x21
  private           System.Boolean                  keypairGenerated  // 0x22
  private           System.Boolean                  m_disposed  // 0x23
  private           Mono.Math.BigInteger            d  // 0x28
  private           Mono.Math.BigInteger            p  // 0x30
  private           Mono.Math.BigInteger            q  // 0x38
  private           Mono.Math.BigInteger            dp  // 0x40
  private           Mono.Math.BigInteger            dq  // 0x48
  private           Mono.Math.BigInteger            qInv  // 0x50
  private           Mono.Math.BigInteger            n  // 0x58
  private           Mono.Math.BigInteger            e  // 0x60
  private           Mono.Security.Cryptography.RSAManaged.KeyGeneratedEventHandlerKeyGenerated  // 0x68
PROPERTIES:
  KeySize  get=0x09132D50
  PublicOnly  get=0x09132DE8
METHODS:
  RVA=0x09132C84  token=0x60001C0  System.Void .ctor()
  RVA=0x09132C94  token=0x60001C1  System.Void .ctor(System.Int32 keySize)
  RVA=0x09131CE0  token=0x60001C2  System.Void Finalize()
  RVA=0x09131D58  token=0x60001C3  System.Void GenerateKeyPair()
  RVA=0x09131210  token=0x60001C6  System.Byte[] DecryptValue(System.Byte[] rgb)
  RVA=0x091317F0  token=0x60001C7  System.Byte[] EncryptValue(System.Byte[] rgb)
  RVA=0x0913191C  token=0x60001C8  System.Security.Cryptography.RSAParameters ExportParameters(System.Boolean includePrivateParameters)
  RVA=0x091320C8  token=0x60001C9  System.Void ImportParameters(System.Security.Cryptography.RSAParameters parameters)
  RVA=0x09131580  token=0x60001CA  System.Void Dispose(System.Boolean disposing)
  RVA=0x091326EC  token=0x60001CB  System.String ToXmlString(System.Boolean includePrivateParameters)
  RVA=0x0913201C  token=0x60001CC  System.Byte[] GetPaddedValue(Mono.Math.BigInteger value, System.Int32 length)
END_CLASS

CLASS: Mono.Security.Interface.AlertLevel
TYPE:  sealed struct
TOKEN: 0x2000038
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Mono.Security.Interface.AlertLevelWarning  // const
  public    static  Mono.Security.Interface.AlertLevelFatal  // const
METHODS:
END_CLASS

CLASS: Mono.Security.Interface.AlertDescription
TYPE:  sealed struct
TOKEN: 0x2000039
SIZE:  0x11
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Mono.Security.Interface.AlertDescriptionCloseNotify  // const
  public    static  Mono.Security.Interface.AlertDescriptionUnexpectedMessage  // const
  public    static  Mono.Security.Interface.AlertDescriptionBadRecordMAC  // const
  public    static  Mono.Security.Interface.AlertDescriptionDecryptionFailed_RESERVED  // const
  public    static  Mono.Security.Interface.AlertDescriptionRecordOverflow  // const
  public    static  Mono.Security.Interface.AlertDescriptionDecompressionFailure  // const
  public    static  Mono.Security.Interface.AlertDescriptionHandshakeFailure  // const
  public    static  Mono.Security.Interface.AlertDescriptionNoCertificate_RESERVED  // const
  public    static  Mono.Security.Interface.AlertDescriptionBadCertificate  // const
  public    static  Mono.Security.Interface.AlertDescriptionUnsupportedCertificate  // const
  public    static  Mono.Security.Interface.AlertDescriptionCertificateRevoked  // const
  public    static  Mono.Security.Interface.AlertDescriptionCertificateExpired  // const
  public    static  Mono.Security.Interface.AlertDescriptionCertificateUnknown  // const
  public    static  Mono.Security.Interface.AlertDescriptionIlegalParameter  // const
  public    static  Mono.Security.Interface.AlertDescriptionUnknownCA  // const
  public    static  Mono.Security.Interface.AlertDescriptionAccessDenied  // const
  public    static  Mono.Security.Interface.AlertDescriptionDecodeError  // const
  public    static  Mono.Security.Interface.AlertDescriptionDecryptError  // const
  public    static  Mono.Security.Interface.AlertDescriptionExportRestriction  // const
  public    static  Mono.Security.Interface.AlertDescriptionProtocolVersion  // const
  public    static  Mono.Security.Interface.AlertDescriptionInsuficientSecurity  // const
  public    static  Mono.Security.Interface.AlertDescriptionInternalError  // const
  public    static  Mono.Security.Interface.AlertDescriptionUserCancelled  // const
  public    static  Mono.Security.Interface.AlertDescriptionNoRenegotiation  // const
  public    static  Mono.Security.Interface.AlertDescriptionUnsupportedExtension  // const
METHODS:
END_CLASS

CLASS: Mono.Security.Interface.Alert
TYPE:  class
TOKEN: 0x200003A
SIZE:  0x18
FIELDS:
  private           Mono.Security.Interface.AlertLevellevel  // 0x10
  private           Mono.Security.Interface.AlertDescriptiondescription  // 0x11
PROPERTIES:
  Level  get=0x011797F0
  Description  get=0x03D510E0
METHODS:
  RVA=0x09125E08  token=0x6000141  System.Void .ctor(Mono.Security.Interface.AlertDescription description)
  RVA=0x09125E14  token=0x6000142  System.Void inferAlertLevel()
  RVA=0x09125D74  token=0x6000143  System.String ToString()
END_CLASS

CLASS: Mono.Security.Interface.ValidationResult
TYPE:  class
TOKEN: 0x200003B
SIZE:  0x20
FIELDS:
  private           System.Boolean                  trusted  // 0x10
  private           System.Boolean                  user_denied  // 0x11
  private           System.Int32                    error_code  // 0x14
  private           System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors>policy_errors  // 0x18
PROPERTIES:
  Trusted  get=0x011797F0
  UserDenied  get=0x03D510E0
METHODS:
  RVA=0x03D6E7D0  token=0x6000144  System.Void .ctor(System.Boolean trusted, System.Boolean user_denied, System.Int32 error_code, System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors)
END_CLASS

CLASS: Mono.Security.Interface.ICertificateValidator
TYPE:  interface
TOKEN: 0x200003C
FIELDS:
METHODS:
END_CLASS

CLASS: Mono.Security.Interface.CipherSuiteCode
TYPE:  sealed struct
TOKEN: 0x200003D
SIZE:  0x12
FIELDS:
  public            System.UInt16                   value__  // 0x10
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_NULL_WITH_NULL_NULL  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_NULL_MD5  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_NULL_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_EXPORT_WITH_RC4_40_MD5  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_RC4_128_MD5  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_RC4_128_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_IDEA_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_EXPORT_WITH_DES40_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_DES_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_DES_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_DES_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_DES_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_DES_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_EXPORT_WITH_RC4_40_MD5  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_RC4_128_MD5  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_DES_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_CAMELLIA_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_CAMELLIA_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_CAMELLIA_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_CAMELLIA_256_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_SEED_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_SEED_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_SEED_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_SEED_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_SEED_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_SEED_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_RC4_128_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_RC4_128_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_RC4_128_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_NULL_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_RC4_128_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_NULL_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_RC4_128_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_NULL_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_RC4_128_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_NULL_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_RC4_128_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_anon_WITH_NULL_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_anon_WITH_RC4_128_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_anon_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_anon_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_NULL_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_NULL_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_NULL_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_NULL_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_256_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_AES_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_AES_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_AES_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_AES_256_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_AES_256_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_AES_256_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_256_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_AES_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_AES_256_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_AES_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_AES_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_AES_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_AES_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_AES_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_AES_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_AES_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_AES_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_AES_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_AES_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_AES_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_AES_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_AES_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_AES_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_NULL_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_NULL_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_NULL_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_NULL_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_AES_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_AES_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_NULL_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_NULL_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_RC4_128_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_AES_128_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_AES_256_CBC_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_NULL_SHA  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_NULL_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_NULL_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_EMPTY_RENEGOTIATION_INFO_SCSV  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_CAMELLIA_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_CAMELLIA_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_CAMELLIA_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_CAMELLIA_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_CAMELLIA_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_CAMELLIA_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_128_CCM  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_256_CCM  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_128_CCM  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_256_CCM  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_128_CCM_8  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_AES_256_CCM_8  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_128_CCM_8  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_AES_256_CCM_8  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_128_CCM  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_256_CCM  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_128_CCM  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_AES_256_CCM  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_128_CCM_8  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_AES_256_CCM_8  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_DHE_WITH_AES_128_CCM_8  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_DHE_WITH_AES_256_CCM_8  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_ESTREAM_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_WITH_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_RSA_WITH_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_ECDSA_WITH_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_ESTREAM_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_PSK_WITH_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_ECDHE_PSK_WITH_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_RSA_PSK_WITH_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_PSK_WITH_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_DHE_RSA_WITH_SALSA20_SHA1  // const
  public    static  Mono.Security.Interface.CipherSuiteCodeTLS_FALLBACK_SCSV  // const
METHODS:
END_CLASS

CLASS: Mono.Security.Interface.MonoTlsConnectionInfo
TYPE:  class
TOKEN: 0x200003E
SIZE:  0x20
FIELDS:
  private           Mono.Security.Interface.CipherSuiteCode<CipherSuiteCode>k__BackingField  // 0x10
  private           Mono.Security.Interface.TlsProtocols<ProtocolVersion>k__BackingField  // 0x14
  private           System.String                   <PeerDomainName>k__BackingField  // 0x18
PROPERTIES:
  CipherSuiteCode  get=0x03D61390  set=0x03D60960
  ProtocolVersion  get=0x03D50CC0  set=0x03D595B0
  PeerDomainName  set=0x022C3A90
METHODS:
  RVA=0x0912E5AC  token=0x600014C  System.String ToString()
  RVA=0x0350B670  token=0x600014D  System.Void .ctor()
END_CLASS

CLASS: Mono.Security.Interface.MonoSslPolicyErrors
TYPE:  sealed struct
TOKEN: 0x200003F
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Security.Interface.MonoSslPolicyErrorsNone  // const
  public    static  Mono.Security.Interface.MonoSslPolicyErrorsRemoteCertificateNotAvailable  // const
  public    static  Mono.Security.Interface.MonoSslPolicyErrorsRemoteCertificateNameMismatch  // const
  public    static  Mono.Security.Interface.MonoSslPolicyErrorsRemoteCertificateChainErrors  // const
METHODS:
END_CLASS

CLASS: Mono.Security.Interface.MonoRemoteCertificateValidationCallback
TYPE:  sealed class
TOKEN: 0x2000040
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x0912E4D8  token=0x600014E  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x0101C850  token=0x600014F  System.Boolean Invoke(System.String targetHost, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, Mono.Security.Interface.MonoSslPolicyErrors sslPolicyErrors)
END_CLASS

CLASS: Mono.Security.Interface.MonoLocalCertificateSelectionCallback
TYPE:  sealed class
TOKEN: 0x2000041
SIZE:  0x80
EXTENDS: System.MulticastDelegate
FIELDS:
METHODS:
  RVA=0x081A0B58  token=0x6000150  System.Void .ctor(System.Object object, System.IntPtr method)
  RVA=0x0101C850  token=0x6000151  System.Security.Cryptography.X509Certificates.X509Certificate Invoke(System.String targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers)
END_CLASS

CLASS: Mono.Security.Interface.MonoTlsProvider
TYPE:  abstract class
TOKEN: 0x2000042
SIZE:  0x10
FIELDS:
PROPERTIES:
  ID  get=-1  // abstract
  Name  get=-1  // abstract
  SupportsSslStream  get=-1  // abstract
  SupportsConnectionInfo  get=-1  // abstract
  SupportsMonoExtensions  get=-1  // abstract
  SupportedProtocols  get=-1  // abstract
  SupportsCleanShutdown  get=-1  // abstract
METHODS:
  RVA=0x0350B670  token=0x6000152  System.Void .ctor()
END_CLASS

CLASS: Mono.Security.Interface.MonoTlsProviderFactory
TYPE:  static class
TOKEN: 0x2000043
SIZE:  0x10
FIELDS:
METHODS:
  RVA=0x0912E644  token=0x600015A  Mono.Security.Interface.MonoTlsProvider GetProvider()
END_CLASS

CLASS: Mono.Security.Interface.MonoTlsSettings
TYPE:  sealed class
TOKEN: 0x2000044
SIZE:  0x80
FIELDS:
  private           Mono.Security.Interface.MonoRemoteCertificateValidationCallback<RemoteCertificateValidationCallback>k__BackingField  // 0x10
  private           Mono.Security.Interface.MonoLocalCertificateSelectionCallback<ClientCertificateSelectionCallback>k__BackingField  // 0x18
  private           System.Nullable<System.DateTime><CertificateValidationTime>k__BackingField  // 0x20
  private           System.Security.Cryptography.X509Certificates.X509CertificateCollection<TrustAnchors>k__BackingField  // 0x30
  private           System.Object                   <UserSettings>k__BackingField  // 0x38
  private           System.String[]                 <CertificateSearchPaths>k__BackingField  // 0x40
  private           System.Boolean                  <SendCloseNotify>k__BackingField  // 0x48
  private           System.String[]                 <ClientCertificateIssuers>k__BackingField  // 0x50
  private           System.Boolean                  <DisallowUnauthenticatedCertificateRequest>k__BackingField  // 0x58
  private           System.Nullable<Mono.Security.Interface.TlsProtocols><EnabledProtocols>k__BackingField  // 0x5c
  private           Mono.Security.Interface.CipherSuiteCode[]<EnabledCiphers>k__BackingField  // 0x68
  private           System.Boolean                  cloned  // 0x70
  private           System.Boolean                  checkCertName  // 0x71
  private           System.Boolean                  checkCertRevocationStatus  // 0x72
  private           System.Nullable<System.Boolean> useServicePointManagerCallback  // 0x73
  private           System.Boolean                  skipSystemValidators  // 0x75
  private           System.Boolean                  callbackNeedsChain  // 0x76
  private           Mono.Security.Interface.ICertificateValidatorcertificateValidator  // 0x78
  private   static  Mono.Security.Interface.MonoTlsSettingsdefaultSettings  // static @ 0x0
PROPERTIES:
  RemoteCertificateValidationCallback  get=0x020B7B20  set=0x0426FEE0
  ClientCertificateSelectionCallback  get=0x01041090  set=0x022C3A90
  UseServicePointManagerCallback  get=0x03D6E7A0  set=0x03D6E7C0
  CallbackNeedsCertificateChain  get=0x03D589B0
  CertificateValidationTime  get=0x03D54E00  set=0x03D54E10
  TrustAnchors  get=0x01003830  set=0x04270470
  UserSettings  get=0x03D4E2A0  set=0x0388FF30
  CertificateSearchPaths  get=0x03D4E2B0  set=0x03CB2D80
  SendCloseNotify  get=0x03D4EFE0  set=0x03D4F010
  ClientCertificateIssuers  get=0x03D4EAF0  set=0x02C926C0
  DisallowUnauthenticatedCertificateRequest  get=0x03D4F7E0  set=0x03D4F7F0
  EnabledProtocols  get=0x03D6E790  set=0x03D6E7B0
  EnabledCiphers  get=0x03D4EAB0  set=0x038C5570
  DefaultSettings  get=0x0912E91C
  CertificateValidator  get=0x03D4EB20
METHODS:
  RVA=0x03D6E780  token=0x6000174  System.Void .ctor()
  RVA=0x0912E774  token=0x6000176  Mono.Security.Interface.MonoTlsSettings CopyDefaultSettings()
  RVA=0x0912E680  token=0x6000178  Mono.Security.Interface.MonoTlsSettings CloneWithValidator(Mono.Security.Interface.ICertificateValidator validator)
  RVA=0x0912E714  token=0x6000179  Mono.Security.Interface.MonoTlsSettings Clone()
  RVA=0x0912E798  token=0x600017A  System.Void .ctor(Mono.Security.Interface.MonoTlsSettings other)
END_CLASS

CLASS: Mono.Security.Interface.TlsException
TYPE:  sealed class
TOKEN: 0x2000045
SIZE:  0x98
EXTENDS: System.Exception
FIELDS:
  private           Mono.Security.Interface.Alert   alert  // 0x90
METHODS:
  RVA=0x09133258  token=0x600017B  System.Void .ctor(Mono.Security.Interface.Alert alert)
  RVA=0x091330E8  token=0x600017C  System.Void .ctor(Mono.Security.Interface.Alert alert, System.String message)
  RVA=0x091331E0  token=0x600017D  System.Void .ctor(Mono.Security.Interface.AlertDescription description)
  RVA=0x09133158  token=0x600017E  System.Void .ctor(Mono.Security.Interface.AlertDescription description, System.String message)
END_CLASS

CLASS: Mono.Security.Interface.TlsProtocolCode
TYPE:  sealed struct
TOKEN: 0x2000046
SIZE:  0x12
FIELDS:
  public            System.Int16                    value__  // 0x10
  public    static  Mono.Security.Interface.TlsProtocolCodeTls10  // const
  public    static  Mono.Security.Interface.TlsProtocolCodeTls11  // const
  public    static  Mono.Security.Interface.TlsProtocolCodeTls12  // const
METHODS:
END_CLASS

CLASS: Mono.Security.Interface.TlsProtocols
TYPE:  sealed struct
TOKEN: 0x2000047
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Security.Interface.TlsProtocolsZero  // const
  public    static  Mono.Security.Interface.TlsProtocolsTls10Client  // const
  public    static  Mono.Security.Interface.TlsProtocolsTls10Server  // const
  public    static  Mono.Security.Interface.TlsProtocolsTls10  // const
  public    static  Mono.Security.Interface.TlsProtocolsTls11Client  // const
  public    static  Mono.Security.Interface.TlsProtocolsTls11Server  // const
  public    static  Mono.Security.Interface.TlsProtocolsTls11  // const
  public    static  Mono.Security.Interface.TlsProtocolsTls12Client  // const
  public    static  Mono.Security.Interface.TlsProtocolsTls12Server  // const
  public    static  Mono.Security.Interface.TlsProtocolsTls12  // const
  public    static  Mono.Security.Interface.TlsProtocolsClientMask  // const
  public    static  Mono.Security.Interface.TlsProtocolsServerMask  // const
METHODS:
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.ChallengeResponse
TYPE:  class
TOKEN: 0x200002F
SIZE:  0x30
IMPLEMENTS: System.IDisposable
FIELDS:
  private   static  System.Byte[]                   magic  // static @ 0x0
  private   static  System.Byte[]                   nullEncMagic  // static @ 0x8
  private           System.Boolean                  _disposed  // 0x10
  private           System.Byte[]                   _challenge  // 0x18
  private           System.Byte[]                   _lmpwd  // 0x20
  private           System.Byte[]                   _ntpwd  // 0x28
PROPERTIES:
  Password  set=0x09114948
  Challenge  set=0x09114828
  LM  get=0x09114740
  NT  get=0x091147B4
METHODS:
  RVA=0x091146D4  token=0x6000108  System.Void .ctor()
  RVA=0x09114688  token=0x6000109  System.Void .ctor(System.String password, System.Byte[] challenge)
  RVA=0x0911407C  token=0x600010A  System.Void Finalize()
  RVA=0x09113FB8  token=0x600010F  System.Void Dispose()
  RVA=0x09114008  token=0x6000110  System.Void Dispose(System.Boolean disposing)
  RVA=0x091140F4  token=0x6000111  System.Byte[] GetResponse(System.Byte[] pwd)
  RVA=0x091143C4  token=0x6000112  System.Byte[] PrepareDESKey(System.Byte[] key56bits, System.Int32 position)
  RVA=0x091142A0  token=0x6000113  System.Byte[] PasswordToKey(System.String password, System.Int32 position)
  RVA=0x091145A4  token=0x6000114  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.ChallengeResponse2
TYPE:  static class
TOKEN: 0x2000030
SIZE:  0x10
FIELDS:
  private   static  System.Byte[]                   magic  // static @ 0x0
  private   static  System.Byte[]                   nullEncMagic  // static @ 0x8
METHODS:
  RVA=0x09112EA8  token=0x6000115  System.Byte[] Compute_LM(System.String password, System.Byte[] challenge)
  RVA=0x091130E4  token=0x6000116  System.Byte[] Compute_NTLM_Password(System.String password)
  RVA=0x091131E4  token=0x6000117  System.Byte[] Compute_NTLM(System.String password, System.Byte[] challenge)
  RVA=0x09113240  token=0x6000118  System.Void Compute_NTLMv2_Session(System.String password, System.Byte[] challenge, System.Byte[]& lm, System.Byte[]& ntlm)
  RVA=0x09113414  token=0x6000119  System.Byte[] Compute_NTLMv2(Mono.Security.Protocol.Ntlm.Type2Message type2, System.String username, System.String password, System.String domain)
  RVA=0x0911383C  token=0x600011A  System.Void Compute(Mono.Security.Protocol.Ntlm.Type2Message type2, Mono.Security.Protocol.Ntlm.NtlmAuthLevel level, System.String username, System.String password, System.String domain, System.Byte[]& lm, System.Byte[]& ntlm)
  RVA=0x09113A04  token=0x600011B  System.Byte[] GetResponse(System.Byte[] challenge, System.Byte[] pwd)
  RVA=0x09113CF4  token=0x600011C  System.Byte[] PrepareDESKey(System.Byte[] key56bits, System.Int32 position)
  RVA=0x09113BBC  token=0x600011D  System.Byte[] PasswordToKey(System.String password, System.Int32 position)
  RVA=0x09113ED4  token=0x600011E  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.MessageBase
TYPE:  abstract class
TOKEN: 0x2000031
SIZE:  0x18
FIELDS:
  private   static  System.Byte[]                   header  // static @ 0x0
  private           System.Int32                    _type  // 0x10
  private           Mono.Security.Protocol.Ntlm.NtlmFlags_flags  // 0x14
PROPERTIES:
  Flags  get=0x03D50CC0  set=0x03D595B0
  Type  get=0x03D4E340
METHODS:
  RVA=0x010410F0  token=0x600011F  System.Void .ctor(System.Int32 messageType)
  RVA=0x0912DB30  token=0x6000123  System.Byte[] PrepareMessage(System.Int32 messageSize)
  RVA=0x0912D974  token=0x6000124  System.Void Decode(System.Byte[] message)
  RVA=0x0912D890  token=0x6000125  System.Boolean CheckHeader(System.Byte[] message)
  RVA=-1  // abstract  token=0x6000126  System.Byte[] GetBytes()
  RVA=0x0912DC0C  token=0x6000127  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.NtlmAuthLevel
TYPE:  sealed struct
TOKEN: 0x2000032
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Security.Protocol.Ntlm.NtlmAuthLevelLM_and_NTLM  // const
  public    static  Mono.Security.Protocol.Ntlm.NtlmAuthLevelLM_and_NTLM_and_try_NTLMv2_Session  // const
  public    static  Mono.Security.Protocol.Ntlm.NtlmAuthLevelNTLM_only  // const
  public    static  Mono.Security.Protocol.Ntlm.NtlmAuthLevelNTLMv2_only  // const
METHODS:
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.NtlmFlags
TYPE:  sealed struct
TOKEN: 0x2000033
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiateUnicode  // const
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiateOem  // const
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsRequestTarget  // const
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiateNtlm  // const
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiateDomainSupplied  // const
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiateWorkstationSupplied  // const
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiateAlwaysSign  // const
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiateNtlm2Key  // const
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiate128  // const
  public    static  Mono.Security.Protocol.Ntlm.NtlmFlagsNegotiate56  // const
METHODS:
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.NtlmSettings
TYPE:  static class
TOKEN: 0x2000034
SIZE:  0x10
FIELDS:
  private   static  Mono.Security.Protocol.Ntlm.NtlmAuthLeveldefaultAuthLevel  // static @ 0x0
PROPERTIES:
  DefaultAuthLevel  get=0x0912E9D4
METHODS:
  RVA=0x0912E998  token=0x6000129  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.Type1Message
TYPE:  class
TOKEN: 0x2000035
SIZE:  0x28
EXTENDS: Mono.Security.Protocol.Ntlm.MessageBase
FIELDS:
  private           System.String                   _host  // 0x18
  private           System.String                   _domain  // 0x20
PROPERTIES:
  Domain  set=0x091336C8
  Host  set=0x0913373C
METHODS:
  RVA=0x0913365C  token=0x600012A  System.Void .ctor()
  RVA=0x091332D0  token=0x600012D  System.Void Decode(System.Byte[] message)
  RVA=0x091333B0  token=0x600012E  System.Byte[] GetBytes()
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.Type2Message
TYPE:  class
TOKEN: 0x2000036
SIZE:  0x30
EXTENDS: Mono.Security.Protocol.Ntlm.MessageBase
FIELDS:
  private           System.Byte[]                   _nonce  // 0x18
  private           System.String                   _targetName  // 0x20
  private           System.Byte[]                   _targetInfo  // 0x28
PROPERTIES:
  Nonce  get=0x09133AE8
  TargetName  get=0x03D4EB40
  TargetInfo  get=0x09133B38
METHODS:
  RVA=0x09133A64  token=0x600012F  System.Void .ctor(System.Byte[] message)
  RVA=0x0913391C  token=0x6000130  System.Void Finalize()
  RVA=0x091337B0  token=0x6000134  System.Void Decode(System.Byte[] message)
  RVA=0x091339A4  token=0x6000135  System.Byte[] GetBytes()
END_CLASS

CLASS: Mono.Security.Protocol.Ntlm.Type3Message
TYPE:  class
TOKEN: 0x2000037
SIZE:  0x60
EXTENDS: Mono.Security.Protocol.Ntlm.MessageBase
FIELDS:
  private           Mono.Security.Protocol.Ntlm.NtlmAuthLevel_level  // 0x18
  private           System.Byte[]                   _challenge  // 0x20
  private           System.String                   _host  // 0x28
  private           System.String                   _domain  // 0x30
  private           System.String                   _username  // 0x38
  private           System.String                   _password  // 0x40
  private           Mono.Security.Protocol.Ntlm.Type2Message_type2  // 0x48
  private           System.Byte[]                   _lm  // 0x50
  private           System.Byte[]                   _nt  // 0x58
PROPERTIES:
  Domain  set=0x0913476C
  Password  set=0x03CB2D80
  Username  set=0x0388FF30
METHODS:
  RVA=0x091345D0  token=0x6000136  System.Void .ctor(Mono.Security.Protocol.Ntlm.Type2Message type2)
  RVA=0x09133E78  token=0x6000137  System.Void Finalize()
  RVA=0x09133BE4  token=0x600013B  System.Void Decode(System.Byte[] message)
  RVA=0x09133B88  token=0x600013C  System.String DecodeString(System.Byte[] buffer, System.Int32 offset, System.Int32 len)
  RVA=0x09133DFC  token=0x600013D  System.Byte[] EncodeString(System.String text)
  RVA=0x09133F44  token=0x600013E  System.Byte[] GetBytes()
END_CLASS

CLASS: Mono.Security.X509.SafeBag
TYPE:  class
TOKEN: 0x200000B
SIZE:  0x20
FIELDS:
  private           System.String                   _bagOID  // 0x10
  private           Mono.Security.ASN1              _asn1  // 0x18
PROPERTIES:
  BagOID  get=0x020B7B20
  ASN1  get=0x01041090
METHODS:
  RVA=0x02676770  token=0x6000041  System.Void .ctor(System.String bagOID, Mono.Security.ASN1 asn1)
END_CLASS

CLASS: Mono.Security.X509.PKCS12
TYPE:  class
TOKEN: 0x200000C
SIZE:  0x48
IMPLEMENTS: System.ICloneable
FIELDS:
  private           System.Byte[]                   _password  // 0x10
  private           System.Collections.ArrayList    _keyBags  // 0x18
  private           System.Collections.ArrayList    _secretBags  // 0x20
  private           Mono.Security.X509.X509CertificateCollection_certs  // 0x28
  private           System.Boolean                  _keyBagsChanged  // 0x30
  private           System.Boolean                  _secretBagsChanged  // 0x31
  private           System.Boolean                  _certsChanged  // 0x32
  private           System.Int32                    _iterations  // 0x34
  private           System.Collections.ArrayList    _safeBags  // 0x38
  private           System.Security.Cryptography.RandomNumberGenerator_rng  // 0x40
  private   static  System.Int32                    password_max_length  // static @ 0x0
PROPERTIES:
  Password  set=0x0911D17C
  IterationCount  get=0x03D4EE00  set=0x03D4EE40
  Keys  get=0x0911CB44
  Certificates  get=0x0911C774
  RNG  get=0x0911D148
  MaximumPasswordLength  get=0x0911D0F8
METHODS:
  RVA=0x0911C668  token=0x6000044  System.Void .ctor()
  RVA=0x0911C62C  token=0x6000045  System.Void .ctor(System.Byte[] data)
  RVA=0x0911C5E0  token=0x6000046  System.Void .ctor(System.Byte[] data, System.String password)
  RVA=0x0911746C  token=0x6000047  System.Void Decode(System.Byte[] data)
  RVA=0x09118354  token=0x6000048  System.Void Finalize()
  RVA=0x0911740C  token=0x600004F  System.Boolean Compare(System.Byte[] expected, System.Byte[] actual)
  RVA=0x0911A60C  token=0x6000050  System.Security.Cryptography.SymmetricAlgorithm GetSymmetricAlgorithm(System.String algorithmOid, System.Byte[] salt, System.Int32 iterationCount)
  RVA=0x09117E30  token=0x6000051  System.Byte[] Decrypt(System.String algorithmOid, System.Byte[] salt, System.Int32 iterationCount, System.Byte[] encryptedData)
  RVA=0x09117D5C  token=0x6000052  System.Byte[] Decrypt(Mono.Security.PKCS7.EncryptedData ed)
  RVA=0x09117F14  token=0x6000053  System.Byte[] Encrypt(System.String algorithmOid, System.Byte[] salt, System.Int32 iterationCount, System.Byte[] data)
  RVA=0x0911A3E0  token=0x6000054  System.Security.Cryptography.DSAParameters GetExistingParameters(System.Boolean& found)
  RVA=0x0911654C  token=0x6000055  System.Void AddPrivateKey(Mono.Security.Cryptography.PKCS8.PrivateKeyInfo pki)
  RVA=0x0911B958  token=0x6000056  System.Void ReadSafeBag(Mono.Security.ASN1 safeBag)
  RVA=0x0911AC74  token=0x6000057  Mono.Security.ASN1 Pkcs8ShroudedKeyBagSafeBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes)
  RVA=0x09116888  token=0x6000058  Mono.Security.ASN1 CertificateSafeBag(Mono.Security.X509.X509Certificate x509, System.Collections.IDictionary attributes)
  RVA=0x0911AB60  token=0x6000059  System.Byte[] MAC(System.Byte[] password, System.Byte[] salt, System.Int32 iterations, System.Byte[] data)
  RVA=0x09118428  token=0x600005A  System.Byte[] GetBytes()
  RVA=0x09118034  token=0x600005B  Mono.Security.PKCS7.ContentInfo EncryptedContentInfo(Mono.Security.ASN1 safeBags, System.String algorithmOid)
  RVA=0x09115F80  token=0x600005C  System.Void AddCertificate(Mono.Security.X509.X509Certificate cert)
  RVA=0x09115F8C  token=0x600005D  System.Void AddCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attributes)
  RVA=0x0911C598  token=0x600005E  System.Void RemoveCertificate(Mono.Security.X509.X509Certificate cert)
  RVA=0x0911C1BC  token=0x600005F  System.Void RemoveCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attrs)
  RVA=0x09117384  token=0x6000060  System.Boolean CompareAsymmetricAlgorithm(System.Security.Cryptography.AsymmetricAlgorithm a1, System.Security.Cryptography.AsymmetricAlgorithm a2)
  RVA=0x091161C4  token=0x6000061  System.Void AddPkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes)
  RVA=0x091172A8  token=0x6000062  System.Object Clone()
  RVA=0x0911C5A4  token=0x6000064  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.X509.X501
TYPE:  sealed class
TOKEN: 0x200000E
SIZE:  0x10
FIELDS:
  private   static  System.Byte[]                   countryName  // static @ 0x0
  private   static  System.Byte[]                   organizationName  // static @ 0x8
  private   static  System.Byte[]                   organizationalUnitName  // static @ 0x10
  private   static  System.Byte[]                   commonName  // static @ 0x18
  private   static  System.Byte[]                   localityName  // static @ 0x20
  private   static  System.Byte[]                   stateOrProvinceName  // static @ 0x28
  private   static  System.Byte[]                   streetAddress  // static @ 0x30
  private   static  System.Byte[]                   serialNumber  // static @ 0x38
  private   static  System.Byte[]                   domainComponent  // static @ 0x40
  private   static  System.Byte[]                   userid  // static @ 0x48
  private   static  System.Byte[]                   email  // static @ 0x50
  private   static  System.Byte[]                   dnQualifier  // static @ 0x58
  private   static  System.Byte[]                   title  // static @ 0x60
  private   static  System.Byte[]                   surname  // static @ 0x68
  private   static  System.Byte[]                   givenName  // static @ 0x70
  private   static  System.Byte[]                   initial  // static @ 0x78
METHODS:
  RVA=0x0911FDAC  token=0x6000070  System.String ToString(Mono.Security.ASN1 seq)
  RVA=0x0911FC40  token=0x6000071  System.String ToString(Mono.Security.ASN1 seq, System.Boolean reversed, System.String separator, System.Boolean quotes)
  RVA=0x0911E120  token=0x6000072  System.Void AppendEntry(System.Text.StringBuilder sb, Mono.Security.ASN1 entry, System.Boolean quotes)
  RVA=0x0911EB38  token=0x6000073  Mono.Security.X509.X520.AttributeTypeAndValue GetAttributeFromOid(System.String attributeType)
  RVA=0x0911F3A8  token=0x6000074  System.Boolean IsOid(System.String oid)
  RVA=0x0911F434  token=0x6000075  Mono.Security.X509.X520.AttributeTypeAndValue ReadAttribute(System.String value, System.Int32& pos)
  RVA=0x0911F308  token=0x6000076  System.Boolean IsHex(System.Char c)
  RVA=0x0911F730  token=0x6000077  System.String ReadHex(System.String value, System.Int32& pos)
  RVA=0x0911F5A8  token=0x6000078  System.Int32 ReadEscaped(System.Text.StringBuilder sb, System.String value, System.Int32 pos)
  RVA=0x0911F8B4  token=0x6000079  System.Int32 ReadQuoted(System.Text.StringBuilder sb, System.String value, System.Int32 pos)
  RVA=0x0911F9EC  token=0x600007A  System.String ReadValue(System.String value, System.Int32& pos)
  RVA=0x0911E9B8  token=0x600007B  Mono.Security.ASN1 FromString(System.String rdn)
  RVA=0x0911FEAC  token=0x600007C  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.X509.X509Crl
TYPE:  class
TOKEN: 0x200000F
SIZE:  0x60
FIELDS:
  private           System.String                   issuer  // 0x10
  private           System.Byte                     version  // 0x18
  private           System.DateTime                 thisUpdate  // 0x20
  private           System.DateTime                 nextUpdate  // 0x28
  private           System.Collections.ArrayList    entries  // 0x30
  private           System.String                   signatureOID  // 0x38
  private           System.Byte[]                   signature  // 0x40
  private           Mono.Security.X509.X509ExtensionCollectionextensions  // 0x48
  private           System.Byte[]                   encoded  // 0x50
  private           System.Byte[]                   hash_value  // 0x58
PROPERTIES:
  Extensions  get=0x03D4EA70
  Hash  get=0x091240E4
  IssuerName  get=0x020B7B20
  NextUpdate  get=0x03D4EAC0
METHODS:
  RVA=0x09124010  token=0x600007D  System.Void .ctor(System.Byte[] crl)
  RVA=0x091234F0  token=0x600007E  System.Void Parse(System.Byte[] crl)
  RVA=0x091205B8  token=0x6000083  System.Boolean Compare(System.Byte[] array1, System.Byte[] array2)
  RVA=0x09123350  token=0x6000084  Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(Mono.Security.X509.X509Certificate x509)
  RVA=0x091233D4  token=0x6000085  Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(System.Byte[] serialNumber)
  RVA=0x09123D6C  token=0x6000086  System.Boolean VerifySignature(System.Security.Cryptography.DSA dsa)
  RVA=0x09123CAC  token=0x6000087  System.Boolean VerifySignature(System.Security.Cryptography.RSA rsa)
  RVA=0x09123B34  token=0x6000088  System.Boolean VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa)
END_CLASS

CLASS: Mono.Security.X509.X509Certificate
TYPE:  class
TOKEN: 0x2000011
SIZE:  0xC0
IMPLEMENTS: System.Runtime.Serialization.ISerializable
FIELDS:
  private           Mono.Security.ASN1              decoder  // 0x10
  private           System.Byte[]                   m_encodedcert  // 0x18
  private           System.DateTime                 m_from  // 0x20
  private           System.DateTime                 m_until  // 0x28
  private           Mono.Security.ASN1              issuer  // 0x30
  private           System.String                   m_issuername  // 0x38
  private           System.String                   m_keyalgo  // 0x40
  private           System.Byte[]                   m_keyalgoparams  // 0x48
  private           Mono.Security.ASN1              subject  // 0x50
  private           System.String                   m_subject  // 0x58
  private           System.Byte[]                   m_publickey  // 0x60
  private           System.Byte[]                   signature  // 0x68
  private           System.String                   m_signaturealgo  // 0x70
  private           System.Byte[]                   m_signaturealgoparams  // 0x78
  private           System.Byte[]                   certhash  // 0x80
  private           System.Security.Cryptography.RSA_rsa  // 0x88
  private           System.Security.Cryptography.DSA_dsa  // 0x90
  private           System.Int32                    version  // 0x98
  private           System.Byte[]                   serialnumber  // 0xa0
  private           System.Byte[]                   issuerUniqueID  // 0xa8
  private           System.Byte[]                   subjectUniqueID  // 0xb0
  private           Mono.Security.X509.X509ExtensionCollectionextensions  // 0xb8
  private   static  System.String                   encoding_error  // static @ 0x0
PROPERTIES:
  DSA  get=0x09121A8C  set=0x091227F0
  Extensions  get=0x03D4E750
  Hash  get=0x09121DD0
  IssuerName  get=0x03D4E2A0
  KeyAlgorithm  get=0x03D4E2B0
  KeyAlgorithmParameters  get=0x09122124  set=0x02692290
  PublicKey  get=0x09122178
  RSA  get=0x091221CC  set=0x09122834
  RawData  get=0x091223AC
  SerialNumber  get=0x09122400
  Signature  get=0x09122458
  SubjectName  get=0x03D4EAA0
  ValidFrom  get=0x03D4EB40
  ValidUntil  get=0x03D4EAC0
  Version  get=0x03D4EB50
  IsCurrent  get=0x09121FEC
  IsSelfSigned  get=0x09122038
METHODS:
  RVA=0x09120C18  token=0x600008D  System.Void Parse(System.Byte[] data)
  RVA=0x09121910  token=0x600008E  System.Void .ctor(System.Byte[] data)
  RVA=0x09120A78  token=0x600008F  System.Byte[] GetUnsignedBigInteger(System.Byte[] integer)
  RVA=0x09121830  token=0x60000A3  System.Boolean WasCurrent(System.DateTime instant)
  RVA=0x0912177C  token=0x60000A4  System.Boolean VerifySignature(System.Security.Cryptography.DSA dsa)
  RVA=0x09121684  token=0x60000A5  System.Boolean VerifySignature(System.Security.Cryptography.RSA rsa)
  RVA=0x0912150C  token=0x60000A6  System.Boolean VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa)
  RVA=0x09120A20  token=0x60000A8  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  RVA=0x09120B10  token=0x60000A9  System.Byte[] PEM(System.String type, System.Byte[] data)
  RVA=0x091218B4  token=0x60000AA  System.Void .cctor()
END_CLASS

CLASS: Mono.Security.X509.X509CertificateCollection
TYPE:  class
TOKEN: 0x2000012
SIZE:  0x18
EXTENDS: System.Collections.CollectionBase
IMPLEMENTS: System.Collections.IEnumerable
FIELDS:
PROPERTIES:
  Item  get=0x091207D0
METHODS:
  RVA=0x091207C8  token=0x60000AB  System.Void .ctor()
  RVA=0x0912053C  token=0x60000AD  System.Int32 Add(Mono.Security.X509.X509Certificate value)
  RVA=0x09120470  token=0x60000AE  System.Void AddRange(Mono.Security.X509.X509CertificateCollection value)
  RVA=0x09120610  token=0x60000AF  System.Boolean Contains(Mono.Security.X509.X509Certificate value)
  RVA=0x09120628  token=0x60000B0  Mono.Security.X509.X509CertificateCollection.X509CertificateEnumerator GetEnumerator()
  RVA=0x091207A4  token=0x60000B1  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  RVA=0x06FAB9A8  token=0x60000B2  System.Int32 GetHashCode()
  RVA=0x09120688  token=0x60000B3  System.Int32 IndexOf(Mono.Security.X509.X509Certificate value)
  RVA=0x091205B8  token=0x60000B4  System.Boolean Compare(System.Byte[] array1, System.Byte[] array2)
END_CLASS

CLASS: Mono.Security.X509.X509Chain
TYPE:  class
TOKEN: 0x2000014
SIZE:  0x38
FIELDS:
  private           Mono.Security.X509.X509CertificateCollectionroots  // 0x10
  private           Mono.Security.X509.X509CertificateCollectioncerts  // 0x18
  private           Mono.Security.X509.X509Certificate_root  // 0x20
  private           Mono.Security.X509.X509CertificateCollection_chain  // 0x28
  private           Mono.Security.X509.X509ChainStatusFlags_status  // 0x30
PROPERTIES:
  TrustAnchors  get=0x09123178
METHODS:
  RVA=0x09123114  token=0x60000BB  System.Void .ctor()
  RVA=0x091230A8  token=0x60000BD  System.Void LoadCertificates(Mono.Security.X509.X509CertificateCollection collection)
  RVA=0x09122874  token=0x60000BE  System.Boolean Build(Mono.Security.X509.X509Certificate leaf)
  RVA=0x091230C8  token=0x60000BF  System.Void Reset()
  RVA=0x09123038  token=0x60000C0  System.Boolean IsValid(Mono.Security.X509.X509Certificate cert)
  RVA=0x09122BDC  token=0x60000C1  Mono.Security.X509.X509Certificate FindCertificateParent(Mono.Security.X509.X509Certificate child)
  RVA=0x09122D24  token=0x60000C2  Mono.Security.X509.X509Certificate FindCertificateRoot(Mono.Security.X509.X509Certificate potentialRoot)
  RVA=0x09123008  token=0x60000C3  System.Boolean IsTrusted(Mono.Security.X509.X509Certificate potentialTrusted)
  RVA=0x09122ED8  token=0x60000C4  System.Boolean IsParent(Mono.Security.X509.X509Certificate child, Mono.Security.X509.X509Certificate parent)
END_CLASS

CLASS: Mono.Security.X509.X509ChainStatusFlags
TYPE:  sealed struct
TOKEN: 0x2000015
SIZE:  0x14
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Mono.Security.X509.X509ChainStatusFlagsInvalidBasicConstraints  // const
  public    static  Mono.Security.X509.X509ChainStatusFlagsNoError  // const
  public    static  Mono.Security.X509.X509ChainStatusFlagsNotSignatureValid  // const
  public    static  Mono.Security.X509.X509ChainStatusFlagsNotTimeNested  // const
  public    static  Mono.Security.X509.X509ChainStatusFlagsNotTimeValid  // const
  public    static  Mono.Security.X509.X509ChainStatusFlagsPartialChain  // const
  public    static  Mono.Security.X509.X509ChainStatusFlagsUntrustedRoot  // const
METHODS:
END_CLASS

CLASS: Mono.Security.X509.X509Extension
TYPE:  class
TOKEN: 0x2000016
SIZE:  0x28
FIELDS:
  protected         System.String                   extnOid  // 0x10
  protected         System.Boolean                  extnCritical  // 0x18
  protected         Mono.Security.ASN1              extnValue  // 0x20
PROPERTIES:
  Oid  get=0x020B7B20
  Critical  get=0x01002A50
  Value  get=0x09124DA0
METHODS:
  RVA=0x09124944  token=0x60000C5  System.Void .ctor(Mono.Security.ASN1 asn1)
  RVA=0x09124C4C  token=0x60000C6  System.Void .ctor(Mono.Security.X509.X509Extension extension)
  RVA=0x0350B670  token=0x60000C7  System.Void Decode()
  RVA=0x0350B670  token=0x60000C8  System.Void Encode()
  RVA=0x09124554  token=0x60000CC  System.Boolean Equals(System.Object obj)
  RVA=0x06FAB9A8  token=0x60000CD  System.Int32 GetHashCode()
  RVA=0x09124760  token=0x60000CE  System.Void WriteLine(System.Text.StringBuilder sb, System.Int32 n, System.Int32 pos)
  RVA=0x09124660  token=0x60000CF  System.String ToString()
END_CLASS

CLASS: Mono.Security.X509.X509ExtensionCollection
TYPE:  sealed class
TOKEN: 0x2000017
SIZE:  0x20
EXTENDS: System.Collections.CollectionBase
IMPLEMENTS: System.Collections.IEnumerable
FIELDS:
  private           System.Boolean                  readOnly  // 0x18
PROPERTIES:
  Item  get=0x091244D8
METHODS:
  RVA=0x091207C8  token=0x60000D0  System.Void .ctor()
  RVA=0x091243B0  token=0x60000D1  System.Void .ctor(Mono.Security.ASN1 asn1)
  RVA=0x0912428C  token=0x60000D2  System.Int32 IndexOf(System.String oid)
  RVA=0x091207A4  token=0x60000D3  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Mono.Security.X509.X509Store
TYPE:  class
TOKEN: 0x2000018
SIZE:  0x30
FIELDS:
  private           System.String                   _storePath  // 0x10
  private           Mono.Security.X509.X509CertificateCollection_certificates  // 0x18
  private           System.Collections.ArrayList    _crls  // 0x20
  private           System.Boolean                  _crl  // 0x28
  private           System.Boolean                  _newFormat  // 0x29
PROPERTIES:
  Certificates  get=0x09125AC0
  Crls  get=0x09125AFC
METHODS:
  RVA=0x09125A98  token=0x60000D5  System.Void .ctor(System.String path, System.Boolean crl, System.Boolean newFormat)
  RVA=0x0912595C  token=0x60000D8  System.Byte[] Load(System.String filename)
  RVA=0x09125874  token=0x60000D9  Mono.Security.X509.X509Certificate LoadCertificate(System.String filename)
  RVA=0x091258E8  token=0x60000DA  Mono.Security.X509.X509Crl LoadCrl(System.String filename)
  RVA=0x091257BC  token=0x60000DB  System.Boolean CheckStore(System.String path, System.Boolean throwException)
  RVA=0x09125460  token=0x60000DC  Mono.Security.X509.X509CertificateCollection BuildCertificatesCollection(System.String storeName)
  RVA=0x09125618  token=0x60000DD  System.Collections.ArrayList BuildCrlsCollection(System.String storeName)
END_CLASS

CLASS: Mono.Security.X509.X509StoreManager
TYPE:  sealed class
TOKEN: 0x2000019
SIZE:  0x10
FIELDS:
  private   static  System.String                   _userPath  // static @ 0x0
  private   static  System.String                   _localMachinePath  // static @ 0x8
  private   static  System.String                   _newUserPath  // static @ 0x10
  private   static  System.String                   _newLocalMachinePath  // static @ 0x18
  private   static  Mono.Security.X509.X509Stores   _userStore  // static @ 0x20
  private   static  Mono.Security.X509.X509Stores   _machineStore  // static @ 0x28
PROPERTIES:
  CurrentUserPath  get=0x09124DD0
  LocalMachinePath  get=0x09124F9C
  NewCurrentUserPath  get=0x09125178
  NewLocalMachinePath  get=0x09125290
  CurrentUser  get=0x09124ED8
  LocalMachine  get=0x091250B4
  TrustedRootCertificates  get=0x091253A8
METHODS:
END_CLASS

CLASS: Mono.Security.X509.X509Stores
TYPE:  class
TOKEN: 0x200001A
SIZE:  0x28
FIELDS:
  private           System.String                   _storePath  // 0x10
  private           System.Boolean                  _newFormat  // 0x18
  private           Mono.Security.X509.X509Store    _trusted  // 0x20
PROPERTIES:
  TrustedRoot  get=0x09125CA0
METHODS:
  RVA=0x025E7390  token=0x60000E5  System.Void .ctor(System.String path, System.Boolean newFormat)
  RVA=0x09125B90  token=0x60000E7  Mono.Security.X509.X509Store Open(System.String storeName, System.Boolean create)
END_CLASS

CLASS: Mono.Security.X509.X520
TYPE:  class
TOKEN: 0x200001B
SIZE:  0x10
FIELDS:
METHODS:
END_CLASS

CLASS: Mono.Security.X509.Extensions.AuthorityKeyIdentifierExtension
TYPE:  class
TOKEN: 0x200002D
SIZE:  0x30
EXTENDS: Mono.Security.X509.X509Extension
FIELDS:
  private           System.Byte[]                   aki  // 0x28
PROPERTIES:
  Identifier  get=0x09112600
METHODS:
  RVA=0x091125F8  token=0x60000FE  System.Void .ctor(Mono.Security.X509.X509Extension extension)
  RVA=0x09112248  token=0x60000FF  System.Void Decode()
  RVA=0x09112364  token=0x6000100  System.Void Encode()
  RVA=0x091124A8  token=0x6000102  System.String ToString()
END_CLASS

CLASS: Mono.Security.X509.Extensions.BasicConstraintsExtension
TYPE:  class
TOKEN: 0x200002E
SIZE:  0x30
EXTENDS: Mono.Security.X509.X509Extension
FIELDS:
  private           System.Boolean                  cA  // 0x28
  private           System.Int32                    pathLenConstraint  // 0x2c
PROPERTIES:
  CertificateAuthority  get=0x03D4ED50
METHODS:
  RVA=0x091125F8  token=0x6000103  System.Void .ctor(Mono.Security.X509.X509Extension extension)
  RVA=0x09112654  token=0x6000104  System.Void Decode()
  RVA=0x0911279C  token=0x6000105  System.Void Encode()
  RVA=0x091128E4  token=0x6000107  System.String ToString()
END_CLASS

