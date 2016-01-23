using System;
using System.ComponentModel;

namespace ITTrust.UI.Common.Globalization
{
/// <summary>
	/// Localized category (for property grid, etc)
	/// </summary>
	/// <example> This sample shows how to use LocalizedCategory
	/// <code>
	///	[LocalizedCategory("Some")]
	///	public String SomeProp
	///	{
	///		get { return _smth; }
	///		set { _smth = value; }
	///	}
	/// </code>
	///
	/// Note that Resources.resx must contain an entry for PropertyCategorySome:
	///
	///	<data name="PropertyCategorySome">
	///		<value xml:space="preserve">Some</value>
	///	</data>
	///
	/// </example>
	[AttributeUsage(AttributeTargets.All)]
	public class LocalizedCategoryAttribute : CategoryAttribute
	{
		internal LocalizedCategoryAttribute(String key): base(key)
		{}

		public LocalizedCategoryAttribute(Type type): this(type.Name, type)
		{
		}

		public LocalizedCategoryAttribute(String key, Type type): this(key)
		{
			_type = type;
		}

		public Type Type
		{
			get { return _type; }
			set { _type = value; }
		}

		protected override String GetLocalizedString(String key)
		{
			key = "PropertyCategory" + key;
#if DEBUG
			String localizedCategory = LocalizedResourceManager.GetResourceString(key, Type); ;
			if (String.IsNullOrEmpty(localizedCategory))
			{
				localizedCategory = String.Format("NOT FOUND: [{0}]", key);
			}

			return localizedCategory;
#else
			return LocalizedResourceManager.GetResourceString(key, Type);
#endif
		}

		private Type _type;
	}
}