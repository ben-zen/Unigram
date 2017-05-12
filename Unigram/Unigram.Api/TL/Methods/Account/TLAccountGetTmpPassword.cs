// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.getTmpPassword.
	/// Returns <see cref="Telegram.Api.TL.TLAccountTmpPassword"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLAccountGetTmpPassword : ITLObject, TLAccountGetTmpPassword
	{
		public Byte[] PasswordHash { get; set; }
		public Int32 Period { get; set; }

		public ITLAccountGetTmpPassword() { }
		public ITLAccountGetTmpPassword(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountGetTmpPassword; } }

		public override void Read(TLBinaryReader from)
		{
			PasswordHash = from.ReadByteArray();
			Period = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x4A82327E);
			to.WriteByteArray(PasswordHash);
			to.Write(Period);
		}
	}

#if !PORTABLE
	[Guid(0x3301a4fe, 0x6b64, 0x42a5, 0x7f, 0x35, 0x8f, 0xfc, 0x96, 0x62, 0x81, 0x31)]
	public partial interface TLAccountGetTmpPassword : TLObject
	{
		Byte[] PasswordHash { get; set; }
		Int32 Period { get; set; }
	}
#endif

}