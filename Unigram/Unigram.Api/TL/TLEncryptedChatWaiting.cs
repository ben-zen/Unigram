// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLEncryptedChatWaiting : TLEncryptedChatBase 
	{

		public TLEncryptedChatWaiting() { }
		public TLEncryptedChatWaiting(TLBinaryReader from, TLType type = TLType.EncryptedChatWaiting)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.EncryptedChatWaiting; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.EncryptedChatWaiting)
		{
			Id = from.ReadInt32();
			AccessHash = from.ReadInt64();
			Date = from.ReadInt32();
			AdminId = from.ReadInt32();
			ParticipantId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x3BF703DC);
			to.Write(Id);
			to.Write(AccessHash);
			to.Write(Date);
			to.Write(AdminId);
			to.Write(ParticipantId);
		}
	}
}