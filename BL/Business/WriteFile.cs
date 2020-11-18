using BL.Business.Writer;
using CL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Business
{
    public class WriteFile
    {
        private readonly string _prmReadFile;
        private readonly WriteType _prmWriteType;
        private AWriter _prmWriter;
        public WriteFile(string prmReadFile)
        {
            _prmReadFile = prmReadFile;
            _prmWriteType = prmReadFile.Contains(".txt") ? WriteType.TXT : WriteType.DOCX;
        }

        public void WritingData(List<string> writeData)
        {
            switch (_prmWriteType)
            {
                case WriteType.DOCX:
                    _prmWriter = new WriterDOCX(_prmReadFile);
                    break;
                case WriteType.TXT:
                    _prmWriter = new WriterTXT(_prmReadFile);
                    break;
            }
            _prmWriter.Write(writeData);
        }
    }
}
