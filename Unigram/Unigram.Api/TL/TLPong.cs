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
	partial class ITLPong : ITLObject, TLPong 
	{
		public Int64 MsgId { get; set; }
		public Int64 PingId { get; set; }

		public ITLPong() { }
		public ITLPong(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.Pong; } }

		public override void Read(TLBinaryReader from)
		{
			MsgId = from.ReadInt64();
			PingId = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x347773C5);
			to.Write(MsgId);
			to.Write(PingId);
		}
	}

#if !PORTABLE
	[Guid(0x7a08db6f, 0xfba3, 0xcbfb, 0x82, 0x87, 0xa5, 0x93, 0xa0, 0x91, 0x9e, 0x61)]
	public partial interface TLPong : TLObject
	{
		Int64 MsgId { get; set; }
		Int64 PingId { get; set; }
	}
#endif

}