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
	partial class ITLPageBlockSubheader : ITLPageBlockBase, TLPageBlockSubheader 
	{
		public TLRichTextBase Text { get; set; }

		public ITLPageBlockSubheader() { }
		public ITLPageBlockSubheader(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PageBlockSubheader; } }

		public override void Read(TLBinaryReader from)
		{
			Text = TLFactory.Read<TLRichTextBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xF12BB6E1);
			to.WriteObject(Text);
		}
	}

#if !PORTABLE
	[Guid(0x784d446a, 0x4e73, 0x3e67, 0xb1, 0x20, 0xe8, 0xd2, 0xc6, 0xec, 0x8d, 0x4d)]
	public partial interface TLPageBlockSubheader : TLPageBlockBase
	{
		TLRichTextBase Text { get; set; }
	}
#endif

}