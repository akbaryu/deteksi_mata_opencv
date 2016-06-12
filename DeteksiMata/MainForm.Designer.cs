namespace KC_DeteksiMata
{
    partial class MainForm
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
            
            this.btnDeteksi = new System.Windows.Forms.Button();
            this.simpanFile = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pctCvWindow = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pctMata = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCvWindow)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMata)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            
            this.panel1.Controls.Add(this.btnDeteksi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 37);
            this.panel1.TabIndex = 0;
            
            // 
            // btnDeteksi
            // 
            this.btnDeteksi.Location = new System.Drawing.Point(3, 7);
            this.btnDeteksi.Name = "btnDeteksi";
            this.btnDeteksi.Size = new System.Drawing.Size(75, 23);
            this.btnDeteksi.TabIndex = 0;
            this.btnDeteksi.Text = "Deteksi Mata";
            this.btnDeteksi.UseVisualStyleBackColor = true;
            this.btnDeteksi.Click += new System.EventHandler(this.btnDeteksi_Click);
            // 
            // simpanFile
            // 
            this.simpanFile.DefaultExt = "jpg";
            this.simpanFile.Filter = "JPEG|*.jpg";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 469);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pctCvWindow);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 334);
            this.panel4.TabIndex = 2;
            // 
            // pctCvWindow
            // 
            this.pctCvWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctCvWindow.Location = new System.Drawing.Point(0, 0);
            this.pctCvWindow.Name = "pctCvWindow";
            this.pctCvWindow.Size = new System.Drawing.Size(463, 334);
            this.pctCvWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCvWindow.TabIndex = 0;
            this.pctCvWindow.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 135);
            this.panel3.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pctMata);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Size = new System.Drawing.Size(463, 135);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
            // 
            // pctMata
            // 
            this.pctMata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctMata.Location = new System.Drawing.Point(0, 0);
            this.pctMata.Name = "pctMata";
            this.pctMata.Size = new System.Drawing.Size(232, 135);
            this.pctMata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMata.TabIndex = 0;
            this.pctMata.TabStop = false;
           
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "TugasKC_DeteksiMata";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCvWindow)).EndInit();
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctMata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeteksi;
        private System.Windows.Forms.SaveFileDialog simpanFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pctCvWindow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pctMata;
    }
}

