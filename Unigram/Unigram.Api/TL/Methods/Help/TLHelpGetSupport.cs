// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Help
{
	/// <summary>
	/// RCP method help.getSupport.
	/// Returns <see cref="Telegram.Api.TL.TLHelpSupport"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLHelpGetSupport : ITLObject, TLHelpGetSupport
	{
		public ITLHelpGetSupport() { }
		public ITLHelpGetSupport(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.HelpGetSupport; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9CDF08CD);
		}
	}

#if !PORTABLE
	[Guid(0x2735e94d, 0xe0a7, 0x72c0, 0x40, 0x76, 0x7a, 0xe0, 0x4f, 0x35, 0x7f, 0xb1)]
	public partial interface TLHelpGetSupport : TLObject
	{
	}
#endif

}