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
	partial class ITLInputMessagesFilterChatPhotos : ITLMessagesFilterBase, TLInputMessagesFilterChatPhotos 
	{
		public ITLInputMessagesFilterChatPhotos() { }
		public ITLInputMessagesFilterChatPhotos(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputMessagesFilterChatPhotos; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x3A20ECB8);
		}
	}

#if !PORTABLE
	[Guid(0x63af71ad, 0x7446, 0x5eb0, 0x8d, 0x39, 0xc2, 0xf1, 0x6f, 0xd8, 0xcf, 0x7d)]
	public partial interface TLInputMessagesFilterChatPhotos : TLMessagesFilterBase
	{
	}
#endif

}