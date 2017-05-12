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
	abstract partial class ITLChatFullBase : ITLObject, TLChatFullBase
	{
		public Int32 Id { get; set; }
		public TLPhotoBase ChatPhoto { get; set; }
		public TLPeerNotifySettingsBase NotifySettings { get; set; }
		public TLExportedChatInviteBase ExportedInvite { get; set; }
		public TLVector<TLBotInfo> BotInfo { get; set; }
	}

#if !PORTABLE
	[Guid(0xbc8a6f0d, 0x9eae, 0x6402, 0xba, 0xb3, 0x83, 0x7c, 0xc3, 0xf6, 0x48, 0x9d)]
	public partial interface TLChatFullBase : TLObject
	{
		Int32 Id { get; set; }
		TLPhotoBase ChatPhoto { get; set; }
		TLPeerNotifySettingsBase NotifySettings { get; set; }
		TLExportedChatInviteBase ExportedInvite { get; set; }
		TLVector<TLBotInfo> BotInfo { get; set; }
	}
#endif

}