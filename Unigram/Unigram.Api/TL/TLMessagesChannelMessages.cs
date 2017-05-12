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
	partial class ITLMessagesChannelMessages : ITLMessagesMessagesBase, TLMessagesChannelMessages 
	{
		public TLMessagesChannelMessagesFlag Flags { get; set; }
		public Int32 Pts { get; set; }
		public Int32 Count { get; set; }

		public ITLMessagesChannelMessages() { }
		public ITLMessagesChannelMessages(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesChannelMessages; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (TLMessagesChannelMessagesFlag)from.ReadInt32();
			Pts = from.ReadInt32();
			Count = from.ReadInt32();
			Messages = TLFactory.Read<TLVector<TLMessageBase>>(from);
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x99262E37);
			to.Write((Int32)Flags);
			to.Write(Pts);
			to.Write(Count);
			to.WriteObject(Messages);
			to.WriteObject(Chats);
			to.WriteObject(Users);
		}
	}

#if !PORTABLE
	[Flags]
	public enum TLMessagesChannelMessagesFlag : Int32
	{
		None = 0
	}
#endif

#if !PORTABLE
	[Guid(0x136920a5, 0xc016, 0xafe2, 0x62, 0x0d, 0xf2, 0x74, 0x96, 0xa0, 0x45, 0x01)]
	public partial interface TLMessagesChannelMessages : TLMessagesMessagesBase
	{
		TLMessagesChannelMessagesFlag Flags { get; set; }
		Int32 Pts { get; set; }
		Int32 Count { get; set; }
		TLVector<TLMessageBase> Messages { get; set; }
		TLVector<TLChatBase> Chats { get; set; }
		TLVector<TLUserBase> Users { get; set; }
	}
#endif

}