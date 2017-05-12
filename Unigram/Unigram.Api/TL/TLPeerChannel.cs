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
	partial class ITLPeerChannel : ITLPeerBase, TLPeerChannel 
	{
		public Int32 ChannelId { get; set; }

		public ITLPeerChannel() { }
		public ITLPeerChannel(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PeerChannel; } }

		public override void Read(TLBinaryReader from)
		{
			ChannelId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xBDDDE532);
			to.Write(ChannelId);
		}
	}

#if !PORTABLE
	[Guid(0xb468fef8, 0xcbc4, 0x97a1, 0xef, 0xa9, 0xc8, 0xbb, 0xd4, 0x5f, 0x14, 0x4e)]
	public partial interface TLPeerChannel : TLPeerBase
	{
		Int32 ChannelId { get; set; }
	}
#endif

}