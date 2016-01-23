using System;
using System.ComponentModel;

namespace ITTrust.UI.Common.Globalization
{
	/// <summary>
	/// Localized display name (for property grid, etc)
	/// </summary>
	/// <example> This sample shows how to use LocalizedDisplayName
	/// <code>
	///	[LocalizedDisplayName("SomePropName")]
	///	public String SomeProp
	///	{
	///		get { return _smth; }
	///		set { _smth = value; }
	///	}
	/// </code>
	///
	/// Note that Resources.resx must contain an entry for SomePropName:
	///
	///	<data name="SomePropName">
	///		<value xml:space="preserve">SomeProp</value>
	///	</data>
	///
	/// </example>
	[AttributeUsage(AttributeTargets.All)]
	public class LocalizedDisplayNameAttribute : DisplayNameAttribute
	{
		internal LocalizedDisplayNameAttribute(String key): base(key)
		{
		}

		public LocalizedDisplayNameAttribute(Type type) : this(type.Name + "Name", type)
		{
		}

		public LocalizedDisplayNameAttribute(String key, Type type): this(key)
		{
			_type = type;
		}

		public Type Type
		{
			get { return _type; }
			set { _type = value; }
		}

		public override String DisplayName
		{
			get
			{
				if (!localized)
				{
					localized = true;
					String localizedDisplayName = LocalizedResourceManager.GetResourceString(base.DisplayName, Type);
					if (!String.IsNullOrEmpty(localizedDisplayName))
					{
						DisplayNameValue = localizedDisplayName;
					}
#if DEBUG
					else
					{
						DisplayNameValue = String.Format("NOT FOUND: [{0}]", base.DisplayName);
					}
#endif
				}

				return DisplayNameValue;
			}
		}

		private bool localized = false;
		private Type _type;
	}
}