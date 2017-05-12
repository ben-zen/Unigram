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
	partial class ITLMessagesBotResults : ITLObject, TLMessagesBotResults 
	{
		public bool IsGallery { get { return Flags.HasFlag(TLMessagesBotResultsFlag.Gallery); } set { Flags = value ? (Flags | TLMessagesBotResultsFlag.Gallery) : (Flags & ~TLMessagesBotResultsFlag.Gallery); } }
		public bool HasNextOffset { get { return Flags.HasFlag(TLMessagesBotResultsFlag.NextOffset); } set { Flags = value ? (Flags | TLMessagesBotResultsFlag.NextOffset) : (Flags & ~TLMessagesBotResultsFlag.NextOffset); } }
		public bool HasSwitchPm { get { return Flags.HasFlag(TLMessagesBotResultsFlag.SwitchPm); } set { Flags = value ? (Flags | TLMessagesBotResultsFlag.SwitchPm) : (Flags & ~TLMessagesBotResultsFlag.SwitchPm); } }

		public TLMessagesBotResultsFlag Flags { get; set; }
		public Int64 QueryId { get; set; }
		public String NextOffset { get; set; }
		public TLInlineBotSwitchPM SwitchPm { get; set; }
		public TLVector<TLBotInlineResultBase> Results { get; set; }
		public Int32 CacheTime { get; set; }

		public ITLMessagesBotResults() { }
		public ITLMessagesBotResults(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesBotResults; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (TLMessagesBotResultsFlag)from.ReadInt32();
			QueryId = from.ReadInt64();
			if (HasNextOffset) NextOffset = from.ReadString();
			if (HasSwitchPm) SwitchPm = TLFactory.Read<TLInlineBotSwitchPM>(from);
			Results = TLFactory.Read<TLVector<TLBotInlineResultBase>>(from);
			CacheTime = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0xCCD3563D);
			to.Write((Int32)Flags);
			to.Write(QueryId);
			if (HasNextOffset) to.Write(NextOffset);
			if (HasSwitchPm) to.WriteObject(SwitchPm);
			to.WriteObject(Results);
			to.Write(CacheTime);
		}

		private void UpdateFlags()
		{
			HasNextOffset = NextOffset != null;
			HasSwitchPm = SwitchPm != null;
		}
	}

#if !PORTABLE
	[Flags]
	public enum TLMessagesBotResultsFlag : Int32
	{
		Gallery = (1 << 0),
		NextOffset = (1 << 1),
		SwitchPm = (1 << 2),
	}
#endif

#if !PORTABLE
	[Guid(0xc16565de, 0x5caf, 0x3c48, 0x0f, 0x29, 0x7b, 0x2f, 0xf8, 0x49, 0xa2, 0x29)]
	public partial interface TLMessagesBotResults : TLObject
	{
		bool IsGallery { get; set; }
		bool HasNextOffset { get; set; }
		bool HasSwitchPm { get; set; }

		TLMessagesBotResultsFlag Flags { get; set; }
		Int64 QueryId { get; set; }
		String NextOffset { get; set; }
		TLInlineBotSwitchPM SwitchPm { get; set; }
		TLVector<TLBotInlineResultBase> Results { get; set; }
		Int32 CacheTime { get; set; }
	}
#endif

}