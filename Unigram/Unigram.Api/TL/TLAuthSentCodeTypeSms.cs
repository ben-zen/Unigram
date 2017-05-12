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
	partial class ITLAuthSentCodeTypeSms : ITLAuthSentCodeTypeBase, TLAuthSentCodeTypeSms 
	{
		public Int32 Length { get; set; }

		public ITLAuthSentCodeTypeSms() { }
		public ITLAuthSentCodeTypeSms(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthSentCodeTypeSms; } }

		public override void Read(TLBinaryReader from)
		{
			Length = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xC000BBA2);
			to.Write(Length);
		}
	}

#if !PORTABLE
	[Guid(0x931caec8, 0xb222, 0x3e03, 0x57, 0xbf, 0xc9, 0x5a, 0x6b, 0x3d, 0xcc, 0x0e)]
	public partial interface TLAuthSentCodeTypeSms : TLAuthSentCodeTypeBase
	{
		Int32 Length { get; set; }
	}
#endif

}