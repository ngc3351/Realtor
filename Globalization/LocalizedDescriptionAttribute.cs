using System;
using System.ComponentModel;

namespace ITTrust.UI.Common.Globalization
{
	/// <summary>
	/// Localized description (for property grid, etc)
	/// </summary>
	/// <example> This sample shows how to use LocalizedDescription
	/// <code>
	///	[LocalizedDescription("SomePropDesc")]
	///	public String SomeProp
	///	{
	///		get { return _smth; }
	///		set { _smth = value; }
	///	}
	/// </code>
	///
	/// Note that Resources.resx must contain an entry for SomePropDesc:
	///
	///	<data name="SomePropDesc">
	///		<value xml:space="preserve">Some property localized description</value>
	///	</data>
	///
	/// </example>
	[AttributeUsage(AttributeTargets.All)]
	public class LocalizedDescriptionAttribute : DescriptionAttribute
	{
		internal LocalizedDescriptionAttribute(String key): base(key)
		{
		}

		public LocalizedDescriptionAttribute(Type type): this(type.Name + "Desc", type)
		{
		}

		public LocalizedDescriptionAttribute(String key, Type type): this(key)
		{
			_type = type;
		}

		public Type Type
		{
			get { return _type; }
			set { _type = value; }
		}

		public override String Description
		{
			get
			{
				if (!localized)
				{
					localized = true;
					String localizedDescription = LocalizedResourceManager.GetResourceString(base.Description, Type);
					if (!String.IsNullOrEmpty(localizedDescription))
					{
						DescriptionValue = localizedDescription;
					}
#if DEBUG
					else
					{
						DescriptionValue = String.Format("NOT FOUND: [{0}]", base.Description);
					}
#endif
				}

				return DescriptionValue;
			}
		}

		private bool localized;
		private Type _type;
	}
}