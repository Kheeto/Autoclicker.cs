namespace Autoclicker
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.MinLMB = new System.Windows.Forms.Label();
            this.MinLMBbar = new System.Windows.Forms.TrackBar();
            this.MinRMBbar = new System.Windows.Forms.TrackBar();
            this.MinRMB = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.leftEnabled = new System.Windows.Forms.CheckBox();
            this.rightEnabled = new System.Windows.Forms.CheckBox();
            this.LeftClicker = new System.Windows.Forms.Timer(this.components);
            this.RightClicker = new System.Windows.Forms.Timer(this.components);
            this.LeftRandom = new System.Windows.Forms.Timer(this.components);
            this.RightRandom = new System.Windows.Forms.Timer(this.components);
            this.MaxLMBbar = new System.Windows.Forms.TrackBar();
            this.MaxLMB = new System.Windows.Forms.Label();
            this.MaxRMBbar = new System.Windows.Forms.TrackBar();
            this.MaxRMB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinLMBbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRMBbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLMBbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRMBbar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 35F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autoclicker";
            // 
            // MinLMB
            // 
            this.MinLMB.Font = new System.Drawing.Font("Arial", 15F);
            this.MinLMB.ForeColor = System.Drawing.SystemColors.Control;
            this.MinLMB.Location = new System.Drawing.Point(8, 83);
            this.MinLMB.Name = "MinLMB";
            this.MinLMB.Size = new System.Drawing.Size(429, 59);
            this.MinLMB.TabIndex = 1;
            this.MinLMB.Text = "Minimum LMB CPS: 10";
            this.MinLMB.Click += new System.EventHandler(this.label2_Click);
            // 
            // MinLMBbar
            // 
            this.MinLMBbar.Location = new System.Drawing.Point(8, 112);
            this.MinLMBbar.Maximum = 50;
            this.MinLMBbar.Minimum = 1;
            this.MinLMBbar.Name = "MinLMBbar";
            this.MinLMBbar.Size = new System.Drawing.Size(398, 45);
            this.MinLMBbar.TabIndex = 2;
            this.MinLMBbar.Value = 10;
            this.MinLMBbar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // MinRMBbar
            // 
            this.MinRMBbar.Location = new System.Drawing.Point(434, 112);
            this.MinRMBbar.Maximum = 50;
            this.MinRMBbar.Minimum = 1;
            this.MinRMBbar.Name = "MinRMBbar";
            this.MinRMBbar.Size = new System.Drawing.Size(394, 45);
            this.MinRMBbar.TabIndex = 4;
            this.MinRMBbar.Value = 10;
            this.MinRMBbar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // MinRMB
            // 
            this.MinRMB.Font = new System.Drawing.Font("Arial", 15F);
            this.MinRMB.ForeColor = System.Drawing.SystemColors.Control;
            this.MinRMB.Location = new System.Drawing.Point(430, 83);
            this.MinRMB.Name = "MinRMB";
            this.MinRMB.Size = new System.Drawing.Size(429, 59);
            this.MinRMB.TabIndex = 3;
            this.MinRMB.Text = "Minimum RMB CPS: 10\r\n\r\n";
            // 
            // leftEnabled
            // 
            this.leftEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftEnabled.ForeColor = System.Drawing.SystemColors.Control;
            this.leftEnabled.Location = new System.Drawing.Point(12, 47);
            this.leftEnabled.Name = "leftEnabled";
            this.leftEnabled.Size = new System.Drawing.Size(183, 33);
            this.leftEnabled.TabIndex = 5;
            this.leftEnabled.Text = "LMB Enabled";
            this.leftEnabled.UseVisualStyleBackColor = true;
            this.leftEnabled.CheckedChanged += new System.EventHandler(this.leftEnabled_CheckedChanged);
            // 
            // rightEnabled
            // 
            this.rightEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightEnabled.ForeColor = System.Drawing.SystemColors.Control;
            this.rightEnabled.Location = new System.Drawing.Point(434, 47);
            this.rightEnabled.Name = "rightEnabled";
            this.rightEnabled.Size = new System.Drawing.Size(232, 33);
            this.rightEnabled.TabIndex = 6;
            this.rightEnabled.Text = "RMB Enabled";
            this.rightEnabled.UseVisualStyleBackColor = true;
            this.rightEnabled.CheckedChanged += new System.EventHandler(this.rightEnabled_CheckedChanged);
            // 
            // LeftClicker
            // 
            this.LeftClicker.Tick += new System.EventHandler(this.LeftClicker_Tick);
            // 
            // RightClicker
            // 
            this.RightClicker.Tick += new System.EventHandler(this.RightClicker_Tick);
            // 
            // LeftRandom
            // 
            this.LeftRandom.Tick += new System.EventHandler(this.LeftRandom_Tick);
            // 
            // RightRandom
            // 
            this.RightRandom.Tick += new System.EventHandler(this.RightRandom_Tick);
            // 
            // MaxLMBbar
            // 
            this.MaxLMBbar.Location = new System.Drawing.Point(12, 216);
            this.MaxLMBbar.Maximum = 50;
            this.MaxLMBbar.Minimum = 1;
            this.MaxLMBbar.Name = "MaxLMBbar";
            this.MaxLMBbar.Size = new System.Drawing.Size(394, 45);
            this.MaxLMBbar.TabIndex = 7;
            this.MaxLMBbar.Value = 12;
            this.MaxLMBbar.Scroll += new System.EventHandler(this.MaxLMBbar_Scroll);
            // 
            // MaxLMB
            // 
            this.MaxLMB.Font = new System.Drawing.Font("Arial", 15F);
            this.MaxLMB.ForeColor = System.Drawing.SystemColors.Control;
            this.MaxLMB.Location = new System.Drawing.Point(12, 182);
            this.MaxLMB.Name = "MaxLMB";
            this.MaxLMB.Size = new System.Drawing.Size(429, 59);
            this.MaxLMB.TabIndex = 8;
            this.MaxLMB.Text = "Maximum LMB CPS: 12\r\n";
            // 
            // MaxRMBbar
            // 
            this.MaxRMBbar.Location = new System.Drawing.Point(434, 216);
            this.MaxRMBbar.Maximum = 50;
            this.MaxRMBbar.Minimum = 1;
            this.MaxRMBbar.Name = "MaxRMBbar";
            this.MaxRMBbar.Size = new System.Drawing.Size(394, 45);
            this.MaxRMBbar.TabIndex = 10;
            this.MaxRMBbar.Value = 12;
            this.MaxRMBbar.Scroll += new System.EventHandler(this.MaxRMBbar_Scroll);
            // 
            // MaxRMB
            // 
            this.MaxRMB.Font = new System.Drawing.Font("Arial", 15F);
            this.MaxRMB.ForeColor = System.Drawing.SystemColors.Control;
            this.MaxRMB.Location = new System.Drawing.Point(430, 182);
            this.MaxRMB.Name = "MaxRMB";
            this.MaxRMB.Size = new System.Drawing.Size(429, 59);
            this.MaxRMB.TabIndex = 9;
            this.MaxRMB.Text = "Minimum RMB CPS: 12";
            this.MaxRMB.Click += new System.EventHandler(this.MaxRMB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.MaxRMBbar);
            this.Controls.Add(this.MaxRMB);
            this.Controls.Add(this.MaxLMBbar);
            this.Controls.Add(this.rightEnabled);
            this.Controls.Add(this.leftEnabled);
            this.Controls.Add(this.MinRMBbar);
            this.Controls.Add(this.MinRMB);
            this.Controls.Add(this.MinLMBbar);
            this.Controls.Add(this.MinLMB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxLMB);
            this.Name = "Form1";
            this.Text = "Autoclicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinLMBbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinRMBbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLMBbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRMBbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MinLMB;
        private System.Windows.Forms.TrackBar MinLMBbar;
        private System.Windows.Forms.TrackBar MinRMBbar;
        private System.Windows.Forms.Label MinRMB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox leftEnabled;
        private System.Windows.Forms.CheckBox rightEnabled;
        private System.Windows.Forms.Timer LeftClicker;
        private System.Windows.Forms.Timer RightClicker;
        private System.Windows.Forms.Timer LeftRandom;
        private System.Windows.Forms.Timer RightRandom;
        private System.Windows.Forms.TrackBar MaxLMBbar;
        private System.Windows.Forms.Label MaxLMB;
        private System.Windows.Forms.TrackBar MaxRMBbar;
        private System.Windows.Forms.Label MaxRMB;
    }
}

