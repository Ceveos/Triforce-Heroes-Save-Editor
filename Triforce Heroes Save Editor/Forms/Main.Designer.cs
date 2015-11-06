namespace Triforce_Heroes_Save_Editor.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.maxMaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxMaterialsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minMaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxRupeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxRupeesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minRupeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costumesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unlockAllCostumesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseAllCostumesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpurchaseAllCostumesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAllCostumesNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNewCostumeFlagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numRupees = new System.Windows.Forms.NumericUpDown();
            this.cbCostumes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKeyItems = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lvKeyItems = new System.Windows.Forms.ListView();
            this.keyItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbMaterial = new System.Windows.Forms.TabPage();
            this.dgMaterials = new System.Windows.Forms.DataGridView();
            this.Materials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCostumes = new System.Windows.Forms.TabPage();
            this.dgCostumes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostumeVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NewIconFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CostumePurchased = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.cbVoice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tsMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRupees)).BeginInit();
            this.tbKeyItems.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tbMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterials)).BeginInit();
            this.tbCostumes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCostumes)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton2});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(531, 27);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(46, 24);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxMaterialsToolStripMenuItem,
            this.maxRupeesToolStripMenuItem,
            this.costumesToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(78, 24);
            this.toolStripDropDownButton3.Text = "Fast Edit";
            // 
            // maxMaterialsToolStripMenuItem
            // 
            this.maxMaterialsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxMaterialsToolStripMenuItem1,
            this.minMaterialsToolStripMenuItem});
            this.maxMaterialsToolStripMenuItem.Name = "maxMaterialsToolStripMenuItem";
            this.maxMaterialsToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.maxMaterialsToolStripMenuItem.Text = "Materials";
            // 
            // maxMaterialsToolStripMenuItem1
            // 
            this.maxMaterialsToolStripMenuItem1.Name = "maxMaterialsToolStripMenuItem1";
            this.maxMaterialsToolStripMenuItem1.Size = new System.Drawing.Size(177, 26);
            this.maxMaterialsToolStripMenuItem1.Text = "Max Materials";
            this.maxMaterialsToolStripMenuItem1.Click += new System.EventHandler(this.maxMaterialsToolStripMenuItem1_Click);
            // 
            // minMaterialsToolStripMenuItem
            // 
            this.minMaterialsToolStripMenuItem.Name = "minMaterialsToolStripMenuItem";
            this.minMaterialsToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.minMaterialsToolStripMenuItem.Text = "Min Materials";
            this.minMaterialsToolStripMenuItem.Click += new System.EventHandler(this.minMaterialsToolStripMenuItem_Click);
            // 
            // maxRupeesToolStripMenuItem
            // 
            this.maxRupeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxRupeesToolStripMenuItem1,
            this.minRupeesToolStripMenuItem});
            this.maxRupeesToolStripMenuItem.Name = "maxRupeesToolStripMenuItem";
            this.maxRupeesToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.maxRupeesToolStripMenuItem.Text = "Rupees";
            // 
            // maxRupeesToolStripMenuItem1
            // 
            this.maxRupeesToolStripMenuItem1.Name = "maxRupeesToolStripMenuItem1";
            this.maxRupeesToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.maxRupeesToolStripMenuItem1.Text = "Max Rupees";
            this.maxRupeesToolStripMenuItem1.Click += new System.EventHandler(this.maxRupeesToolStripMenuItem1_Click);
            // 
            // minRupeesToolStripMenuItem
            // 
            this.minRupeesToolStripMenuItem.Name = "minRupeesToolStripMenuItem";
            this.minRupeesToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.minRupeesToolStripMenuItem.Text = "Min Rupees";
            this.minRupeesToolStripMenuItem.Click += new System.EventHandler(this.minRupeesToolStripMenuItem_Click);
            // 
            // costumesToolStripMenuItem
            // 
            this.costumesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unlockAllCostumesToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.newIconToolStripMenuItem});
            this.costumesToolStripMenuItem.Name = "costumesToolStripMenuItem";
            this.costumesToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.costumesToolStripMenuItem.Text = "Costumes";
            // 
            // unlockAllCostumesToolStripMenuItem
            // 
            this.unlockAllCostumesToolStripMenuItem.Name = "unlockAllCostumesToolStripMenuItem";
            this.unlockAllCostumesToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.unlockAllCostumesToolStripMenuItem.Text = "Unlock All Costumes (visibility)";
            this.unlockAllCostumesToolStripMenuItem.Click += new System.EventHandler(this.unlockAllCostumesToolStripMenuItem_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseAllCostumesToolStripMenuItem,
            this.unpurchaseAllCostumesToolStripMenuItem});
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // purchaseAllCostumesToolStripMenuItem
            // 
            this.purchaseAllCostumesToolStripMenuItem.Name = "purchaseAllCostumesToolStripMenuItem";
            this.purchaseAllCostumesToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.purchaseAllCostumesToolStripMenuItem.Text = "Purchase All Costumes";
            this.purchaseAllCostumesToolStripMenuItem.Click += new System.EventHandler(this.purchaseAllCostumesToolStripMenuItem_Click);
            // 
            // unpurchaseAllCostumesToolStripMenuItem
            // 
            this.unpurchaseAllCostumesToolStripMenuItem.Name = "unpurchaseAllCostumesToolStripMenuItem";
            this.unpurchaseAllCostumesToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.unpurchaseAllCostumesToolStripMenuItem.Text = "Unpurchase All Costumes";
            this.unpurchaseAllCostumesToolStripMenuItem.Click += new System.EventHandler(this.unpurchaseAllCostumesToolStripMenuItem_Click);
            // 
            // newIconToolStripMenuItem
            // 
            this.newIconToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeAllCostumesNewToolStripMenuItem,
            this.removeNewCostumeFlagsToolStripMenuItem});
            this.newIconToolStripMenuItem.Name = "newIconToolStripMenuItem";
            this.newIconToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.newIconToolStripMenuItem.Text = "New Icon";
            // 
            // makeAllCostumesNewToolStripMenuItem
            // 
            this.makeAllCostumesNewToolStripMenuItem.Name = "makeAllCostumesNewToolStripMenuItem";
            this.makeAllCostumesNewToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.makeAllCostumesNewToolStripMenuItem.Text = "Make All Costumes New";
            this.makeAllCostumesNewToolStripMenuItem.Click += new System.EventHandler(this.makeAllCostumesNewToolStripMenuItem_Click);
            // 
            // removeNewCostumeFlagsToolStripMenuItem
            // 
            this.removeNewCostumeFlagsToolStripMenuItem.Name = "removeNewCostumeFlagsToolStripMenuItem";
            this.removeNewCostumeFlagsToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.removeNewCostumeFlagsToolStripMenuItem.Text = "Make All Costumes Old";
            this.removeNewCostumeFlagsToolStripMenuItem.Click += new System.EventHandler(this.removeNewCostumeFlagsToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(55, 24);
            this.toolStripDropDownButton2.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tcMain
            // 
            this.tcMain.AllowDrop = true;
            this.tcMain.Controls.Add(this.tpGeneral);
            this.tcMain.Controls.Add(this.tbKeyItems);
            this.tcMain.Controls.Add(this.tbMaterial);
            this.tcMain.Controls.Add(this.tbCostumes);
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 27);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(531, 306);
            this.tcMain.TabIndex = 1;
            this.tcMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.tcMain_DragDrop);
            this.tcMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.tcMain_DragEnter);
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.tableLayoutPanel1);
            this.tpGeneral.Location = new System.Drawing.Point(4, 25);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(523, 277);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numRupees, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbCostumes, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbVoice, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 271);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character Name:";
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Location = new System.Drawing.Point(127, 3);
            this.tbName.MaxLength = 8;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(387, 22);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rupees:";
            // 
            // numRupees
            // 
            this.numRupees.Location = new System.Drawing.Point(127, 31);
            this.numRupees.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numRupees.Name = "numRupees";
            this.numRupees.Size = new System.Drawing.Size(195, 22);
            this.numRupees.TabIndex = 4;
            // 
            // cbCostumes
            // 
            this.cbCostumes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCostumes.FormattingEnabled = true;
            this.cbCostumes.Location = new System.Drawing.Point(127, 59);
            this.cbCostumes.Name = "cbCostumes";
            this.cbCostumes.Size = new System.Drawing.Size(195, 24);
            this.cbCostumes.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current Costume:";
            // 
            // tbKeyItems
            // 
            this.tbKeyItems.Controls.Add(this.tableLayoutPanel2);
            this.tbKeyItems.Location = new System.Drawing.Point(4, 25);
            this.tbKeyItems.Name = "tbKeyItems";
            this.tbKeyItems.Size = new System.Drawing.Size(523, 277);
            this.tbKeyItems.TabIndex = 2;
            this.tbKeyItems.Text = "Key Items";
            this.tbKeyItems.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lvKeyItems, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(523, 277);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(517, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "--- Warning ---\nChanging these values may break your game";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lvKeyItems
            // 
            this.lvKeyItems.CheckBoxes = true;
            this.lvKeyItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.keyItem});
            this.lvKeyItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKeyItems.FullRowSelect = true;
            this.lvKeyItems.GridLines = true;
            this.lvKeyItems.Location = new System.Drawing.Point(3, 53);
            this.lvKeyItems.Name = "lvKeyItems";
            this.lvKeyItems.Size = new System.Drawing.Size(517, 221);
            this.lvKeyItems.TabIndex = 1;
            this.lvKeyItems.UseCompatibleStateImageBehavior = false;
            this.lvKeyItems.View = System.Windows.Forms.View.Details;
            // 
            // keyItem
            // 
            this.keyItem.Text = "Key Item";
            this.keyItem.Width = 203;
            // 
            // tbMaterial
            // 
            this.tbMaterial.Controls.Add(this.dgMaterials);
            this.tbMaterial.Location = new System.Drawing.Point(4, 25);
            this.tbMaterial.Name = "tbMaterial";
            this.tbMaterial.Padding = new System.Windows.Forms.Padding(3);
            this.tbMaterial.Size = new System.Drawing.Size(523, 277);
            this.tbMaterial.TabIndex = 1;
            this.tbMaterial.Text = "Materials";
            this.tbMaterial.UseVisualStyleBackColor = true;
            // 
            // dgMaterials
            // 
            this.dgMaterials.AllowUserToAddRows = false;
            this.dgMaterials.AllowUserToDeleteRows = false;
            this.dgMaterials.AllowUserToOrderColumns = true;
            this.dgMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materials,
            this.Quantity});
            this.dgMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMaterials.Location = new System.Drawing.Point(3, 3);
            this.dgMaterials.Name = "dgMaterials";
            this.dgMaterials.RowTemplate.Height = 24;
            this.dgMaterials.Size = new System.Drawing.Size(517, 271);
            this.dgMaterials.TabIndex = 1;
            this.dgMaterials.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMaterials_CellEndEdit);
            this.dgMaterials.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgMaterials_CellValidating);
            // 
            // Materials
            // 
            this.Materials.DataPropertyName = "Material";
            this.Materials.HeaderText = "Materials";
            this.Materials.Name = "Materials";
            this.Materials.ReadOnly = true;
            this.Materials.Width = 94;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MaxInputLength = 2;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 90;
            // 
            // tbCostumes
            // 
            this.tbCostumes.Controls.Add(this.dgCostumes);
            this.tbCostumes.Location = new System.Drawing.Point(4, 25);
            this.tbCostumes.Name = "tbCostumes";
            this.tbCostumes.Size = new System.Drawing.Size(523, 277);
            this.tbCostumes.TabIndex = 3;
            this.tbCostumes.Text = "Costumes";
            this.tbCostumes.UseVisualStyleBackColor = true;
            // 
            // dgCostumes
            // 
            this.dgCostumes.AllowUserToAddRows = false;
            this.dgCostumes.AllowUserToDeleteRows = false;
            this.dgCostumes.AllowUserToOrderColumns = true;
            this.dgCostumes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgCostumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCostumes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.CostumeVisible,
            this.NewIconFlag,
            this.CostumePurchased});
            this.dgCostumes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCostumes.Location = new System.Drawing.Point(0, 0);
            this.dgCostumes.Name = "dgCostumes";
            this.dgCostumes.RowTemplate.Height = 24;
            this.dgCostumes.Size = new System.Drawing.Size(523, 277);
            this.dgCostumes.TabIndex = 2;
            this.dgCostumes.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgCostumes_CurrentCellDirtyStateChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Costume";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 92;
            // 
            // CostumeVisible
            // 
            this.CostumeVisible.DataPropertyName = "CostumeVisible";
            this.CostumeVisible.HeaderText = "Visible";
            this.CostumeVisible.Name = "CostumeVisible";
            this.CostumeVisible.Width = 55;
            // 
            // NewIconFlag
            // 
            this.NewIconFlag.DataPropertyName = "CostumeNewIcon";
            this.NewIconFlag.HeaderText = "New Icon Flag";
            this.NewIconFlag.Name = "NewIconFlag";
            this.NewIconFlag.Width = 102;
            // 
            // CostumePurchased
            // 
            this.CostumePurchased.DataPropertyName = "CostumePurchased";
            this.CostumePurchased.HeaderText = "Purchased";
            this.CostumePurchased.Name = "CostumePurchased";
            this.CostumePurchased.Width = 82;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(523, 277);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "World";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ofdOpen
            // 
            this.ofdOpen.Filter = "Save Data|SaveData.bin";
            // 
            // sfdSave
            // 
            this.sfdSave.Filter = "Save Data|SaveData.bin";
            // 
            // cbVoice
            // 
            this.cbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoice.FormattingEnabled = true;
            this.cbVoice.Location = new System.Drawing.Point(127, 89);
            this.cbVoice.Name = "cbVoice";
            this.cbVoice.Size = new System.Drawing.Size(195, 24);
            this.cbVoice.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current Voice:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 333);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.tsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triforce Heroes Save Editor (by Fafaffy)";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRupees)).EndInit();
            this.tbKeyItems.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tbMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterials)).EndInit();
            this.tbCostumes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCostumes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tbMaterial;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numRupees;
        private System.Windows.Forms.TabPage tbKeyItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem maxMaterialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxRupeesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgMaterials;
        private System.Windows.Forms.ListView lvKeyItems;
        private System.Windows.Forms.ColumnHeader keyItem;
        private System.Windows.Forms.ToolStripMenuItem maxMaterialsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minMaterialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxRupeesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minRupeesToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materials;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.TabPage tbCostumes;
        private System.Windows.Forms.ComboBox cbCostumes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgCostumes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CostumeVisible;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NewIconFlag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CostumePurchased;
        private System.Windows.Forms.ToolStripMenuItem costumesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unlockAllCostumesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseAllCostumesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpurchaseAllCostumesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAllCostumesNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNewCostumeFlagsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbVoice;
        private System.Windows.Forms.Label label5;
    }
}

