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
	partial class ITLSendMessageUploadDocumentAction : ITLSendMessageActionBase, TLSendMessageUploadDocumentAction 
	{
		public Int32 Progress { get; set; }

		public ITLSendMessageUploadDocumentAction() { }
		public ITLSendMessageUploadDocumentAction(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.SendMessageUploadDocumentAction; } }

		public override void Read(TLBinaryReader from)
		{
			Progress = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xAA0CD9E4);
			to.Write(Progress);
		}
	}

#if !PORTABLE
	[Guid(0x991dd7ea, 0x97f9, 0x9c29, 0x8a, 0x70, 0x66, 0xbd, 0x97, 0x76, 0xf3, 0xb7)]
	public partial interface TLSendMessageUploadDocumentAction : TLSendMessageActionBase
	{
		Int32 Progress { get; set; }
	}
#endif

}