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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOverview = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.btnBuildings = new System.Windows.Forms.Button();
            this.btnResources = new System.Windows.Forms.Button();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnDock = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.logout1 = new Quantum_World.Logout();
            this.map1 = new Quantum_World.Map();
            this.dock1 = new Quantum_World.Dock();
            this.overview1 = new Quantum_World.Overview();
            this.buildings1 = new Quantum_World.Buildings();
            this.research1 = new Quantum_World.Research();
            this.resources1 = new Quantum_World.Resources();
            this.lblCarbonFiber = new System.Windows.Forms.Label();
            this.lblQuantumGlass = new System.Windows.Forms.Label();
            this.lblHiggsBoson = new System.Windows.Forms.Label();
            this.lblSolarEnergy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOverview
            // 
            this.btnOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnOverview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOverview.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOverview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnOverview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Location = new System.Drawing.Point(12, 146);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(90, 45);
            this.btnOverview.TabIndex = 0;
            this.btnOverview.Text = "Overview";
            this.btnOverview.UseVisualStyleBackColor = false;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(353, 76);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(0, 17);
            this.lblHelloWorld.TabIndex = 1;
            // 
            // btnBuildings
            // 
            this.btnBuildings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnBuildings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuildings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuildings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnBuildings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnBuildings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuildings.Location = new System.Drawing.Point(12, 197);
            this.btnBuildings.Name = "btnBuildings";
            this.btnBuildings.Size = new System.Drawing.Size(90, 45);
            this.btnBuildings.TabIndex = 2;
            this.btnBuildings.Text = "Buildings";
            this.btnBuildings.UseVisualStyleBackColor = false;
            this.btnBuildings.Click += new System.EventHandler(this.btnBuildings_Click);
            // 
            // btnResources
            // 
            this.btnResources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnResources.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResources.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnResources.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResources.Location = new System.Drawing.Point(12, 248);
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(90, 45);
            this.btnResources.TabIndex = 3;
            this.btnResources.Text = "Resources";
            this.btnResources.UseVisualStyleBackColor = false;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // btnResearch
            // 
            this.btnResearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnResearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnResearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnResearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResearch.Location = new System.Drawing.Point(12, 299);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(90, 45);
            this.btnResearch.TabIndex = 4;
            this.btnResearch.Text = "Research";
            this.btnResearch.UseVisualStyleBackColor = false;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // btnDock
            // 
            this.btnDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnDock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnDock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnDock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDock.Location = new System.Drawing.Point(12, 350);
            this.btnDock.Name = "btnDock";
            this.btnDock.Size = new System.Drawing.Size(90, 45);
            this.btnDock.TabIndex = 5;
            this.btnDock.Text = "Dock";
            this.btnDock.UseVisualStyleBackColor = false;
            this.btnDock.Click += new System.EventHandler(this.btnDock_Click);
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnMap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMap.Location = new System.Drawing.Point(12, 401);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(90, 45);
            this.btnMap.TabIndex = 6;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(12, 452);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 45);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // logout1
            // 
            this.logout1.Location = new System.Drawing.Point(170, 12);
            this.logout1.Name = "logout1";
            this.logout1.Size = new System.Drawing.Size(653, 419);
            this.logout1.TabIndex = 10;
            // 
            // map1
            // 
            this.map1.Location = new System.Drawing.Point(161, 5);
            this.map1.Name = "map1";
            this.map1.Size = new System.Drawing.Size(662, 385);
            this.map1.TabIndex = 9;
            // 
            // dock1
            // 
            this.dock1.Location = new System.Drawing.Point(248, 5);
            this.dock1.Name = "dock1";
            this.dock1.Size = new System.Drawing.Size(445, 321);
            this.dock1.TabIndex = 8;
            // 
            // overview1
            // 
            this.overview1.Location = new System.Drawing.Point(243, 66);
            this.overview1.Name = "overview1";
            this.overview1.Size = new System.Drawing.Size(434, 325);
            this.overview1.TabIndex = 11;
            // 
            // buildings1
            // 
            this.buildings1.Location = new System.Drawing.Point(248, 26);
            this.buildings1.Name = "buildings1";
            this.buildings1.Size = new System.Drawing.Size(502, 364);
            this.buildings1.TabIndex = 12;
            // 
            // research1
            // 
            this.research1.Location = new System.Drawing.Point(161, 26);
            this.research1.Name = "research1";
            this.research1.Size = new System.Drawing.Size(840, 562);
            this.research1.TabIndex = 13;
            // 
            // resources1
            // 
            this.resources1.Location = new System.Drawing.Point(170, 66);
            this.resources1.Name = "resources1";
            this.resources1.Size = new System.Drawing.Size(831, 529);
            this.resources1.TabIndex = 14;
            // 
            // lblCarbonFiber
            // 
            this.lblCarbonFiber.AutoSize = true;
            this.lblCarbonFiber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCarbonFiber.Location = new System.Drawing.Point(187, 5);
            this.lblCarbonFiber.Name = "lblCarbonFiber";
            this.lblCarbonFiber.Size = new System.Drawing.Size(128, 21);
            this.lblCarbonFiber.TabIndex = 15;
            this.lblCarbonFiber.Text = "Carbon Fiber: 0";
            // 
            // lblQuantumGlass
            // 
            this.lblQuantumGlass.AutoSize = true;
            this.lblQuantumGlass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuantumGlass.Location = new System.Drawing.Point(375, 5);
            this.lblQuantumGlass.Name = "lblQuantumGlass";
            this.lblQuantumGlass.Size = new System.Drawing.Size(148, 21);
            this.lblQuantumGlass.TabIndex = 16;
            this.lblQuantumGlass.Text = "Quantum Glass: 0";
            // 
            // lblHiggsBoson
            // 
            this.lblHiggsBoson.AutoSize = true;
            this.lblHiggsBoson.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHiggsBoson.Location = new System.Drawing.Point(600, 5);
            this.lblHiggsBoson.Name = "lblHiggsBoson";
            this.lblHiggsBoson.Size = new System.Drawing.Size(118, 21);
            this.lblHiggsBoson.TabIndex = 17;
            this.lblHiggsBoson.Text = "Higgs Boson: 0";
            // 
            // lblSolarEnergy
            // 
            this.lblSolarEnergy.AutoSize = true;
            this.lblSolarEnergy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSolarEnergy.Location = new System.Drawing.Point(791, 5);
            this.lblSolarEnergy.Name = "lblSolarEnergy";
            this.lblSolarEnergy.Size = new System.Drawing.Size(121, 21);
            this.lblSolarEnergy.TabIndex = 18;
            this.lblSolarEnergy.Text = "Solar Energy: 0";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1063, 652);
            this.Controls.Add(this.lblSolarEnergy);
            this.Controls.Add(this.lblHiggsBoson);
            this.Controls.Add(this.lblQuantumGlass);
            this.Controls.Add(this.lblCarbonFiber);
            this.Controls.Add(this.resources1);
            this.Controls.Add(this.research1);
            this.Controls.Add(this.buildings1);
            this.Controls.Add(this.overview1);
            this.Controls.Add(this.logout1);
            this.Controls.Add(this.map1);
            this.Controls.Add(this.dock1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnDock);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.btnResources);
            this.Controls.Add(this.btnBuildings);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnOverview);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Dock dock1;
        private Map map1;
        private Logout logout1;
        private Overview overview1;
        private Buildings buildings1;
        private Research research1;
        private Resources resources1;
        private System.Windows.Forms.Label lblCarbonFiber;
        private System.Windows.Forms.Label lblQuantumGlass;
        private System.Windows.Forms.Label lblHiggsBoson;
        private System.Windows.Forms.Label lblSolarEnergy;
        
    }
}

