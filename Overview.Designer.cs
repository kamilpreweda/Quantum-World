
namespace Quantum_World
{
    partial class Overview
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
            this.lblOverview = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOverview
            // 
            this.lblOverview.AutoSize = true;
            this.lblOverview.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOverview.ForeColor = System.Drawing.Color.White;
            this.lblOverview.Location = new System.Drawing.Point(304, 208);
            this.lblOverview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(136, 17);
            this.lblOverview.TabIndex = 0;
            this.lblOverview.Text = "You are in overview";
            // 
            // Overview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.lblOverview);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(148, 36);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(760, 440);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOverview;
    }
}
