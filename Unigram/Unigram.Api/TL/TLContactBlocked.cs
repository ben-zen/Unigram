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
	partial class ITLContactBlocked : ITLObject, TLContactBlocked 
	{
		public Int32 UserId { get; set; }
		public Int32 Date { get; set; }

		public ITLContactBlocked() { }
		public ITLContactBlocked(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactBlocked; } }

		public override void Read(TLBinaryReader from)
		{
			UserId = from.ReadInt32();
			Date = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x561BC879);
			to.Write(UserId);
			to.Write(Date);
		}
	}

#if !PORTABLE
	[Guid(0x46c06f2b, 0xa9db, 0xc314, 0x33, 0x85, 0xf3, 0xdc, 0xb7, 0x3c, 0xc9, 0xf5)]
	public partial interface TLContactBlocked : TLObject
	{
		Int32 UserId { get; set; }
		Int32 Date { get; set; }
	}
#endif

}