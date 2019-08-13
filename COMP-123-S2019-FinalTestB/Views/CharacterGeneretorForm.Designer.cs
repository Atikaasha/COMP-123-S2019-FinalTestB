namespace COMP_123_S2019_FinalTestB.Views
{
    partial class CharacterGeneretorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterGeneretorForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.IdentityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GenerateName = new System.Windows.Forms.Button();
            this.CharacterNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AbilityPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DexterityDataLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.StrengthDataLabel = new System.Windows.Forms.Label();
            this.ConstitutionDataLabel = new System.Windows.Forms.Label();
            this.IntelligenceDataLabel = new System.Windows.Forms.Label();
            this.WisdomDataLabel = new System.Windows.Forms.Label();
            this.CharismaDataLabel = new System.Windows.Forms.Label();
            this.GenerateAbilitiesButton = new System.Windows.Forms.Button();
            this.InventoryPage = new System.Windows.Forms.TabPage();
            this.CharactersheetPage = new System.Windows.Forms.TabPage();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.IdentityTableLayoutPanel.SuspendLayout();
            this.AbilityPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.CharactersheetPage.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(52, 449);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(121, 57);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(754, 449);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(121, 57);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.IdentityPage);
            this.MainTabControl.Controls.Add(this.AbilityPage);
            this.MainTabControl.Controls.Add(this.InventoryPage);
            this.MainTabControl.Controls.Add(this.CharactersheetPage);
            this.MainTabControl.Location = new System.Drawing.Point(12, 37);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(870, 372);
            this.MainTabControl.TabIndex = 5;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Controls.Add(this.IdentityTableLayoutPanel);
            this.IdentityPage.Location = new System.Drawing.Point(4, 41);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Padding = new System.Windows.Forms.Padding(3);
            this.IdentityPage.Size = new System.Drawing.Size(862, 327);
            this.IdentityPage.TabIndex = 0;
            this.IdentityPage.Text = "Identity";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // IdentityTableLayoutPanel
            // 
            this.IdentityTableLayoutPanel.ColumnCount = 4;
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.Controls.Add(this.GenerateName, 2, 4);
            this.IdentityTableLayoutPanel.Controls.Add(this.CharacterNameLabel, 0, 0);
            this.IdentityTableLayoutPanel.Controls.Add(this.FirstNameLabel, 0, 1);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastNameLabel, 0, 2);
            this.IdentityTableLayoutPanel.Controls.Add(this.label1, 1, 1);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastNameDataLabel, 1, 2);
            this.IdentityTableLayoutPanel.Controls.Add(this.textBox1, 1, 0);
            this.IdentityTableLayoutPanel.Location = new System.Drawing.Point(3, 0);
            this.IdentityTableLayoutPanel.Name = "IdentityTableLayoutPanel";
            this.IdentityTableLayoutPanel.RowCount = 5;
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.Size = new System.Drawing.Size(859, 321);
            this.IdentityTableLayoutPanel.TabIndex = 4;
            // 
            // GenerateName
            // 
            this.GenerateName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentityTableLayoutPanel.SetColumnSpan(this.GenerateName, 2);
            this.GenerateName.Location = new System.Drawing.Point(431, 259);
            this.GenerateName.Name = "GenerateName";
            this.GenerateName.Size = new System.Drawing.Size(425, 59);
            this.GenerateName.TabIndex = 4;
            this.GenerateName.Text = "Generate Name";
            this.GenerateName.UseVisualStyleBackColor = true;
            // 
            // CharacterNameLabel
            // 
            this.CharacterNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharacterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterNameLabel.Location = new System.Drawing.Point(3, 0);
            this.CharacterNameLabel.Name = "CharacterNameLabel";
            this.CharacterNameLabel.Size = new System.Drawing.Size(251, 64);
            this.CharacterNameLabel.TabIndex = 4;
            this.CharacterNameLabel.Text = "Character Name";
            this.CharacterNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(3, 64);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(251, 64);
            this.FirstNameLabel.TabIndex = 5;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(3, 128);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(251, 64);
            this.LastNameLabel.TabIndex = 6;
            this.LastNameLabel.Text = "LastName";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.label1, 3);
            this.label1.Location = new System.Drawing.Point(260, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 64);
            this.label1.TabIndex = 7;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.BackColor = System.Drawing.Color.LightGray;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.LastNameDataLabel, 3);
            this.LastNameDataLabel.Location = new System.Drawing.Point(260, 128);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(593, 64);
            this.LastNameDataLabel.TabIndex = 8;
            // 
            // textBox1
            // 
            this.IdentityTableLayoutPanel.SetColumnSpan(this.textBox1, 3);
            this.textBox1.Location = new System.Drawing.Point(260, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(596, 39);
            this.textBox1.TabIndex = 9;
            // 
            // AbilityPage
            // 
            this.AbilityPage.Controls.Add(this.tableLayoutPanel1);
            this.AbilityPage.Location = new System.Drawing.Point(4, 41);
            this.AbilityPage.Name = "AbilityPage";
            this.AbilityPage.Padding = new System.Windows.Forms.Padding(3);
            this.AbilityPage.Size = new System.Drawing.Size(862, 327);
            this.AbilityPage.TabIndex = 1;
            this.AbilityPage.Text = "Abilities";
            this.AbilityPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.DexterityDataLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.StrengthLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.StrengthDataLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ConstitutionDataLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.IntelligenceDataLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.WisdomDataLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.CharismaDataLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.GenerateAbilitiesButton, 2, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 315);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DexterityDataLabel
            // 
            this.DexterityDataLabel.BackColor = System.Drawing.Color.LightGray;
            this.DexterityDataLabel.Location = new System.Drawing.Point(215, 39);
            this.DexterityDataLabel.Name = "DexterityDataLabel";
            this.DexterityDataLabel.Size = new System.Drawing.Size(206, 39);
            this.DexterityDataLabel.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 39);
            this.label9.TabIndex = 8;
            this.label9.Text = "Constitution";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dexterity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.Location = new System.Drawing.Point(3, 0);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(206, 39);
            this.StrengthLabel.TabIndex = 0;
            this.StrengthLabel.Text = "Strength";
            this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Intelligence";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 39);
            this.label6.TabIndex = 5;
            this.label6.Text = "Wisdom";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 39);
            this.label10.TabIndex = 9;
            this.label10.Text = "Charisma";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StrengthDataLabel
            // 
            this.StrengthDataLabel.BackColor = System.Drawing.Color.LightGray;
            this.StrengthDataLabel.Location = new System.Drawing.Point(215, 0);
            this.StrengthDataLabel.Name = "StrengthDataLabel";
            this.StrengthDataLabel.Size = new System.Drawing.Size(206, 39);
            this.StrengthDataLabel.TabIndex = 10;
            // 
            // ConstitutionDataLabel
            // 
            this.ConstitutionDataLabel.BackColor = System.Drawing.Color.LightGray;
            this.ConstitutionDataLabel.Location = new System.Drawing.Point(215, 78);
            this.ConstitutionDataLabel.Name = "ConstitutionDataLabel";
            this.ConstitutionDataLabel.Size = new System.Drawing.Size(206, 39);
            this.ConstitutionDataLabel.TabIndex = 14;
            // 
            // IntelligenceDataLabel
            // 
            this.IntelligenceDataLabel.BackColor = System.Drawing.Color.LightGray;
            this.IntelligenceDataLabel.Location = new System.Drawing.Point(215, 117);
            this.IntelligenceDataLabel.Name = "IntelligenceDataLabel";
            this.IntelligenceDataLabel.Size = new System.Drawing.Size(206, 39);
            this.IntelligenceDataLabel.TabIndex = 11;
            // 
            // WisdomDataLabel
            // 
            this.WisdomDataLabel.BackColor = System.Drawing.Color.LightGray;
            this.WisdomDataLabel.Location = new System.Drawing.Point(215, 156);
            this.WisdomDataLabel.Name = "WisdomDataLabel";
            this.WisdomDataLabel.Size = new System.Drawing.Size(206, 39);
            this.WisdomDataLabel.TabIndex = 15;
            // 
            // CharismaDataLabel
            // 
            this.CharismaDataLabel.BackColor = System.Drawing.Color.LightGray;
            this.CharismaDataLabel.Location = new System.Drawing.Point(215, 195);
            this.CharismaDataLabel.Name = "CharismaDataLabel";
            this.CharismaDataLabel.Size = new System.Drawing.Size(206, 39);
            this.CharismaDataLabel.TabIndex = 12;
            // 
            // GenerateAbilitiesButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.GenerateAbilitiesButton, 2);
            this.GenerateAbilitiesButton.Location = new System.Drawing.Point(427, 276);
            this.GenerateAbilitiesButton.Name = "GenerateAbilitiesButton";
            this.GenerateAbilitiesButton.Size = new System.Drawing.Size(420, 36);
            this.GenerateAbilitiesButton.TabIndex = 16;
            this.GenerateAbilitiesButton.Text = "Generate Abilities";
            this.GenerateAbilitiesButton.UseVisualStyleBackColor = true;
            // 
            // InventoryPage
            // 
            this.InventoryPage.Location = new System.Drawing.Point(4, 41);
            this.InventoryPage.Name = "InventoryPage";
            this.InventoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryPage.Size = new System.Drawing.Size(862, 327);
            this.InventoryPage.TabIndex = 2;
            this.InventoryPage.Text = "Inventory";
            this.InventoryPage.UseVisualStyleBackColor = true;
            // 
            // CharactersheetPage
            // 
            this.CharactersheetPage.Controls.Add(this.MainToolStrip);
            this.CharactersheetPage.Controls.Add(this.MainMenuStrip);
            this.CharactersheetPage.Location = new System.Drawing.Point(4, 41);
            this.CharactersheetPage.Name = "CharactersheetPage";
            this.CharactersheetPage.Padding = new System.Windows.Forms.Padding(3);
            this.CharactersheetPage.Size = new System.Drawing.Size(862, 327);
            this.CharactersheetPage.TabIndex = 3;
            this.CharactersheetPage.Text = "Character Sheet";
            this.CharactersheetPage.UseVisualStyleBackColor = true;
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator7,
            this.helpToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(3, 36);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(856, 31);
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(856, 33);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(202, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(164, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // CharacterGeneretorForm
            // 
            this.ClientSize = new System.Drawing.Size(894, 544);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Name = "CharacterGeneretorForm";
            this.Text = "Character Generetor";
            this.Load += new System.EventHandler(this.CharacterGeneretorForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.IdentityPage.ResumeLayout(false);
            this.IdentityTableLayoutPanel.ResumeLayout(false);
            this.IdentityTableLayoutPanel.PerformLayout();
            this.AbilityPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.CharactersheetPage.ResumeLayout(false);
            this.CharactersheetPage.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.TabPage AbilityPage;
        private System.Windows.Forms.TabPage InventoryPage;
        private System.Windows.Forms.TabPage CharactersheetPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel IdentityTableLayoutPanel;
        private System.Windows.Forms.Button GenerateName;
        private System.Windows.Forms.Label CharacterNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DexterityDataLabel;
        private System.Windows.Forms.Label StrengthDataLabel;
        private System.Windows.Forms.Label ConstitutionDataLabel;
        private System.Windows.Forms.Label IntelligenceDataLabel;
        private System.Windows.Forms.Label WisdomDataLabel;
        private System.Windows.Forms.Label CharismaDataLabel;
        private System.Windows.Forms.Button GenerateAbilitiesButton;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
