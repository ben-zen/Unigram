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
	partial class ITLMessagesAllStickersNotModified : ITLMessagesAllStickersBase, TLMessagesAllStickersNotModified 
	{
		public ITLMessagesAllStickersNotModified() { }
		public ITLMessagesAllStickersNotModified(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesAllStickersNotModified; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE86602C3);
		}
	}

#if !PORTABLE
	[Guid(0x4cb693f4, 0x4cf4, 0x94dc, 0xc0, 0xcc, 0xa7, 0x4d, 0xdb, 0x48, 0x74, 0xd8)]
	public partial interface TLMessagesAllStickersNotModified : TLMessagesAllStickersBase
	{
	}
#endif

}