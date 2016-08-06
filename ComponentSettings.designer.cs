namespace LiveSplit.LADX
{
    partial class LADXSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tail Cave (D1)");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Bottle Grotto (D2)");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Key Cavern (D3)");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Angler\'s Tunnel (D4)");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Catfish\'s Maw (D5)");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Face Shrine (D6)");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Eagle\'s Tower (D7)");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Turtle Rock (D8)");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Color Dungeon (D0)");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Dungeon Entrances", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Full Moon Cello (D1)");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Conch Horn (D2)");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Sea Lily\'s Bell (D3)");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Surf Harp (D4)");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Wind Marimba (D5)");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Coral Triangle (D6)");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Organ of Evening Calm (D7)");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Thunder Drum (D8)");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Tunic Upgrade (D0)");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Wind Fish\'s Egg (Final Split)");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Instruments (Dungeon Ends)", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Tail Key");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Bird Key");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Flippers");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Magnifying Lens");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("L1 Sword");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("L2 Sword");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Items", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Shoplifting");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Marin");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Rooster Photo");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Ballad of the Wind Fish (Song 1)");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Manbo\'s Mambo (Song 2)");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Frog\'s Song of Soul (Song 3)");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Others", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34});
            this.chkStartTimer = new System.Windows.Forms.CheckBox();
            this.chkSelectFile = new System.Windows.Forms.CheckBox();
            this.chkAutoReset = new System.Windows.Forms.CheckBox();
            this.chkICSTimings = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new LiveSplit.LADX.NewTreeView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkStartTimer
            // 
            this.chkStartTimer.AutoSize = true;
            this.chkStartTimer.Location = new System.Drawing.Point(6, 19);
            this.chkStartTimer.Name = "chkStartTimer";
            this.chkStartTimer.Size = new System.Drawing.Size(235, 17);
            this.chkStartTimer.TabIndex = 14;
            this.chkStartTimer.TabStop = false;
            this.chkStartTimer.Text = "Automatically start timer when selecting a file";
            this.chkStartTimer.UseVisualStyleBackColor = true;
            this.chkStartTimer.CheckedChanged += new System.EventHandler(this.checkStartTimer_CheckedChanged);
            // 
            // chkSelectFile
            // 
            this.chkSelectFile.AutoSize = true;
            this.chkSelectFile.Location = new System.Drawing.Point(6, 42);
            this.chkSelectFile.Name = "chkSelectFile";
            this.chkSelectFile.Size = new System.Drawing.Size(226, 17);
            this.chkSelectFile.TabIndex = 15;
            this.chkSelectFile.TabStop = false;
            this.chkSelectFile.Text = "Automatically select file when starting timer";
            this.chkSelectFile.UseVisualStyleBackColor = true;
            this.chkSelectFile.CheckedChanged += new System.EventHandler(this.checkSelectFile_CheckedChanged);
            // 
            // chkAutoReset
            // 
            this.chkAutoReset.AutoSize = true;
            this.chkAutoReset.Location = new System.Drawing.Point(6, 65);
            this.chkAutoReset.Name = "chkAutoReset";
            this.chkAutoReset.Size = new System.Drawing.Size(294, 17);
            this.chkAutoReset.TabIndex = 16;
            this.chkAutoReset.TabStop = false;
            this.chkAutoReset.Text = "Automatically reset timer after hard resetting the emulator ";
            this.chkAutoReset.UseVisualStyleBackColor = true;
            this.chkAutoReset.CheckedChanged += new System.EventHandler(this.checkAutoReset_CheckedChanged);
            // 
            // chkICSTimings
            // 
            this.chkICSTimings.AutoSize = true;
            this.chkICSTimings.Location = new System.Drawing.Point(6, 88);
            this.chkICSTimings.Name = "chkICSTimings";
            this.chkICSTimings.Size = new System.Drawing.Size(280, 17);
            this.chkICSTimings.TabIndex = 18;
            this.chkICSTimings.Text = "Use alternate ICS timings for instrument splits (LA only)";
            this.chkICSTimings.UseVisualStyleBackColor = true;
            this.chkICSTimings.CheckedChanged += new System.EventHandler(this.chkICSTimings_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkStartTimer);
            this.groupBox2.Controls.Add(this.chkSelectFile);
            this.groupBox2.Controls.Add(this.chkAutoReset);
            this.groupBox2.Controls.Add(this.chkICSTimings);
            this.groupBox2.Location = new System.Drawing.Point(10, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 111);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 364);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the splits you would like the autosplitter to split for:";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.treeView1.Location = new System.Drawing.Point(3, 16);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "node_ED1";
            treeNode1.Text = "Tail Cave (D1)";
            treeNode2.Name = "node_ED2";
            treeNode2.Text = "Bottle Grotto (D2)";
            treeNode3.Name = "node_ED3";
            treeNode3.Text = "Key Cavern (D3)";
            treeNode4.Name = "node_ED4";
            treeNode4.Text = "Angler\'s Tunnel (D4)";
            treeNode5.Name = "node_ED5";
            treeNode5.Text = "Catfish\'s Maw (D5)";
            treeNode6.Name = "node_ED6";
            treeNode6.Text = "Face Shrine (D6)";
            treeNode7.Name = "node_ED7";
            treeNode7.Text = "Eagle\'s Tower (D7)";
            treeNode8.Name = "node_ED8";
            treeNode8.Text = "Turtle Rock (D8)";
            treeNode9.Name = "node_ED0";
            treeNode9.Text = "Color Dungeon (D0)";
            treeNode10.Name = "Node0";
            treeNode10.Text = "Dungeon Entrances";
            treeNode11.Name = "node_D1";
            treeNode11.Text = "Full Moon Cello (D1)";
            treeNode12.Name = "node_D2";
            treeNode12.Text = "Conch Horn (D2)";
            treeNode13.Name = "node_D3";
            treeNode13.Text = "Sea Lily\'s Bell (D3)";
            treeNode14.Name = "node_D4";
            treeNode14.Text = "Surf Harp (D4)";
            treeNode15.Name = "node_D5";
            treeNode15.Text = "Wind Marimba (D5)";
            treeNode16.Name = "node_D6";
            treeNode16.Text = "Coral Triangle (D6)";
            treeNode17.Name = "node_D7";
            treeNode17.Text = "Organ of Evening Calm (D7)";
            treeNode18.Name = "node_D8";
            treeNode18.Text = "Thunder Drum (D8)";
            treeNode19.Name = "node_D0";
            treeNode19.Text = "Tunic Upgrade (D0)";
            treeNode20.Name = "node_Egg";
            treeNode20.Text = "Wind Fish\'s Egg (Final Split)";
            treeNode21.Name = "Node1";
            treeNode21.Text = "Instruments (Dungeon Ends)";
            treeNode22.Name = "node_TK";
            treeNode22.Text = "Tail Key";
            treeNode23.Name = "node_BK";
            treeNode23.Text = "Bird Key";
            treeNode24.Name = "node_Flippers";
            treeNode24.Text = "Flippers";
            treeNode25.Name = "node_ML";
            treeNode25.Text = "Magnifying Lens";
            treeNode26.Name = "node_L1S";
            treeNode26.Text = "L1 Sword";
            treeNode27.Name = "node_L2S";
            treeNode27.Text = "L2 Sword";
            treeNode28.Name = "Node2";
            treeNode28.Text = "Items";
            treeNode29.Name = "node_Shop";
            treeNode29.Text = "Shoplifting";
            treeNode30.Name = "node_Marin";
            treeNode30.Text = "Marin";
            treeNode31.Name = "node_RP";
            treeNode31.Text = "Rooster Photo";
            treeNode32.Name = "node_Song1";
            treeNode32.Text = "Ballad of the Wind Fish (Song 1)";
            treeNode33.Name = "node_Song2";
            treeNode33.Text = "Manbo\'s Mambo (Song 2)";
            treeNode34.Name = "node_Song3";
            treeNode34.Text = "Frog\'s Song of Soul (Song 3)";
            treeNode35.Name = "Node3";
            treeNode35.Text = "Others";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode21,
            treeNode28,
            treeNode35});
            this.treeView1.Size = new System.Drawing.Size(449, 345);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // LADXSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "LADXSettings";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(475, 501);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkStartTimer;
        private System.Windows.Forms.CheckBox chkSelectFile;
        private System.Windows.Forms.CheckBox chkAutoReset;
        private System.Windows.Forms.CheckBox chkICSTimings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private LiveSplit.LADX.NewTreeView treeView1;
    }
}
