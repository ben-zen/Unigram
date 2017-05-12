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
	partial class ITLUpdatesDifferenceTooLong : ITLUpdatesDifferenceBase, TLUpdatesDifferenceTooLong 
	{
		public Int32 Pts { get; set; }

		public ITLUpdatesDifferenceTooLong() { }
		public ITLUpdatesDifferenceTooLong(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdatesDifferenceTooLong; } }

		public override void Read(TLBinaryReader from)
		{
			Pts = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x4AFE8F6D);
			to.Write(Pts);
		}
	}

#if !PORTABLE
	[Guid(0x7c8c2e4d, 0x8e8e, 0x99b6, 0x1d, 0x70, 0xe7, 0xfa, 0x4c, 0x7e, 0x35, 0xb8)]
	public partial interface TLUpdatesDifferenceTooLong : TLUpdatesDifferenceBase
	{
		Int32 Pts { get; set; }
	}
#endif

}