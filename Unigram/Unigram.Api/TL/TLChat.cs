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
	partial class ITLChat : ITLChatBase, TLChat 
	{
		public bool IsCreator { get { return Flags.HasFlag(TLChatFlag.Creator); } set { Flags = value ? (Flags | TLChatFlag.Creator) : (Flags & ~TLChatFlag.Creator); } }
		public bool IsKicked { get { return Flags.HasFlag(TLChatFlag.Kicked); } set { Flags = value ? (Flags | TLChatFlag.Kicked) : (Flags & ~TLChatFlag.Kicked); } }
		public bool IsLeft { get { return Flags.HasFlag(TLChatFlag.Left); } set { Flags = value ? (Flags | TLChatFlag.Left) : (Flags & ~TLChatFlag.Left); } }
		public bool IsAdminsEnabled { get { return Flags.HasFlag(TLChatFlag.AdminsEnabled); } set { Flags = value ? (Flags | TLChatFlag.AdminsEnabled) : (Flags & ~TLChatFlag.AdminsEnabled); } }
		public bool IsAdmin { get { return Flags.HasFlag(TLChatFlag.Admin); } set { Flags = value ? (Flags | TLChatFlag.Admin) : (Flags & ~TLChatFlag.Admin); } }
		public bool IsDeactivated { get { return Flags.HasFlag(TLChatFlag.Deactivated); } set { Flags = value ? (Flags | TLChatFlag.Deactivated) : (Flags & ~TLChatFlag.Deactivated); } }
		public bool HasMigratedTo { get { return Flags.HasFlag(TLChatFlag.MigratedTo); } set { Flags = value ? (Flags | TLChatFlag.MigratedTo) : (Flags & ~TLChatFlag.MigratedTo); } }

		public TLChatFlag Flags { get; set; }
		public String Title { get; set; }
		public TLChatPhotoBase Photo { get; set; }
		public Int32 ParticipantsCount { get; set; }
		public Int32 Date { get; set; }
		public Int32 Version { get; set; }
		public TLInputChannelBase MigratedTo { get; set; }

		public ITLChat() { }
		public ITLChat(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.Chat; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (TLChatFlag)from.ReadInt32();
			Id = from.ReadInt32();
			Title = from.ReadString();
			Photo = TLFactory.Read<TLChatPhotoBase>(from);
			ParticipantsCount = from.ReadInt32();
			Date = from.ReadInt32();
			Version = from.ReadInt32();
			if (HasMigratedTo) MigratedTo = TLFactory.Read<TLInputChannelBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0xD91CDD54);
			to.Write((Int32)Flags);
			to.Write(Id);
			to.Write(Title);
			to.WriteObject(Photo);
			to.Write(ParticipantsCount);
			to.Write(Date);
			to.Write(Version);
			if (HasMigratedTo) to.WriteObject(MigratedTo);
		}

		private void UpdateFlags()
		{
			HasMigratedTo = MigratedTo != null;
		}
	}

#if !PORTABLE
	[Flags]
	public enum TLChatFlag : Int32
	{
		Creator = (1 << 0),
		Kicked = (1 << 1),
		Left = (1 << 2),
		AdminsEnabled = (1 << 3),
		Admin = (1 << 4),
		Deactivated = (1 << 5),
		MigratedTo = (1 << 6),
	}
#endif

#if !PORTABLE
	[Guid(0xebf38aaa, 0x48e1, 0xa731, 0xcd, 0x1b, 0x6d, 0x13, 0x83, 0xa0, 0x37, 0x55)]
	public partial interface TLChat : TLChatBase
	{
		bool IsCreator { get; set; }
		bool IsKicked { get; set; }
		bool IsLeft { get; set; }
		bool IsAdminsEnabled { get; set; }
		bool IsAdmin { get; set; }
		bool IsDeactivated { get; set; }
		bool HasMigratedTo { get; set; }

		TLChatFlag Flags { get; set; }
		Int32 Id { get; set; }
		String Title { get; set; }
		TLChatPhotoBase Photo { get; set; }
		Int32 ParticipantsCount { get; set; }
		Int32 Date { get; set; }
		Int32 Version { get; set; }
		TLInputChannelBase MigratedTo { get; set; }
	}
#endif

}