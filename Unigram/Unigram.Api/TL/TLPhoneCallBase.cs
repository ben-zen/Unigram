// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL
{
	public abstract partial class TLPhoneCallBase : TLObject, ITLPhoneCallBase
	{
		public Int64 Id { get; set; }
	}

	[Guid(0x8aab306d, 0x4218, 0x45d3, 0x35, 0x19, 0x67, 0x9a, 0xea, 0x50, 0xa9, 0x1a)]
	public partial interface ITLPhoneCallBase : TLObject
	{
		Int64 Id { get; set; }
	}
}