namespace Skyline.DataMiner.ConnectorAPI.Generic
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Provides the list of Inter-App message types supported by this package.
	/// </summary>
	public static class InterApp
	{
		/// <summary>
		/// Gets the known message types for serialization and deserialization.
		/// </summary>
		public static IReadOnlyList<Type> KnownTypes { get; } = Array.AsReadOnly(new[]
		{
			typeof(RawDataMessage),
			typeof(RawDataMessageResult),
		});
	}
}
