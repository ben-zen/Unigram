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
	partial class ITLDocumentAttributeAudio : ITLDocumentAttributeBase, TLDocumentAttributeAudio 
	{
		public bool IsVoice { get { return Flags.HasFlag(TLDocumentAttributeAudioFlag.Voice); } set { Flags = value ? (Flags | TLDocumentAttributeAudioFlag.Voice) : (Flags & ~TLDocumentAttributeAudioFlag.Voice); } }
		public bool HasTitle { get { return Flags.HasFlag(TLDocumentAttributeAudioFlag.Title); } set { Flags = value ? (Flags | TLDocumentAttributeAudioFlag.Title) : (Flags & ~TLDocumentAttributeAudioFlag.Title); } }
		public bool HasPerformer { get { return Flags.HasFlag(TLDocumentAttributeAudioFlag.Performer); } set { Flags = value ? (Flags | TLDocumentAttributeAudioFlag.Performer) : (Flags & ~TLDocumentAttributeAudioFlag.Performer); } }
		public bool HasWaveform { get { return Flags.HasFlag(TLDocumentAttributeAudioFlag.Waveform); } set { Flags = value ? (Flags | TLDocumentAttributeAudioFlag.Waveform) : (Flags & ~TLDocumentAttributeAudioFlag.Waveform); } }

		public TLDocumentAttributeAudioFlag Flags { get; set; }
		public Int32 Duration { get; set; }
		public String Title { get; set; }
		public String Performer { get; set; }
		public Byte[] Waveform { get; set; }

		public ITLDocumentAttributeAudio() { }
		public ITLDocumentAttributeAudio(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.DocumentAttributeAudio; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (TLDocumentAttributeAudioFlag)from.ReadInt32();
			Duration = from.ReadInt32();
			if (HasTitle) Title = from.ReadString();
			if (HasPerformer) Performer = from.ReadString();
			if (HasWaveform) Waveform = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0x9852F9C6);
			to.Write((Int32)Flags);
			to.Write(Duration);
			if (HasTitle) to.Write(Title);
			if (HasPerformer) to.Write(Performer);
			if (HasWaveform) to.WriteByteArray(Waveform);
		}

		private void UpdateFlags()
		{
			HasTitle = Title != null;
			HasPerformer = Performer != null;
			HasWaveform = Waveform != null;
		}
	}

#if !PORTABLE
	[Flags]
	public enum TLDocumentAttributeAudioFlag : Int32
	{
		Voice = (1 << 10),
		Title = (1 << 0),
		Performer = (1 << 1),
		Waveform = (1 << 2),
	}
#endif

#if !PORTABLE
	[Guid(0xf83854a2, 0xd82b, 0x0277, 0x53, 0x06, 0x42, 0x2d, 0x19, 0x01, 0x4b, 0xf8)]
	public partial interface TLDocumentAttributeAudio : TLDocumentAttributeBase
	{
		bool IsVoice { get; set; }
		bool HasTitle { get; set; }
		bool HasPerformer { get; set; }
		bool HasWaveform { get; set; }

		TLDocumentAttributeAudioFlag Flags { get; set; }
		Int32 Duration { get; set; }
		String Title { get; set; }
		String Performer { get; set; }
		Byte[] Waveform { get; set; }
	}
#endif

}