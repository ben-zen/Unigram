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
	partial class ITLSendMessageGamePlayAction : ITLSendMessageActionBase, TLSendMessageGamePlayAction 
	{
		public ITLSendMessageGamePlayAction() { }
		public ITLSendMessageGamePlayAction(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.SendMessageGamePlayAction; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xDD6A8F48);
		}
	}

#if !PORTABLE
	[Guid(0x991dd7ea, 0x97f9, 0x9c29, 0x8a, 0x70, 0x66, 0xbd, 0x97, 0x76, 0xf3, 0xb7)]
	public partial interface TLSendMessageGamePlayAction : TLSendMessageActionBase
	{
	}
#endif

}