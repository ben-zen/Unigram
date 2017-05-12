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
	partial class ITLMessageEmpty : ITLMessageBase, TLMessageEmpty 
	{
		public ITLMessageEmpty() { }
		public ITLMessageEmpty(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageEmpty; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x83E5DE54);
			to.Write(Id);
		}
	}

#if !PORTABLE
	[Guid(0x0231e778, 0x8f7d, 0x0ed5, 0xd6, 0x42, 0x34, 0x0b, 0x7c, 0x9a, 0x63, 0xb3)]
	public partial interface TLMessageEmpty : TLMessageBase
	{
		Int32 Id { get; set; }
	}
#endif

}