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
	partial class ITLReplyKeyboardHide : ITLReplyMarkupBase, TLReplyKeyboardHide 
	{
		public bool IsSelective { get { return Flags.HasFlag(TLReplyKeyboardHideFlag.Selective); } set { Flags = value ? (Flags | TLReplyKeyboardHideFlag.Selective) : (Flags & ~TLReplyKeyboardHideFlag.Selective); } }

		public TLReplyKeyboardHideFlag Flags { get; set; }

		public ITLReplyKeyboardHide() { }
		public ITLReplyKeyboardHide(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ReplyKeyboardHide; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (TLReplyKeyboardHideFlag)from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xA03E5B85);
			to.Write((Int32)Flags);
		}
	}

#if !PORTABLE
	[Flags]
	public enum TLReplyKeyboardHideFlag : Int32
	{
		Selective = (1 << 2),
	}
#endif

#if !PORTABLE
	[Guid(0xbf780e09, 0x4654, 0x7369, 0xe6, 0x54, 0x8b, 0xb2, 0x75, 0x41, 0x0d, 0xf2)]
	public partial interface TLReplyKeyboardHide : TLReplyMarkupBase
	{
		bool IsSelective { get; set; }

		TLReplyKeyboardHideFlag Flags { get; set; }
	}
#endif

}