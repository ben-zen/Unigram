// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Auth
{
	/// <summary>
	/// RCP method auth.exportAuthorization.
	/// Returns <see cref="Telegram.Api.TL.TLAuthExportedAuthorization"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLAuthExportAuthorization : ITLObject, TLAuthExportAuthorization
	{
		public Int32 DCId { get; set; }

		public ITLAuthExportAuthorization() { }
		public ITLAuthExportAuthorization(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthExportAuthorization; } }

		public override void Read(TLBinaryReader from)
		{
			DCId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE5BFFFCD);
			to.Write(DCId);
		}
	}

#if !PORTABLE
	[Guid(0x82961b76, 0x6f5f, 0xd4ed, 0xd5, 0x13, 0x26, 0x41, 0xcb, 0xc9, 0x0a, 0x2b)]
	public partial interface TLAuthExportAuthorization : TLObject
	{
		Int32 DCId { get; set; }
	}
#endif

}