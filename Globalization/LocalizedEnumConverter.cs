using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace ITTrust.UI.Common.Globalization
{
	/// <summary>
	/// Localized enum values (for property grid, etc)
	/// </summary>
	/// <example> This sample shows how to use LocalizedEnumConverter
	/// <code>
	/// [TypeConverter(typeof(LocalizedEnumConverter))]
	/// public enum SomeEnum
	/// {
	/// 	Foo,
	/// 	Bar,
	/// }
	/// </code>
	///
	/// Note that Resources.resx must contain all entries for SomeEnum values:
	///
	///	<data name="SomeEnum_Foo">
	///		<value xml:space="preserve">Foo</value>
	///	</data>
	///	<data name="SomeEnum_Bar">
	///		<value xml:space="preserve">Bar</value>
	///	</data>
	///
	///	LocalizedDisplayName attribute is also supported:
	///
	/// <code>
	/// [TypeConverter(typeof(LocalizedEnumConverter))]
	/// public enum SomeEnum
	/// {
	///		[LocalizedDisplayName("FooName")]
	/// 	Foo,
	///		[LocalizedDisplayName("BarName")]
	/// 	Bar,
	/// }
	/// </code>
	///
	/// In this case Resources.resx must contain entries specified for LocalizedDisplayName attribute:
	///
	///	<data name="FooName">
	///		<value xml:space="preserve">Foo</value>
	///	</data>
	///	<data name="BarName">
	///		<value xml:space="preserve">Bar</value>
	///	</data>
	///
	/// Type converter can be specified per property instead of type:
	/// <code>
	///	[TypeConverter(typeof(LocalizedEnumConverter))]
	///	public EnumType SomeProp
	///	{
	///		get { return _smth; }
	///		set { _smth = value; }
	///	}
	/// </code>
	/// </example>
	public class LocalizedEnumConverter : EnumConverter
	{
		#region ctor

		public LocalizedEnumConverter(Type type)
			: base(type)
		{}

		#endregion

		#region Implementation

		private Hashtable GetMapEnumToName(CultureInfo culture)
		{
			if (null == _mapEnumToName || _culture != culture)
			{
				InitMaps(culture);
			}

			return _mapEnumToName;
		}

		private Hashtable GetMapNameToEnum(CultureInfo culture)
		{
			if (null == _mapNameToEnum || _culture != culture)
			{
				InitMaps(culture);
			}

			return _mapNameToEnum;
		}

		public static String GetLocalizedName(Type enumType, FieldInfo fi, CultureInfo culture)
		{
			Debug.Assert(CultureInfo.InvariantCulture != culture,
				"This method should not be used for InvariantCulture. Pass to base class instead");

			// Check attributes first
			DisplayNameAttribute attr =
				(DisplayNameAttribute)Attribute.GetCustomAttribute(fi, typeof (DisplayNameAttribute), true);
			if (null != attr && !String.IsNullOrEmpty(attr.DisplayName))
			{
				return attr.DisplayName;
			}

			// Get prefix override
			String compositeName;
			attr = (DisplayNameAttribute)Attribute.GetCustomAttribute(enumType, typeof (DisplayNameAttribute), true);
			if (null != attr && !String.IsNullOrEmpty(attr.DisplayName))
			{
				compositeName = String.Concat(attr.DisplayName, "_", fi.Name);

			}
			else
			{
				// Typical situation
				compositeName = String.Concat(enumType.Name, "_", fi.Name);
			}

			Type refType = enumType;
			LocalizedWithAttribute attrLWT = (LocalizedWithAttribute)Attribute.GetCustomAttribute(enumType, typeof(LocalizedWithAttribute), true);
			if (null != attrLWT)
			{
				refType = attrLWT.Type;
			}

			// Look for Type_Field String in resources
			String name = LocalizedResourceManager.GetResourceString(compositeName, refType, culture);
			if (!String.IsNullOrEmpty(name))
			{
				return name;
			}

			// Look for Type_Field String in resources
			name = LocalizedResourceManager.GetResourceString(compositeName, null, culture);
			if (!String.IsNullOrEmpty(name))
			{
				return name;
			}

			// Use non-localized String if none was found
			return fi.Name;
		}

		private void InitMaps(CultureInfo culture)
		{
			FieldInfo[] fields = EnumType.GetFields(BindingFlags.Public | BindingFlags.Static);

			_culture = culture;
			_mapEnumToName = new Hashtable(fields.Length);
			_mapNameToEnum = new Hashtable(fields.Length);

			for (int i = 0; i < fields.Length; ++i)
			{
				if (!IsBrowsable(fields[i]))
				{
					// Ignore this field - it's not browsable
					continue;
				}

				object value = fields[i].GetValue(null);
				String name = GetLocalizedName(EnumType, fields[i], culture);

				// Although compiler does validation for enum values, it doesn't aware of such localization
				Debug.Assert(!_mapNameToEnum.Contains(name), String.Format("Duplicate localized enum String: {0}", name));

				_mapNameToEnum[name] = value;
				_mapEnumToName[value] = name;
			}
		}

		public static bool IsBrowsable(MemberInfo mi)
		{
			BrowsableAttribute browsableAttr = (BrowsableAttribute)Attribute.GetCustomAttribute(
				mi, typeof (BrowsableAttribute), true) ?? BrowsableAttribute.Default;
			return browsableAttr.Browsable;
		}

		#endregion

		#region Overrides

		public override bool IsValid(ITypeDescriptorContext context, object value)
		{
			return GetMapNameToEnum(null).Contains(value) || base.IsValid(context, value);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value,
			Type destinationType)
		{
			// Default serialization for InvariantCulture
			if (CultureInfo.InvariantCulture == culture)
				return base.ConvertTo(context, culture, value, destinationType);

			object retVal = null;

			if (typeof (String) == destinationType && null != value && CultureInfo.InvariantCulture != culture)
			{
				if (EnumType == value.GetType())
				{
					if (null == _mapEnumToName)
					{
						// Maps are not initialized yet, so query just for this value
						// It's approx. 100 times faster then build our maps

						// No need to check args, since Enum.GetName will throw the right exception if some bad arguments were passed
						String fieldName = Enum.GetName(EnumType, value);
						if (null != fieldName)
						{
							FieldInfo fi = EnumType.GetField(fieldName);
							if (null != fi && IsBrowsable(fi))
							{
								retVal = GetLocalizedName(EnumType, fi, culture);
							}
						}
					}
					else
					{
						// Maps are built, use them
						retVal = GetMapEnumToName(culture)[value];
					}
				}
				else if (GetMapNameToEnum(culture).Contains(value))
				{
					// String-to-same String conversion
					retVal = value;
				}
			}

			return retVal ?? base.ConvertTo(context, culture, value, destinationType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			// Default serialization for InvariantCulture
			if (CultureInfo.InvariantCulture == culture)
				return base.ConvertFrom(context, culture, value);

			return GetMapNameToEnum(culture)[value] ?? base.ConvertFrom(context, culture, value);
		}

		#endregion

		#region Implementation Fields

		private Hashtable _mapEnumToName;
		private Hashtable _mapNameToEnum;
		private CultureInfo _culture;

		#endregion
	}
}