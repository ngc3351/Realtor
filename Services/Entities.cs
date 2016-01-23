using System;
using System.ComponentModel;
using System.Xml.Serialization;
using BLToolkit.Common;
using BLToolkit.Mapping;
using BLToolkit.TypeBuilder;

namespace Realtor
{
    [XmlType(Namespace = "urn:abstr")]
    public abstract class Client : EntityBase<Client>
    {
        public abstract int IDclient { get; set; }
        public abstract string IDsetup { get; set; }
        public abstract int IDperson { get; set; }
        public abstract int IDowner { get; set; }

        [LocalizedDisplayName("Дата")]
        public abstract DateTime DateReg { get; set; }

        [LocalizedDisplayName("Ф.И.О.")]
        public abstract string Names { get; set; }

        [LocalizedDisplayName("Город")]
        public abstract string City { get; set; }

        [LocalizedDisplayName("Адрес")]
        public abstract string Address { get; set; }

        [LocalizedDisplayName("Телефон")]
        public abstract string Phone { get; set; }

        [LocalizedDisplayName("Эл. почта")]
        public abstract string Mail { get; set; }

        [LocalizedDisplayName("Пейджер")]
        public abstract string Pager { get; set; }

        [LocalizedDisplayName("Тип")]
        public abstract string Types { get; set; }

        [LocalizedDisplayName("Состояние")]
        public abstract string Stat { get; set; }
    }

    [XmlType(Namespace = "urn:abstr")]
    public abstract class Agent : EntityBase<Agent>
    {
        public abstract int IdPerson { get; set; }
        public abstract int IdOwner { get; set; }
        public abstract string Family { get; set; }
        public abstract string Post { get; set; }
        public abstract string Mail { get; set; }
        public abstract string Phone { get; set; }
        public abstract string Priv { get; set; }
        public abstract string Stat { get; set; }
        public abstract string Self { get; set; }
        public abstract string Dayly { get; set; }
        public abstract string Pass { get; set; }
    }

    [XmlType(Namespace = "urn:abstr")]
    public abstract class Company : EntityBase<Company>
    {
        [LocalizedDisplayName("ID владельца")]
        public abstract int IdOwner { get; set; }

        [LocalizedDisplayName("Имя")]
        public abstract string Name { get; set; }

        [LocalizedDisplayName("E-mail")]
        public abstract string Mail { get; set; }

        [LocalizedDisplayName("Телефон")]
        public abstract string Phone { get; set; }

        [LocalizedDisplayName("Адрес")]
        public abstract string Address { get; set; }

        [LocalizedDisplayName("ID города")]
        public abstract int IdCity { get; set; }

        public string ToStirng()
        {
            return Name;
        }
    }

    [GenerateBltXmlType(typeof (ObjSale))]
    public abstract class ObjSale : EntityBase<ObjSale>
    {
        public abstract string IDobj { get; set; }

        public abstract string IDsetup { get; set; }

        public abstract int IDaction { get; set; }

        public abstract int IDobject { get; set; }

        public abstract int IDowner { get; set; }

        public abstract int IDperson { get; set; }

        public abstract int IDclient { get; set; }

        public abstract int IDcity { get; set; }

        public abstract int IDrayon { get; set; }

        public abstract int IDstreet { get; set; }

        public abstract int IDreg { get; set; }

        public abstract ushort X { get; set; }

        public abstract ushort Y { get; set; }

        public abstract string Img { get; set; }

        [MemberMapper(typeof (UtcDateMapper))]
        public abstract DateTime DateReg { get; set; }

        [MemberMapper(typeof (UtcDateMapper))]
        public abstract DateTime DateUpdate { get; set; }

        public DateTime DateRegUtc
        {
            get { return DateReg.ToUniversalTime(); }

            set { DateReg = value.ToLocalTime(); }
        }

        public DateTime DateUpdateUtc
        {
            get { return DateUpdate.ToUniversalTime(); }

            set { DateUpdate = value.ToLocalTime(); }
        }

        public abstract string Object { get; set; }

        //[MapValue(null, (byte)0)]
        public abstract byte Flats { get; set; }

        public abstract string Material { get; set; }

        /*[MapValue(true, "+")]
        [MapValue(false, "-")]
        [MapValue(null, "")]
        public abstract bool? Live { get; set; }
         */
        public abstract string Live { get; set; }

        public abstract string Series { get; set; }

        [MapValue(null, 0.0f)]
        public abstract float? SqAll { get; set; }

        [MapValue(null, 0.0f)]
        public abstract float? SqHome { get; set; }

        [MapValue(null, 0.0f)]
        public abstract float? SqKitch { get; set; }

        [MapValue(null, 0.0f)]
        public abstract float? SqLand { get; set; }

        public abstract string Raspol { get; set; }

        public abstract int Flour { get; set; }

        public abstract byte Flours { get; set; }

        public abstract string Balcony { get; set; }

        public abstract string WC { get; set; }

        /*[MapValue(true, "+")]
        [MapValue(false, "-")]
        [MapValue(null, "")]
        public abstract bool? Phone { get; set; }
        */
        public abstract string Phone { get; set; }

        /*[MapValue(true, "+")]
        [MapValue(false, "-")]
        [MapValue(null, "")]
        public abstract bool? Mebel { get; set; }
         */
        public abstract string Mebel { get; set; }

        public abstract string Electricity { get; set; }

        public abstract string Hot { get; set; }

        public abstract string Water { get; set; }

        /*[MapValue(true, "+")]
        [MapValue(false, "-")]
        [MapValue(null, "")]
        public abstract bool? Entrance { get; set; }
        */
        public abstract string Entrance { get; set; }

        /*[MapValue(true, "+")]
        [MapValue(false, "-")]
        [MapValue(null, "")]
        public abstract bool? Security { get; set; }*/
        public abstract string Security { get; set; }

        /*[MapValue(true, "+")]
        [MapValue(false, "-")]
        [MapValue(null, "")]
        public abstract bool? Parking { get; set; }
         */
        public abstract string Parking { get; set; }

        /*[MapValue(true, "+")]
        [MapValue(false, "-")]
        [MapValue(null, "")]
        public abstract bool? New { get; set; }*/
        public abstract string New { get; set; }

        /*[MapValue(true, "+")]
        [MapValue(false, "-")]
        [MapValue(null, "")]
        public abstract bool? Privat { get; set; }
         */
        public abstract string Privat { get; set; }

        public abstract byte Prava { get; set; }

        public abstract string Rayon { get; set; }

        public abstract string Street { get; set; }

        [MapValue(null, 0.0f)]
        public abstract float? Price { get; set; }

        public abstract string Term { get; set; }

        public abstract string ForSQ { get; set; }

        [MapValue(null, 0.0f)]
        public abstract float? PriceMeter { get; set; }

        public abstract string Contact { get; set; }

        public abstract string PhoneObj { get; set; }

        public abstract string MailObj { get; set; }

        public abstract string PagerObj { get; set; }

        public abstract ushort Views { get; set; }

        public abstract byte Arhiv { get; set; }

        public abstract byte Upload { get; set; }

        public abstract sbyte Stat { get; set; }

        public abstract string Note { get; set; }

        [MemberMapper(typeof (UtcDateMapper))]
        public abstract DateTime DateUpdate_1 { get; set; }

        public DateTime DateUpdate_1Utc
        {
            get { return DateUpdate_1.ToUniversalTime(); }

            set { DateUpdate_1 = value.ToLocalTime(); }
        }
    }

    [XmlType(Namespace = "urn:abstr")]
    public abstract class FieldView
    {
        public abstract int Obj { get; set; }

        public abstract int Act { get; set; }

        public abstract string FName { get; set; }

        public abstract string FLabel { get; set; }

        public abstract string FShortLabel { get; set; }

        public abstract int FView { get; set; }
    }

    [XmlType(Namespace = "urn:abstr")]
    public abstract class CityRayon : EntityBase<CityRayon>
    {
        public abstract int IdRayon { get; set; }
        public abstract int IdCity { get; set; }
        public abstract string Rayon { get; set; }
    }

    [XmlType(Namespace = "urn:abstr")]
    public abstract class CityStreet : EntityBase<CityStreet>
    {
        public abstract int IdStreet { get; set; }
        public abstract int IdCity { get; set; }
        public abstract string Street { get; set; }
    }

    [XmlType(Namespace = "urn:abstr")]
    public abstract class CityEntity : EntityBase<CityEntity>
    {
        public abstract int IdCity { get; set; }
        public abstract string City { get; set; }
    }


    [AttributeUsage(AttributeTargets.All)]
    public class LocalizedDisplayNameAttribute : DisplayNameAttribute
    {
        public LocalizedDisplayNameAttribute(string displayName) : base(displayName)
        {
        }
    }
}