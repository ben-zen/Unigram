// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Bots
{
	/// <summary>
	/// RCP method bots.sendCustomRequest.
	/// Returns <see cref="Telegram.Api.TL.TLDataJSON"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLBotsSendCustomRequest : ITLObject, TLBotsSendCustomRequest
	{
		public String CustomMethod { get; set; }
		public TLDataJSON Params { get; set; }

		public ITLBotsSendCustomRequest() { }
		public ITLBotsSendCustomRequest(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.BotsSendCustomRequest; } }

		public override void Read(TLBinaryReader from)
		{
			CustomMethod = from.ReadString();
			Params = TLFactory.Read<TLDataJSON>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xAA2769ED);
			to.Write(CustomMethod);
			to.WriteObject(Params);
		}
	}

#if !PORTABLE
	[Guid(0x11e3faea, 0x31d2, 0x9c89, 0x09, 0x4b, 0x39, 0xb5, 0xce, 0xf0, 0xe5, 0x55)]
	public partial interface TLBotsSendCustomRequest : TLObject
	{
		String CustomMethod { get; set; }
		TLDataJSON Params { get; set; }
	}
#endif

}