namespace ProjectUD
{
    partial class ReportCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLCPDataSet = new ProjectUD.QLCPDataSet();
            this.FOODCATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FOODCATEGORYTableAdapter = new ProjectUD.QLCPDataSetTableAdapters.FOODCATEGORYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLCPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FOODCATEGORYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "tbCategory";
            reportDataSource1.Value = this.FOODCATEGORYBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectUD.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(65, 42);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(765, 289);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // QLCPDataSet
            // 
            this.QLCPDataSet.DataSetName = "QLCPDataSet";
            this.QLCPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FOODCATEGORYBindingSource
            // 
            this.FOODCATEGORYBindingSource.DataMember = "FOODCATEGORY";
            this.FOODCATEGORYBindingSource.DataSource = this.QLCPDataSet;
            // 
            // FOODCATEGORYTableAdapter
            // 
            this.FOODCATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // ReportCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 365);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportCategory";
            this.Text = "ReportCategory";
            this.Load += new System.EventHandler(this.ReportCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLCPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FOODCATEGORYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FOODCATEGORYBindingSource;
        private QLCPDataSet QLCPDataSet;
        private QLCPDataSetTableAdapters.FOODCATEGORYTableAdapter FOODCATEGORYTableAdapter;
    }
}