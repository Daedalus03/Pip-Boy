
namespace Pip_Boy_V2._0
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.STAT = new System.Windows.Forms.TabPage();
            this.subTabControlSTAT = new System.Windows.Forms.TabControl();
            this.Status = new System.Windows.Forms.TabPage();
            this.Statusgif = new System.Windows.Forms.PictureBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DeviceInfo = new System.Windows.Forms.TabPage();
            this.DeviceInfoText = new System.Windows.Forms.RichTextBox();
            this.PersonalData = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Manual = new System.Windows.Forms.TabPage();
            this.ManualText = new System.Windows.Forms.RichTextBox();
            this.DATA = new System.Windows.Forms.TabPage();
            this.subTabControlDATA = new System.Windows.Forms.TabControl();
            this.Terminal = new System.Windows.Forms.TabPage();
            this.Terminalinputcosmetic = new System.Windows.Forms.TextBox();
            this.TerminalinputEnter = new System.Windows.Forms.Button();
            this.Terminalinput = new System.Windows.Forms.TextBox();
            this.Terminaloutput = new System.Windows.Forms.RichTextBox();
            this.Inventory = new System.Windows.Forms.TabPage();
            this.DeleteAllButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.InventoryInput = new System.Windows.Forms.TextBox();
            this.DownButton = new System.Windows.Forms.Button();
            this.AddSelectedButton = new System.Windows.Forms.Button();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.InventoryList = new System.Windows.Forms.ListBox();
            this.RADIO = new System.Windows.Forms.TabPage();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SoundwaveGif = new System.Windows.Forms.PictureBox();
            this.Songlist = new System.Windows.Forms.ListBox();
            this.mainTabControl.SuspendLayout();
            this.STAT.SuspendLayout();
            this.subTabControlSTAT.SuspendLayout();
            this.Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Statusgif)).BeginInit();
            this.DeviceInfo.SuspendLayout();
            this.PersonalData.SuspendLayout();
            this.Manual.SuspendLayout();
            this.DATA.SuspendLayout();
            this.subTabControlDATA.SuspendLayout();
            this.Terminal.SuspendLayout();
            this.Inventory.SuspendLayout();
            this.RADIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundwaveGif)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.STAT);
            this.mainTabControl.Controls.Add(this.DATA);
            this.mainTabControl.Controls.Add(this.RADIO);
            this.mainTabControl.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(464, 261);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.TabStop = false;
            // 
            // STAT
            // 
            this.STAT.BackColor = System.Drawing.Color.Black;
            this.STAT.Controls.Add(this.subTabControlSTAT);
            this.STAT.Cursor = System.Windows.Forms.Cursors.Cross;
            this.STAT.ForeColor = System.Drawing.Color.Black;
            this.STAT.Location = new System.Drawing.Point(4, 22);
            this.STAT.Name = "STAT";
            this.STAT.Padding = new System.Windows.Forms.Padding(3);
            this.STAT.Size = new System.Drawing.Size(456, 235);
            this.STAT.TabIndex = 0;
            this.STAT.Text = "STAT";
            // 
            // subTabControlSTAT
            // 
            this.subTabControlSTAT.Controls.Add(this.Status);
            this.subTabControlSTAT.Controls.Add(this.DeviceInfo);
            this.subTabControlSTAT.Controls.Add(this.PersonalData);
            this.subTabControlSTAT.Controls.Add(this.Manual);
            this.subTabControlSTAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subTabControlSTAT.Location = new System.Drawing.Point(3, 3);
            this.subTabControlSTAT.Name = "subTabControlSTAT";
            this.subTabControlSTAT.SelectedIndex = 0;
            this.subTabControlSTAT.Size = new System.Drawing.Size(450, 229);
            this.subTabControlSTAT.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.subTabControlSTAT.TabIndex = 2;
            this.subTabControlSTAT.TabStop = false;
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Black;
            this.Status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Status.Controls.Add(this.Statusgif);
            this.Status.Controls.Add(this.Date);
            this.Status.Controls.Add(this.Time);
            this.Status.Controls.Add(this.textBox3);
            this.Status.ForeColor = System.Drawing.Color.Black;
            this.Status.Location = new System.Drawing.Point(4, 22);
            this.Status.Name = "Status";
            this.Status.Padding = new System.Windows.Forms.Padding(3);
            this.Status.Size = new System.Drawing.Size(442, 203);
            this.Status.TabIndex = 0;
            this.Status.Text = "Status";
            // 
            // Statusgif
            // 
            this.Statusgif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Statusgif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Statusgif.ErrorImage = null;
            this.Statusgif.Image = ((System.Drawing.Image)(resources.GetObject("Statusgif.Image")));
            this.Statusgif.InitialImage = null;
            this.Statusgif.Location = new System.Drawing.Point(0, 6);
            this.Statusgif.Name = "Statusgif";
            this.Statusgif.Size = new System.Drawing.Size(440, 170);
            this.Statusgif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Statusgif.TabIndex = 9;
            this.Statusgif.TabStop = false;
            // 
            // Date
            // 
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Date.BackColor = System.Drawing.Color.Green;
            this.Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Date.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.Chartreuse;
            this.Date.Location = new System.Drawing.Point(6, 177);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(75, 20);
            this.Date.TabIndex = 8;
            this.Date.TabStop = false;
            this.Date.Text = "10.23.2287";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Time
            // 
            this.Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Time.BackColor = System.Drawing.Color.Green;
            this.Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Time.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.Chartreuse;
            this.Time.Location = new System.Drawing.Point(87, 177);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(75, 20);
            this.Time.TabIndex = 7;
            this.Time.TabStop = false;
            this.Time.Text = "18:02";
            this.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.Green;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(168, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(268, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TabStop = false;
            // 
            // DeviceInfo
            // 
            this.DeviceInfo.BackColor = System.Drawing.Color.Black;
            this.DeviceInfo.Controls.Add(this.DeviceInfoText);
            this.DeviceInfo.Location = new System.Drawing.Point(4, 22);
            this.DeviceInfo.Name = "DeviceInfo";
            this.DeviceInfo.Padding = new System.Windows.Forms.Padding(3);
            this.DeviceInfo.Size = new System.Drawing.Size(442, 203);
            this.DeviceInfo.TabIndex = 1;
            this.DeviceInfo.Text = "Device Info";
            // 
            // DeviceInfoText
            // 
            this.DeviceInfoText.BackColor = System.Drawing.Color.Green;
            this.DeviceInfoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeviceInfoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceInfoText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceInfoText.ForeColor = System.Drawing.Color.Chartreuse;
            this.DeviceInfoText.Location = new System.Drawing.Point(3, 3);
            this.DeviceInfoText.Name = "DeviceInfoText";
            this.DeviceInfoText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.DeviceInfoText.Size = new System.Drawing.Size(436, 197);
            this.DeviceInfoText.TabIndex = 0;
            this.DeviceInfoText.Text = "\nPIP-OS(R) V7.1.0.8\n\nCOPYRIGHT 2075 DAEDALUS CORP. (R)\nLOADER V1.1\nEXEC VERSION 4" +
    "1.10\n64k RAM SYSTEM\n38911 BYTES FREE\nNO HOLOTAPE FOUND\nLOAD ROM(1): DEITRIX 303";
            // 
            // PersonalData
            // 
            this.PersonalData.BackColor = System.Drawing.Color.Black;
            this.PersonalData.Controls.Add(this.richTextBox1);
            this.PersonalData.Location = new System.Drawing.Point(4, 22);
            this.PersonalData.Name = "PersonalData";
            this.PersonalData.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalData.Size = new System.Drawing.Size(442, 203);
            this.PersonalData.TabIndex = 2;
            this.PersonalData.Text = "Personal Data";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Green;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Chartreuse;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(436, 197);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "\nOWNER:\n\n...\n...\n...\n...\n";
            // 
            // Manual
            // 
            this.Manual.BackColor = System.Drawing.Color.Black;
            this.Manual.Controls.Add(this.ManualText);
            this.Manual.Location = new System.Drawing.Point(4, 22);
            this.Manual.Name = "Manual";
            this.Manual.Padding = new System.Windows.Forms.Padding(3);
            this.Manual.Size = new System.Drawing.Size(442, 203);
            this.Manual.TabIndex = 3;
            this.Manual.Text = "Manual";
            // 
            // ManualText
            // 
            this.ManualText.BackColor = System.Drawing.Color.Green;
            this.ManualText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManualText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManualText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualText.ForeColor = System.Drawing.Color.Chartreuse;
            this.ManualText.Location = new System.Drawing.Point(3, 3);
            this.ManualText.Name = "ManualText";
            this.ManualText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ManualText.Size = new System.Drawing.Size(436, 197);
            this.ManualText.TabIndex = 0;
            this.ManualText.Text = resources.GetString("ManualText.Text");
            // 
            // DATA
            // 
            this.DATA.BackColor = System.Drawing.Color.Black;
            this.DATA.Controls.Add(this.subTabControlDATA);
            this.DATA.Location = new System.Drawing.Point(4, 22);
            this.DATA.Name = "DATA";
            this.DATA.Padding = new System.Windows.Forms.Padding(3);
            this.DATA.Size = new System.Drawing.Size(456, 235);
            this.DATA.TabIndex = 1;
            this.DATA.Text = "DATA";
            // 
            // subTabControlDATA
            // 
            this.subTabControlDATA.Controls.Add(this.Terminal);
            this.subTabControlDATA.Controls.Add(this.Inventory);
            this.subTabControlDATA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subTabControlDATA.Location = new System.Drawing.Point(3, 3);
            this.subTabControlDATA.Name = "subTabControlDATA";
            this.subTabControlDATA.SelectedIndex = 0;
            this.subTabControlDATA.Size = new System.Drawing.Size(450, 229);
            this.subTabControlDATA.TabIndex = 0;
            this.subTabControlDATA.TabStop = false;
            // 
            // Terminal
            // 
            this.Terminal.BackColor = System.Drawing.Color.Black;
            this.Terminal.Controls.Add(this.Terminalinputcosmetic);
            this.Terminal.Controls.Add(this.TerminalinputEnter);
            this.Terminal.Controls.Add(this.Terminalinput);
            this.Terminal.Controls.Add(this.Terminaloutput);
            this.Terminal.Location = new System.Drawing.Point(4, 22);
            this.Terminal.Name = "Terminal";
            this.Terminal.Padding = new System.Windows.Forms.Padding(3);
            this.Terminal.Size = new System.Drawing.Size(442, 203);
            this.Terminal.TabIndex = 0;
            this.Terminal.Text = "Terminal";
            // 
            // Terminalinputcosmetic
            // 
            this.Terminalinputcosmetic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Terminalinputcosmetic.BackColor = System.Drawing.Color.Black;
            this.Terminalinputcosmetic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Terminalinputcosmetic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terminalinputcosmetic.ForeColor = System.Drawing.Color.Chartreuse;
            this.Terminalinputcosmetic.Location = new System.Drawing.Point(3, 173);
            this.Terminalinputcosmetic.Name = "Terminalinputcosmetic";
            this.Terminalinputcosmetic.Size = new System.Drawing.Size(35, 19);
            this.Terminalinputcosmetic.TabIndex = 11;
            this.Terminalinputcosmetic.TabStop = false;
            this.Terminalinputcosmetic.Text = "   >_";
            // 
            // TerminalinputEnter
            // 
            this.TerminalinputEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TerminalinputEnter.BackColor = System.Drawing.Color.Green;
            this.TerminalinputEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TerminalinputEnter.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminalinputEnter.ForeColor = System.Drawing.Color.Chartreuse;
            this.TerminalinputEnter.Location = new System.Drawing.Point(386, 169);
            this.TerminalinputEnter.Name = "TerminalinputEnter";
            this.TerminalinputEnter.Size = new System.Drawing.Size(50, 28);
            this.TerminalinputEnter.TabIndex = 10;
            this.TerminalinputEnter.Text = "ENTER";
            this.TerminalinputEnter.UseVisualStyleBackColor = false;
            this.TerminalinputEnter.Click += new System.EventHandler(this.TerminalinputEnter_Click);
            // 
            // Terminalinput
            // 
            this.Terminalinput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Terminalinput.BackColor = System.Drawing.Color.Green;
            this.Terminalinput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Terminalinput.Font = new System.Drawing.Font("Arial", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terminalinput.ForeColor = System.Drawing.Color.Chartreuse;
            this.Terminalinput.Location = new System.Drawing.Point(44, 173);
            this.Terminalinput.Name = "Terminalinput";
            this.Terminalinput.Size = new System.Drawing.Size(336, 20);
            this.Terminalinput.TabIndex = 9;
            this.Terminalinput.Text = "Enter Text here";
            this.Terminalinput.TextChanged += new System.EventHandler(this.Terminalinput_TextChanged);
            this.Terminalinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Terminalinput_KeyPress);
            // 
            // Terminaloutput
            // 
            this.Terminaloutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Terminaloutput.BackColor = System.Drawing.Color.Black;
            this.Terminaloutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Terminaloutput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terminaloutput.ForeColor = System.Drawing.Color.Chartreuse;
            this.Terminaloutput.Location = new System.Drawing.Point(6, 6);
            this.Terminaloutput.Name = "Terminaloutput";
            this.Terminaloutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.Terminaloutput.Size = new System.Drawing.Size(430, 161);
            this.Terminaloutput.TabIndex = 7;
            this.Terminaloutput.TabStop = false;
            this.Terminaloutput.Text = "Willkommen bei Termlink von ROBCO Industries (TM)";
            // 
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.Color.Black;
            this.Inventory.Controls.Add(this.DeleteAllButton);
            this.Inventory.Controls.Add(this.AddNewButton);
            this.Inventory.Controls.Add(this.InventoryInput);
            this.Inventory.Controls.Add(this.DownButton);
            this.Inventory.Controls.Add(this.AddSelectedButton);
            this.Inventory.Controls.Add(this.DeleteSelectedButton);
            this.Inventory.Controls.Add(this.UpButton);
            this.Inventory.Controls.Add(this.InventoryList);
            this.Inventory.Location = new System.Drawing.Point(4, 22);
            this.Inventory.Name = "Inventory";
            this.Inventory.Padding = new System.Windows.Forms.Padding(3);
            this.Inventory.Size = new System.Drawing.Size(442, 203);
            this.Inventory.TabIndex = 1;
            this.Inventory.Text = "Inventory";
            // 
            // DeleteAllButton
            // 
            this.DeleteAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteAllButton.BackColor = System.Drawing.Color.Green;
            this.DeleteAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAllButton.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAllButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.DeleteAllButton.Location = new System.Drawing.Point(336, 68);
            this.DeleteAllButton.Name = "DeleteAllButton";
            this.DeleteAllButton.Size = new System.Drawing.Size(100, 20);
            this.DeleteAllButton.TabIndex = 5;
            this.DeleteAllButton.Text = "DELETE All";
            this.DeleteAllButton.UseVisualStyleBackColor = false;
            this.DeleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewButton.BackColor = System.Drawing.Color.Green;
            this.AddNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewButton.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.AddNewButton.Location = new System.Drawing.Point(336, 146);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(100, 20);
            this.AddNewButton.TabIndex = 8;
            this.AddNewButton.Text = "ADD New";
            this.AddNewButton.UseVisualStyleBackColor = false;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // InventoryInput
            // 
            this.InventoryInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InventoryInput.BackColor = System.Drawing.Color.Green;
            this.InventoryInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InventoryInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InventoryInput.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryInput.ForeColor = System.Drawing.Color.Chartreuse;
            this.InventoryInput.Location = new System.Drawing.Point(6, 175);
            this.InventoryInput.Name = "InventoryInput";
            this.InventoryInput.Size = new System.Drawing.Size(430, 22);
            this.InventoryInput.TabIndex = 2;
            this.InventoryInput.Text = "new item";
            this.InventoryInput.TextChanged += new System.EventHandler(this.InventoryInput_TextChanged);
            this.InventoryInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InventoryInput_KeyPress);
            // 
            // DownButton
            // 
            this.DownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownButton.BackColor = System.Drawing.Color.Green;
            this.DownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownButton.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.DownButton.Location = new System.Drawing.Point(336, 32);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(100, 20);
            this.DownButton.TabIndex = 4;
            this.DownButton.Text = "DOWN";
            this.DownButton.UseVisualStyleBackColor = false;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // AddSelectedButton
            // 
            this.AddSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSelectedButton.BackColor = System.Drawing.Color.Green;
            this.AddSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSelectedButton.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSelectedButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.AddSelectedButton.Location = new System.Drawing.Point(336, 120);
            this.AddSelectedButton.Name = "AddSelectedButton";
            this.AddSelectedButton.Size = new System.Drawing.Size(100, 20);
            this.AddSelectedButton.TabIndex = 7;
            this.AddSelectedButton.Text = "ADD Selected";
            this.AddSelectedButton.UseVisualStyleBackColor = false;
            this.AddSelectedButton.Click += new System.EventHandler(this.AddSelectedButton_Click);
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSelectedButton.BackColor = System.Drawing.Color.Green;
            this.DeleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedButton.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.DeleteSelectedButton.Location = new System.Drawing.Point(336, 94);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(100, 20);
            this.DeleteSelectedButton.TabIndex = 6;
            this.DeleteSelectedButton.Text = "DELETE Selected";
            this.DeleteSelectedButton.UseVisualStyleBackColor = false;
            this.DeleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpButton.BackColor = System.Drawing.Color.Green;
            this.UpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpButton.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.UpButton.Location = new System.Drawing.Point(336, 6);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(100, 20);
            this.UpButton.TabIndex = 3;
            this.UpButton.Text = "UP";
            this.UpButton.UseVisualStyleBackColor = false;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // InventoryList
            // 
            this.InventoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InventoryList.BackColor = System.Drawing.Color.Green;
            this.InventoryList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InventoryList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryList.ForeColor = System.Drawing.Color.Chartreuse;
            this.InventoryList.FormattingEnabled = true;
            this.InventoryList.ItemHeight = 14;
            this.InventoryList.Location = new System.Drawing.Point(6, 6);
            this.InventoryList.Name = "InventoryList";
            this.InventoryList.Size = new System.Drawing.Size(318, 156);
            this.InventoryList.TabIndex = 1;
            this.InventoryList.SelectedValueChanged += new System.EventHandler(this.SelectedTextChange);
            // 
            // RADIO
            // 
            this.RADIO.BackColor = System.Drawing.Color.Black;
            this.RADIO.Controls.Add(this.PreviousButton);
            this.RADIO.Controls.Add(this.PlayPauseButton);
            this.RADIO.Controls.Add(this.StopButton);
            this.RADIO.Controls.Add(this.NextButton);
            this.RADIO.Controls.Add(this.SoundwaveGif);
            this.RADIO.Controls.Add(this.Songlist);
            this.RADIO.Location = new System.Drawing.Point(4, 22);
            this.RADIO.Name = "RADIO";
            this.RADIO.Padding = new System.Windows.Forms.Padding(3);
            this.RADIO.Size = new System.Drawing.Size(456, 235);
            this.RADIO.TabIndex = 2;
            this.RADIO.Text = "RADIO";
            // 
            // PreviousButton
            // 
            this.PreviousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviousButton.BackColor = System.Drawing.Color.Green;
            this.PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.PreviousButton.Location = new System.Drawing.Point(230, 177);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(50, 50);
            this.PreviousButton.TabIndex = 15;
            this.PreviousButton.Text = "button1";
            this.PreviousButton.UseVisualStyleBackColor = false;
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayPauseButton.BackColor = System.Drawing.Color.Green;
            this.PlayPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayPauseButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.PlayPauseButton.Location = new System.Drawing.Point(286, 177);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(50, 50);
            this.PlayPauseButton.TabIndex = 14;
            this.PlayPauseButton.Text = "button2";
            this.PlayPauseButton.UseVisualStyleBackColor = false;
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StopButton.BackColor = System.Drawing.Color.Green;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.StopButton.Location = new System.Drawing.Point(342, 177);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(50, 50);
            this.StopButton.TabIndex = 13;
            this.StopButton.Text = "button3";
            this.StopButton.UseVisualStyleBackColor = false;
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.BackColor = System.Drawing.Color.Green;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.ForeColor = System.Drawing.Color.Chartreuse;
            this.NextButton.Location = new System.Drawing.Point(398, 177);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(50, 50);
            this.NextButton.TabIndex = 12;
            this.NextButton.Text = "button4";
            this.NextButton.UseVisualStyleBackColor = false;
            // 
            // SoundwaveGif
            // 
            this.SoundwaveGif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SoundwaveGif.BackColor = System.Drawing.Color.Green;
            this.SoundwaveGif.Image = ((System.Drawing.Image)(resources.GetObject("SoundwaveGif.Image")));
            this.SoundwaveGif.Location = new System.Drawing.Point(230, 6);
            this.SoundwaveGif.Name = "SoundwaveGif";
            this.SoundwaveGif.Size = new System.Drawing.Size(220, 114);
            this.SoundwaveGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SoundwaveGif.TabIndex = 11;
            this.SoundwaveGif.TabStop = false;
            // 
            // Songlist
            // 
            this.Songlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Songlist.BackColor = System.Drawing.Color.Green;
            this.Songlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Songlist.ForeColor = System.Drawing.Color.Chartreuse;
            this.Songlist.FormattingEnabled = true;
            this.Songlist.Location = new System.Drawing.Point(8, 6);
            this.Songlist.Name = "Songlist";
            this.Songlist.Size = new System.Drawing.Size(213, 223);
            this.Songlist.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.mainTabControl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PIP-OS V7.1.0.8";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainTabControl.ResumeLayout(false);
            this.STAT.ResumeLayout(false);
            this.subTabControlSTAT.ResumeLayout(false);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Statusgif)).EndInit();
            this.DeviceInfo.ResumeLayout(false);
            this.PersonalData.ResumeLayout(false);
            this.Manual.ResumeLayout(false);
            this.DATA.ResumeLayout(false);
            this.subTabControlDATA.ResumeLayout(false);
            this.Terminal.ResumeLayout(false);
            this.Terminal.PerformLayout();
            this.Inventory.ResumeLayout(false);
            this.Inventory.PerformLayout();
            this.RADIO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SoundwaveGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage STAT;
        private System.Windows.Forms.TabPage DATA;
        private System.Windows.Forms.TabPage RADIO;
        private System.Windows.Forms.TabControl subTabControlSTAT;
        private System.Windows.Forms.TabPage Status;
        private System.Windows.Forms.PictureBox Statusgif;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabPage DeviceInfo;
        private System.Windows.Forms.TabPage PersonalData;
        private System.Windows.Forms.TabPage Manual;
        private System.Windows.Forms.TabControl subTabControlDATA;
        private System.Windows.Forms.TabPage Terminal;
        private System.Windows.Forms.Button TerminalinputEnter;
        private System.Windows.Forms.TextBox Terminalinput;
        private System.Windows.Forms.RichTextBox Terminaloutput;
        private System.Windows.Forms.TabPage Inventory;
        private System.Windows.Forms.TextBox Terminalinputcosmetic;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button PlayPauseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.PictureBox SoundwaveGif;
        private System.Windows.Forms.ListBox Songlist;
        private System.Windows.Forms.TextBox InventoryInput;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button AddSelectedButton;
        private System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.ListBox InventoryList;
        private System.Windows.Forms.RichTextBox ManualText;
        private System.Windows.Forms.RichTextBox DeviceInfoText;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button DeleteAllButton;
    }
}

