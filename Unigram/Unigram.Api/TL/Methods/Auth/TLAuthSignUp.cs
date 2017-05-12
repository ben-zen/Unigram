// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Auth
{
	/// <summary>
	/// RCP method auth.signUp.
	/// Returns <see cref="Telegram.Api.TL.TLAuthAuthorization"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLAuthSignUp : ITLObject, TLAuthSignUp
	{
		public String PhoneNumber { get; set; }
		public String PhoneCodeHash { get; set; }
		public String PhoneCode { get; set; }
		public String FirstName { get; set; }
		public String LastName { get; set; }

		public ITLAuthSignUp() { }
		public ITLAuthSignUp(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthSignUp; } }

		public override void Read(TLBinaryReader from)
		{
			PhoneNumber = from.ReadString();
			PhoneCodeHash = from.ReadString();
			PhoneCode = from.ReadString();
			FirstName = from.ReadString();
			LastName = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x1B067634);
			to.Write(PhoneNumber);
			to.Write(PhoneCodeHash);
			to.Write(PhoneCode);
			to.Write(FirstName);
			to.Write(LastName);
		}
	}

#if !PORTABLE
	[Guid(0x6798571d, 0xf859, 0x4598, 0xde, 0x4d, 0x0b, 0xba, 0xee, 0xd9, 0x3b, 0x85)]
	public partial interface TLAuthSignUp : TLObject
	{
		String PhoneNumber { get; set; }
		String PhoneCodeHash { get; set; }
		String PhoneCode { get; set; }
		String FirstName { get; set; }
		String LastName { get; set; }
	}
#endif

}