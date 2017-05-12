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
	partial class ITLMessageEntityBold : ITLMessageEntityBase, TLMessageEntityBold 
	{
		public ITLMessageEntityBold() { }
		public ITLMessageEntityBold(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageEntityBold; } }

		public override void Read(TLBinaryReader from)
		{
			Offset = from.ReadInt32();
			Length = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xBD610BC9);
			to.Write(Offset);
			to.Write(Length);
		}
	}

#if !PORTABLE
	[Guid(0xe8a61fc9, 0xc157, 0xd711, 0x6e, 0xec, 0x85, 0x83, 0x43, 0x42, 0xe8, 0xce)]
	public partial interface TLMessageEntityBold : TLMessageEntityBase
	{
		Int32 Offset { get; set; }
		Int32 Length { get; set; }
	}
#endif

}