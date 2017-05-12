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
	partial class ITLShippingOption : ITLObject, TLShippingOption 
	{
		public String Id { get; set; }
		public String Title { get; set; }
		public TLVector<TLLabeledPrice> Prices { get; set; }

		public ITLShippingOption() { }
		public ITLShippingOption(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ShippingOption; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadString();
			Title = from.ReadString();
			Prices = TLFactory.Read<TLVector<TLLabeledPrice>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xB6213CDF);
			to.Write(Id);
			to.Write(Title);
			to.WriteObject(Prices);
		}
	}

#if !PORTABLE
	[Guid(0x2ecd746b, 0x8202, 0x8097, 0x5d, 0xa4, 0x32, 0x38, 0x3b, 0x75, 0x92, 0x83)]
	public partial interface TLShippingOption : TLObject
	{
		String Id { get; set; }
		String Title { get; set; }
		TLVector<TLLabeledPrice> Prices { get; set; }
	}
#endif

}