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
	partial class ITLHelpInviteText : ITLObject, TLHelpInviteText 
	{
		public String Message { get; set; }

		public ITLHelpInviteText() { }
		public ITLHelpInviteText(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.HelpInviteText; } }

		public override void Read(TLBinaryReader from)
		{
			Message = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x18CB9F78);
			to.Write(Message);
		}
	}

#if !PORTABLE
	[Guid(0x8f95e035, 0xff3c, 0xc86f, 0xbb, 0x83, 0x76, 0xfb, 0x31, 0xc3, 0xf0, 0xe6)]
	public partial interface TLHelpInviteText : TLObject
	{
		String Message { get; set; }
	}
#endif

}