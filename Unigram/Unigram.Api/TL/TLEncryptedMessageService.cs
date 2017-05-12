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
	partial class ITLEncryptedMessageService : ITLEncryptedMessageBase, TLEncryptedMessageService 
	{
		public ITLEncryptedMessageService() { }
		public ITLEncryptedMessageService(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.EncryptedMessageService; } }

		public override void Read(TLBinaryReader from)
		{
			RandomId = from.ReadInt64();
			ChatId = from.ReadInt32();
			Date = from.ReadInt32();
			Bytes = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x23734B06);
			to.Write(RandomId);
			to.Write(ChatId);
			to.Write(Date);
			to.WriteByteArray(Bytes);
		}
	}

#if !PORTABLE
	[Guid(0x40237ff6, 0x2adf, 0x2a92, 0x84, 0xb7, 0x25, 0xdc, 0xf0, 0x36, 0xb1, 0x1a)]
	public partial interface TLEncryptedMessageService : TLEncryptedMessageBase
	{
		Int64 RandomId { get; set; }
		Int32 ChatId { get; set; }
		Int32 Date { get; set; }
		Byte[] Bytes { get; set; }
	}
#endif

}