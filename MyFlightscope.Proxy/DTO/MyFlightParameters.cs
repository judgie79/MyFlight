using System.Xml;

namespace MyFlightscope.Proxy.DTO
{
    public abstract class MyFlightParameters : SerializableDictionary<string, string>
    {
        protected override string KeyName
        {
            get { return "ParameterName"; }
        }

        protected override string ValueName
        {
            get { return "ParameterValue"; }
        }

        public override void ReadXml(XmlReader reader)
        {
            bool wasEmpty = reader.IsEmptyElement;
            reader.Read();

            if (wasEmpty)
                return;

            while (reader.NodeType != System.Xml.XmlNodeType.EndElement)
            {
                reader.ReadStartElement(ItemName);

                reader.ReadStartElement(KeyName);
                string key = reader.ReadString();
                reader.ReadEndElement();

                reader.ReadStartElement(ValueName);
                string value = reader.ReadString();
                reader.ReadEndElement();

                this.Add(key, value);

                reader.ReadEndElement();
                reader.MoveToContent();
            }
            reader.ReadEndElement();
        }
    }
}