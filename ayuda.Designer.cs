namespace SistemaFarmacia
{
    partial class ayuda
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
            this.bup = new System.Windows.Forms.Button();
            this.texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bup
            // 
            this.bup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bup.Location = new System.Drawing.Point(503, 331);
            this.bup.Name = "bup";
            this.bup.Size = new System.Drawing.Size(85, 37);
            this.bup.TabIndex = 3;
            this.bup.Text = "Ayuda";
            this.bup.UseVisualStyleBackColor = false;
            // 
            // texto
            // 
            this.texto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.texto.Enabled = false;
            this.texto.ForeColor = System.Drawing.Color.Black;
            this.texto.Location = new System.Drawing.Point(72, 33);
            this.texto.Multiline = true;
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(536, 287);
            this.texto.TabIndex = 2;
            this.texto.Text = " Se le otorgara ayuda";
            // 
            // ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(658, 390);
            this.Controls.Add(this.bup);
            this.Controls.Add(this.texto);
            this.Name = "ayuda";
            this.Text = "ayuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bup;
        private System.Windows.Forms.TextBox texto;
    }
}