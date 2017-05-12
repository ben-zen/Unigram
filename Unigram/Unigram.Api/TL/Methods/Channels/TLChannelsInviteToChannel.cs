// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Channels
{
	/// <summary>
	/// RCP method channels.inviteToChannel.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLChannelsInviteToChannel : ITLObject, TLChannelsInviteToChannel
	{
		public TLInputChannelBase Channel { get; set; }
		public TLVector<TLInputUserBase> Users { get; set; }

		public ITLChannelsInviteToChannel() { }
		public ITLChannelsInviteToChannel(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsInviteToChannel; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
			Users = TLFactory.Read<TLVector<TLInputUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x199F3A6C);
			to.WriteObject(Channel);
			to.WriteObject(Users);
		}
	}

#if !PORTABLE
	[Guid(0xd35752d0, 0x0452, 0x6165, 0xb5, 0xbf, 0xa2, 0x65, 0x03, 0x22, 0xd8, 0x2d)]
	public partial interface TLChannelsInviteToChannel : TLObject
	{
		TLInputChannelBase Channel { get; set; }
		TLVector<TLInputUserBase> Users { get; set; }
	}
#endif

}