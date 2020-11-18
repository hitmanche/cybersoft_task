using System.Collections.Generic;
using Xceed.Words.NET;

namespace BL.Business.Writer
{
    class WriterDOCX : AWriter
    {
        private readonly string _prmReadFile;
        public WriterDOCX(string prmReadFile)
        {
            _prmReadFile = prmReadFile;
        }
        public override void Write(List<string> writeData)
        {
            using (var document = DocX.Create(_prmReadFile))
            {
                foreach (string line in writeData)
                {
                    document.InsertParagraph(line);
                }
                document.Save();
            }
        }
    }
}
