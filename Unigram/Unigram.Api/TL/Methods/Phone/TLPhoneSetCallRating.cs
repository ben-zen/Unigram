// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Phone
{
	/// <summary>
	/// RCP method phone.setCallRating.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLPhoneSetCallRating : ITLObject, TLPhoneSetCallRating
	{
		public TLInputPhoneCall Peer { get; set; }
		public Int32 Rating { get; set; }
		public String Comment { get; set; }

		public ITLPhoneSetCallRating() { }
		public ITLPhoneSetCallRating(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PhoneSetCallRating; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLInputPhoneCall>(from);
			Rating = from.ReadInt32();
			Comment = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x1C536A34);
			to.WriteObject(Peer);
			to.Write(Rating);
			to.Write(Comment);
		}
	}

#if !PORTABLE
	[Guid(0xd35752d0, 0x0452, 0x6165, 0xb5, 0xbf, 0xa2, 0x65, 0x03, 0x22, 0xd8, 0x2d)]
	public partial interface TLPhoneSetCallRating : TLObject
	{
		TLInputPhoneCall Peer { get; set; }
		Int32 Rating { get; set; }
		String Comment { get; set; }
	}
#endif

}