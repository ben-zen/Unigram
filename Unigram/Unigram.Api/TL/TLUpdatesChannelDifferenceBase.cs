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
	abstract partial class ITLUpdatesChannelDifferenceBase : ITLObject, TLUpdatesChannelDifferenceBase
	{
		public abstract bool IsFinal { get; set; }
		public Int32 Pts { get; set; }
		public Int32? Timeout { get; set; }
	}

#if !PORTABLE
	[Guid(0x87cdb580, 0x39b8, 0x0e6f, 0x03, 0x7a, 0x9a, 0x4f, 0xac, 0x0d, 0x25, 0x0d)]
	public partial interface TLUpdatesChannelDifferenceBase : TLObject
	{
		bool IsFinal { get; set; }
		Int32 Pts { get; set; }
		Int32? Timeout { get; set; }
	}
#endif

}