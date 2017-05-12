// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.editMessage.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLMessagesEditMessage : ITLObject, TLMessagesEditMessage
	{
		public bool IsNoWebPage { get { return Flags.HasFlag(TLMessagesEditMessageFlag.NoWebPage); } set { Flags = value ? (Flags | TLMessagesEditMessageFlag.NoWebPage) : (Flags & ~TLMessagesEditMessageFlag.NoWebPage); } }
		public bool HasMessage { get { return Flags.HasFlag(TLMessagesEditMessageFlag.Message); } set { Flags = value ? (Flags | TLMessagesEditMessageFlag.Message) : (Flags & ~TLMessagesEditMessageFlag.Message); } }
		public bool HasReplyMarkup { get { return Flags.HasFlag(TLMessagesEditMessageFlag.ReplyMarkup); } set { Flags = value ? (Flags | TLMessagesEditMessageFlag.ReplyMarkup) : (Flags & ~TLMessagesEditMessageFlag.ReplyMarkup); } }
		public bool HasEntities { get { return Flags.HasFlag(TLMessagesEditMessageFlag.Entities); } set { Flags = value ? (Flags | TLMessagesEditMessageFlag.Entities) : (Flags & ~TLMessagesEditMessageFlag.Entities); } }

		public TLMessagesEditMessageFlag Flags { get; set; }
		public TLInputPeerBase Peer { get; set; }
		public Int32 Id { get; set; }
		public String Message { get; set; }
		public TLReplyMarkupBase ReplyMarkup { get; set; }
		public TLVector<TLMessageEntityBase> Entities { get; set; }

		public ITLMessagesEditMessage() { }
		public ITLMessagesEditMessage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesEditMessage; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (TLMessagesEditMessageFlag)from.ReadInt32();
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			Id = from.ReadInt32();
			if (HasMessage) Message = from.ReadString();
			if (HasReplyMarkup) ReplyMarkup = TLFactory.Read<TLReplyMarkupBase>(from);
			if (HasEntities) Entities = TLFactory.Read<TLVector<TLMessageEntityBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0xCE91E4CA);
			to.Write((Int32)Flags);
			to.WriteObject(Peer);
			to.Write(Id);
			if (HasMessage) to.Write(Message);
			if (HasReplyMarkup) to.WriteObject(ReplyMarkup);
			if (HasEntities) to.WriteObject(Entities);
		}

		private void UpdateFlags()
		{
			HasMessage = Message != null;
			HasReplyMarkup = ReplyMarkup != null;
			HasEntities = Entities != null;
		}
	}

#if !PORTABLE
	[Flags]
	public enum TLMessagesEditMessageFlag : Int32
	{
		NoWebPage = (1 << 1),
		Message = (1 << 11),
		ReplyMarkup = (1 << 2),
		Entities = (1 << 3),
	}
#endif

#if !PORTABLE
	[Guid(0xd35752d0, 0x0452, 0x6165, 0xb5, 0xbf, 0xa2, 0x65, 0x03, 0x22, 0xd8, 0x2d)]
	public partial interface TLMessagesEditMessage : TLObject
	{
		bool IsNoWebPage { get; set; }
		bool HasMessage { get; set; }
		bool HasReplyMarkup { get; set; }
		bool HasEntities { get; set; }

		TLMessagesEditMessageFlag Flags { get; set; }
		TLInputPeerBase Peer { get; set; }
		Int32 Id { get; set; }
		String Message { get; set; }
		TLReplyMarkupBase ReplyMarkup { get; set; }
		TLVector<TLMessageEntityBase> Entities { get; set; }
	}
#endif

}