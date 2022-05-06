
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
            this.lblShip1 = new System.Windows.Forms.Label();
            this.lblShip3 = new System.Windows.Forms.Label();
            this.lblShip2 = new System.Windows.Forms.Label();
            this.lblShip4 = new System.Windows.Forms.Label();
            this.btnShip1 = new System.Windows.Forms.Button();
            this.btnShip2 = new System.Windows.Forms.Button();
            this.btnShip3 = new System.Windows.Forms.Button();
            this.btnShip4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDock
            // 
            this.lblDock.AutoSize = true;
            this.lblDock.Location = new System.Drawing.Point(163, 161);
            this.lblDock.Name = "lblDock";
            this.lblDock.Size = new System.Drawing.Size(89, 13);
            this.lblDock.TabIndex = 0;
            this.lblDock.Text = "You are in Docks";
            this.lblDock.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblShip1
            // 
            this.lblShip1.AutoSize = true;
            this.lblShip1.Location = new System.Drawing.Point(94, 65);
            this.lblShip1.Name = "lblShip1";
            this.lblShip1.Size = new System.Drawing.Size(44, 13);
            this.lblShip1.TabIndex = 1;
            this.lblShip1.Text = "lblShip1";
            // 
            // lblShip3
            // 
            this.lblShip3.AutoSize = true;
            this.lblShip3.Location = new System.Drawing.Point(97, 211);
            this.lblShip3.Name = "lblShip3";
            this.lblShip3.Size = new System.Drawing.Size(44, 13);
            this.lblShip3.TabIndex = 2;
            this.lblShip3.Text = "lblShip3";
            // 
            // lblShip2
            // 
            this.lblShip2.AutoSize = true;
            this.lblShip2.Location = new System.Drawing.Point(308, 65);
            this.lblShip2.Name = "lblShip2";
            this.lblShip2.Size = new System.Drawing.Size(44, 13);
            this.lblShip2.TabIndex = 3;
            this.lblShip2.Text = "lblShip2";
            // 
            // lblShip4
            // 
            this.lblShip4.AutoSize = true;
            this.lblShip4.Location = new System.Drawing.Point(307, 210);
            this.lblShip4.Name = "lblShip4";
            this.lblShip4.Size = new System.Drawing.Size(44, 13);
            this.lblShip4.TabIndex = 4;
            this.lblShip4.Text = "lblShip4";
            // 
            // btnShip1
            // 
            this.btnShip1.Location = new System.Drawing.Point(63, 81);
            this.btnShip1.Name = "btnShip1";
            this.btnShip1.Size = new System.Drawing.Size(75, 55);
            this.btnShip1.TabIndex = 5;
            this.btnShip1.Text = "Build";
            this.btnShip1.UseVisualStyleBackColor = true;
            this.btnShip1.Click += new System.EventHandler(this.BtnShip1_Click);
            // 
            // btnShip2
            // 
            this.btnShip2.Location = new System.Drawing.Point(277, 81);
            this.btnShip2.Name = "btnShip2";
            this.btnShip2.Size = new System.Drawing.Size(75, 55);
            this.btnShip2.TabIndex = 6;
            this.btnShip2.Text = "Build";
            this.btnShip2.UseVisualStyleBackColor = true;
            this.btnShip2.Click += new System.EventHandler(this.BtnShip2_Click);
            // 
            // btnShip3
            // 
            this.btnShip3.Location = new System.Drawing.Point(63, 227);
            this.btnShip3.Name = "btnShip3";
            this.btnShip3.Size = new System.Drawing.Size(75, 54);
            this.btnShip3.TabIndex = 7;
            this.btnShip3.Text = "Build";
            this.btnShip3.UseVisualStyleBackColor = true;
            this.btnShip3.Click += new System.EventHandler(this.BtnShip3_Click);
            // 
            // btnShip4
            // 
            this.btnShip4.Location = new System.Drawing.Point(277, 226);
            this.btnShip4.Name = "btnShip4";
            this.btnShip4.Size = new System.Drawing.Size(75, 55);
            this.btnShip4.TabIndex = 8;
            this.btnShip4.Text = "Build";
            this.btnShip4.UseVisualStyleBackColor = true;
            this.btnShip4.Click += new System.EventHandler(this.BtnShip4_Click);
            // 
            // Dock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShip4);
            this.Controls.Add(this.btnShip3);
            this.Controls.Add(this.btnShip2);
            this.Controls.Add(this.btnShip1);
            this.Controls.Add(this.lblShip4);
            this.Controls.Add(this.lblShip2);
            this.Controls.Add(this.lblShip3);
            this.Controls.Add(this.lblShip1);
            this.Controls.Add(this.lblDock);
            this.Name = "Dock";
            this.Size = new System.Drawing.Size(420, 347);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDock;
        private System.Windows.Forms.Label lblShip1;
        private System.Windows.Forms.Label lblShip3;
        private System.Windows.Forms.Label lblShip2;
        private System.Windows.Forms.Label lblShip4;
        private System.Windows.Forms.Button btnShip1;
        private System.Windows.Forms.Button btnShip2;
        private System.Windows.Forms.Button btnShip3;
        private System.Windows.Forms.Button btnShip4;
    }
}
