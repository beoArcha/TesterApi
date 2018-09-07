namespace TesterApi
{
    partial class ApiTestApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApiTestApp));
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.adressBox = new System.Windows.Forms.TextBox();
            this.adressLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.workingPanel = new System.Windows.Forms.Panel();
            this.groupBoxQuest = new System.Windows.Forms.GroupBox();
            this.radioButtonGetOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonGetInvoice = new System.Windows.Forms.RadioButton();
            this.timeListView = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.ordersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.getOrderNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.getOrderButton = new System.Windows.Forms.Button();
            this.portNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.testingButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.spaceRadioButton = new System.Windows.Forms.RadioButton();
            this.b2bRadioButton = new System.Windows.Forms.RadioButton();
            this.workingPanel.SuspendLayout();
            this.groupBoxQuest.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.typeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(71, 166);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(195, 20);
            this.loginBox.TabIndex = 8;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(71, 193);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(195, 20);
            this.passBox.TabIndex = 10;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(9, 174);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(36, 13);
            this.loginLabel.TabIndex = 7;
            this.loginLabel.Text = "Login:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(9, 200);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password:";
            // 
            // adressBox
            // 
            this.adressBox.Location = new System.Drawing.Point(71, 112);
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(195, 20);
            this.adressBox.TabIndex = 4;
            this.adressBox.Text = "http://localhost";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Location = new System.Drawing.Point(9, 119);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(48, 13);
            this.adressLabel.TabIndex = 3;
            this.adressLabel.Text = "Address:";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(9, 146);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 13);
            this.portLabel.TabIndex = 5;
            this.portLabel.Text = "Port:";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(71, 229);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // workingPanel
            // 
            this.workingPanel.Controls.Add(this.groupBoxQuest);
            this.workingPanel.Controls.Add(this.timeListView);
            this.workingPanel.Controls.Add(this.panel2);
            this.workingPanel.Location = new System.Drawing.Point(287, 12);
            this.workingPanel.Name = "workingPanel";
            this.workingPanel.Size = new System.Drawing.Size(531, 382);
            this.workingPanel.TabIndex = 9;
            this.workingPanel.Visible = false;
            // 
            // groupBoxQuest
            // 
            this.groupBoxQuest.Controls.Add(this.radioButtonGetOrder);
            this.groupBoxQuest.Controls.Add(this.radioButtonGetInvoice);
            this.groupBoxQuest.Location = new System.Drawing.Point(12, 3);
            this.groupBoxQuest.Name = "groupBoxQuest";
            this.groupBoxQuest.Size = new System.Drawing.Size(273, 36);
            this.groupBoxQuest.TabIndex = 6;
            this.groupBoxQuest.TabStop = false;
            this.groupBoxQuest.Visible = false;
            this.groupBoxQuest.RegionChanged += new System.EventHandler(this.groupBoxQuest_RegionChanged);
            // 
            // radioButtonGetOrder
            // 
            this.radioButtonGetOrder.AutoSize = true;
            this.radioButtonGetOrder.Checked = true;
            this.radioButtonGetOrder.Location = new System.Drawing.Point(11, 13);
            this.radioButtonGetOrder.Name = "radioButtonGetOrder";
            this.radioButtonGetOrder.Size = new System.Drawing.Size(69, 17);
            this.radioButtonGetOrder.TabIndex = 4;
            this.radioButtonGetOrder.TabStop = true;
            this.radioButtonGetOrder.Text = "Get order";
            this.radioButtonGetOrder.UseVisualStyleBackColor = true;
            // 
            // radioButtonGetInvoice
            // 
            this.radioButtonGetInvoice.AutoSize = true;
            this.radioButtonGetInvoice.Location = new System.Drawing.Point(102, 13);
            this.radioButtonGetInvoice.Name = "radioButtonGetInvoice";
            this.radioButtonGetInvoice.Size = new System.Drawing.Size(80, 17);
            this.radioButtonGetInvoice.TabIndex = 5;
            this.radioButtonGetInvoice.Text = "Get bills pdf";
            this.radioButtonGetInvoice.UseVisualStyleBackColor = true;
            // 
            // timeListView
            // 
            this.timeListView.Location = new System.Drawing.Point(12, 115);
            this.timeListView.Name = "timeListView";
            this.timeListView.Size = new System.Drawing.Size(515, 261);
            this.timeListView.TabIndex = 1;
            this.timeListView.UseCompatibleStateImageBehavior = false;
            this.timeListView.View = System.Windows.Forms.View.List;
            this.timeListView.SelectedIndexChanged += new System.EventHandler(this.timeListView_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userLabel);
            this.panel2.Controls.Add(this.ordersNumericUpDown);
            this.panel2.Controls.Add(this.getOrderNumericUpDown);
            this.panel2.Controls.Add(this.getOrderButton);
            this.panel2.Location = new System.Drawing.Point(12, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 72);
            this.panel2.TabIndex = 3;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(18, 44);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(29, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "User";
            // 
            // ordersNumericUpDown
            // 
            this.ordersNumericUpDown.Location = new System.Drawing.Point(84, 42);
            this.ordersNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ordersNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ordersNumericUpDown.Name = "ordersNumericUpDown";
            this.ordersNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.ordersNumericUpDown.TabIndex = 0;
            this.ordersNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // getOrderNumericUpDown
            // 
            this.getOrderNumericUpDown.Location = new System.Drawing.Point(84, 8);
            this.getOrderNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.getOrderNumericUpDown.Name = "getOrderNumericUpDown";
            this.getOrderNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.getOrderNumericUpDown.TabIndex = 1;
            this.getOrderNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // getOrderButton
            // 
            this.getOrderButton.Location = new System.Drawing.Point(3, 8);
            this.getOrderButton.Name = "getOrderButton";
            this.getOrderButton.Size = new System.Drawing.Size(75, 23);
            this.getOrderButton.TabIndex = 0;
            this.getOrderButton.Text = "Get order";
            this.getOrderButton.UseVisualStyleBackColor = true;
            this.getOrderButton.Click += new System.EventHandler(this.getOrderButton_Click);
            // 
            // portNumericUpDown
            // 
            this.portNumericUpDown.Location = new System.Drawing.Point(71, 138);
            this.portNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.portNumericUpDown.Name = "portNumericUpDown";
            this.portNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.portNumericUpDown.TabIndex = 6;
            this.portNumericUpDown.Value = new decimal(new int[] {
            881,
            0,
            0,
            0});
            // 
            // testingButton
            // 
            this.testingButton.Location = new System.Drawing.Point(153, 229);
            this.testingButton.Name = "testingButton";
            this.testingButton.Size = new System.Drawing.Size(113, 23);
            this.testingButton.TabIndex = 12;
            this.testingButton.Text = "Connection test";
            this.testingButton.UseVisualStyleBackColor = true;
            this.testingButton.Click += new System.EventHandler(this.testingButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.typeGroupBox);
            this.panel1.Controls.Add(this.testingButton);
            this.panel1.Controls.Add(this.loginBox);
            this.panel1.Controls.Add(this.portNumericUpDown);
            this.panel1.Controls.Add(this.passBox);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.portLabel);
            this.panel1.Controls.Add(this.adressBox);
            this.panel1.Controls.Add(this.adressLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 280);
            this.panel1.TabIndex = 12;
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.spaceRadioButton);
            this.typeGroupBox.Controls.Add(this.b2bRadioButton);
            this.typeGroupBox.Location = new System.Drawing.Point(12, 9);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(102, 82);
            this.typeGroupBox.TabIndex = 0;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "Wybór API";
            this.typeGroupBox.RegionChanged += new System.EventHandler(this.typeGroupBox_RegionChanged);
            // 
            // spaceRadioButton
            // 
            this.spaceRadioButton.AutoSize = true;
            this.spaceRadioButton.Location = new System.Drawing.Point(17, 42);
            this.spaceRadioButton.Name = "spaceRadioButton";
            this.spaceRadioButton.Size = new System.Drawing.Size(56, 17);
            this.spaceRadioButton.TabIndex = 2;
            this.spaceRadioButton.TabStop = true;
            this.spaceRadioButton.Text = "Space";
            this.spaceRadioButton.UseVisualStyleBackColor = true;
            this.spaceRadioButton.CheckedChanged += new System.EventHandler(this.typeGroupBox_RegionChanged);
            // 
            // b2bRadioButton
            // 
            this.b2bRadioButton.AutoSize = true;
            this.b2bRadioButton.Location = new System.Drawing.Point(17, 19);
            this.b2bRadioButton.Name = "b2bRadioButton";
            this.b2bRadioButton.Size = new System.Drawing.Size(45, 17);
            this.b2bRadioButton.TabIndex = 1;
            this.b2bRadioButton.TabStop = true;
            this.b2bRadioButton.Text = "B2B";
            this.b2bRadioButton.UseVisualStyleBackColor = true;
            this.b2bRadioButton.ClientSizeChanged += new System.EventHandler(this.typeGroupBox_RegionChanged);
            // 
            // ApiTestApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(240, 120);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(826, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.workingPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApiTestApp";
            this.Text = "API Tester";
            this.workingPanel.ResumeLayout(false);
            this.groupBoxQuest.ResumeLayout(false);
            this.groupBoxQuest.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox adressBox;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel workingPanel;
        private System.Windows.Forms.NumericUpDown getOrderNumericUpDown;
        private System.Windows.Forms.Button getOrderButton;
        private System.Windows.Forms.NumericUpDown portNumericUpDown;
        private System.Windows.Forms.Button testingButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox typeGroupBox;
        private System.Windows.Forms.RadioButton b2bRadioButton;
        private System.Windows.Forms.RadioButton spaceRadioButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.NumericUpDown ordersNumericUpDown;
        private System.Windows.Forms.ListView timeListView;
        private System.Windows.Forms.GroupBox groupBoxQuest;
        private System.Windows.Forms.RadioButton radioButtonGetOrder;
        private System.Windows.Forms.RadioButton radioButtonGetInvoice;
    }
}

