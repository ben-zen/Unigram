// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Channels
{
	/// <summary>
	/// RCP method channels.getFullChannel.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesChatFull"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLChannelsGetFullChannel : ITLObject, TLChannelsGetFullChannel
	{
		public TLInputChannelBase Channel { get; set; }

		public ITLChannelsGetFullChannel() { }
		public ITLChannelsGetFullChannel(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsGetFullChannel; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x8736A09);
			to.WriteObject(Channel);
		}
	}

#if !PORTABLE
	[Guid(0x12e975eb, 0x8c91, 0x38fa, 0xf6, 0x8f, 0x44, 0x4f, 0xb9, 0x36, 0xcf, 0xca)]
	public partial interface TLChannelsGetFullChannel : TLObject
	{
		TLInputChannelBase Channel { get; set; }
	}
#endif

}