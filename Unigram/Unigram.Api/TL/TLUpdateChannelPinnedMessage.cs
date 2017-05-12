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
	partial class ITLUpdateChannelPinnedMessage : ITLUpdateBase, TLUpdateChannelPinnedMessage 
	{
		public Int32 ChannelId { get; set; }
		public Int32 Id { get; set; }

		public ITLUpdateChannelPinnedMessage() { }
		public ITLUpdateChannelPinnedMessage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateChannelPinnedMessage; } }

		public override void Read(TLBinaryReader from)
		{
			ChannelId = from.ReadInt32();
			Id = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x98592475);
			to.Write(ChannelId);
			to.Write(Id);
		}
	}

#if !PORTABLE
	[Guid(0x8340c33a, 0x292f, 0x15c1, 0x38, 0xfb, 0xe2, 0xd6, 0xf7, 0x5e, 0x8b, 0xcc)]
	public partial interface TLUpdateChannelPinnedMessage : TLUpdateBase
	{
		Int32 ChannelId { get; set; }
		Int32 Id { get; set; }
	}
#endif

}