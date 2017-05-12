// <auto-generated/>
using System;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL.Methods.Auth
{
	/// <summary>
	/// RCP method auth.dropTempAuthKeys.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
#if !PORTABLE
	internal
#else
	public
#endif
	partial class ITLAuthDropTempAuthKeys : ITLObject, TLAuthDropTempAuthKeys
	{
		public TLVector<Int64> ExceptAuthKeys { get; set; }

		public ITLAuthDropTempAuthKeys() { }
		public ITLAuthDropTempAuthKeys(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthDropTempAuthKeys; } }

		public override void Read(TLBinaryReader from)
		{
			ExceptAuthKeys = TLFactory.Read<TLVector<Int64>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x8E48A188);
			to.WriteObject(ExceptAuthKeys);
		}
	}

#if !PORTABLE
	[Guid(0x13ff06c5, 0xab4b, 0x6edd, 0x68, 0xab, 0x3e, 0x63, 0x50, 0xe9, 0x53, 0x05)]
	public partial interface TLAuthDropTempAuthKeys : TLObject
	{
		TLVector<Int64> ExceptAuthKeys { get; set; }
	}
#endif

}