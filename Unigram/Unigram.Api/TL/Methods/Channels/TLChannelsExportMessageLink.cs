// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Channels
{
	/// <summary>
	/// RCP method channels.exportMessageLink.
	/// Returns <see cref="Telegram.Api.TL.TLExportedMessageLink"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLChannelsExportMessageLink : ITLObject, TLChannelsExportMessageLink
	{
		public TLInputChannelBase Channel { get; set; }
		public Int32 Id { get; set; }

		public ITLChannelsExportMessageLink() { }
		public ITLChannelsExportMessageLink(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsExportMessageLink; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
			Id = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xC846D22D);
			to.WriteObject(Channel);
			to.Write(Id);
		}
	}

#if !PORTABLE
	[Guid(0x56e5e9f6, 0xb8d0, 0x414b, 0x9d, 0x07, 0xf5, 0x19, 0x3e, 0x08, 0xbc, 0xdd)]
	public partial interface TLChannelsExportMessageLink : TLObject
	{
		TLInputChannelBase Channel { get; set; }
		Int32 Id { get; set; }
	}
#endif

}