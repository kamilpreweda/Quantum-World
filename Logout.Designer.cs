
namespace Quantum_World
{
    partial class Logout
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Location = new System.Drawing.Point(282, 189);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(122, 17);
            this.lblLogout.TabIndex = 0;
            this.lblLogout.Text = "You Are in Logout";
            // 
            // Logout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.lblLogout);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(148, 36);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Logout";
            this.Size = new System.Drawing.Size(760, 440);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogout;
    }
}
