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
	abstract partial class ITLBotInlineMessageBase : ITLObject, TLBotInlineMessageBase
	{
		public TLReplyMarkupBase ReplyMarkup { get; set; }
	}

#if !PORTABLE
	[Guid(0xaaeaed91, 0xa5b1, 0x94ae, 0xb9, 0x7c, 0x74, 0xcc, 0x41, 0xb3, 0xaf, 0x8a)]
	public partial interface TLBotInlineMessageBase : TLObject
	{
		TLReplyMarkupBase ReplyMarkup { get; set; }
	}
#endif

}