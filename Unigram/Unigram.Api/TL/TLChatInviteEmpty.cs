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
	partial class ITLChatInviteEmpty : ITLExportedChatInviteBase, TLChatInviteEmpty 
	{
		public ITLChatInviteEmpty() { }
		public ITLChatInviteEmpty(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChatInviteEmpty; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x69DF3769);
		}
	}

#if !PORTABLE
	[Guid(0x84704edf, 0x6337, 0x6109, 0x07, 0x66, 0x18, 0xa1, 0xa9, 0x76, 0x9a, 0xbd)]
	public partial interface TLChatInviteEmpty : TLExportedChatInviteBase
	{
	}
#endif

}