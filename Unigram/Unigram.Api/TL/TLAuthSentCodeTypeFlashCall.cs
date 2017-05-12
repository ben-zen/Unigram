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
	partial class ITLAuthSentCodeTypeFlashCall : ITLAuthSentCodeTypeBase, TLAuthSentCodeTypeFlashCall 
	{
		public String Pattern { get; set; }

		public ITLAuthSentCodeTypeFlashCall() { }
		public ITLAuthSentCodeTypeFlashCall(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthSentCodeTypeFlashCall; } }

		public override void Read(TLBinaryReader from)
		{
			Pattern = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xAB03C6D9);
			to.Write(Pattern);
		}
	}

#if !PORTABLE
	[Guid(0x931caec8, 0xb222, 0x3e03, 0x57, 0xbf, 0xc9, 0x5a, 0x6b, 0x3d, 0xcc, 0x0e)]
	public partial interface TLAuthSentCodeTypeFlashCall : TLAuthSentCodeTypeBase
	{
		String Pattern { get; set; }
	}
#endif

}