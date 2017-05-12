// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Auth
{
	/// <summary>
	/// RCP method auth.checkPhone.
	/// Returns <see cref="Telegram.Api.TL.TLAuthCheckedPhone"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLAuthCheckPhone : ITLObject, TLAuthCheckPhone
	{
		public String PhoneNumber { get; set; }

		public ITLAuthCheckPhone() { }
		public ITLAuthCheckPhone(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthCheckPhone; } }

		public override void Read(TLBinaryReader from)
		{
			PhoneNumber = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x6FE51DFB);
			to.Write(PhoneNumber);
		}
	}

#if !PORTABLE
	[Guid(0x68babe0f, 0x02e8, 0x5c80, 0xd2, 0xb0, 0x08, 0x41, 0xf9, 0x1b, 0x6f, 0xe1)]
	public partial interface TLAuthCheckPhone : TLObject
	{
		String PhoneNumber { get; set; }
	}
#endif

}