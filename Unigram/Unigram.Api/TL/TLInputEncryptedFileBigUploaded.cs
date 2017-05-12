// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL
{
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLInputEncryptedFileBigUploaded : ITLInputEncryptedFileBase, TLInputEncryptedFileBigUploaded 
	{
		public Int64 Id { get; set; }
		public Int32 Parts { get; set; }
		public Int32 KeyFingerprint { get; set; }

		public ITLInputEncryptedFileBigUploaded() { }
		public ITLInputEncryptedFileBigUploaded(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputEncryptedFileBigUploaded; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt64();
			Parts = from.ReadInt32();
			KeyFingerprint = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x2DC173C8);
			to.Write(Id);
			to.Write(Parts);
			to.Write(KeyFingerprint);
		}
	}

#if !PORTABLE
	[Guid(0x9c81ce41, 0x7ef0, 0xcbc7, 0x21, 0xfa, 0x15, 0x68, 0x7d, 0x58, 0x59, 0xb0)]
	public partial interface TLInputEncryptedFileBigUploaded : TLInputEncryptedFileBase
	{
		Int64 Id { get; set; }
		Int32 Parts { get; set; }
		Int32 KeyFingerprint { get; set; }
	}
#endif

}