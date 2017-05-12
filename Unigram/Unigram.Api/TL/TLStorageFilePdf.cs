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
	partial class ITLStorageFilePdf : ITLStorageFileTypeBase, TLStorageFilePdf 
	{
		public ITLStorageFilePdf() { }
		public ITLStorageFilePdf(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.StorageFilePdf; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xAE1E508D);
		}
	}

#if !PORTABLE
	[Guid(0x18068029, 0xeb39, 0x8ea6, 0xf0, 0xfc, 0x4c, 0xee, 0x26, 0x8c, 0x5c, 0xef)]
	public partial interface TLStorageFilePdf : TLStorageFileTypeBase
	{
	}
#endif

}