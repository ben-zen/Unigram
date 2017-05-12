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
	abstract partial class ITLInputFileBase : ITLObject, TLInputFileBase
	{
		public Int64 Id { get; set; }
		public Int32 Parts { get; set; }
		public String Name { get; set; }
	}

#if !PORTABLE
	[Guid(0x43f99e29, 0xc7a1, 0x755a, 0xb2, 0xfc, 0x0f, 0x67, 0x1d, 0xec, 0x8c, 0x52)]
	public partial interface TLInputFileBase : TLObject
	{
		Int64 Id { get; set; }
		Int32 Parts { get; set; }
		String Name { get; set; }
	}
#endif

}