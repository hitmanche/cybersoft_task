namespace cybersoft_task
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstInput = new System.Windows.Forms.ListBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnExportResult = new System.Windows.Forms.Button();
            this.btnClearResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            resources.ApplyResources(this.btnSelectFile, "btnSelectFile");
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lstInput
            // 
            this.lstInput.FormattingEnabled = true;
            resources.ApplyResources(this.lstInput, "lstInput");
            this.lstInput.Name = "lstInput";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            resources.ApplyResources(this.lstOutput, "lstOutput");
            this.lstOutput.Name = "lstOutput";
            // 
            // btnExportResult
            // 
            resources.ApplyResources(this.btnExportResult, "btnExportResult");
            this.btnExportResult.Name = "btnExportResult";
            this.btnExportResult.UseVisualStyleBackColor = true;
            this.btnExportResult.Click += new System.EventHandler(this.btnExportResult_Click);
            // 
            // btnClearResult
            // 
            resources.ApplyResources(this.btnClearResult, "btnClearResult");
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.UseVisualStyleBackColor = true;
            this.btnClearResult.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClearResult);
            this.Controls.Add(this.btnExportResult);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.lstInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstInput;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnExportResult;
        private System.Windows.Forms.Button btnClearResult;
    }
}

