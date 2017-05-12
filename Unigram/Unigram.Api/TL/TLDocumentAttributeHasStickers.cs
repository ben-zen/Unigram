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
	partial class ITLDocumentAttributeHasStickers : ITLDocumentAttributeBase, TLDocumentAttributeHasStickers 
	{
		public ITLDocumentAttributeHasStickers() { }
		public ITLDocumentAttributeHasStickers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.DocumentAttributeHasStickers; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9801D2F7);
		}
	}

#if !PORTABLE
	[Guid(0xf83854a2, 0xd82b, 0x0277, 0x53, 0x06, 0x42, 0x2d, 0x19, 0x01, 0x4b, 0xf8)]
	public partial interface TLDocumentAttributeHasStickers : TLDocumentAttributeBase
	{
	}
#endif

}