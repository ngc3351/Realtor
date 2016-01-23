using System.Collections.Generic;
using System.Windows.Forms;
using BLToolkit.Common;
using Realtor.Services.Abstract;

namespace Realtor
{
    public enum PeriodCriteriaEnum
    {
        Any,
        Last7Days,
        LastMonth
    }

    ///<summary>
    ///������
    ///</summary>
    public class PeriodCriteria : EnumValues<PeriodCriteriaEnum, string>
    {
        public PeriodCriteria()
            : this(string.Empty)
        {
        }

        public PeriodCriteria(string defaultName)
        {
            Add(PeriodCriteriaEnum.Any, defaultName);
            Add(PeriodCriteriaEnum.Last7Days, "�� ��������� 7 ����");
            Add(PeriodCriteriaEnum.LastMonth, "�� ��������� �����");
        }

        public static PeriodCriteria GetInstance()
        {
            return GetInstance<PeriodCriteria>();
        }
    }

    public class WaterCriteria : EnumValues<bool, CriteriaGroup>
    {
        public WaterCriteria()
        {
            //Add(false, Criteria<string>.CreateInstance(CompareOperator.Equal, ""));
            Add(true, CriteriaGroup.CreateInstance(
                    GroupOperator.AND,
                    Criteria<string>.CreateInstance(CompareOperator.NE, "", ""),
                    Criteria<string>.CreateInstance(CompareOperator.NE, "-", "")
                ));
        }

        public static WaterCriteria GetInstance()
        {
            return GetInstance<WaterCriteria>();
        }
    }

    ///<summary>
    ///������ ������
    ///</summary>
    public class WCCriteria : EnumValues<string, string>
    {
        public WCCriteria()
            : this(string.Empty)
        {
        }

        public WCCriteria(string defaultName)
        {
            Add("", defaultName);
            Add("���", "����������");
            Add("���", "�����������");
            Add("2��", "��� � �����");
        }
    }

    public enum FlourCriteriaEnum
    {
        Any,
        NotFirstLast,
        NotFirst,
        NotLast,
        First,
        BaseOrSubBase,
        Last
    }

    ///<summary>
    ///������ ���������� ������
    ///</summary>
    public class FlourCriteria : EnumValues<FlourCriteriaEnum, string>
    {
        public FlourCriteria()
            : this(string.Empty)
        {
        }

        public FlourCriteria(string defaultName)
        {
            Add(FlourCriteriaEnum.Any, defaultName);
            Add(FlourCriteriaEnum.NotFirstLast, "����� �������");
            Add(FlourCriteriaEnum.NotFirst, "����� �������");
            Add(FlourCriteriaEnum.NotLast, "����� ����������");
            Add(FlourCriteriaEnum.First , "������ ������");
            Add(FlourCriteriaEnum.BaseOrSubBase, "������ ��� ������");
            Add(FlourCriteriaEnum.Last, "������ ���������");
        }

        public static FlourCriteria GetInstance()
        {
            return GetInstance<FlourCriteria>();
        }
    }

    ///<summary>
    ///������� ������
    ///</summary>
    /// 
    public class TermLeasing : EnumValues<string, string>
    {
        public TermLeasing()
        {
            Add("���", "�����");
            Add("���", "�������");
            Add("���", "���");
        }

        public static TermLeasing GetInstance()
        {
            return GetInstance<TermLeasing>();
        }
    }

    ///<summary>
    ///��� �������
    ///</summary>
    public class NoresidentObjectType : EnumValues<int, string>
    {
        public NoresidentObjectType()
            :this(false)
        {
        }

        public NoresidentObjectType(bool appendDefault)
        {
            if (appendDefault)
                Add(0, "");
            Add(5, "������� �����.");
            Add(6, "��������� �����.");
            Add(7, "�������� �����.");
            Add(8, "��������. �����.");
            Add(9, "������ �������");
        }

        public static NoresidentObjectType GetInstance()
        {
            return GetInstance<NoresidentObjectType>();
        }
    }

    ///<summary>
    ///���� ��
    ///</summary>
    public class ForSQ : EnumValues<string, string>
    {
        public ForSQ()
        {
            Add("", "���� ������");
            Add("�2", "��.�.");
        }

        public void Add(string arg1)
        {
            Add(arg1, arg1);
        }

        public static ForSQ GetInstance()
        {
            return GetInstance<ForSQ>();
        }
    }

    ///<summary>
    ///����� �������������
    ///</summary>
    public class Prava : EnumValues<byte, string>
    {
        public Prava()
            : this(string.Empty)
        {
        }

        public Prava(string defaultName)
        {
            Add(0, defaultName);
            Add(2, "������� �������������");
            Add(3, "������ 5 ���");
            Add(4, "������ 10 ���");
            Add(5, "������ 15 ���");
            Add(6, "������ 20 ���");
            Add(7, "������ 25 ���");
        }

        public static Prava GetInstance()
        {
            return GetInstance<Prava>();
        }
    }

    ///<summary>
    ///�������������
    ///</summary>
    public class Water : Electricity
    {
        public Water()
            : base(string.Empty)
        {
        }

        public Water(string defaultName)
            : base(defaultName)
        {
        }
    }

    ///<summary>
    ///��������������
    ///</summary>
    public class Hot : Electricity
    {
        public Hot()
            : base(string.Empty)
        {
        }

        public Hot(string defaultName)
            : base(defaultName)
        {
        }
    }

    ///<summary>
    ///����������������
    ///</summary>
    public class Electricity : EnumValues<string, string>
    {
        public Electricity()
            : this(string.Empty)
        {
        }

        public Electricity(string defaultName)
        {
            Add("", defaultName);
            Add("C", "�����������");
            Add("A", "����������");
            Add("C+A", "�����. + ����������");
            Add("-", "�����������");
        }


        public static ClientStatus GetInstance()
        {
            return GetInstance<ClientStatus>();
        }
    }

    ///<summary>
    ///������ �������
    ///</summary>
    public class ClientStatus : EnumValues<string, string>
    {
        public ClientStatus()
        {
            Add("Y", "� ������");
            Add("N", "�� � ������");
        }

        public static ClientStatus GetInstance()
        {
            return GetInstance<ClientStatus>();
        }
    }

    ///<summary>
    ///��� �������
    ///</summary>
    public class ClientType : EnumValues<string, string>
    {
        public ClientType()
        {
            Add("Y", "������� ����");
            Add("N", "�������������");
        }

        public static ClientType GetInstance()
        {
            return GetInstance<ClientType>();
        }
    }

    ///<summary>
    ///������� ������
    ///</summary>
    public class Stat : EnumValues<sbyte, string>
    {
        public Stat()
            : this(string.Empty)
        {
        }

        public Stat(string defaultName)
        {
            Add(0, defaultName);
            Add(1, "������ �������");
            Add(2, "�������� �������");
        }
    }

    ///<summary>
    ///�������� ������
    ///</summary>
    public class Material : EnumValues<string, string>
    {
        public Material()
            : this(string.Empty)
        {
        }

        public Material(string defaultName)
        {
            Add("", defaultName);
            Add("���", "���������");
            Add("���", "���������");
            Add("���", "����������");
            Add("���", "����������");
            Add("���", "�������");
            Add("���", "������������");
        }
    }

    ///<summary>
    ///����� ������
    ///</summary>
    public class Series : EnumValues<string, string>
    {
        public Series()
            : this(string.Empty)
        {
        }

        public Series(string defaultName)
        {
            Add("", defaultName);
            Add("����������");
            Add("��������");
            Add("�����������");
            Add("��������");
            Add("81-� �����");
            Add("83-� �����");
            Add("121-� �����");
            Add("125-� ����� (���������)");
            Add("������� ��-�");
            Add("�������. ��-�");
        }

        public void Add(string arg1)
        {
            Add(arg1, arg1);
        }
    }

    ///<summary>
    ///���������� ������/���������
    ///</summary>
    public class Flats : EnumValues<byte, string>
    {
        public Flats()
            : this(string.Empty)
        {
        }

        public Flats(string defaultValue)
            : this(0, defaultValue)
        {
        }

        public Flats(byte defaultKey, string defaultValue)
        {
            Add(defaultKey, defaultValue);
            for (int i = 1; i < 10; i++)
                Add((byte)i, i.ToString());
        }
    }

    ///<summary>
    ///���������� ������
    ///</summary>
    public class Flours : EnumValues<byte, string>
    {
        public Flours()
            : this(string.Empty)
        {
        }

        public Flours(string defaultName)
            : this(defaultName, 26)
        {
        }

        public Flours(string defaultName, int max)
        {
            Add(0, defaultName);
            for (int i = 1; i < max; i++)
                Add((byte) i, i.ToString());
        }

        public static Flours GetInstance()
        {
            return GetInstance<Flours>();
        }
    }

    ///<summary>
    ///���������� ������
    ///</summary>
    public class FlourEx : EnumValues<int, string>
    {
        public FlourEx()
            : this(string.Empty)
        {
        }

        public FlourEx(string defaultName)
        {
            Add(0, defaultName);
            Add(-1, "������");
            Add(-2, "������");
            for (int i = 1; i < 26; i++)
                Add(i, i.ToString());
        }

        public static FlourEx GetInstance()
        {
            return GetInstance<FlourEx>();
        }
    }

    ///<summary>
    ///����
    ///</summary>
    public class Flour : EnumValues<int, string>
    {
        public Flour()
            : this(string.Empty)
        {
        }

        public Flour(string defaultName)
        {
            Add(0, defaultName);
            Add(-1, "��");
            Add(-2, "��");
            for (int i = 1; i < 26; i++)
                Add(i, i.ToString());
        }

        public static Flour GetInstance()
        {
            return GetInstance<Flour>();
        }
    }

    ///<summary>
    ///������������ ������
    ///</summary>
    public class Raspol : EnumValues<string, string>
    {
        public Raspol()
            : this(string.Empty)
        {
        }

        public Raspol(string defaultName)
        {
            Add("", defaultName);
            Add("���", "�������� �������");
            Add("���", "���������� �������");
        }
    }

    ///<summary>
    ///������� �������
    ///</summary>
    public class Balcony : EnumValues<string, string>
    {
        public Balcony()
            : this(string.Empty)
        {
        }

        public Balcony(string defaultName)
        {
            Add("", defaultName);
            Add("-", "���");
            Add("�", "������");
            Add("�", "������");
        }
    }

    ///<summary>
    ///������
    ///</summary>
    public class WC : EnumValues<string, string>
    {
        public WC()
            : this(string.Empty)
        {
        }

        public WC(string defaultName)
        {
            Add("", defaultName);
            Add("���", "����������");
            Add("���", "�����������");
            Add("2��", "2 �������");
            Add("-", "�����������");
        }
    }

    ///<summary>
    ///��/���/�� ������� ��� '+'/'-'/''
    ///</summary>
    public class YesNo : EnumValues<CheckState, string>
    {
        public YesNo()
            : this(string.Empty)
        {
        }

        public YesNo(string defaultName)
            : this(CheckState.Indeterminate, defaultName, "+", "-")
        {
        }

        public YesNo(CheckState defaultKey, string defaultValue, string checkValue, string uncheckValue)
        {
            Add(defaultKey, defaultValue);
            Add(CheckState.Unchecked, uncheckValue);
            Add(CheckState.Checked, checkValue);
        }

        public static YesNo GetInstance()
        {
            return GetInstance<YesNo>();
        }
    }

    ///<summary>
    ///
    ///</summary>
    ///<typeparam name="T1">key type</typeparam>
    ///<typeparam name="T2">value type</typeparam>
    public class EnumValues<T1, T2> : List<EnumValue<T1, T2>>
    {
        private static readonly List<EnumValues<T1, T2>> _instances = new List<EnumValues<T1, T2>>();

        public static T3 GetInstance<T3>() where T3 : EnumValues<T1, T2>, new()
        {
            for (int i = 0; i < _instances.Count; i++)
                if (_instances[i] is T3)
                    return (T3) _instances[i];

            _instances.Add(new T3());

            return (T3) _instances[_instances.Count - 1];
        }

        public void Add(T1 key, T2 value)
        {
            Add(new EnumValue<T1, T2>(key, value));
        }

        public T2 GetValue(T1 key)
        {
            for (int i = 0; i < Count; i++)
                if (this[i].Key.Equals(key))
                    return this[i].Value;

            return default(T2);
        }

        public T1 FindKey(T2 value)
        {
            for (int i = 0; i < Count; i++)
                if (this[i].Value.Equals(value))
                    return this[i].Key;

            return default(T1);
        }
    }

    ///<summary>
    ///
    ///</summary>
    ///<typeparam name="T1">key type</typeparam>
    ///<typeparam name="T2">value type</typeparam>
    public class EnumValue<T1, T2>
    {
        private readonly T1 _key;
        private readonly T2 _value;

        public EnumValue(T1 key, T2 value)
        {
            _key = key;
            _value = value;
        }

        public T1 Key
        {
            get { return _key; }
        }

        public T2 Value
        {
            get { return _value; }
        }
    }

    public abstract class TSEnumValue : EntityBase<TSEnumValue>
    {
        //[MapField("enum_type")]
        public abstract string EnumType { get; set; }
        //[MapField("display_name")]
        public abstract object Key { get; set; }
        //[MapField("enum_value")]
        public abstract object Value { get; set; }
        //[MapField("icon_id")]
        public abstract int IconId { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}