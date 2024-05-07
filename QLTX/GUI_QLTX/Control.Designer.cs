namespace GUI_QLTX
{
    partial class Control
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btXe = new System.Windows.Forms.Button();
            this.lbNameUser = new System.Windows.Forms.Label();
            this.pnForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbChucVu);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btXe);
            this.panel1.Controls.Add(this.lbNameUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 654);
            this.panel1.TabIndex = 0;
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(17, 47);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(83, 20);
            this.lbChucVu.TabIndex = 3;
            this.lbChucVu.Text = "Nhân Viên";
            this.lbChucVu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(48, 544);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 49);
            this.button4.TabIndex = 2;
            this.button4.Text = "Đăng Xuất";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(3, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 53);
            this.button3.TabIndex = 1;
            this.button3.Text = "button1";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(3, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "button1";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btXe
            // 
            this.btXe.BackColor = System.Drawing.Color.White;
            this.btXe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXe.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXe.ForeColor = System.Drawing.Color.Black;
            this.btXe.Location = new System.Drawing.Point(3, 156);
            this.btXe.Name = "btXe";
            this.btXe.Size = new System.Drawing.Size(230, 53);
            this.btXe.TabIndex = 1;
            this.btXe.Text = "Quản Lý Xe";
            this.btXe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXe.UseVisualStyleBackColor = false;
            this.btXe.Click += new System.EventHandler(this.btXe_Click);
            // 
            // lbNameUser
            // 
            this.lbNameUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNameUser.AutoSize = true;
            this.lbNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameUser.Location = new System.Drawing.Point(16, 22);
            this.lbNameUser.Name = "lbNameUser";
            this.lbNameUser.Size = new System.Drawing.Size(194, 25);
            this.lbNameUser.TabIndex = 0;
            this.lbNameUser.Text = "Đặng Trung Thắng";
            // 
            // pnForm
            // 
            this.pnForm.BackColor = System.Drawing.Color.Silver;
            this.pnForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForm.Location = new System.Drawing.Point(235, 0);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(1040, 654);
            this.pnForm.TabIndex = 1;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1275, 654);
            this.Controls.Add(this.pnForm);
            this.Controls.Add(this.panel1);
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Control_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNameUser;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btXe;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnForm;
    }
}