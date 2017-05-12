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
	partial class ITLMessageActionGameScore : ITLMessageActionBase, TLMessageActionGameScore 
	{
		public Int64 GameId { get; set; }
		public Int32 Score { get; set; }

		public ITLMessageActionGameScore() { }
		public ITLMessageActionGameScore(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageActionGameScore; } }

		public override void Read(TLBinaryReader from)
		{
			GameId = from.ReadInt64();
			Score = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x92A72876);
			to.Write(GameId);
			to.Write(Score);
		}
	}

#if !PORTABLE
	[Guid(0xb7ad6125, 0xe49b, 0x6bc2, 0x5b, 0x0d, 0x45, 0x94, 0xee, 0x69, 0x89, 0x21)]
	public partial interface TLMessageActionGameScore : TLMessageActionBase
	{
		Int64 GameId { get; set; }
		Int32 Score { get; set; }
	}
#endif

}