
namespace Quantum_World
{
    partial class Resources
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
            this.lblResources = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResources
            // 
            this.lblResources.AutoSize = true;
            this.lblResources.Location = new System.Drawing.Point(307, 194);
            this.lblResources.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResources.Name = "lblResources";
            this.lblResources.Size = new System.Drawing.Size(139, 17);
            this.lblResources.TabIndex = 0;
            this.lblResources.Text = "You are in Resources";
            // 
            // Resources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.lblResources);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(148, 36);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Resources";
            this.Size = new System.Drawing.Size(760, 440);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResources;
    }
}
