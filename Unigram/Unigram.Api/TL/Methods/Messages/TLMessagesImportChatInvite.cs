// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.importChatInvite.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLMessagesImportChatInvite : ITLObject, TLMessagesImportChatInvite
	{
		public String Hash { get; set; }

		public ITLMessagesImportChatInvite() { }
		public ITLMessagesImportChatInvite(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesImportChatInvite; } }

		public override void Read(TLBinaryReader from)
		{
			Hash = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x6C50051C);
			to.Write(Hash);
		}
	}

#if !PORTABLE
	[Guid(0xd35752d0, 0x0452, 0x6165, 0xb5, 0xbf, 0xa2, 0x65, 0x03, 0x22, 0xd8, 0x2d)]
	public partial interface TLMessagesImportChatInvite : TLObject
	{
		String Hash { get; set; }
	}
#endif

}