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
    ///Период
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
            Add(PeriodCriteriaEnum.Last7Days, "за последние 7 дней");
            Add(PeriodCriteriaEnum.LastMonth, "за последний месяц");
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
    ///Фильтр Туалет
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
            Add("Сов", "Совместный");
            Add("Раз", "Разднельный");
            Add("2СУ", "Два и более");
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
    ///Фильтр Количество этажей
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
            Add(FlourCriteriaEnum.NotFirstLast, "кроме крайних");
            Add(FlourCriteriaEnum.NotFirst, "кроме первого");
            Add(FlourCriteriaEnum.NotLast, "кроме последнего");
            Add(FlourCriteriaEnum.First , "только первый");
            Add(FlourCriteriaEnum.BaseOrSubBase, "цоколь или подвал");
            Add(FlourCriteriaEnum.Last, "только последний");
        }

        public static FlourCriteria GetInstance()
        {
            return GetInstance<FlourCriteria>();
        }
    }

    ///<summary>
    ///Условия аренды
    ///</summary>
    /// 
    public class TermLeasing : EnumValues<string, string>
    {
        public TermLeasing()
        {
            Add("мес", "месяц");
            Add("квр", "квартал");
            Add("год", "год");
        }

        public static TermLeasing GetInstance()
        {
            return GetInstance<TermLeasing>();
        }
    }

    ///<summary>
    ///Тип объекта
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
            Add(5, "Офисное помещ.");
            Add(6, "Складское помещ.");
            Add(7, "Торговое помещ.");
            Add(8, "Производ. помещ.");
            Add(9, "Прочие объекты");
        }

        public static NoresidentObjectType GetInstance()
        {
            return GetInstance<NoresidentObjectType>();
        }
    }

    ///<summary>
    ///Цена за
    ///</summary>
    public class ForSQ : EnumValues<string, string>
    {
        public ForSQ()
        {
            Add("", "весь объект");
            Add("м2", "кв.м.");
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
    ///Право собственности
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
            Add(2, "частная собственность");
            Add(3, "аренда 5 лет");
            Add(4, "аренда 10 лет");
            Add(5, "аренда 15 лет");
            Add(6, "аренда 20 лет");
            Add(7, "аренда 25 лет");
        }

        public static Prava GetInstance()
        {
            return GetInstance<Prava>();
        }
    }

    ///<summary>
    ///Водоснабжение
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
    ///Теплоснабжение
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
    ///Электроснабжение
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
            Add("C", "Центральное");
            Add("A", "Автономное");
            Add("C+A", "Центр. + Автономное");
            Add("-", "Отсутствует");
        }


        public static ClientStatus GetInstance()
        {
            return GetInstance<ClientStatus>();
        }
    }

    ///<summary>
    ///Статус клиента
    ///</summary>
    public class ClientStatus : EnumValues<string, string>
    {
        public ClientStatus()
        {
            Add("Y", "в работе");
            Add("N", "не в работе");
        }

        public static ClientStatus GetInstance()
        {
            return GetInstance<ClientStatus>();
        }
    }

    ///<summary>
    ///Тип клиента
    ///</summary>
    public class ClientType : EnumValues<string, string>
    {
        public ClientType()
        {
            Add("Y", "частное лицо");
            Add("N", "корпоративный");
        }

        public static ClientType GetInstance()
        {
            return GetInstance<ClientType>();
        }
    }

    ///<summary>
    ///Условия сделки
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
            Add(1, "чистая продажа");
            Add(2, "обменный вариант");
        }
    }

    ///<summary>
    ///Материал здания
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
            Add("Пан", "Панельное");
            Add("Кир", "Кирпичное");
            Add("Мнл", "Монолитное");
            Add("Дер", "Деревянное");
            Add("Блч", "Блочное");
            Add("Шлк", "Шлакоблочное");
        }
    }

    ///<summary>
    ///Серия здания
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
            Add("Подселение");
            Add("Гостинка");
            Add("Малосемейка");
            Add("Хрущевка");
            Add("81-я серия");
            Add("83-я серия");
            Add("121-я серия");
            Add("125-я серия (ленпроект)");
            Add("Чешский пр-т");
            Add("Индивид. пр-т");
        }

        public void Add(string arg1)
        {
            Add(arg1, arg1);
        }
    }

    ///<summary>
    ///Количество комнат/помещений
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
    ///Количество этажей
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
    ///Количество этажей
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
            Add(-1, "Цоколь");
            Add(-2, "Подвал");
            for (int i = 1; i < 26; i++)
                Add(i, i.ToString());
        }

        public static FlourEx GetInstance()
        {
            return GetInstance<FlourEx>();
        }
    }

    ///<summary>
    ///Этаж
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
            Add(-1, "цк");
            Add(-2, "пд");
            for (int i = 1; i < 26; i++)
                Add(i, i.ToString());
        }

        public static Flour GetInstance()
        {
            return GetInstance<Flour>();
        }
    }

    ///<summary>
    ///Расположение комнат
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
            Add("Смж", "Смежнные комнаты");
            Add("Раз", "Раздельные комнаты");
        }
    }

    ///<summary>
    ///Наличие балкона
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
            Add("-", "Нет");
            Add("Л", "Лоджия");
            Add("Б", "Балкон");
        }
    }

    ///<summary>
    ///Туалет
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
            Add("Сов", "Совместный");
            Add("Раз", "Разднельный");
            Add("2СУ", "2 санузла");
            Add("-", "Отсутствует");
        }
    }

    ///<summary>
    ///Да/Нет/Не указано как '+'/'-'/''
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