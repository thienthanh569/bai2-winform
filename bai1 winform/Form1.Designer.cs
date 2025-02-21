namespace bai1_winform
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            txtso1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtso2 = new TextBox();
            label4 = new Label();
            txtkq = new TextBox();
            btCong = new Button();
            btTru = new Button();
            btNhan = new Button();
            btChia = new Button();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 21);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "ứng dụng tính cơ bản";
            // 
            // txtso1
            // 
            txtso1.Location = new Point(332, 99);
            txtso1.Name = "txtso1";
            txtso1.Size = new Size(100, 23);
            txtso1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 107);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "số thứ nhất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 136);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 0;
            label3.Text = "số thứ hai";
            // 
            // txtso2
            // 
            txtso2.Location = new Point(332, 128);
            txtso2.Name = "txtso2";
            txtso2.Size = new Size(100, 23);
            txtso2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 165);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 0;
            label4.Text = "kết quả";
            // 
            // txtkq
            // 
            txtkq.Location = new Point(332, 157);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(100, 23);
            txtkq.TabIndex = 1;
            // 
            // btCong
            // 
            btCong.Location = new Point(232, 201);
            btCong.Name = "btCong";
            btCong.Size = new Size(41, 36);
            btCong.TabIndex = 2;
            btCong.Text = "+";
            btCong.UseVisualStyleBackColor = true;
            // 
            // btTru
            // 
            btTru.Location = new Point(279, 201);
            btTru.Name = "btTru";
            btTru.Size = new Size(41, 36);
            btTru.TabIndex = 2;
            btTru.Text = "-";
            btTru.UseVisualStyleBackColor = true;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(326, 201);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(41, 36);
            btNhan.TabIndex = 2;
            btNhan.Text = "*";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btChia
            // 
            btChia.Location = new Point(373, 201);
            btChia.Name = "btChia";
            btChia.Size = new Size(41, 36);
            btChia.TabIndex = 2;
            btChia.Text = "/";
            btChia.UseVisualStyleBackColor = true;
            btChia.Click += btChia_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(471, 77);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = -100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(229, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(471, 128);
            trackBar2.Maximum = 100;
            trackBar2.Minimum = -100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(229, 45);
            trackBar2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 450);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(btChia);
            Controls.Add(btNhan);
            Controls.Add(btTru);
            Controls.Add(btCong);
            Controls.Add(txtkq);
            Controls.Add(label4);
            Controls.Add(txtso2);
            Controls.Add(label3);
            Controls.Add(txtso1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ung";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btCong;
        private Button btTru;
        private Button btNhan;
        private Label label1;
        private TextBox txtso1;
        private Label label2;
        private Label label3;
        private TextBox txtso2;
        private Label label4;
        private TextBox txtkq;
        private Button btChia;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
    }
}
