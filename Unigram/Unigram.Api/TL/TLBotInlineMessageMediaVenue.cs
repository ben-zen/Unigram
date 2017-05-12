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
	partial class ITLBotInlineMessageMediaVenue : ITLBotInlineMessageBase, TLBotInlineMessageMediaVenue 
	{
		public bool HasReplyMarkup { get { return Flags.HasFlag(TLBotInlineMessageMediaVenueFlag.ReplyMarkup); } set { Flags = value ? (Flags | TLBotInlineMessageMediaVenueFlag.ReplyMarkup) : (Flags & ~TLBotInlineMessageMediaVenueFlag.ReplyMarkup); } }

		public TLBotInlineMessageMediaVenueFlag Flags { get; set; }
		public TLGeoPointBase Geo { get; set; }
		public String Title { get; set; }
		public String Address { get; set; }
		public String Provider { get; set; }
		public String VenueId { get; set; }

		public ITLBotInlineMessageMediaVenue() { }
		public ITLBotInlineMessageMediaVenue(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.BotInlineMessageMediaVenue; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (TLBotInlineMessageMediaVenueFlag)from.ReadInt32();
			Geo = TLFactory.Read<TLGeoPointBase>(from);
			Title = from.ReadString();
			Address = from.ReadString();
			Provider = from.ReadString();
			VenueId = from.ReadString();
			if (HasReplyMarkup) ReplyMarkup = TLFactory.Read<TLReplyMarkupBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0x4366232E);
			to.Write((Int32)Flags);
			to.WriteObject(Geo);
			to.Write(Title);
			to.Write(Address);
			to.Write(Provider);
			to.Write(VenueId);
			if (HasReplyMarkup) to.WriteObject(ReplyMarkup);
		}

		private void UpdateFlags()
		{
			HasReplyMarkup = ReplyMarkup != null;
		}
	}

#if !PORTABLE
	[Flags]
	public enum TLBotInlineMessageMediaVenueFlag : Int32
	{
		ReplyMarkup = (1 << 2),
	}
#endif

#if !PORTABLE
	[Guid(0xaaeaed91, 0xa5b1, 0x94ae, 0xb9, 0x7c, 0x74, 0xcc, 0x41, 0xb3, 0xaf, 0x8a)]
	public partial interface TLBotInlineMessageMediaVenue : TLBotInlineMessageBase
	{
		bool HasReplyMarkup { get; set; }

		TLBotInlineMessageMediaVenueFlag Flags { get; set; }
		TLGeoPointBase Geo { get; set; }
		String Title { get; set; }
		String Address { get; set; }
		String Provider { get; set; }
		String VenueId { get; set; }
		TLReplyMarkupBase ReplyMarkup { get; set; }
	}
#endif

}