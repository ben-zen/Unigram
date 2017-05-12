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
	partial class ITLMessageEntityMention : ITLMessageEntityBase, TLMessageEntityMention 
	{
		public ITLMessageEntityMention() { }
		public ITLMessageEntityMention(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageEntityMention; } }

		public override void Read(TLBinaryReader from)
		{
			Offset = from.ReadInt32();
			Length = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xFA04579D);
			to.Write(Offset);
			to.Write(Length);
		}
	}

#if !PORTABLE
	[Guid(0xe8a61fc9, 0xc157, 0xd711, 0x6e, 0xec, 0x85, 0x83, 0x43, 0x42, 0xe8, 0xce)]
	public partial interface TLMessageEntityMention : TLMessageEntityBase
	{
		Int32 Offset { get; set; }
		Int32 Length { get; set; }
	}
#endif

}