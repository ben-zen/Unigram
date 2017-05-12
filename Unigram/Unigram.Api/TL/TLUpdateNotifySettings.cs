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
	partial class ITLUpdateNotifySettings : ITLUpdateBase, TLUpdateNotifySettings 
	{
		public TLNotifyPeerBase Peer { get; set; }
		public TLPeerNotifySettingsBase NotifySettings { get; set; }

		public ITLUpdateNotifySettings() { }
		public ITLUpdateNotifySettings(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateNotifySettings; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLNotifyPeerBase>(from);
			NotifySettings = TLFactory.Read<TLPeerNotifySettingsBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xBEC268EF);
			to.WriteObject(Peer);
			to.WriteObject(NotifySettings);
		}
	}

#if !PORTABLE
	[Guid(0x8340c33a, 0x292f, 0x15c1, 0x38, 0xfb, 0xe2, 0xd6, 0xf7, 0x5e, 0x8b, 0xcc)]
	public partial interface TLUpdateNotifySettings : TLUpdateBase
	{
		TLNotifyPeerBase Peer { get; set; }
		TLPeerNotifySettingsBase NotifySettings { get; set; }
	}
#endif

}