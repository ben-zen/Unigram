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
	partial class ITLMessagesSentEncryptedFile : ITLMessagesSentEncryptedMessageBase, TLMessagesSentEncryptedFile 
	{
		public TLEncryptedFileBase File { get; set; }

		public ITLMessagesSentEncryptedFile() { }
		public ITLMessagesSentEncryptedFile(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesSentEncryptedFile; } }

		public override void Read(TLBinaryReader from)
		{
			Date = from.ReadInt32();
			File = TLFactory.Read<TLEncryptedFileBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9493FF32);
			to.Write(Date);
			to.WriteObject(File);
		}
	}

#if !PORTABLE
	[Guid(0x52738c6c, 0x5a5a, 0xe520, 0xc5, 0x94, 0x46, 0x4d, 0xc3, 0x11, 0x0e, 0x18)]
	public partial interface TLMessagesSentEncryptedFile : TLMessagesSentEncryptedMessageBase
	{
		Int32 Date { get; set; }
		TLEncryptedFileBase File { get; set; }
	}
#endif

}