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
	partial class ITLInputReportReasonViolence : ITLReportReasonBase, TLInputReportReasonViolence 
	{
		public ITLInputReportReasonViolence() { }
		public ITLInputReportReasonViolence(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputReportReasonViolence; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x1E22C78D);
		}
	}

#if !PORTABLE
	[Guid(0x69c7d797, 0x483d, 0x9458, 0xe4, 0x04, 0x43, 0x5c, 0x8c, 0x9b, 0xad, 0x2a)]
	public partial interface TLInputReportReasonViolence : TLReportReasonBase
	{
	}
#endif

}