
namespace DilaraDastanApp
{
    partial class FrmAyakkabiBul
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
            this.grpUrunArama = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpUrunArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUrunArama
            // 
            this.grpUrunArama.Controls.Add(this.btnAra);
            this.grpUrunArama.Controls.Add(this.txtBarkodNo);
            this.grpUrunArama.Controls.Add(this.label1);
            this.grpUrunArama.Location = new System.Drawing.Point(137, 94);
            this.grpUrunArama.Name = "grpUrunArama";
            this.grpUrunArama.Size = new System.Drawing.Size(387, 189);
            this.grpUrunArama.TabIndex = 0;
            this.grpUrunArama.TabStop = false;
            this.grpUrunArama.Text = "Ürün Arama Ekranı";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(143, 102);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(139, 66);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 20);
            this.txtBarkodNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod No Giriniz";
            // 
            // FrmAyakkabiBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpUrunArama);
            this.Name = "FrmAyakkabiBul";
            this.Text = "FrmAyakkabiBul";
            this.grpUrunArama.ResumeLayout(false);
            this.grpUrunArama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUrunArama;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBarkodNo;
    }
}