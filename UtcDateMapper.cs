using System;
using BLToolkit.Mapping;

namespace Realtor
{
	public class UtcDateMapper : MemberMapper
	{
		public override object GetValue(object o)
		{
			object value = MemberAccessor.GetValue(o);
			return (null != value && MapMemberInfo.NullValue != value)?
                ((DateTime)value).ToUniversalTime() : DateTime.MinValue;
		}

		public override void SetValue(object o, object value)
		{
			MemberAccessor.SetValue(o, (null != value)? ((DateTime)value).ToLocalTime() : DateTime.MinValue);//MapMemberInfo.NullValue);
		}

		public override Type Type
		{
			get { return typeof(string); }
		}
	}
}
