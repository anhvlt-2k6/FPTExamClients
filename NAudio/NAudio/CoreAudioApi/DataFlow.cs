﻿using System;

namespace NAudio.CoreAudioApi
{
	/// <summary>
	/// The EDataFlow enumeration defines constants that indicate the direction 
	/// in which audio data flows between an audio endpoint device and an application
	/// </summary>
	// Token: 0x02000124 RID: 292
	public enum DataFlow
	{
		/// <summary>
		/// Audio rendering stream. 
		/// Audio data flows from the application to the audio endpoint device, which renders the stream.
		/// </summary>
		// Token: 0x0400071B RID: 1819
		Render,
		/// <summary>
		/// Audio capture stream. Audio data flows from the audio endpoint device that captures the stream, 
		/// to the application
		/// </summary>
		// Token: 0x0400071C RID: 1820
		Capture,
		/// <summary>
		/// Audio rendering or capture stream. Audio data can flow either from the application to the audio 
		/// endpoint device, or from the audio endpoint device to the application.
		/// </summary>
		// Token: 0x0400071D RID: 1821
		All
	}
}
