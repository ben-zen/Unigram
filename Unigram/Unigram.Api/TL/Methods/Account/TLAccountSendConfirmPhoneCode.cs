// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.sendConfirmPhoneCode.
	/// Returns <see cref="Telegram.Api.TL.TLAuthSentCode"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLAccountSendConfirmPhoneCode : ITLObject, TLAccountSendConfirmPhoneCode
	{
		public bool IsAllowFlashcall { get { return Flags.HasFlag(TLAccountSendConfirmPhoneCodeFlag.AllowFlashcall); } set { Flags = value ? (Flags | TLAccountSendConfirmPhoneCodeFlag.AllowFlashcall) : (Flags & ~TLAccountSendConfirmPhoneCodeFlag.AllowFlashcall); } }
		public bool HasCurrentNumber { get { return Flags.HasFlag(TLAccountSendConfirmPhoneCodeFlag.CurrentNumber); } set { Flags = value ? (Flags | TLAccountSendConfirmPhoneCodeFlag.CurrentNumber) : (Flags & ~TLAccountSendConfirmPhoneCodeFlag.CurrentNumber); } }

		public TLAccountSendConfirmPhoneCodeFlag Flags { get; set; }
		public String Hash { get; set; }
		public Boolean? CurrentNumber { get; set; }

		public ITLAccountSendConfirmPhoneCode() { }
		public ITLAccountSendConfirmPhoneCode(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountSendConfirmPhoneCode; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (TLAccountSendConfirmPhoneCodeFlag)from.ReadInt32();
			Hash = from.ReadString();
			if (HasCurrentNumber) CurrentNumber = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0x1516D7BD);
			to.Write((Int32)Flags);
			to.Write(Hash);
			if (HasCurrentNumber) to.Write(CurrentNumber.Value);
		}

		private void UpdateFlags()
		{
			HasCurrentNumber = CurrentNumber != null;
		}
	}

#if !PORTABLE
	[Flags]
	public enum TLAccountSendConfirmPhoneCodeFlag : Int32
	{
		AllowFlashcall = (1 << 0),
		CurrentNumber = (1 << 0),
	}
#endif

#if !PORTABLE
	[Guid(0xacc4b0bb, 0xd58d, 0x5f6f, 0xa8, 0xa5, 0xc0, 0x5f, 0x34, 0x96, 0x5d, 0x55)]
	public partial interface TLAccountSendConfirmPhoneCode : TLObject
	{
		bool IsAllowFlashcall { get; set; }
		bool HasCurrentNumber { get; set; }

		TLAccountSendConfirmPhoneCodeFlag Flags { get; set; }
		String Hash { get; set; }
		Boolean? CurrentNumber { get; set; }
	}
#endif

}