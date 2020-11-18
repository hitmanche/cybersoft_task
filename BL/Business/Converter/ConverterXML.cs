using CL.Models;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace BL.Business.Converter
{
    class ConverterXML : AConverter
    {
        private readonly string _prmReadFile;
        public ConverterXML(string prmReadFile)
        {
            _prmReadFile = prmReadFile;
        }
        public override void Converter(ref List<Alive> returnData)
        {
            var xdoc = XDocument.Load(_prmReadFile);
            returnData = new List<Alive>();
            foreach (XElement XmlNode in xdoc.Element("list").Elements())
            {
                switch (Functions.GetAliveType(XmlNode.Attribute("value").Value))
                {
                    case AliveType.Enemy:
                        returnData.Add(new Alive
                        {
                            type = AliveType.Enemy,
                            name = XmlNode.Element("name").Value,
                            health = Convert.ToInt32(XmlNode.Element("health").Value),
                            position = Convert.ToInt32(XmlNode.Element("position").Value),
                            attack = Convert.ToInt32(XmlNode.Element("attack").Value)
                        });
                        break;
                    case AliveType.Human:
                        returnData.Add(new Alive
                        {
                            type = AliveType.Human,
                            name = XmlNode.Element("name").Value,
                            health = Convert.ToInt32(XmlNode.Element("health").Value),
                            attack = Convert.ToInt32(XmlNode.Element("attack").Value)
                        });
                        break;
                    case AliveType.Distance:
                        returnData.Add(new Alive
                        {
                            type = AliveType.Distance,
                            position = Convert.ToInt32(XmlNode.Element("length").Value),
                        });
                        break;
                    case AliveType.None:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
