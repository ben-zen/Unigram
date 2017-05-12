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
	partial class ITLInputFileLocation : ITLInputFileLocationBase, TLInputFileLocation 
	{
		public Int64 VolumeId { get; set; }
		public Int32 LocalId { get; set; }
		public Int64 Secret { get; set; }

		public ITLInputFileLocation() { }
		public ITLInputFileLocation(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputFileLocation; } }

		public override void Read(TLBinaryReader from)
		{
			VolumeId = from.ReadInt64();
			LocalId = from.ReadInt32();
			Secret = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x14637196);
			to.Write(VolumeId);
			to.Write(LocalId);
			to.Write(Secret);
		}
	}

#if !PORTABLE
	[Guid(0xc4ea377a, 0x995b, 0x50c3, 0x03, 0x35, 0x99, 0x43, 0x26, 0xe6, 0xff, 0x59)]
	public partial interface TLInputFileLocation : TLInputFileLocationBase
	{
		Int64 VolumeId { get; set; }
		Int32 LocalId { get; set; }
		Int64 Secret { get; set; }
	}
#endif

}