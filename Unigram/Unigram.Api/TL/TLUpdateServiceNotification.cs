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
	partial class ITLUpdateServiceNotification : ITLUpdateBase, TLUpdateServiceNotification 
	{
		public bool IsPopup { get { return Flags.HasFlag(TLUpdateServiceNotificationFlag.Popup); } set { Flags = value ? (Flags | TLUpdateServiceNotificationFlag.Popup) : (Flags & ~TLUpdateServiceNotificationFlag.Popup); } }
		public bool HasInboxDate { get { return Flags.HasFlag(TLUpdateServiceNotificationFlag.InboxDate); } set { Flags = value ? (Flags | TLUpdateServiceNotificationFlag.InboxDate) : (Flags & ~TLUpdateServiceNotificationFlag.InboxDate); } }

		public TLUpdateServiceNotificationFlag Flags { get; set; }
		public Int32? InboxDate { get; set; }
		public String Type { get; set; }
		public String Message { get; set; }
		public TLMessageMediaBase Media { get; set; }
		public TLVector<TLMessageEntityBase> Entities { get; set; }

		public ITLUpdateServiceNotification() { }
		public ITLUpdateServiceNotification(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateServiceNotification; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (TLUpdateServiceNotificationFlag)from.ReadInt32();
			if (HasInboxDate) InboxDate = from.ReadInt32();
			Type = from.ReadString();
			Message = from.ReadString();
			Media = TLFactory.Read<TLMessageMediaBase>(from);
			Entities = TLFactory.Read<TLVector<TLMessageEntityBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0xEBE46819);
			to.Write((Int32)Flags);
			if (HasInboxDate) to.Write(InboxDate.Value);
			to.Write(Type);
			to.Write(Message);
			to.WriteObject(Media);
			to.WriteObject(Entities);
		}

		private void UpdateFlags()
		{
			HasInboxDate = InboxDate != null;
		}
	}

#if !PORTABLE
	[Flags]
	public enum TLUpdateServiceNotificationFlag : Int32
	{
		Popup = (1 << 0),
		InboxDate = (1 << 1),
	}
#endif

#if !PORTABLE
	[Guid(0x8340c33a, 0x292f, 0x15c1, 0x38, 0xfb, 0xe2, 0xd6, 0xf7, 0x5e, 0x8b, 0xcc)]
	public partial interface TLUpdateServiceNotification : TLUpdateBase
	{
		bool IsPopup { get; set; }
		bool HasInboxDate { get; set; }

		TLUpdateServiceNotificationFlag Flags { get; set; }
		Int32? InboxDate { get; set; }
		String Type { get; set; }
		String Message { get; set; }
		TLMessageMediaBase Media { get; set; }
		TLVector<TLMessageEntityBase> Entities { get; set; }
	}
#endif

}