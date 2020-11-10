namespace KEEP_COUNT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.digit1_lb = new System.Windows.Forms.Label();
            this.digit2_lb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CONTROL_BOX = new System.Windows.Forms.GroupBox();
            this.ports_list = new System.Windows.Forms.ComboBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.restart_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CONTROL_BOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // digit1_lb
            // 
            this.digit1_lb.Font = new System.Drawing.Font("Times New Roman", 200F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit1_lb.ForeColor = System.Drawing.Color.White;
            this.digit1_lb.Location = new System.Drawing.Point(636, 148);
            this.digit1_lb.Name = "digit1_lb";
            this.digit1_lb.Size = new System.Drawing.Size(300, 461);
            this.digit1_lb.TabIndex = 2;
            this.digit1_lb.Text = "0";
            this.digit1_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // digit2_lb
            // 
            this.digit2_lb.Font = new System.Drawing.Font("Times New Roman", 200F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit2_lb.ForeColor = System.Drawing.Color.White;
            this.digit2_lb.Location = new System.Drawing.Point(400, 148);
            this.digit2_lb.Name = "digit2_lb";
            this.digit2_lb.Size = new System.Drawing.Size(300, 461);
            this.digit2_lb.TabIndex = 1;
            this.digit2_lb.Text = "0";
            this.digit2_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // CONTROL_BOX
            // 
            this.CONTROL_BOX.Controls.Add(this.ports_list);
            this.CONTROL_BOX.Controls.Add(this.connect_btn);
            this.CONTROL_BOX.Location = new System.Drawing.Point(2, 634);
            this.CONTROL_BOX.Name = "CONTROL_BOX";
            this.CONTROL_BOX.Size = new System.Drawing.Size(181, 49);
            this.CONTROL_BOX.TabIndex = 3;
            this.CONTROL_BOX.TabStop = false;
            this.CONTROL_BOX.Text = "Control";
            // 
            // ports_list
            // 
            this.ports_list.FormattingEnabled = true;
            this.ports_list.Location = new System.Drawing.Point(6, 16);
            this.ports_list.Name = "ports_list";
            this.ports_list.Size = new System.Drawing.Size(98, 21);
            this.ports_list.TabIndex = 1;
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(110, 16);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(63, 23);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // restart_btn
            // 
            this.restart_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.restart_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.restart_btn.FlatAppearance.BorderSize = 0;
            this.restart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart_btn.Location = new System.Drawing.Point(2, 689);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(63, 23);
            this.restart_btn.TabIndex = 2;
            this.restart_btn.Text = "Restart";
            this.restart_btn.UseVisualStyleBackColor = false;
            this.restart_btn.Click += new System.EventHandler(this.Restart_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.stop_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.stop_btn.FlatAppearance.BorderSize = 0;
            this.stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_btn.Location = new System.Drawing.Point(71, 689);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(63, 23);
            this.stop_btn.TabIndex = 4;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.restart_btn);
            this.Controls.Add(this.CONTROL_BOX);
            this.Controls.Add(this.digit1_lb);
            this.Controls.Add(this.digit2_lb);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CONTROL_BOX.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label digit1_lb;
        private System.Windows.Forms.Label digit2_lb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox CONTROL_BOX;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.ComboBox ports_list;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Button stop_btn;
    }
}

