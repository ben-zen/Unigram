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
	partial class ITLInputBotInlineMessageGame : ITLInputBotInlineMessageBase, TLInputBotInlineMessageGame 
	{
		public bool HasReplyMarkup { get { return Flags.HasFlag(TLInputBotInlineMessageGameFlag.ReplyMarkup); } set { Flags = value ? (Flags | TLInputBotInlineMessageGameFlag.ReplyMarkup) : (Flags & ~TLInputBotInlineMessageGameFlag.ReplyMarkup); } }

		public TLInputBotInlineMessageGameFlag Flags { get; set; }

		public ITLInputBotInlineMessageGame() { }
		public ITLInputBotInlineMessageGame(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputBotInlineMessageGame; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (TLInputBotInlineMessageGameFlag)from.ReadInt32();
			if (HasReplyMarkup) ReplyMarkup = TLFactory.Read<TLReplyMarkupBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0x4B425864);
			to.Write((Int32)Flags);
			if (HasReplyMarkup) to.WriteObject(ReplyMarkup);
		}

		private void UpdateFlags()
		{
			HasReplyMarkup = ReplyMarkup != null;
		}
	}

#if !PORTABLE
	[Flags]
	public enum TLInputBotInlineMessageGameFlag : Int32
	{
		ReplyMarkup = (1 << 2),
	}
#endif

#if !PORTABLE
	[Guid(0xdd9053ca, 0xf83c, 0xaafa, 0x47, 0x35, 0xce, 0x04, 0x7d, 0x2e, 0x53, 0x17)]
	public partial interface TLInputBotInlineMessageGame : TLInputBotInlineMessageBase
	{
		bool HasReplyMarkup { get; set; }

		TLInputBotInlineMessageGameFlag Flags { get; set; }
		TLReplyMarkupBase ReplyMarkup { get; set; }
	}
#endif

}