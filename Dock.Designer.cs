
namespace Quantum_World
{
    partial class Dock
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
            this.lblDock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDock
            // 
            this.lblDock.AutoSize = true;
            this.lblDock.Location = new System.Drawing.Point(144, 88);
            this.lblDock.Name = "lblDock";
            this.lblDock.Size = new System.Drawing.Size(89, 13);
            this.lblDock.TabIndex = 0;
            this.lblDock.Text = "You are in Docks";
            this.lblDock.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDock);
            this.Name = "Dock";
            this.Size = new System.Drawing.Size(445, 321);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDock;
    }
}
