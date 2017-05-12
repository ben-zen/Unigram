// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Contacts
{
	/// <summary>
	/// RCP method contacts.search.
	/// Returns <see cref="Telegram.Api.TL.TLContactsFound"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLContactsSearch : ITLObject, TLContactsSearch
	{
		public String Q { get; set; }
		public Int32 Limit { get; set; }

		public ITLContactsSearch() { }
		public ITLContactsSearch(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsSearch; } }

		public override void Read(TLBinaryReader from)
		{
			Q = from.ReadString();
			Limit = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x11F812D8);
			to.Write(Q);
			to.Write(Limit);
		}
	}

#if !PORTABLE
	[Guid(0x0a3ebb11, 0xfc9e, 0xccf5, 0x6c, 0x7d, 0xe1, 0x96, 0x6c, 0x1e, 0xec, 0xb2)]
	public partial interface TLContactsSearch : TLObject
	{
		String Q { get; set; }
		Int32 Limit { get; set; }
	}
#endif

}