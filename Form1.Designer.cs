namespace WA_BGW_Macchine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptb_Car1 = new System.Windows.Forms.PictureBox();
            this.ptb_Car2 = new System.Windows.Forms.PictureBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ptb_Car1
            // 
            this.ptb_Car1.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Car1.Image")));
            this.ptb_Car1.Location = new System.Drawing.Point(151, 123);
            this.ptb_Car1.Name = "ptb_Car1";
            this.ptb_Car1.Size = new System.Drawing.Size(100, 50);
            this.ptb_Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Car1.TabIndex = 0;
            this.ptb_Car1.TabStop = false;
            // 
            // ptb_Car2
            // 
            this.ptb_Car2.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Car2.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Car2.Image")));
            this.ptb_Car2.Location = new System.Drawing.Point(151, 243);
            this.ptb_Car2.Name = "ptb_Car2";
            this.ptb_Car2.Size = new System.Drawing.Size(100, 50);
            this.ptb_Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Car2.TabIndex = 0;
            this.ptb_Car2.TabStop = false;
            this.ptb_Car2.Click += new System.EventHandler(this.ptb_Car2_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(33, 31);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click_1);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(33, 88);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(533, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 248);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.ptb_Car1);
            this.Controls.Add(this.ptb_Car2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptb_Car1;
        private System.Windows.Forms.PictureBox ptb_Car2;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

