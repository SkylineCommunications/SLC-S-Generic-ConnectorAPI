namespace Skyline.DataMiner.ConnectorAPI.Generic
{
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// Inter-App message carrying a raw string payload.
	/// </summary>
	public class RawDataMessage : Message
	{
		/// <summary>
		/// Gets or sets the raw message value.
		/// </summary>
		public string MessageValue { get; set; }
	}
}
