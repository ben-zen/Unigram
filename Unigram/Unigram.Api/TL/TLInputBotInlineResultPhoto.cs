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
	partial class ITLInputBotInlineResultPhoto : ITLInputBotInlineResultBase, TLInputBotInlineResultPhoto 
	{
		public String Type { get; set; }
		public TLInputPhotoBase Photo { get; set; }

		public ITLInputBotInlineResultPhoto() { }
		public ITLInputBotInlineResultPhoto(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputBotInlineResultPhoto; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadString();
			Type = from.ReadString();
			Photo = TLFactory.Read<TLInputPhotoBase>(from);
			SendMessage = TLFactory.Read<TLInputBotInlineMessageBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xA8D864A7);
			to.Write(Id);
			to.Write(Type);
			to.WriteObject(Photo);
			to.WriteObject(SendMessage);
		}
	}

#if !PORTABLE
	[Guid(0xe2885374, 0x6d32, 0x33fe, 0xf3, 0x8d, 0x2e, 0x5b, 0x2f, 0x0a, 0x68, 0x0e)]
	public partial interface TLInputBotInlineResultPhoto : TLInputBotInlineResultBase
	{
		String Id { get; set; }
		String Type { get; set; }
		TLInputPhotoBase Photo { get; set; }
		TLInputBotInlineMessageBase SendMessage { get; set; }
	}
#endif

}