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
	partial class ITLInputBotInlineMessageID : ITLObject, TLInputBotInlineMessageID 
	{
		public Int32 DCId { get; set; }
		public Int64 Id { get; set; }
		public Int64 AccessHash { get; set; }

		public ITLInputBotInlineMessageID() { }
		public ITLInputBotInlineMessageID(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputBotInlineMessageID; } }

		public override void Read(TLBinaryReader from)
		{
			DCId = from.ReadInt32();
			Id = from.ReadInt64();
			AccessHash = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x890C3D89);
			to.Write(DCId);
			to.Write(Id);
			to.Write(AccessHash);
		}
	}

#if !PORTABLE
	[Guid(0x861bafa8, 0x5b3c, 0x1100, 0xdb, 0x7b, 0xe9, 0x42, 0x41, 0x61, 0xe3, 0x55)]
	public partial interface TLInputBotInlineMessageID : TLObject
	{
		Int32 DCId { get; set; }
		Int64 Id { get; set; }
		Int64 AccessHash { get; set; }
	}
#endif

}