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
	partial class ITLUpdateNewEncryptedMessage : ITLUpdateBase, TLUpdateNewEncryptedMessage 
	{
		public TLEncryptedMessageBase Message { get; set; }
		public Int32 Qts { get; set; }

		public ITLUpdateNewEncryptedMessage() { }
		public ITLUpdateNewEncryptedMessage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateNewEncryptedMessage; } }

		public override void Read(TLBinaryReader from)
		{
			Message = TLFactory.Read<TLEncryptedMessageBase>(from);
			Qts = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x12BCBD9A);
			to.WriteObject(Message);
			to.Write(Qts);
		}
	}

#if !PORTABLE
	[Guid(0x8340c33a, 0x292f, 0x15c1, 0x38, 0xfb, 0xe2, 0xd6, 0xf7, 0x5e, 0x8b, 0xcc)]
	public partial interface TLUpdateNewEncryptedMessage : TLUpdateBase
	{
		TLEncryptedMessageBase Message { get; set; }
		Int32 Qts { get; set; }
	}
#endif

}