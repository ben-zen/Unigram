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
	partial class ITLUpdatePrivacy : ITLUpdateBase, TLUpdatePrivacy 
	{
		public TLPrivacyKeyBase Key { get; set; }
		public TLVector<TLPrivacyRuleBase> Rules { get; set; }

		public ITLUpdatePrivacy() { }
		public ITLUpdatePrivacy(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdatePrivacy; } }

		public override void Read(TLBinaryReader from)
		{
			Key = TLFactory.Read<TLPrivacyKeyBase>(from);
			Rules = TLFactory.Read<TLVector<TLPrivacyRuleBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xEE3B272A);
			to.WriteObject(Key);
			to.WriteObject(Rules);
		}
	}

#if !PORTABLE
	[Guid(0x8340c33a, 0x292f, 0x15c1, 0x38, 0xfb, 0xe2, 0xd6, 0xf7, 0x5e, 0x8b, 0xcc)]
	public partial interface TLUpdatePrivacy : TLUpdateBase
	{
		TLPrivacyKeyBase Key { get; set; }
		TLVector<TLPrivacyRuleBase> Rules { get; set; }
	}
#endif

}