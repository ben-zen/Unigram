// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Contacts
{
	/// <summary>
	/// RCP method contacts.getContacts.
	/// Returns <see cref="Telegram.Api.TL.TLContactsContactsBase"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLContactsGetContacts : ITLObject, TLContactsGetContacts
	{
		public String Hash { get; set; }

		public ITLContactsGetContacts() { }
		public ITLContactsGetContacts(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsGetContacts; } }

		public override void Read(TLBinaryReader from)
		{
			Hash = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x22C6AA08);
			to.Write(Hash);
		}
	}

#if !PORTABLE
	[Guid(0xf1bc53e6, 0xd11a, 0xb62b, 0x31, 0x2c, 0xb5, 0x94, 0x2c, 0x34, 0xa9, 0xcc)]
	public partial interface TLContactsGetContacts : TLObject
	{
		String Hash { get; set; }
	}
#endif

}