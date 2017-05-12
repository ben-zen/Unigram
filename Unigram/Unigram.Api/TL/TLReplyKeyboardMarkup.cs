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
	partial class ITLReplyKeyboardMarkup : ITLReplyMarkupBase, TLReplyKeyboardMarkup 
	{
		public bool IsResize { get { return Flags.HasFlag(TLReplyKeyboardMarkupFlag.Resize); } set { Flags = value ? (Flags | TLReplyKeyboardMarkupFlag.Resize) : (Flags & ~TLReplyKeyboardMarkupFlag.Resize); } }
		public bool IsSingleUse { get { return Flags.HasFlag(TLReplyKeyboardMarkupFlag.SingleUse); } set { Flags = value ? (Flags | TLReplyKeyboardMarkupFlag.SingleUse) : (Flags & ~TLReplyKeyboardMarkupFlag.SingleUse); } }
		public bool IsSelective { get { return Flags.HasFlag(TLReplyKeyboardMarkupFlag.Selective); } set { Flags = value ? (Flags | TLReplyKeyboardMarkupFlag.Selective) : (Flags & ~TLReplyKeyboardMarkupFlag.Selective); } }

		public TLReplyKeyboardMarkupFlag Flags { get; set; }
		public TLVector<TLKeyboardButtonRow> Rows { get; set; }

		public ITLReplyKeyboardMarkup() { }
		public ITLReplyKeyboardMarkup(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ReplyKeyboardMarkup; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (TLReplyKeyboardMarkupFlag)from.ReadInt32();
			Rows = TLFactory.Read<TLVector<TLKeyboardButtonRow>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x3502758C);
			to.Write((Int32)Flags);
			to.WriteObject(Rows);
		}
	}

#if !PORTABLE
	[Flags]
	public enum TLReplyKeyboardMarkupFlag : Int32
	{
		Resize = (1 << 0),
		SingleUse = (1 << 1),
		Selective = (1 << 2),
	}
#endif

#if !PORTABLE
	[Guid(0xbf780e09, 0x4654, 0x7369, 0xe6, 0x54, 0x8b, 0xb2, 0x75, 0x41, 0x0d, 0xf2)]
	public partial interface TLReplyKeyboardMarkup : TLReplyMarkupBase
	{
		bool IsResize { get; set; }
		bool IsSingleUse { get; set; }
		bool IsSelective { get; set; }

		TLReplyKeyboardMarkupFlag Flags { get; set; }
		TLVector<TLKeyboardButtonRow> Rows { get; set; }
	}
#endif

}