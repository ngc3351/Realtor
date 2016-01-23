using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace ITTrust.UI.Common.Globalization
{
	public class LocalizedResourceManager : ResourceManager
	{
		private static ResourceManager _defaultRM;
		private static readonly Dictionary<Type, ResourceManager> _rmCache = new Dictionary<Type, ResourceManager>();

		private static CultureInfo _neutralResourcesCulture;

		public static CultureInfo NeutralResourcesCulture
		{
			get
			{
				if (null == _neutralResourcesCulture)
				{
					_neutralResourcesCulture = GetNeutralResourcesLanguage(Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly());
					Debug.Assert(_neutralResourcesCulture.Name == "ru", _neutralResourcesCulture.Name);
				}

				return _neutralResourcesCulture;
			}
		}

		private static ResourceManager GetRM(Type type)
		{
			if (null == type)
			{
				if (null == _defaultRM)
				{
					lock (_rmCache)
					{
						if (null == _defaultRM)
						{
							Assembly entryAssembly = Assembly.GetExecutingAssembly();
							String resources =
								Array.Find
									( entryAssembly.GetManifestResourceNames()
										, delegate(String name) { return name.Contains(".Properties.Resources.resources"); }
									);

							_defaultRM =
								(null != resources)
									? new ResourceManager
										( resources.Substring(0, resources.LastIndexOf('.'))
											, entryAssembly
										)
									: null;
						}
					}
				}

				return _defaultRM;
			}

			ResourceManager rm;
			if (!_rmCache.TryGetValue(type, out rm))
			{
				lock (_rmCache)
				{
					if (!_rmCache.TryGetValue(type, out rm))
					{
						if (null != type.Assembly.GetManifestResourceInfo(type.FullName + ".resources"))
							rm = new ResourceManager(type.FullName, type.Assembly);

						_rmCache.Add(type, rm);
					}
				}
			}

			return rm;
		}

		public static CultureInfo GetResourceStringCulture(String name, Type refType)
		{
			return GetResourceStringCulture(name, refType, null);
		}

		public static CultureInfo GetResourceStringCulture(String name, Type refType, CultureInfo culture)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}

			if (culture == null)
			{
				culture = CultureInfo.CurrentUICulture;
			}

			ResourceSet rs;
			ResourceManager rm = GetRM(refType);

			if (null == rm)
			{
				return null;
			}

			lock (rm)
			{
				for (;;)
				{
					rs = rm.GetResourceSet(culture, true, false);
					if (null != rs && null != rs.GetString(name, rm.IgnoreCase))
					{
						return (culture == CultureInfo.InvariantCulture) ? NeutralResourcesCulture : culture;
					}

					if (culture.Equals(CultureInfo.InvariantCulture) || culture.Equals(NeutralResourcesCulture))
					{
						// The requested String was not found
						return null;
					}

					culture = culture.Parent;
				}
			}
		}

		public static String GetResourceString(String name, Type refType)
		{
			return GetResourceString(name, refType, null);
		}

		public static String GetResourceString(String name, Type refType, CultureInfo culture)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}

			if (culture == null)
			{
				culture = CultureInfo.CurrentUICulture;
			}

			ResourceSet rs;
			ResourceManager rm = GetRM(refType);

			if (null == rm)
			{
				return null;
			}

			lock (rm)
			{
				for (;;)
				{
					rs = rm.GetResourceSet(culture, true, false);
					if (null != rs)
					{
						String localizedString = rs.GetString(name, rm.IgnoreCase);
						if (null != localizedString)
						{
							// Gotcha!
							return localizedString;
						}
					}

					if (culture.Equals(CultureInfo.InvariantCulture) || culture.Equals(NeutralResourcesCulture))
					{
						// The requested String was not found
						return null;
					}

					culture = culture.Parent;
				}
			}
		}

		public static Object GetResourceObject(String name, Type refType)
		{
			return GetResourceObject(name, refType, null);
		}

		public static Object GetResourceObject(String name, Type refType, CultureInfo culture)
		{
			if (name == null)
				throw new ArgumentNullException("name");

			if (culture == null)
				culture = CultureInfo.CurrentUICulture;

			ResourceManager rm = GetRM(refType);

			return (null != rm) ? rm.GetObject(name, culture) : null;
		}
	}
}