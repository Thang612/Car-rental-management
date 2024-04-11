namespace GUI_QLTX
{
    partial class GUI_DSXe
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
            this.dgvDSXe = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbLoaiXe = new System.Windows.Forms.ComboBox();
            this.btnSearchBienSo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSXe
            // 
            this.dgvDSXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDSXe.Location = new System.Drawing.Point(0, 0);
            this.dgvDSXe.Name = "dgvDSXe";
            this.dgvDSXe.RowHeadersWidth = 62;
            this.dgvDSXe.RowTemplate.Height = 28;
            this.dgvDSXe.Size = new System.Drawing.Size(800, 294);
            this.dgvDSXe.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 336);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbLoaiXe.Location = new System.Drawing.Point(12, 391);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(121, 28);
            this.cbLoaiXe.TabIndex = 2;
            this.cbLoaiXe.SelectedIndexChanged += new System.EventHandler(this.cbLoaiXe_SelectedIndexChanged);
            // 
            // btnSearchBienSo
            // 
            this.btnSearchBienSo.Location = new System.Drawing.Point(213, 332);
            this.btnSearchBienSo.Name = "btnSearchBienSo";
            this.btnSearchBienSo.Size = new System.Drawing.Size(95, 30);
            this.btnSearchBienSo.TabIndex = 3;
            this.btnSearchBienSo.Text = "Tìm kiếm";
            this.btnSearchBienSo.UseVisualStyleBackColor = true;
            this.btnSearchBienSo.Click += new System.EventHandler(this.btnSearchBienSo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm theo biển số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại xe";
            // 
            // GUI_DSXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchBienSo);
            this.Controls.Add(this.cbLoaiXe);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDSXe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "GUI_DSXe";
            this.Text = "GUI_DSXe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_DSXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSXe;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.Windows.Forms.Button btnSearchBienSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}