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
	partial class ITLPhoneCallProtocol : ITLObject, TLPhoneCallProtocol 
	{
		public bool IsUdpP2p { get { return Flags.HasFlag(TLPhoneCallProtocolFlag.UdpP2p); } set { Flags = value ? (Flags | TLPhoneCallProtocolFlag.UdpP2p) : (Flags & ~TLPhoneCallProtocolFlag.UdpP2p); } }
		public bool IsUdpReflector { get { return Flags.HasFlag(TLPhoneCallProtocolFlag.UdpReflector); } set { Flags = value ? (Flags | TLPhoneCallProtocolFlag.UdpReflector) : (Flags & ~TLPhoneCallProtocolFlag.UdpReflector); } }

		public TLPhoneCallProtocolFlag Flags { get; set; }
		public Int32 MinLayer { get; set; }
		public Int32 MaxLayer { get; set; }

		public ITLPhoneCallProtocol() { }
		public ITLPhoneCallProtocol(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PhoneCallProtocol; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (TLPhoneCallProtocolFlag)from.ReadInt32();
			MinLayer = from.ReadInt32();
			MaxLayer = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xA2BB35CB);
			to.Write((Int32)Flags);
			to.Write(MinLayer);
			to.Write(MaxLayer);
		}
	}

#if !PORTABLE
	[Flags]
	public enum TLPhoneCallProtocolFlag : Int32
	{
		UdpP2p = (1 << 0),
		UdpReflector = (1 << 1),
	}
#endif

#if !PORTABLE
	[Guid(0x7cf280e7, 0x07ae, 0x4bf8, 0x40, 0x18, 0xac, 0x7c, 0x2e, 0xb8, 0xc9, 0xf2)]
	public partial interface TLPhoneCallProtocol : TLObject
	{
		bool IsUdpP2p { get; set; }
		bool IsUdpReflector { get; set; }

		TLPhoneCallProtocolFlag Flags { get; set; }
		Int32 MinLayer { get; set; }
		Int32 MaxLayer { get; set; }
	}
#endif

}