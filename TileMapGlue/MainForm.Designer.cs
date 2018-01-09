namespace TileMapGlue
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.glueProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.glueButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.destinationTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.sourceTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.yMaximumTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.yMinimumTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.xMaximumTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.xMinimumTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tileResolutionXTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tileResolutionYTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.threadTimer = new System.Windows.Forms.Timer(this.components);
            this.spacingXTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.spacingYTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mainPanel.Controls.Add(this.spacingYTextField);
            this.mainPanel.Controls.Add(this.spacingXTextField);
            this.mainPanel.Controls.Add(this.tileResolutionYTextField);
            this.mainPanel.Controls.Add(this.tileResolutionXTextField);
            this.mainPanel.Controls.Add(this.glueProgressBar);
            this.mainPanel.Controls.Add(this.glueButton);
            this.mainPanel.Controls.Add(this.destinationTextField);
            this.mainPanel.Controls.Add(this.sourceTextField);
            this.mainPanel.Controls.Add(this.yMaximumTextField);
            this.mainPanel.Controls.Add(this.yMinimumTextField);
            this.mainPanel.Controls.Add(this.xMaximumTextField);
            this.mainPanel.Controls.Add(this.xMinimumTextField);
            this.mainPanel.Location = new System.Drawing.Point(12, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(376, 343);
            this.mainPanel.TabIndex = 0;
            // 
            // glueProgressBar
            // 
            this.glueProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glueProgressBar.Depth = 0;
            this.glueProgressBar.Location = new System.Drawing.Point(3, 335);
            this.glueProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.glueProgressBar.Name = "glueProgressBar";
            this.glueProgressBar.Size = new System.Drawing.Size(370, 5);
            this.glueProgressBar.Step = 1;
            this.glueProgressBar.TabIndex = 11;
            this.glueProgressBar.Visible = false;
            // 
            // glueButton
            // 
            this.glueButton.AutoSize = true;
            this.glueButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.glueButton.Depth = 0;
            this.glueButton.Icon = null;
            this.glueButton.Location = new System.Drawing.Point(3, 293);
            this.glueButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.glueButton.Name = "glueButton";
            this.glueButton.Primary = true;
            this.glueButton.Size = new System.Drawing.Size(54, 36);
            this.glueButton.TabIndex = 10;
            this.glueButton.Text = "Glue";
            this.glueButton.UseVisualStyleBackColor = true;
            this.glueButton.Click += new System.EventHandler(this.glueButton_Click);
            // 
            // destinationTextField
            // 
            this.destinationTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationTextField.Depth = 0;
            this.destinationTextField.Hint = "Destination...";
            this.destinationTextField.Location = new System.Drawing.Point(3, 206);
            this.destinationTextField.MaxLength = 32767;
            this.destinationTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.destinationTextField.Name = "destinationTextField";
            this.destinationTextField.PasswordChar = '\0';
            this.destinationTextField.SelectedText = "";
            this.destinationTextField.SelectionLength = 0;
            this.destinationTextField.SelectionStart = 0;
            this.destinationTextField.Size = new System.Drawing.Size(370, 23);
            this.destinationTextField.TabIndex = 7;
            this.destinationTextField.TabStop = false;
            this.destinationTextField.UseSystemPasswordChar = false;
            // 
            // sourceTextField
            // 
            this.sourceTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceTextField.Depth = 0;
            this.sourceTextField.Hint = "Source...";
            this.sourceTextField.Location = new System.Drawing.Point(3, 177);
            this.sourceTextField.MaxLength = 32767;
            this.sourceTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.sourceTextField.Name = "sourceTextField";
            this.sourceTextField.PasswordChar = '\0';
            this.sourceTextField.SelectedText = "";
            this.sourceTextField.SelectionLength = 0;
            this.sourceTextField.SelectionStart = 0;
            this.sourceTextField.Size = new System.Drawing.Size(370, 23);
            this.sourceTextField.TabIndex = 6;
            this.sourceTextField.TabStop = false;
            this.sourceTextField.UseSystemPasswordChar = false;
            // 
            // yMaximumTextField
            // 
            this.yMaximumTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yMaximumTextField.Depth = 0;
            this.yMaximumTextField.Hint = "Y maximum...";
            this.yMaximumTextField.Location = new System.Drawing.Point(3, 90);
            this.yMaximumTextField.MaxLength = 32767;
            this.yMaximumTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.yMaximumTextField.Name = "yMaximumTextField";
            this.yMaximumTextField.PasswordChar = '\0';
            this.yMaximumTextField.SelectedText = "";
            this.yMaximumTextField.SelectionLength = 0;
            this.yMaximumTextField.SelectionStart = 0;
            this.yMaximumTextField.Size = new System.Drawing.Size(370, 23);
            this.yMaximumTextField.TabIndex = 3;
            this.yMaximumTextField.TabStop = false;
            this.yMaximumTextField.UseSystemPasswordChar = false;
            // 
            // yMinimumTextField
            // 
            this.yMinimumTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yMinimumTextField.Depth = 0;
            this.yMinimumTextField.Hint = "Y minimum...";
            this.yMinimumTextField.Location = new System.Drawing.Point(3, 61);
            this.yMinimumTextField.MaxLength = 32767;
            this.yMinimumTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.yMinimumTextField.Name = "yMinimumTextField";
            this.yMinimumTextField.PasswordChar = '\0';
            this.yMinimumTextField.SelectedText = "";
            this.yMinimumTextField.SelectionLength = 0;
            this.yMinimumTextField.SelectionStart = 0;
            this.yMinimumTextField.Size = new System.Drawing.Size(370, 23);
            this.yMinimumTextField.TabIndex = 2;
            this.yMinimumTextField.TabStop = false;
            this.yMinimumTextField.UseSystemPasswordChar = false;
            // 
            // xMaximumTextField
            // 
            this.xMaximumTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xMaximumTextField.Depth = 0;
            this.xMaximumTextField.Hint = "X maximum...";
            this.xMaximumTextField.Location = new System.Drawing.Point(3, 32);
            this.xMaximumTextField.MaxLength = 32767;
            this.xMaximumTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.xMaximumTextField.Name = "xMaximumTextField";
            this.xMaximumTextField.PasswordChar = '\0';
            this.xMaximumTextField.SelectedText = "";
            this.xMaximumTextField.SelectionLength = 0;
            this.xMaximumTextField.SelectionStart = 0;
            this.xMaximumTextField.Size = new System.Drawing.Size(370, 23);
            this.xMaximumTextField.TabIndex = 1;
            this.xMaximumTextField.TabStop = false;
            this.xMaximumTextField.UseSystemPasswordChar = false;
            // 
            // xMinimumTextField
            // 
            this.xMinimumTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xMinimumTextField.Depth = 0;
            this.xMinimumTextField.Hint = "X minimum...";
            this.xMinimumTextField.Location = new System.Drawing.Point(3, 3);
            this.xMinimumTextField.MaxLength = 32767;
            this.xMinimumTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.xMinimumTextField.Name = "xMinimumTextField";
            this.xMinimumTextField.PasswordChar = '\0';
            this.xMinimumTextField.SelectedText = "";
            this.xMinimumTextField.SelectionLength = 0;
            this.xMinimumTextField.SelectionStart = 0;
            this.xMinimumTextField.Size = new System.Drawing.Size(370, 23);
            this.xMinimumTextField.TabIndex = 0;
            this.xMinimumTextField.TabStop = false;
            this.xMinimumTextField.UseSystemPasswordChar = false;
            // 
            // tileResolutionXTextField
            // 
            this.tileResolutionXTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileResolutionXTextField.Depth = 0;
            this.tileResolutionXTextField.Hint = "Tile resolution X...";
            this.tileResolutionXTextField.Location = new System.Drawing.Point(3, 235);
            this.tileResolutionXTextField.MaxLength = 32767;
            this.tileResolutionXTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.tileResolutionXTextField.Name = "tileResolutionXTextField";
            this.tileResolutionXTextField.PasswordChar = '\0';
            this.tileResolutionXTextField.SelectedText = "";
            this.tileResolutionXTextField.SelectionLength = 0;
            this.tileResolutionXTextField.SelectionStart = 0;
            this.tileResolutionXTextField.Size = new System.Drawing.Size(370, 23);
            this.tileResolutionXTextField.TabIndex = 8;
            this.tileResolutionXTextField.TabStop = false;
            this.tileResolutionXTextField.UseSystemPasswordChar = false;
            // 
            // tileResolutionYTextField
            // 
            this.tileResolutionYTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileResolutionYTextField.Depth = 0;
            this.tileResolutionYTextField.Hint = "Tile resolution Y...";
            this.tileResolutionYTextField.Location = new System.Drawing.Point(3, 264);
            this.tileResolutionYTextField.MaxLength = 32767;
            this.tileResolutionYTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.tileResolutionYTextField.Name = "tileResolutionYTextField";
            this.tileResolutionYTextField.PasswordChar = '\0';
            this.tileResolutionYTextField.SelectedText = "";
            this.tileResolutionYTextField.SelectionLength = 0;
            this.tileResolutionYTextField.SelectionStart = 0;
            this.tileResolutionYTextField.Size = new System.Drawing.Size(370, 23);
            this.tileResolutionYTextField.TabIndex = 9;
            this.tileResolutionYTextField.TabStop = false;
            this.tileResolutionYTextField.UseSystemPasswordChar = false;
            // 
            // threadTimer
            // 
            this.threadTimer.Enabled = true;
            this.threadTimer.Interval = 20;
            this.threadTimer.Tick += new System.EventHandler(this.threadTimer_Tick);
            // 
            // spacingXTextField
            // 
            this.spacingXTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spacingXTextField.Depth = 0;
            this.spacingXTextField.Hint = "Spacing X...";
            this.spacingXTextField.Location = new System.Drawing.Point(3, 119);
            this.spacingXTextField.MaxLength = 32767;
            this.spacingXTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.spacingXTextField.Name = "spacingXTextField";
            this.spacingXTextField.PasswordChar = '\0';
            this.spacingXTextField.SelectedText = "";
            this.spacingXTextField.SelectionLength = 0;
            this.spacingXTextField.SelectionStart = 0;
            this.spacingXTextField.Size = new System.Drawing.Size(370, 23);
            this.spacingXTextField.TabIndex = 4;
            this.spacingXTextField.TabStop = false;
            this.spacingXTextField.UseSystemPasswordChar = false;
            // 
            // spacingYTextField
            // 
            this.spacingYTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spacingYTextField.Depth = 0;
            this.spacingYTextField.Hint = "Spacing Y...";
            this.spacingYTextField.Location = new System.Drawing.Point(3, 148);
            this.spacingYTextField.MaxLength = 32767;
            this.spacingYTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.spacingYTextField.Name = "spacingYTextField";
            this.spacingYTextField.PasswordChar = '\0';
            this.spacingYTextField.SelectedText = "";
            this.spacingYTextField.SelectionLength = 0;
            this.spacingYTextField.SelectionStart = 0;
            this.spacingYTextField.Size = new System.Drawing.Size(370, 23);
            this.spacingYTextField.TabIndex = 5;
            this.spacingYTextField.TabStop = false;
            this.spacingYTextField.UseSystemPasswordChar = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 419);
            this.Controls.Add(this.mainPanel);
            this.MaximumSize = new System.Drawing.Size(1200, 419);
            this.MinimumSize = new System.Drawing.Size(400, 361);
            this.Name = "MainForm";
            this.Text = "Tile map glue";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private MaterialSkin.Controls.MaterialProgressBar glueProgressBar;
        private MaterialSkin.Controls.MaterialRaisedButton glueButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField destinationTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField sourceTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField yMaximumTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField yMinimumTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField xMaximumTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField xMinimumTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField tileResolutionYTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField tileResolutionXTextField;
        private System.Windows.Forms.Timer threadTimer;
        private MaterialSkin.Controls.MaterialSingleLineTextField spacingYTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField spacingXTextField;
    }
}

