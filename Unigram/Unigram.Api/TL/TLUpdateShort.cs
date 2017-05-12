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
	partial class ITLUpdateShort : ITLUpdatesBase, TLUpdateShort 
	{
		public TLUpdateBase Update { get; set; }
		public Int32 Date { get; set; }

		public ITLUpdateShort() { }
		public ITLUpdateShort(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateShort; } }

		public override void Read(TLBinaryReader from)
		{
			Update = TLFactory.Read<TLUpdateBase>(from);
			Date = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x78D4DEC1);
			to.WriteObject(Update);
			to.Write(Date);
		}
	}

#if !PORTABLE
	[Guid(0xd35752d0, 0x0452, 0x6165, 0xb5, 0xbf, 0xa2, 0x65, 0x03, 0x22, 0xd8, 0x2d)]
	public partial interface TLUpdateShort : TLUpdatesBase
	{
		TLUpdateBase Update { get; set; }
		Int32 Date { get; set; }
	}
#endif

}