namespace GlobalizationDemo
{
    partial class FrmLogin
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
            this.btnLaunch = new System.Windows.Forms.Button();
            this.rbtnFrench = new System.Windows.Forms.RadioButton();
            this.rbtnSpanish = new System.Windows.Forms.RadioButton();
            this.rbtnEnglish = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnTelugu = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(217, 104);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(75, 23);
            this.btnLaunch.TabIndex = 5;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // rbtnFrench
            // 
            this.rbtnFrench.AutoSize = true;
            this.rbtnFrench.Location = new System.Drawing.Point(203, 35);
            this.rbtnFrench.Name = "rbtnFrench";
            this.rbtnFrench.Size = new System.Drawing.Size(58, 17);
            this.rbtnFrench.TabIndex = 2;
            this.rbtnFrench.Tag = "fr-FR";
            this.rbtnFrench.Text = "French";
            this.rbtnFrench.UseVisualStyleBackColor = true;
            this.rbtnFrench.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnSpanish
            // 
            this.rbtnSpanish.AutoSize = true;
            this.rbtnSpanish.Location = new System.Drawing.Point(120, 35);
            this.rbtnSpanish.Name = "rbtnSpanish";
            this.rbtnSpanish.Size = new System.Drawing.Size(63, 17);
            this.rbtnSpanish.TabIndex = 3;
            this.rbtnSpanish.Tag = "es-ES";
            this.rbtnSpanish.Text = "Spanish";
            this.rbtnSpanish.UseVisualStyleBackColor = true;
            this.rbtnSpanish.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnEnglish
            // 
            this.rbtnEnglish.AutoSize = true;
            this.rbtnEnglish.Checked = true;
            this.rbtnEnglish.Location = new System.Drawing.Point(41, 35);
            this.rbtnEnglish.Name = "rbtnEnglish";
            this.rbtnEnglish.Size = new System.Drawing.Size(59, 17);
            this.rbtnEnglish.TabIndex = 4;
            this.rbtnEnglish.TabStop = true;
            this.rbtnEnglish.Tag = "en-EN";
            this.rbtnEnglish.Text = "English";
            this.rbtnEnglish.UseVisualStyleBackColor = true;
            this.rbtnEnglish.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // rbtnTelugu
            // 
            this.rbtnTelugu.AutoSize = true;
            this.rbtnTelugu.Location = new System.Drawing.Point(293, 35);
            this.rbtnTelugu.Name = "rbtnTelugu";
            this.rbtnTelugu.Size = new System.Drawing.Size(58, 17);
            this.rbtnTelugu.TabIndex = 8;
            this.rbtnTelugu.TabStop = true;
            this.rbtnTelugu.Tag = "te-IN";
            this.rbtnTelugu.Text = "Telugu";
            this.rbtnTelugu.UseVisualStyleBackColor = true;
            this.rbtnTelugu.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(92, 104);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 268);
            this.Controls.Add(this.rbtnTelugu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.rbtnFrench);
            this.Controls.Add(this.rbtnSpanish);
            this.Controls.Add(this.rbtnEnglish);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.RadioButton rbtnFrench;
        private System.Windows.Forms.RadioButton rbtnSpanish;
        private System.Windows.Forms.RadioButton rbtnEnglish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnTelugu;
        private System.Windows.Forms.Button btnApply;
    }
}

