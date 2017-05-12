// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.readMessageContents.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesAffectedMessages"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLMessagesReadMessageContents : ITLObject, TLMessagesReadMessageContents
	{
		public TLVector<Int32> Id { get; set; }

		public ITLMessagesReadMessageContents() { }
		public ITLMessagesReadMessageContents(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesReadMessageContents; } }

		public override void Read(TLBinaryReader from)
		{
			Id = TLFactory.Read<TLVector<Int32>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x36A73F77);
			to.WriteObject(Id);
		}
	}

#if !PORTABLE
	[Guid(0x8945beb6, 0x1533, 0xf53e, 0x9c, 0x7a, 0x3a, 0xe5, 0x3c, 0x95, 0x34, 0x8b)]
	public partial interface TLMessagesReadMessageContents : TLObject
	{
		TLVector<Int32> Id { get; set; }
	}
#endif

}