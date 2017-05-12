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
	partial class ITLKeyboardButtonUrl : ITLKeyboardButtonBase, TLKeyboardButtonUrl 
	{
		public String Url { get; set; }

		public ITLKeyboardButtonUrl() { }
		public ITLKeyboardButtonUrl(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.KeyboardButtonUrl; } }

		public override void Read(TLBinaryReader from)
		{
			Text = from.ReadString();
			Url = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x258AFF05);
			to.Write(Text);
			to.Write(Url);
		}
	}

#if !PORTABLE
	[Guid(0x64b95636, 0x2de1, 0xcca8, 0xa8, 0xe8, 0xf3, 0xfa, 0x81, 0xc2, 0xe4, 0x8f)]
	public partial interface TLKeyboardButtonUrl : TLKeyboardButtonBase
	{
		String Text { get; set; }
		String Url { get; set; }
	}
#endif

}