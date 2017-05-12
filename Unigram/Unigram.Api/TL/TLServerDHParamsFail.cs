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
	partial class ITLServerDHParamsFail : ITLServerDHParamsBase, TLServerDHParamsFail 
	{
		public TLInt128 NewNonceHash { get; set; }

		public ITLServerDHParamsFail() { }
		public ITLServerDHParamsFail(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ServerDHParamsFail; } }

		public override void Read(TLBinaryReader from)
		{
			Nonce = TLFactory.Read<TLInt128>(from);
			ServerNonce = TLFactory.Read<TLInt128>(from);
			NewNonceHash = TLFactory.Read<TLInt128>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x79CB045D);
			to.WriteObject(Nonce);
			to.WriteObject(ServerNonce);
			to.WriteObject(NewNonceHash);
		}
	}

#if !PORTABLE
	[Guid(0xf0257dbc, 0x2538, 0x9fe9, 0xfb, 0xef, 0x40, 0x12, 0x6e, 0x75, 0x53, 0xe3)]
	public partial interface TLServerDHParamsFail : TLServerDHParamsBase
	{
		TLInt128 Nonce { get; set; }
		TLInt128 ServerNonce { get; set; }
		TLInt128 NewNonceHash { get; set; }
	}
#endif

}