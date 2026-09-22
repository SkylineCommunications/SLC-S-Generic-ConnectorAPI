namespace Skyline.DataMiner.ConnectorAPI.Generic
{
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// Inter-App message carrying a raw string payload.
	/// </summary>
	public class RawDataMessageResult : Message
	{
		/// <summary>
		/// Gets or sets a value indicating whether the message was delivered successfully.
		/// </summary>
		public bool DeliveredSuccessfully { get; set; }
	}
}
