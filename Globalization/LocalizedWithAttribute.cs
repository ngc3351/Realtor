using System;

namespace ITTrust.UI.Common.Globalization
{
	/// <summary>
	/// Localized resources hint.
	/// </summary>
	[AttributeUsage(AttributeTargets.All)]
	public class LocalizedWithAttribute : Attribute
	{
		public LocalizedWithAttribute(Type type)
		{
			_type = type;
		}

		public Type Type
		{
			get { return _type; }
			set { _type = value; }
		}

		private Type _type;
	}
}