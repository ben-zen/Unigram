// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL
{
	public abstract partial class TLDocumentBase : TLObject, ITLDocumentBase
	{
		public Int64 Id { get; set; }
	}

	[Guid(0xefbdc3fd, 0x9cb7, 0x8eec, 0xb8, 0x21, 0x1d, 0x24, 0x99, 0xe0, 0x47, 0x04)]
	public partial interface ITLDocumentBase : TLObject
	{
		Int64 Id { get; set; }
	}
}