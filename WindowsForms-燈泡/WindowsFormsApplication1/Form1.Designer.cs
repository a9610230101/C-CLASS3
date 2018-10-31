namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.nolight = new System.Windows.Forms.PictureBox();
            this.light = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nolight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light)).BeginInit();
            this.SuspendLayout();
            // 
            // nolight
            // 
            this.nolight.Image = global::WindowsFormsApplication1.Properties.Resources._2;
            this.nolight.Location = new System.Drawing.Point(301, 38);
            this.nolight.Name = "nolight";
            this.nolight.Size = new System.Drawing.Size(149, 207);
            this.nolight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nolight.TabIndex = 1;
            this.nolight.TabStop = false;
            this.nolight.Click += new System.EventHandler(this.nolight_Click);
            // 
            // light
            // 
            this.light.Image = global::WindowsFormsApplication1.Properties.Resources.light;
            this.light.Location = new System.Drawing.Point(74, 38);
            this.light.Name = "light";
            this.light.Size = new System.Drawing.Size(130, 207);
            this.light.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.light.TabIndex = 0;
            this.light.TabStop = false;
            this.light.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(117, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 56);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "開燈";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "關燈";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 475);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nolight);
            this.Controls.Add(this.light);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nolight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox light;
        private System.Windows.Forms.PictureBox nolight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

