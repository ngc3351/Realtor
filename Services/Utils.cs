using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using BLToolkit.Common;
using BLToolkit.Reflection;

namespace Realtor.Services
{
    class Utils
    {
        public static XmlDocument Serialize(List<ObjSale> list)
        {
            XmlList<ObjSale> xmlList = new XmlList<ObjSale>();
            xmlList.Save(list);
            return xmlList.Document;
        }

        public static List<T> Deserialize<T>(string text) where T : EntityBase<T>
        {
            XmlList<T> xmlList = new XmlList<T>();
            xmlList.Document.LoadXml(text);
            return xmlList.GetList();
        }
    }

    class XmlList<T> where T : EntityBase<T>
    {
        private string _path;
        private XmlDocument _doc = new XmlDocument();
        private List<T> _list;

        public XmlList(XmlDocument doc, string path)
        {
            if (doc == null)
                doc = new XmlDocument();

            _path = path;
            _doc = doc;
        }

        public XmlList()
        {
            _path = "/doc";
            _doc = new XmlDocument();
        }

        public XmlDocument Document
        {
            get { return _doc; }
        }

        public void Add(T item)
        {
            List<T> list = GetList();
            list.Add(item);
            Save(list);
        }

        public void Remove(T item)
        {
            _list.Remove(item);
            Save(_list);
        }

        public void Update(T item)
        {
            Save(_list);
        }

        public List<T> GetList()
        {
            if (_list == null)
                _list = GetListInternal();
            return _list;
        }

        public List<T> GetListInternal()
        {
            List<T> res = new List<T>();

            XmlNode list = GetOrCreateXmlNode(_doc, _path);
            XmlSerializer ser = new XmlSerializer(typeof(List<T>), new Type[] { TypeAccessor.CreateInstance<T>().GetType() });
            
            if (list.FirstChild != null)
            {
                TextWriter stringWriter = new StringWriter();
                XmlWriter wr = XmlWriter.Create(stringWriter);

                XmlDocument doc = new XmlDocument();

                if (list.FirstChild is XmlElement)
                    doc.AppendChild(doc.ImportNode(list.FirstChild, true));

                doc.WriteContentTo(wr);

                wr.Flush();

                try
                {
                    res = (List<T>)ser.Deserialize(new StringReader(stringWriter.ToString()));
                }
                catch (InvalidOperationException e)
                {
                    //Debug.Fail(e.ToString());
                }
            }

            return res;
        }

        public void Save(List<T> items)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<T>), new Type[] { TypeAccessor.CreateInstance<T>().GetType() });
            TextWriter stringWriter = new StringWriter();
            ser.Serialize(stringWriter, items);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(stringWriter.ToString());

            XmlNode list = GetOrCreateXmlNode(_doc, _path);

            list.RemoveAll();
            list.AppendChild(_doc.ImportNode(doc.DocumentElement, true));
        }

        private XmlNode GetOrCreateXmlNode(XmlNode parent, string path)
        {
            XmlNode child = parent.SelectSingleNode(path);

            if (child != null)
                return child;

            foreach (string nodeName in path.Split('/'))
            {
                if (nodeName == string.Empty)
                    continue;
                child = parent.SelectSingleNode(nodeName);
                if (null == child)
                {
                    XmlDocument xmlDoc = parent.OwnerDocument ?? (XmlDocument)parent;
                    if (nodeName[0] == '@')
                    {
                        XmlAttribute attr = xmlDoc.CreateAttribute(nodeName.Substring(1));
                        parent.Attributes.Append(attr);
                        child = attr;
                    }
                    else
                    {
                        child = xmlDoc.CreateElement(nodeName);
                        parent.AppendChild(child);
                    }
                }

                parent = child;
            }

            return parent;
        }
    }
}

