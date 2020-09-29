namespace TheBattleShipClient
{
    partial class StartGameOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartGameOption));
            this.roomSize = new System.Windows.Forms.ComboBox();
            this.roomSizeLabel = new System.Windows.Forms.Label();
            this.roomId = new System.Windows.Forms.TextBox();
            this.roomIdLabel = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.hostSelectionRadio = new System.Windows.Forms.RadioButton();
            this.joinSelectionRadio = new System.Windows.Forms.RadioButton();
            this.modeSelection = new System.Windows.Forms.GroupBox();
            this.modeSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomSize
            // 
            this.roomSize.FormattingEnabled = true;
            this.roomSize.Items.AddRange(new object[] {
            resources.GetString("roomSize.Items")});
            resources.ApplyResources(this.roomSize, "roomSize");
            this.roomSize.Name = "roomSize";
            // 
            // roomSizeLabel
            // 
            resources.ApplyResources(this.roomSizeLabel, "roomSizeLabel");
            this.roomSizeLabel.Name = "roomSizeLabel";
            // 
            // roomId
            // 
            resources.ApplyResources(this.roomId, "roomId");
            this.roomId.Name = "roomId";
            // 
            // roomIdLabel
            // 
            resources.ApplyResources(this.roomIdLabel, "roomIdLabel");
            this.roomIdLabel.Name = "roomIdLabel";
            // 
            // startGameButton
            // 
            resources.ApplyResources(this.startGameButton, "startGameButton");
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // hostSelectionRadio
            // 
            resources.ApplyResources(this.hostSelectionRadio, "hostSelectionRadio");
            this.hostSelectionRadio.Checked = true;
            this.hostSelectionRadio.Name = "hostSelectionRadio";
            this.hostSelectionRadio.TabStop = true;
            this.hostSelectionRadio.UseVisualStyleBackColor = true;
            this.hostSelectionRadio.CheckedChanged += new System.EventHandler(this.hostSelectionRadio_CheckedChanged);
            // 
            // joinSelectionRadio
            // 
            resources.ApplyResources(this.joinSelectionRadio, "joinSelectionRadio");
            this.joinSelectionRadio.Name = "joinSelectionRadio";
            this.joinSelectionRadio.UseVisualStyleBackColor = true;
            this.joinSelectionRadio.CheckedChanged += new System.EventHandler(this.joinSelectionRadio_CheckedChanged);
            // 
            // modeSelection
            // 
            this.modeSelection.Controls.Add(this.hostSelectionRadio);
            this.modeSelection.Controls.Add(this.joinSelectionRadio);
            resources.ApplyResources(this.modeSelection, "modeSelection");
            this.modeSelection.Name = "modeSelection";
            this.modeSelection.TabStop = false;
            // 
            // StartGameOption
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.roomIdLabel);
            this.Controls.Add(this.roomId);
            this.Controls.Add(this.roomSizeLabel);
            this.Controls.Add(this.roomSize);
            this.Controls.Add(this.modeSelection);
            this.Name = "StartGameOption";
            this.modeSelection.ResumeLayout(false);
            this.modeSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox roomSize;
        private System.Windows.Forms.Label roomSizeLabel;
        private System.Windows.Forms.TextBox roomId;
        private System.Windows.Forms.Label roomIdLabel;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.RadioButton hostSelectionRadio;
        private System.Windows.Forms.RadioButton joinSelectionRadio;
        private System.Windows.Forms.GroupBox modeSelection;
    }
}