namespace Quantum_World
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOverview = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.btnBuildings = new System.Windows.Forms.Button();
            this.btnResources = new System.Windows.Forms.Button();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnDock = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOverview
            // 
            this.btnOverview.Location = new System.Drawing.Point(2, 66);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(75, 23);
            this.btnOverview.TabIndex = 0;
            this.btnOverview.Text = "Overview";
            this.btnOverview.UseVisualStyleBackColor = true;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(353, 76);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(0, 13);
            this.lblHelloWorld.TabIndex = 1;
            // 
            // btnBuildings
            // 
            this.btnBuildings.Location = new System.Drawing.Point(2, 95);
            this.btnBuildings.Name = "btnBuildings";
            this.btnBuildings.Size = new System.Drawing.Size(75, 23);
            this.btnBuildings.TabIndex = 2;
            this.btnBuildings.Text = "Buildings";
            this.btnBuildings.UseVisualStyleBackColor = true;
            this.btnBuildings.Click += new System.EventHandler(this.btnBuildings_Click);
            // 
            // btnResources
            // 
            this.btnResources.Location = new System.Drawing.Point(2, 124);
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(75, 23);
            this.btnResources.TabIndex = 3;
            this.btnResources.Text = "Resources";
            this.btnResources.UseVisualStyleBackColor = true;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // btnResearch
            // 
            this.btnResearch.Location = new System.Drawing.Point(2, 153);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(75, 23);
            this.btnResearch.TabIndex = 4;
            this.btnResearch.Text = "Research";
            this.btnResearch.UseVisualStyleBackColor = true;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // btnDock
            // 
            this.btnDock.Location = new System.Drawing.Point(2, 182);
            this.btnDock.Name = "btnDock";
            this.btnDock.Size = new System.Drawing.Size(75, 23);
            this.btnDock.TabIndex = 5;
            this.btnDock.Text = "Dock";
            this.btnDock.UseVisualStyleBackColor = true;
            this.btnDock.Click += new System.EventHandler(this.btnDock_Click);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(2, 211);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(75, 23);
            this.btnMap.TabIndex = 6;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(2, 240);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnDock);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.btnResources);
            this.Controls.Add(this.btnBuildings);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnOverview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.Button btnBuildings;
        private System.Windows.Forms.Button btnResources;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Button btnDock;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnLogout;
    }
}

