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
	partial class ITLInputMediaVenue : ITLInputMediaBase, TLInputMediaVenue 
	{
		public TLInputGeoPointBase GeoPoint { get; set; }
		public String Title { get; set; }
		public String Address { get; set; }
		public String Provider { get; set; }
		public String VenueId { get; set; }

		public ITLInputMediaVenue() { }
		public ITLInputMediaVenue(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputMediaVenue; } }

		public override void Read(TLBinaryReader from)
		{
			GeoPoint = TLFactory.Read<TLInputGeoPointBase>(from);
			Title = from.ReadString();
			Address = from.ReadString();
			Provider = from.ReadString();
			VenueId = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x2827A81A);
			to.WriteObject(GeoPoint);
			to.Write(Title);
			to.Write(Address);
			to.Write(Provider);
			to.Write(VenueId);
		}
	}

#if !PORTABLE
	[Guid(0x1fd0d7a9, 0x0616, 0x23a7, 0x35, 0x1a, 0x30, 0x0e, 0x9d, 0xb7, 0xaf, 0x84)]
	public partial interface TLInputMediaVenue : TLInputMediaBase
	{
		TLInputGeoPointBase GeoPoint { get; set; }
		String Title { get; set; }
		String Address { get; set; }
		String Provider { get; set; }
		String VenueId { get; set; }
	}
#endif

}