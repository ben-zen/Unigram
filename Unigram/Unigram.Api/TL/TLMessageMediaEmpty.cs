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
	partial class ITLMessageMediaEmpty : ITLMessageMediaBase, TLMessageMediaEmpty 
	{
		public ITLMessageMediaEmpty() { }
		public ITLMessageMediaEmpty(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageMediaEmpty; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x3DED6320);
		}
	}

#if !PORTABLE
	[Guid(0xc59dc1cb, 0xf129, 0xf361, 0xcc, 0x4f, 0x3e, 0xaa, 0x83, 0x64, 0x9d, 0xe7)]
	public partial interface TLMessageMediaEmpty : TLMessageMediaBase
	{
	}
#endif

}