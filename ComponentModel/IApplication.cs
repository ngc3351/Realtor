using System;
using System.Collections.Generic;
using System.Text;

namespace Realtor.ComponentModel
{
    public interface IApplication
    {
        string RegKey { get;}
        string IDSetup { get;}
        int IDCity { get; set;}
        Agent Agent { get;}
        void ShowModule(IModule module);

        List<TSEnumValue> GetEnumValues(Enums enumType);
        List<TSEnumValue> GetEnumValues(Enums enumType, string defKey, string defValue);
        T EnumFindKey<T>(Enums enumType, object value);
        T EnumFindValue<T>(Enums enumType, object key);
    }
}
