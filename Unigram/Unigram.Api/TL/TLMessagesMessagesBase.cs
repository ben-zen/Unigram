// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL
{
	public abstract partial class TLMessagesMessagesBase : TLObject, ITLMessagesMessagesBase
	{
		public TLVector<TLMessageBase> Messages { get; set; }
		public TLVector<TLChatBase> Chats { get; set; }
		public TLVector<TLUserBase> Users { get; set; }
	}

	[Guid(0x136920a5, 0xc016, 0xafe2, 0x62, 0x0d, 0xf2, 0x74, 0x96, 0xa0, 0x45, 0x01)]
	public partial interface ITLMessagesMessagesBase : TLObject
	{
		TLVector<TLMessageBase> Messages { get; set; }
		TLVector<TLChatBase> Chats { get; set; }
		TLVector<TLUserBase> Users { get; set; }
	}
}