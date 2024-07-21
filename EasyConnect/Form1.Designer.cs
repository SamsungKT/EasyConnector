namespace EasyConnect
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioFull = new System.Windows.Forms.RadioButton();
            this.radio640 = new System.Windows.Forms.RadioButton();
            this.radio1280 = new System.Windows.Forms.RadioButton();
            this.radioCustom = new System.Windows.Forms.RadioButton();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.radioRemote = new System.Windows.Forms.RadioButton();
            this.radioLocal = new System.Windows.Forms.RadioButton();
            this.textIp = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.abel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.abel);
            this.groupBox1.Controls.Add(this.textHeight);
            this.groupBox1.Controls.Add(this.textWidth);
            this.groupBox1.Controls.Add(this.radioCustom);
            this.groupBox1.Controls.Add(this.radio1280);
            this.groupBox1.Controls.Add(this.radio640);
            this.groupBox1.Controls.Add(this.radioFull);
            this.groupBox1.Location = new System.Drawing.Point(69, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "스크린해상도";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textPort);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textIp);
            this.groupBox2.Controls.Add(this.radioLocal);
            this.groupBox2.Controls.Add(this.radioRemote);
            this.groupBox2.Location = new System.Drawing.Point(456, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "서버정보";
            // 
            // radioFull
            // 
            this.radioFull.AutoSize = true;
            this.radioFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFull.Location = new System.Drawing.Point(37, 33);
            this.radioFull.Name = "radioFull";
            this.radioFull.Size = new System.Drawing.Size(94, 29);
            this.radioFull.TabIndex = 0;
            this.radioFull.Text = "풀스크린";
            this.radioFull.UseVisualStyleBackColor = true;
            this.radioFull.Click += new System.EventHandler(this.radioFull_Click);
            // 
            // radio640
            // 
            this.radio640.AutoSize = true;
            this.radio640.Location = new System.Drawing.Point(37, 69);
            this.radio640.Name = "radio640";
            this.radio640.Size = new System.Drawing.Size(66, 17);
            this.radio640.TabIndex = 1;
            this.radio640.Text = "640x480";
            this.radio640.UseVisualStyleBackColor = true;
            this.radio640.Click += new System.EventHandler(this.radio640_Click);
            // 
            // radio1280
            // 
            this.radio1280.AutoSize = true;
            this.radio1280.Checked = true;
            this.radio1280.Location = new System.Drawing.Point(37, 106);
            this.radio1280.Name = "radio1280";
            this.radio1280.Size = new System.Drawing.Size(72, 17);
            this.radio1280.TabIndex = 2;
            this.radio1280.TabStop = true;
            this.radio1280.Text = "1280x630";
            this.radio1280.UseVisualStyleBackColor = true;
            this.radio1280.Click += new System.EventHandler(this.radio1280_Click);
            // 
            // radioCustom
            // 
            this.radioCustom.AutoSize = true;
            this.radioCustom.Location = new System.Drawing.Point(37, 152);
            this.radioCustom.Name = "radioCustom";
            this.radioCustom.Size = new System.Drawing.Size(60, 17);
            this.radioCustom.TabIndex = 3;
            this.radioCustom.Text = "Custom";
            this.radioCustom.UseVisualStyleBackColor = true;
            this.radioCustom.Click += new System.EventHandler(this.radioCustom_Click);
            // 
            // textWidth
            // 
            this.textWidth.Enabled = false;
            this.textWidth.Location = new System.Drawing.Point(58, 185);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(71, 20);
            this.textWidth.TabIndex = 4;
            this.textWidth.Text = "800";
            this.textWidth.TextChanged += new System.EventHandler(this.textWidth_TextChanged);
            // 
            // textHeight
            // 
            this.textHeight.Enabled = false;
            this.textHeight.Location = new System.Drawing.Point(58, 220);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(71, 20);
            this.textHeight.TabIndex = 5;
            this.textHeight.Text = "600";
            this.textHeight.TextChanged += new System.EventHandler(this.textHeight_TextChanged);
            // 
            // radioRemote
            // 
            this.radioRemote.AutoSize = true;
            this.radioRemote.Checked = true;
            this.radioRemote.Location = new System.Drawing.Point(48, 33);
            this.radioRemote.Name = "radioRemote";
            this.radioRemote.Size = new System.Drawing.Size(62, 17);
            this.radioRemote.TabIndex = 0;
            this.radioRemote.TabStop = true;
            this.radioRemote.Text = "Remote";
            this.radioRemote.UseVisualStyleBackColor = true;
            // 
            // radioLocal
            // 
            this.radioLocal.AutoSize = true;
            this.radioLocal.Location = new System.Drawing.Point(48, 89);
            this.radioLocal.Name = "radioLocal";
            this.radioLocal.Size = new System.Drawing.Size(51, 17);
            this.radioLocal.TabIndex = 1;
            this.radioLocal.Text = "Local";
            this.radioLocal.UseVisualStyleBackColor = true;
            // 
            // textIp
            // 
            this.textIp.Location = new System.Drawing.Point(58, 56);
            this.textIp.Name = "textIp";
            this.textIp.Size = new System.Drawing.Size(130, 20);
            this.textIp.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(58, 122);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "127.0.0.0.1";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(83, 203);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(82, 20);
            this.textPort.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "서버접속하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "홈페이지가기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // abel
            // 
            this.abel.AutoSize = true;
            this.abel.Location = new System.Drawing.Point(17, 188);
            this.abel.Name = "abel";
            this.abel.Size = new System.Drawing.Size(29, 13);
            this.abel.TabIndex = 6;
            this.abel.Text = "넓이";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "높이";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "EasyConnector 20240721";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCustom;
        private System.Windows.Forms.RadioButton radio1280;
        private System.Windows.Forms.RadioButton radio640;
        private System.Windows.Forms.RadioButton radioFull;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textIp;
        private System.Windows.Forms.RadioButton radioLocal;
        private System.Windows.Forms.RadioButton radioRemote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label abel;
    }
}

