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
	partial class ITLInputChatPhotoEmpty : ITLInputChatPhotoBase, TLInputChatPhotoEmpty 
	{
		public ITLInputChatPhotoEmpty() { }
		public ITLInputChatPhotoEmpty(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputChatPhotoEmpty; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x1CA48F57);
		}
	}

#if !PORTABLE
	[Guid(0x088150f5, 0x7a5b, 0x5cfd, 0xc2, 0x86, 0x87, 0x48, 0xe2, 0xd7, 0x30, 0xf9)]
	public partial interface TLInputChatPhotoEmpty : TLInputChatPhotoBase
	{
	}
#endif

}