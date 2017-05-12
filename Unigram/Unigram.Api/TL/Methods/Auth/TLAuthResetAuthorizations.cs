// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Auth
{
	/// <summary>
	/// RCP method auth.resetAuthorizations.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLAuthResetAuthorizations : ITLObject, TLAuthResetAuthorizations
	{
		public ITLAuthResetAuthorizations() { }
		public ITLAuthResetAuthorizations(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthResetAuthorizations; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9FAB0D1A);
		}
	}

#if !PORTABLE
	[Guid(0x13ff06c5, 0xab4b, 0x6edd, 0x68, 0xab, 0x3e, 0x63, 0x50, 0xe9, 0x53, 0x05)]
	public partial interface TLAuthResetAuthorizations : TLObject
	{
	}
#endif

}