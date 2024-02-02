namespace COD_Ghosts_Fixer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            message = new Label();
            path = new TextBox();
            openFolder = new Button();
            launchGame = new Button();
            toolTip1 = new ToolTip(components);
            findGame = new Button();
            addShortcuts = new Button();
            credits = new Label();
            removeShortcuts = new Button();
            SuspendLayout();
            // 
            // message
            // 
            message.AutoSize = true;
            message.Location = new Point(12, 9);
            message.Name = "message";
            message.Size = new Size(214, 15);
            message.TabIndex = 0;
            message.Text = "Please enter the path to the executable.";
            // 
            // path
            // 
            path.BackColor = Color.White;
            path.Location = new Point(12, 27);
            path.Name = "path";
            path.Size = new Size(358, 23);
            path.TabIndex = 1;
            path.TextChanged += path_TextChanged;
            // 
            // openFolder
            // 
            openFolder.Enabled = false;
            openFolder.Image = Properties.Resources.folder;
            openFolder.Location = new Point(405, 27);
            openFolder.Name = "openFolder";
            openFolder.Size = new Size(23, 23);
            openFolder.TabIndex = 2;
            toolTip1.SetToolTip(openFolder, "Open the game folder");
            openFolder.UseVisualStyleBackColor = true;
            openFolder.Click += openFolder_Click;
            // 
            // launchGame
            // 
            launchGame.Enabled = false;
            launchGame.Image = Properties.Resources.codghosts2;
            launchGame.ImageAlign = ContentAlignment.MiddleLeft;
            launchGame.Location = new Point(368, 56);
            launchGame.Name = "launchGame";
            launchGame.Size = new Size(60, 23);
            launchGame.TabIndex = 3;
            launchGame.Text = "Open";
            launchGame.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(launchGame, "Open Call of Duty: Ghosts");
            launchGame.UseVisualStyleBackColor = true;
            launchGame.Click += launchGame_Click;
            // 
            // findGame
            // 
            findGame.Location = new Point(376, 27);
            findGame.Name = "findGame";
            findGame.Size = new Size(23, 23);
            findGame.TabIndex = 14;
            findGame.Text = "+";
            toolTip1.SetToolTip(findGame, "Select the COD Ghosts executable");
            findGame.UseVisualStyleBackColor = true;
            findGame.Click += findGame_Click;
            // 
            // addShortcuts
            // 
            addShortcuts.Enabled = false;
            addShortcuts.Location = new Point(12, 56);
            addShortcuts.Name = "addShortcuts";
            addShortcuts.Size = new Size(172, 23);
            addShortcuts.TabIndex = 4;
            addShortcuts.Text = "Add Fixed Shortcuts";
            addShortcuts.UseVisualStyleBackColor = true;
            addShortcuts.Click += addShortcuts_Click;
            // 
            // credits
            // 
            credits.AutoSize = true;
            credits.ForeColor = SystemColors.ControlDark;
            credits.Location = new Point(348, 9);
            credits.Name = "credits";
            credits.Size = new Size(80, 15);
            credits.TabIndex = 12;
            credits.Text = "Fixer by cod.y";
            // 
            // removeShortcuts
            // 
            removeShortcuts.Enabled = false;
            removeShortcuts.Location = new Point(190, 56);
            removeShortcuts.Name = "removeShortcuts";
            removeShortcuts.Size = new Size(172, 23);
            removeShortcuts.TabIndex = 13;
            removeShortcuts.Text = "Remove Fixed Shortcuts";
            removeShortcuts.UseVisualStyleBackColor = true;
            removeShortcuts.Click += removeShortcuts_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 91);
            Controls.Add(findGame);
            Controls.Add(removeShortcuts);
            Controls.Add(credits);
            Controls.Add(addShortcuts);
            Controls.Add(launchGame);
            Controls.Add(openFolder);
            Controls.Add(path);
            Controls.Add(message);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Call of Duty: Ghosts - Fixer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label message;
        private TextBox path;
        private Button openFolder;
        private ToolTip toolTip1;
        private Button launchGame;
        private Button addShortcuts;
        private Label credits;
        private Button removeShortcuts;
        private Button findGame;
    }
}
