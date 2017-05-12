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
	partial class ITLInputPrivacyValueAllowUsers : ITLInputPrivacyRuleBase, TLInputPrivacyValueAllowUsers 
	{
		public TLVector<TLInputUserBase> Users { get; set; }

		public ITLInputPrivacyValueAllowUsers() { }
		public ITLInputPrivacyValueAllowUsers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputPrivacyValueAllowUsers; } }

		public override void Read(TLBinaryReader from)
		{
			Users = TLFactory.Read<TLVector<TLInputUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x131CC67F);
			to.WriteObject(Users);
		}
	}

#if !PORTABLE
	[Guid(0x70106d70, 0x9348, 0xb60e, 0x91, 0xfa, 0xc4, 0xc0, 0x72, 0xc7, 0x35, 0x45)]
	public partial interface TLInputPrivacyValueAllowUsers : TLInputPrivacyRuleBase
	{
		TLVector<TLInputUserBase> Users { get; set; }
	}
#endif

}