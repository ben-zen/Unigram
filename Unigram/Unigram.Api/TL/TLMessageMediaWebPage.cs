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
	partial class ITLMessageMediaWebPage : ITLMessageMediaBase, TLMessageMediaWebPage 
	{
		public TLWebPageBase WebPage { get; set; }

		public ITLMessageMediaWebPage() { }
		public ITLMessageMediaWebPage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageMediaWebPage; } }

		public override void Read(TLBinaryReader from)
		{
			WebPage = TLFactory.Read<TLWebPageBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xA32DD600);
			to.WriteObject(WebPage);
		}
	}

#if !PORTABLE
	[Guid(0xc59dc1cb, 0xf129, 0xf361, 0xcc, 0x4f, 0x3e, 0xaa, 0x83, 0x64, 0x9d, 0xe7)]
	public partial interface TLMessageMediaWebPage : TLMessageMediaBase
	{
		TLWebPageBase WebPage { get; set; }
	}
#endif

}