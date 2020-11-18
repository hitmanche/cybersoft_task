using System.IO;
using System.Windows.Forms;

namespace cybersoft_task.FormBusiness
{
    public class Dialog
    {
        OpenFileDialog prmFileDialog;
        public Dialog(string _filter)
        {
            prmFileDialog = new OpenFileDialog();
            prmFileDialog.Filter = _filter;
        }

        public string ShowDialog()
        {
            if (prmFileDialog.ShowDialog() == DialogResult.OK)
            {
                return prmFileDialog.FileName;
            }
            return null;
        }
    }
}
