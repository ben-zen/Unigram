// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL
{
	public abstract partial class TLUserBase : TLObject, ITLUserBase
	{
		public Int32 Id { get; set; }
	}

	[Guid(0xb1cb11ee, 0x5290, 0x0be4, 0x07, 0xaa, 0xc0, 0xca, 0x06, 0x0c, 0x23, 0xee)]
	public partial interface ITLUserBase : TLObject
	{
		Int32 Id { get; set; }
	}
}