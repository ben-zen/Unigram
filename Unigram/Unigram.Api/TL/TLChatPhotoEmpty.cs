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
	partial class ITLChatPhotoEmpty : ITLChatPhotoBase, TLChatPhotoEmpty 
	{
		public ITLChatPhotoEmpty() { }
		public ITLChatPhotoEmpty(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChatPhotoEmpty; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x37C1011C);
		}
	}

#if !PORTABLE
	[Guid(0x9aa71e35, 0x1f2e, 0x982b, 0xb9, 0xdd, 0xe7, 0x69, 0xcf, 0x42, 0x56, 0xa9)]
	public partial interface TLChatPhotoEmpty : TLChatPhotoBase
	{
	}
#endif

}