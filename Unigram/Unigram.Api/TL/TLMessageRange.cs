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
	partial class ITLMessageRange : ITLObject, TLMessageRange 
	{
		public Int32 MinId { get; set; }
		public Int32 MaxId { get; set; }

		public ITLMessageRange() { }
		public ITLMessageRange(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageRange; } }

		public override void Read(TLBinaryReader from)
		{
			MinId = from.ReadInt32();
			MaxId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xAE30253);
			to.Write(MinId);
			to.Write(MaxId);
		}
	}

#if !PORTABLE
	[Guid(0xffc2eb69, 0xbbf2, 0xbcdd, 0x40, 0x03, 0xc1, 0xd7, 0x1f, 0x16, 0x65, 0x6d)]
	public partial interface TLMessageRange : TLObject
	{
		Int32 MinId { get; set; }
		Int32 MaxId { get; set; }
	}
#endif

}