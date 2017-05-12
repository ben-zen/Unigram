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
	partial class ITLMessageActionChannelCreate : ITLMessageActionBase, TLMessageActionChannelCreate 
	{
		public String Title { get; set; }

		public ITLMessageActionChannelCreate() { }
		public ITLMessageActionChannelCreate(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageActionChannelCreate; } }

		public override void Read(TLBinaryReader from)
		{
			Title = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x95D2AC92);
			to.Write(Title);
		}
	}

#if !PORTABLE
	[Guid(0xb7ad6125, 0xe49b, 0x6bc2, 0x5b, 0x0d, 0x45, 0x94, 0xee, 0x69, 0x89, 0x21)]
	public partial interface TLMessageActionChannelCreate : TLMessageActionBase
	{
		String Title { get; set; }
	}
#endif

}