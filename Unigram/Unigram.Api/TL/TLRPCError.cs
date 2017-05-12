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
	partial class ITLRPCError : ITLObject, TLRPCError 
	{
		public Int32 ErrorCode { get; set; }
		public String ErrorMessage { get; set; }

		public ITLRPCError() { }
		public ITLRPCError(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.RPCError; } }

		public override void Read(TLBinaryReader from)
		{
			ErrorCode = from.ReadInt32();
			ErrorMessage = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x2144CA19);
			to.Write(ErrorCode);
			to.Write(ErrorMessage);
		}
	}

#if !PORTABLE
	[Guid(0x95476228, 0x2dae, 0x443f, 0xd2, 0x19, 0x0f, 0x7c, 0xca, 0x1a, 0x12, 0xeb)]
	public partial interface TLRPCError : TLObject
	{
		Int32 ErrorCode { get; set; }
		String ErrorMessage { get; set; }
	}
#endif

}