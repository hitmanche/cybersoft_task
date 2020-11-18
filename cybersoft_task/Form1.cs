using BL.Business;
using cybersoft_task.FormBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cybersoft_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ControlList();
        }

        private void ControlList()
        {
            if (lstInput.Items.Count == 0 && lstOutput.Items.Count == 0)
            {
                btnExportResult.Enabled = false;
                btnClearResult.Enabled = false;
                return;
            }
            btnExportResult.Enabled = true;
            btnClearResult.Enabled = true;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                string prmFileName = new Dialog("XML and TXT Files | *.xml; *.txt").ShowDialog();
                if (prmFileName != null)
                {
                    var listData = new ReadFile(prmFileName).GetData();
                    Analyze prmAnalyze = new Analyze(listData);
                    if (prmAnalyze.ControlSystem())
                    {
                        MessageBox.Show(prmAnalyze.prmErrorMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    lstInput.DataSource = prmAnalyze.Input();
                    lstOutput.DataSource = prmAnalyze.Output();
                    ControlList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearResult_Click(object sender, EventArgs e)
        {
            lstInput.DataSource = null;
            lstOutput.DataSource = null;
            ControlList();
        }

        private void btnExportResult_Click(object sender, EventArgs e)
        {
            List<string> prmResult = new List<string>();
            prmResult.AddRange(lstInput.DataSource as List<string>);
            prmResult.Add("");
            prmResult.Add("---------------------------------------");
            prmResult.Add("");
            prmResult.AddRange(lstOutput.DataSource as List<string>);

            string prmFileName = new Dialog("DOCX and TXT Files | *.txt;*.docx").ShowDialog();
            if (prmFileName != null)
            {
                new WriteFile(prmFileName).WritingData(prmResult);
                MessageBox.Show("Results have been recorded.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
