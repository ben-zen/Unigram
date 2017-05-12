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
	partial class ITLHelpAppUpdate : ITLHelpAppUpdateBase, TLHelpAppUpdate 
	{
		public Int32 Id { get; set; }
		public Boolean Critical { get; set; }
		public String Url { get; set; }
		public String Text { get; set; }

		public ITLHelpAppUpdate() { }
		public ITLHelpAppUpdate(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.HelpAppUpdate; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt32();
			Critical = from.ReadBoolean();
			Url = from.ReadString();
			Text = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x8987F311);
			to.Write(Id);
			to.Write(Critical);
			to.Write(Url);
			to.Write(Text);
		}
	}

#if !PORTABLE
	[Guid(0x64100e49, 0xd256, 0x1926, 0xc1, 0xab, 0x12, 0x91, 0x60, 0x44, 0x22, 0xb7)]
	public partial interface TLHelpAppUpdate : TLHelpAppUpdateBase
	{
		Int32 Id { get; set; }
		Boolean Critical { get; set; }
		String Url { get; set; }
		String Text { get; set; }
	}
#endif

}