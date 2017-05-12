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
	partial class ITLAuthSentCodeTypeApp : ITLAuthSentCodeTypeBase, TLAuthSentCodeTypeApp 
	{
		public Int32 Length { get; set; }

		public ITLAuthSentCodeTypeApp() { }
		public ITLAuthSentCodeTypeApp(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthSentCodeTypeApp; } }

		public override void Read(TLBinaryReader from)
		{
			Length = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x3DBB5986);
			to.Write(Length);
		}
	}

#if !PORTABLE
	[Guid(0x931caec8, 0xb222, 0x3e03, 0x57, 0xbf, 0xc9, 0x5a, 0x6b, 0x3d, 0xcc, 0x0e)]
	public partial interface TLAuthSentCodeTypeApp : TLAuthSentCodeTypeBase
	{
		Int32 Length { get; set; }
	}
#endif

}