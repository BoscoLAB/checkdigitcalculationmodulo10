
namespace Berechnung_Prüfziffer
{
    partial class Prüfziffer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxohneZiffer = new System.Windows.Forms.TextBox();
            this.textBoxmitZiffer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode ohne Prüfziffer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barcode mit Prüfziffer";
            // 
            // textBoxohneZiffer
            // 
            this.textBoxohneZiffer.Location = new System.Drawing.Point(136, 46);
            this.textBoxohneZiffer.Name = "textBoxohneZiffer";
            this.textBoxohneZiffer.Size = new System.Drawing.Size(139, 20);
            this.textBoxohneZiffer.TabIndex = 2;
            this.textBoxohneZiffer.Enter += new System.EventHandler(this.button1_Click);
            // 
            // textBoxmitZiffer
            // 
            this.textBoxmitZiffer.Location = new System.Drawing.Point(136, 80);
            this.textBoxmitZiffer.Name = "textBoxmitZiffer";
            this.textBoxmitZiffer.Size = new System.Drawing.Size(139, 20);
            this.textBoxmitZiffer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prüfzifferberechnung nach Modulo 10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Berechnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Prüfziffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 158);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxmitZiffer);
            this.Controls.Add(this.textBoxohneZiffer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Prüfziffer";
            this.Text = "Prüfziffer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxohneZiffer;
        private System.Windows.Forms.TextBox textBoxmitZiffer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

