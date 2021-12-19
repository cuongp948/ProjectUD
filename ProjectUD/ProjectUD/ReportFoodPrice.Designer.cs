namespace ProjectUD
{
    partial class ReportFoodPrice
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.showfoodprice = new ProjectUD.showfoodprice();
            this.PS_SHOWFOODPRICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PS_SHOWFOODPRICETableAdapter = new ProjectUD.showfoodpriceTableAdapters.PS_SHOWFOODPRICETableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showfoodprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PS_SHOWFOODPRICEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "tbFood";
            reportDataSource2.Value = this.PS_SHOWFOODPRICEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectUD.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(92, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(773, 293);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(152, 9);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 1;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // showfoodprice
            // 
            this.showfoodprice.DataSetName = "showfoodprice";
            this.showfoodprice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PS_SHOWFOODPRICEBindingSource
            // 
            this.PS_SHOWFOODPRICEBindingSource.DataMember = "PS_SHOWFOODPRICE";
            this.PS_SHOWFOODPRICEBindingSource.DataSource = this.showfoodprice;
            // 
            // PS_SHOWFOODPRICETableAdapter
            // 
            this.PS_SHOWFOODPRICETableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập giá";
            // 
            // ReportFoodPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportFoodPrice";
            this.Text = "ReportFoodPrice";
            this.Load += new System.EventHandler(this.ReportFoodPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showfoodprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PS_SHOWFOODPRICEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PS_SHOWFOODPRICEBindingSource;
        private showfoodprice showfoodprice;
        private System.Windows.Forms.TextBox txtprice;
        private showfoodpriceTableAdapters.PS_SHOWFOODPRICETableAdapter PS_SHOWFOODPRICETableAdapter;
        private System.Windows.Forms.Label label1;
    }
}