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
	partial class ITLTextPlain : ITLRichTextBase, TLTextPlain 
	{
		public String Text { get; set; }

		public ITLTextPlain() { }
		public ITLTextPlain(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.TextPlain; } }

		public override void Read(TLBinaryReader from)
		{
			Text = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x744694E0);
			to.Write(Text);
		}
	}

#if !PORTABLE
	[Guid(0xf40e2a31, 0x55d7, 0xc2fa, 0xcb, 0xa6, 0x68, 0xad, 0xba, 0xde, 0x81, 0xc0)]
	public partial interface TLTextPlain : TLRichTextBase
	{
		String Text { get; set; }
	}
#endif

}