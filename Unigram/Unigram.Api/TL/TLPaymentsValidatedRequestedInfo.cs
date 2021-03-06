// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPaymentsValidatedRequestedInfo : TLObject 
	{
		[Flags]
		public enum Flag : Int32
		{
			Id = (1 << 0),
			ShippingOptions = (1 << 1),
		}

		public bool HasId { get { return Flags.HasFlag(Flag.Id); } set { Flags = value ? (Flags | Flag.Id) : (Flags & ~Flag.Id); } }
		public bool HasShippingOptions { get { return Flags.HasFlag(Flag.ShippingOptions); } set { Flags = value ? (Flags | Flag.ShippingOptions) : (Flags & ~Flag.ShippingOptions); } }

		public Flag Flags { get; set; }
		public String Id { get; set; }
		public TLVector<TLShippingOption> ShippingOptions { get; set; }

		public TLPaymentsValidatedRequestedInfo() { }
		public TLPaymentsValidatedRequestedInfo(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PaymentsValidatedRequestedInfo; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			if (HasId) Id = from.ReadString();
			if (HasShippingOptions) ShippingOptions = TLFactory.Read<TLVector<TLShippingOption>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0xD1451883);
			to.Write((Int32)Flags);
			if (HasId) to.Write(Id);
			if (HasShippingOptions) to.WriteObject(ShippingOptions);
		}

		private void UpdateFlags()
		{
			HasId = Id != null;
			HasShippingOptions = ShippingOptions != null;
		}
	}
}