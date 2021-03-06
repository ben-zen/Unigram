// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateReadChannelInbox : TLUpdateBase 
	{
		public Int32 ChannelId { get; set; }
		public Int32 MaxId { get; set; }

		public TLUpdateReadChannelInbox() { }
		public TLUpdateReadChannelInbox(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateReadChannelInbox; } }

		public override void Read(TLBinaryReader from)
		{
			ChannelId = from.ReadInt32();
			MaxId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x4214F37F);
			to.Write(ChannelId);
			to.Write(MaxId);
		}
	}
}