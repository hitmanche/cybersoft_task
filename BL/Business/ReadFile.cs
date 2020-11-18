using BL.Business.Converter;
using CL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace BL.Business
{
    public class ReadFile
    {
        private List<Alive> returnData;
        private readonly string _prmReadFile;
        private readonly ReadType _prmReadType;
        private AConverter _prmConvertFile;
        public ReadFile(string prmReadFile)
        {
            _prmReadFile = prmReadFile;
            _prmReadType = prmReadFile.Contains(".txt") ? ReadType.TXT : ReadType.XML;
            ConvertData();
        }

        public List<Alive> GetData()
        {
            return returnData;
        }

        private void ConvertData()
        {
            switch (_prmReadType)
            {
                case ReadType.XML:
                    _prmConvertFile = new ConverterXML(_prmReadFile);
                    break;
                case ReadType.TXT:
                    _prmConvertFile = new ConverterTXT(_prmReadFile);
                    break;
            }
            _prmConvertFile.Converter(ref returnData);
        }
    }
}
