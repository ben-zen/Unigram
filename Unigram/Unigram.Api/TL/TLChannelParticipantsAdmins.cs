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
	partial class ITLChannelParticipantsAdmins : ITLChannelParticipantsFilterBase, TLChannelParticipantsAdmins 
	{
		public ITLChannelParticipantsAdmins() { }
		public ITLChannelParticipantsAdmins(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelParticipantsAdmins; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xB4608969);
		}
	}

#if !PORTABLE
	[Guid(0xc9ad4282, 0x5af9, 0x0ab8, 0x0d, 0x79, 0xc9, 0x55, 0x60, 0xff, 0xc8, 0x0c)]
	public partial interface TLChannelParticipantsAdmins : TLChannelParticipantsFilterBase
	{
	}
#endif

}