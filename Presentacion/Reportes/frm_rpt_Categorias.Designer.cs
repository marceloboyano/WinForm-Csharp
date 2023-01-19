namespace Presentacion.Reportes
{
    partial class frm_rpt_Categorias
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
            this.DS_Reportes = new Presentacion.Reportes.DS_Reportes();
            this.USP_Listado_caBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_Listado_caTableAdapter = new Presentacion.Reportes.DS_ReportesTableAdapters.USP_Listado_caTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_caBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Reporte_Categorias";
            reportDataSource1.Value = this.USP_Listado_caBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.DS_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(836, 444);
            this.reportViewer1.TabIndex = 0;
            
            // 
            // DS_Reportes
            // 
            this.DS_Reportes.DataSetName = "DS_Reportes";
            this.DS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_Listado_caBindingSource
            // 
            this.USP_Listado_caBindingSource.DataMember = "USP_Listado_ca";
            this.USP_Listado_caBindingSource.DataSource = this.DS_Reportes;
            // 
            // USP_Listado_caTableAdapter
            // 
            this.USP_Listado_caTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(12, 44);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(196, 20);
            this.txt_p1.TabIndex = 1;
            this.txt_p1.Visible = false;
            this.txt_p1.TextChanged += new System.EventHandler(this.txt_p1_TextChanged);
            // 
            // frm_rpt_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 444);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_rpt_Categorias";
            this.Text = "frm_rpt_Categorias";
            this.Load += new System.EventHandler(this.frm_rpt_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_caBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Listado_caBindingSource;
        private DS_Reportes DS_Reportes;
        private DS_ReportesTableAdapters.USP_Listado_caTableAdapter USP_Listado_caTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}