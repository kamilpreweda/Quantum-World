
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
            this.lblDock.Location = new System.Drawing.Point(300, 200);
            this.lblDock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDock.Name = "lblDock";
            this.lblDock.Size = new System.Drawing.Size(115, 17);
            this.lblDock.TabIndex = 0;
            this.lblDock.Text = "You are in Docks";
            this.lblDock.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblShip1
            // 
            this.lblShip1.AutoSize = true;
            this.lblShip1.Location = new System.Drawing.Point(208, 75);
            this.lblShip1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShip1.Name = "lblShip1";
            this.lblShip1.Size = new System.Drawing.Size(56, 17);
            this.lblShip1.TabIndex = 1;
            this.lblShip1.Text = "lblShip1";
            // 
            // lblShip3
            // 
            this.lblShip3.AutoSize = true;
            this.lblShip3.Location = new System.Drawing.Point(212, 266);
            this.lblShip3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShip3.Name = "lblShip3";
            this.lblShip3.Size = new System.Drawing.Size(56, 17);
            this.lblShip3.TabIndex = 2;
            this.lblShip3.Text = "lblShip3";
            // 
            // lblShip2
            // 
            this.lblShip2.AutoSize = true;
            this.lblShip2.Location = new System.Drawing.Point(494, 75);
            this.lblShip2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShip2.Name = "lblShip2";
            this.lblShip2.Size = new System.Drawing.Size(56, 17);
            this.lblShip2.TabIndex = 3;
            this.lblShip2.Text = "lblShip2";
            // 
            // lblShip4
            // 
            this.lblShip4.AutoSize = true;
            this.lblShip4.Location = new System.Drawing.Point(492, 264);
            this.lblShip4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShip4.Name = "lblShip4";
            this.lblShip4.Size = new System.Drawing.Size(56, 17);
            this.lblShip4.TabIndex = 4;
            this.lblShip4.Text = "lblShip4";
            // 
            // btnShip1
            // 
            this.btnShip1.Location = new System.Drawing.Point(167, 96);
            this.btnShip1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShip1.Name = "btnShip1";
            this.btnShip1.Size = new System.Drawing.Size(100, 72);
            this.btnShip1.TabIndex = 5;
            this.btnShip1.Text = "Build";
            this.btnShip1.UseVisualStyleBackColor = true;
            this.btnShip1.Click += new System.EventHandler(this.BtnShip1_Click);
            // 
            // btnShip2
            // 
            this.btnShip2.Location = new System.Drawing.Point(452, 96);
            this.btnShip2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShip2.Name = "btnShip2";
            this.btnShip2.Size = new System.Drawing.Size(100, 72);
            this.btnShip2.TabIndex = 6;
            this.btnShip2.Text = "Build";
            this.btnShip2.UseVisualStyleBackColor = true;
            this.btnShip2.Click += new System.EventHandler(this.BtnShip2_Click);
            // 
            // btnShip3
            // 
            this.btnShip3.Location = new System.Drawing.Point(167, 286);
            this.btnShip3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShip3.Name = "btnShip3";
            this.btnShip3.Size = new System.Drawing.Size(100, 71);
            this.btnShip3.TabIndex = 7;
            this.btnShip3.Text = "Build";
            this.btnShip3.UseVisualStyleBackColor = true;
            this.btnShip3.Click += new System.EventHandler(this.BtnShip3_Click);
            // 
            // btnShip4
            // 
            this.btnShip4.Location = new System.Drawing.Point(452, 285);
            this.btnShip4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShip4.Name = "btnShip4";
            this.btnShip4.Size = new System.Drawing.Size(100, 72);
            this.btnShip4.TabIndex = 8;
            this.btnShip4.Text = "Build";
            this.btnShip4.UseVisualStyleBackColor = true;
            this.btnShip4.Click += new System.EventHandler(this.BtnShip4_Click);
            // 
            // Dock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.btnShip4);
            this.Controls.Add(this.btnShip3);
            this.Controls.Add(this.btnShip2);
            this.Controls.Add(this.btnShip1);
            this.Controls.Add(this.lblShip4);
            this.Controls.Add(this.lblShip2);
            this.Controls.Add(this.lblShip3);
            this.Controls.Add(this.lblShip1);
            this.Controls.Add(this.lblDock);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(148, 36);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dock";
            this.Size = new System.Drawing.Size(760, 440);
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
