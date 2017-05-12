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
	partial class ITLPageBlockPhoto : ITLPageBlockBase, TLPageBlockPhoto 
	{
		public Int64 PhotoId { get; set; }
		public TLRichTextBase Caption { get; set; }

		public ITLPageBlockPhoto() { }
		public ITLPageBlockPhoto(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PageBlockPhoto; } }

		public override void Read(TLBinaryReader from)
		{
			PhotoId = from.ReadInt64();
			Caption = TLFactory.Read<TLRichTextBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE9C69982);
			to.Write(PhotoId);
			to.WriteObject(Caption);
		}
	}

#if !PORTABLE
	[Guid(0x784d446a, 0x4e73, 0x3e67, 0xb1, 0x20, 0xe8, 0xd2, 0xc6, 0xec, 0x8d, 0x4d)]
	public partial interface TLPageBlockPhoto : TLPageBlockBase
	{
		Int64 PhotoId { get; set; }
		TLRichTextBase Caption { get; set; }
	}
#endif

}