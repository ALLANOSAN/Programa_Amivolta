namespace Cadastro_Amivolta
{
    partial class FormLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoading));
            this.Pgb_FormLoading = new System.Windows.Forms.ProgressBar();
            this.Lba_AMIVOLTA = new System.Windows.Forms.Label();
            this.Ptb_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Pgb_FormLoading
            // 
            this.Pgb_FormLoading.Location = new System.Drawing.Point(239, 260);
            this.Pgb_FormLoading.Name = "Pgb_FormLoading";
            this.Pgb_FormLoading.Size = new System.Drawing.Size(310, 23);
            this.Pgb_FormLoading.TabIndex = 0;
            // 
            // Lba_AMIVOLTA
            // 
            this.Lba_AMIVOLTA.AutoSize = true;
            this.Lba_AMIVOLTA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lba_AMIVOLTA.Location = new System.Drawing.Point(342, 186);
            this.Lba_AMIVOLTA.Name = "Lba_AMIVOLTA";
            this.Lba_AMIVOLTA.Size = new System.Drawing.Size(121, 30);
            this.Lba_AMIVOLTA.TabIndex = 1;
            this.Lba_AMIVOLTA.Text = "AMIVOLTA";
            // 
            // Ptb_Logo
            // 
            this.Ptb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Ptb_Logo.Image")));
            this.Ptb_Logo.Location = new System.Drawing.Point(141, 98);
            this.Ptb_Logo.Name = "Ptb_Logo";
            this.Ptb_Logo.Size = new System.Drawing.Size(569, 301);
            this.Ptb_Logo.TabIndex = 2;
            this.Ptb_Logo.TabStop = false;
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lba_AMIVOLTA);
            this.Controls.Add(this.Pgb_FormLoading);
            this.Controls.Add(this.Ptb_Logo);
            this.Name = "FormLoading";
            this.Text = "FormLoading";
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ProgressBar Pgb_FormLoading;
        public System.Windows.Forms.Label Lba_AMIVOLTA;
        public System.Windows.Forms.PictureBox Ptb_Logo;
    }
}