namespace BTTH
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.grListBox = new System.Windows.Forms.GroupBox();
            this.grbXuli = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bntNhap = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.bn3 = new System.Windows.Forms.Button();
            this.bnt5 = new System.Windows.Forms.Button();
            this.bntKetThuc = new System.Windows.Forms.Button();
            this.grListBox.SuspendLayout();
            this.grbXuli.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listbox";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grListBox
            // 
            this.grListBox.Controls.Add(this.listBox1);
            this.grListBox.Controls.Add(this.bntNhap);
            this.grListBox.Controls.Add(this.textBox1);
            this.grListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grListBox.Location = new System.Drawing.Point(57, 85);
            this.grListBox.Name = "grListBox";
            this.grListBox.Size = new System.Drawing.Size(241, 252);
            this.grListBox.TabIndex = 1;
            this.grListBox.TabStop = false;
            this.grListBox.Text = "Listbox";
            // 
            // grbXuli
            // 
            this.grbXuli.Controls.Add(this.bnt5);
            this.grbXuli.Controls.Add(this.bn3);
            this.grbXuli.Controls.Add(this.btn4);
            this.grbXuli.Controls.Add(this.btn2);
            this.grbXuli.Controls.Add(this.btn1);
            this.grbXuli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbXuli.Location = new System.Drawing.Point(444, 85);
            this.grbXuli.Name = "grbXuli";
            this.grbXuli.Size = new System.Drawing.Size(241, 252);
            this.grbXuli.TabIndex = 2;
            this.grbXuli.TabStop = false;
            this.grbXuli.Text = "Xử lí ListBox";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 27);
            this.textBox1.TabIndex = 0;
            // 
            // bntNhap
            // 
            this.bntNhap.Location = new System.Drawing.Point(0, 107);
            this.bntNhap.Name = "bntNhap";
            this.bntNhap.Size = new System.Drawing.Size(241, 34);
            this.bntNhap.TabIndex = 1;
            this.bntNhap.Text = "Nhập";
            this.bntNhap.UseVisualStyleBackColor = true;
            this.bntNhap.Click += new System.EventHandler(this.bntNhap_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 162);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 104);
            this.listBox1.TabIndex = 2;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(0, 34);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(241, 39);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Tổng các phần tử";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(0, 79);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(241, 39);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Xoá đầu và cuối";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(0, 169);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(241, 39);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "Tăng lên 2 đơn vị";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // bn3
            // 
            this.bn3.Location = new System.Drawing.Point(0, 124);
            this.bn3.Name = "bn3";
            this.bn3.Size = new System.Drawing.Size(241, 39);
            this.bn3.TabIndex = 3;
            this.bn3.Text = "Xoá phần tử đang chọn";
            this.bn3.UseVisualStyleBackColor = true;
            this.bn3.Click += new System.EventHandler(this.bn3_Click);
            // 
            // bnt5
            // 
            this.bnt5.Location = new System.Drawing.Point(0, 213);
            this.bnt5.Name = "bnt5";
            this.bnt5.Size = new System.Drawing.Size(241, 39);
            this.bnt5.TabIndex = 5;
            this.bnt5.Text = "Thay bằng bình phương";
            this.bnt5.UseVisualStyleBackColor = true;
            this.bnt5.Click += new System.EventHandler(this.bnt5_Click);
            // 
            // bntKetThuc
            // 
            this.bntKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntKetThuc.Location = new System.Drawing.Point(57, 386);
            this.bntKetThuc.Name = "bntKetThuc";
            this.bntKetThuc.Size = new System.Drawing.Size(628, 39);
            this.bntKetThuc.TabIndex = 3;
            this.bntKetThuc.Text = "Kết thúc";
            this.bntKetThuc.UseVisualStyleBackColor = true;
            this.bntKetThuc.Click += new System.EventHandler(this.bntKetThuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntKetThuc);
            this.Controls.Add(this.grbXuli);
            this.Controls.Add(this.grListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grListBox.ResumeLayout(false);
            this.grListBox.PerformLayout();
            this.grbXuli.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grListBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bntNhap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grbXuli;
        private System.Windows.Forms.Button bnt5;
        private System.Windows.Forms.Button bn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button bntKetThuc;
    }
}

