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
	abstract partial class ITLMessageEntityBase : ITLObject, TLMessageEntityBase
	{
		public Int32 Offset { get; set; }
		public Int32 Length { get; set; }
	}

#if !PORTABLE
	[Guid(0xe8a61fc9, 0xc157, 0xd711, 0x6e, 0xec, 0x85, 0x83, 0x43, 0x42, 0xe8, 0xce)]
	public partial interface TLMessageEntityBase : TLObject
	{
		Int32 Offset { get; set; }
		Int32 Length { get; set; }
	}
#endif

}