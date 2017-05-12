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
	partial class ITLAccountTmpPassword : ITLObject, TLAccountTmpPassword 
	{
		public Byte[] TmpPassword { get; set; }
		public Int32 ValidUntil { get; set; }

		public ITLAccountTmpPassword() { }
		public ITLAccountTmpPassword(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountTmpPassword; } }

		public override void Read(TLBinaryReader from)
		{
			TmpPassword = from.ReadByteArray();
			ValidUntil = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xDB64FD34);
			to.WriteByteArray(TmpPassword);
			to.Write(ValidUntil);
		}
	}

#if !PORTABLE
	[Guid(0x3301a4fe, 0x6b64, 0x42a5, 0x7f, 0x35, 0x8f, 0xfc, 0x96, 0x62, 0x81, 0x31)]
	public partial interface TLAccountTmpPassword : TLObject
	{
		Byte[] TmpPassword { get; set; }
		Int32 ValidUntil { get; set; }
	}
#endif

}