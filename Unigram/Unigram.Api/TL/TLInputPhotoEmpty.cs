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
	partial class ITLInputPhotoEmpty : ITLInputPhotoBase, TLInputPhotoEmpty 
	{
		public ITLInputPhotoEmpty() { }
		public ITLInputPhotoEmpty(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputPhotoEmpty; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x1CD7BF0D);
		}
	}

#if !PORTABLE
	[Guid(0xa7dfd0ba, 0x5fdb, 0x3fd1, 0xea, 0xd8, 0x2b, 0xe7, 0x16, 0x80, 0xe1, 0x80)]
	public partial interface TLInputPhotoEmpty : TLInputPhotoBase
	{
	}
#endif

}