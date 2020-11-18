using System.Collections.Generic;
using System.IO;

namespace BL.Business.Writer
{
    class WriterTXT : AWriter
    {
        private readonly string _prmReadFile;
        public WriterTXT(string prmReadFile)
        {
            _prmReadFile = prmReadFile;
        }
        public override void Write(List<string> writeData)
        {
            File.WriteAllLines(_prmReadFile, writeData);
        }
    }
}
