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
	partial class ITLContactsFound : ITLObject, TLContactsFound 
	{
		public TLVector<TLPeerBase> Results { get; set; }
		public TLVector<TLChatBase> Chats { get; set; }
		public TLVector<TLUserBase> Users { get; set; }

		public ITLContactsFound() { }
		public ITLContactsFound(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsFound; } }

		public override void Read(TLBinaryReader from)
		{
			Results = TLFactory.Read<TLVector<TLPeerBase>>(from);
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x1AA1F784);
			to.WriteObject(Results);
			to.WriteObject(Chats);
			to.WriteObject(Users);
		}
	}

#if !PORTABLE
	[Guid(0x0a3ebb11, 0xfc9e, 0xccf5, 0x6c, 0x7d, 0xe1, 0x96, 0x6c, 0x1e, 0xec, 0xb2)]
	public partial interface TLContactsFound : TLObject
	{
		TLVector<TLPeerBase> Results { get; set; }
		TLVector<TLChatBase> Chats { get; set; }
		TLVector<TLUserBase> Users { get; set; }
	}
#endif

}