// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getMessagesViews.
	/// Returns <see cref="Telegram.Api.TL.TLVector<TLint>"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLMessagesGetMessagesViews : ITLObject, TLMessagesGetMessagesViews
	{
		public TLInputPeerBase Peer { get; set; }
		public TLVector<Int32> Id { get; set; }
		public Boolean Increment { get; set; }

		public ITLMessagesGetMessagesViews() { }
		public ITLMessagesGetMessagesViews(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetMessagesViews; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			Id = TLFactory.Read<TLVector<Int32>>(from);
			Increment = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xC4C8A55D);
			to.WriteObject(Peer);
			to.WriteObject(Id);
			to.Write(Increment);
		}
	}

#if !PORTABLE
	[Guid(0xbb17783a, 0x34ce, 0xed5d, 0xf6, 0x10, 0x99, 0xdd, 0x35, 0xac, 0x5e, 0x66)]
	public partial interface TLMessagesGetMessagesViews : TLObject
	{
		TLInputPeerBase Peer { get; set; }
		TLVector<Int32> Id { get; set; }
		Boolean Increment { get; set; }
	}
#endif

}