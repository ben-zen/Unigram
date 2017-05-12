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
	partial class ITLInputDocumentFileLocation : ITLInputFileLocationBase, TLInputDocumentFileLocation 
	{
		public Int64 Id { get; set; }
		public Int64 AccessHash { get; set; }
		public Int32 Version { get; set; }

		public ITLInputDocumentFileLocation() { }
		public ITLInputDocumentFileLocation(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputDocumentFileLocation; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt64();
			AccessHash = from.ReadInt64();
			Version = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x430F0724);
			to.Write(Id);
			to.Write(AccessHash);
			to.Write(Version);
		}
	}

#if !PORTABLE
	[Guid(0xc4ea377a, 0x995b, 0x50c3, 0x03, 0x35, 0x99, 0x43, 0x26, 0xe6, 0xff, 0x59)]
	public partial interface TLInputDocumentFileLocation : TLInputFileLocationBase
	{
		Int64 Id { get; set; }
		Int64 AccessHash { get; set; }
		Int32 Version { get; set; }
	}
#endif

}