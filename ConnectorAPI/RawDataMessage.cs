namespace Skyline.DataMiner.ConnectorAPI.Generic
{
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// Inter-App message carrying a raw string payload.
	/// The payload is serialized exactly through <see cref="MessageValue"/>.
	/// </summary>
	public class RawDataMessage : Message
	{
		/// <summary>
		/// Gets or sets the raw message value.
		/// Use an empty string when there is intentionally no payload content; null indicates the value was not assigned.
		/// </summary>
		public string MessageValue { get; set; }
	}
}
