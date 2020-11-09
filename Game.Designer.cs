using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TheBattleShipClient
{
    partial class Game
    {
        int xxy;
        char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        int startx = 87;
        int butx = 87, buty = 240;
        int offset = 3;
        List<Button> myButtons;
        List<Button> enemyButtons;
        List<Button> temp;

        void AddButton(string name, EventHandler e)
        {
            Button btn = new Button();

            btn.BackColor = Color.White;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Font = new Font("Courier", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btn.Name = name;
            btn.Text = name;
            btn.UseVisualStyleBackColor = false;
            btn.Location = new Point(butx, buty);
            btn.Size = new Size(63, 47);
            btn.Click += new EventHandler(e);
            temp.Add(btn);
            this.Controls.Add(btn);
            if (butx < startx + (btn.Width + offset) * (xxy - 1))
                butx += offset + btn.Width;
            else
            {
                butx = startx;
                buty += btn.Height + offset - 1;
            }
        }


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
            temp = new List<Button>();
            xxy = RoomResponse.Size;
            for (int i = 0; i < xxy; i++)
            {
                for (int j = 0; j < xxy; j++)
                {
                    AddButton(String.Format("{0}{1}", letters[i], j + 1), BuildConfiguration);
                }
            }
            butx = startx + (630) + 138;
            startx = butx;
            buty = 240;
            myButtons = temp;
            temp = new List<Button>();
            for (int i = 0; i < xxy; i++)
            {
                for (int j = 0; j < xxy; j++)
                {
                    AddButton(String.Format("{0}{1}", letters[i], j + 1), ShootButtonClick);
                }
            }
            enemyButtons = temp;
            temp = new List<Button>();


            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.txtPlayer = new System.Windows.Forms.Label();
            this.shipPlaceInfo = new System.Windows.Forms.Label();
            this.txtEnemy = new System.Windows.Forms.Label();
            this.yourTurn = new System.Windows.Forms.Label();
            this.joinedStatus = new System.Windows.Forms.Label();
            this.yourTurnText = new System.Windows.Forms.Label();
            this.EnemyPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.torpedoRadioButton = new System.Windows.Forms.RadioButton();
            this.bombRadioButton = new System.Windows.Forms.RadioButton();
            this.mineRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorRedRadioButton = new System.Windows.Forms.RadioButton();
            this.ColorBlueRadioButton = new System.Windows.Forms.RadioButton();
            this.ColorGreenRadioButton = new System.Windows.Forms.RadioButton();
            this.atomicRadioButton = new System.Windows.Forms.RadioButton();
            this.turnShipButton = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlayer
            // 
            this.txtPlayer.AutoSize = true;
            this.txtPlayer.BackColor = System.Drawing.Color.Transparent;
            this.txtPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPlayer.ForeColor = System.Drawing.Color.White;
            this.txtPlayer.Location = new System.Drawing.Point(609, 133);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(38, 25);
            this.txtPlayer.TabIndex = 0;
            this.txtPlayer.Text = "00";
            // 
            // shipPlaceInfo
            // 
            this.shipPlaceInfo.AutoSize = true;
            this.shipPlaceInfo.BackColor = System.Drawing.Color.Transparent;
            this.shipPlaceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shipPlaceInfo.ForeColor = System.Drawing.Color.Black;
            this.shipPlaceInfo.Location = new System.Drawing.Point(300, 75);
            this.shipPlaceInfo.Name = "placeShipInfo";
            this.shipPlaceInfo.Size = new System.Drawing.Size(75, 25);
            this.shipPlaceInfo.TabIndex = 0;
            this.shipPlaceInfo.Text = "Next ship size: 4";
            // 
            // turnShipButton
            // 
            this.turnShipButton.Location = new System.Drawing.Point(300, 30);
            this.turnShipButton.Name = "turnShipButton";
            this.turnShipButton.Size = new System.Drawing.Size(100, 30);
            this.turnShipButton.TabIndex = 2;
            this.turnShipButton.Text = "Turn ship";
            this.turnShipButton.UseVisualStyleBackColor = true;
            this.turnShipButton.Click += new System.EventHandler(this.turnShip_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(540, 30);
            this.startGameButton.Enabled = false;
            this.startGameButton.Name = "StartGame";
            this.startGameButton.Size = new System.Drawing.Size(100, 30);
            this.startGameButton.TabIndex = 2;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGame_Click);
            this.startGameButton.Hide();
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(420, 30);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(100, 30);
            this.undoButton.TabIndex = 2;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undo_Click);
            // 
            // txtEnemy
            // 
            this.txtEnemy.AutoSize = true;
            this.txtEnemy.BackColor = System.Drawing.Color.Transparent;
            this.txtEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEnemy.ForeColor = System.Drawing.Color.Black;
            this.txtEnemy.Location = new System.Drawing.Point(1450, 133);
            this.txtEnemy.Name = "txtEnemy";
            this.txtEnemy.Size = new System.Drawing.Size(38, 25);
            this.txtEnemy.TabIndex = 0;
            this.txtEnemy.Text = "00";
            // 
            // yourTurn
            // 
            this.yourTurn.AutoSize = true;
            this.yourTurn.BackColor = System.Drawing.Color.Transparent;
            this.yourTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yourTurn.ForeColor = System.Drawing.Color.Black;
            this.yourTurn.Location = new System.Drawing.Point(800, 30);
            this.yourTurn.Name = "yourTurn";
            this.yourTurn.Size = new System.Drawing.Size(120, 25);
            this.yourTurn.TabIndex = 0;
            this.yourTurn.Text = "Turn status: ";
            // 
            // joinedStatus
            // 
            this.joinedStatus.AutoSize = true;
            this.joinedStatus.BackColor = System.Drawing.Color.Transparent;
            this.joinedStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.joinedStatus.ForeColor = System.Drawing.Color.Black;
            this.joinedStatus.Location = new System.Drawing.Point(800, 60);
            this.joinedStatus.Name = "enemyMove";
            this.joinedStatus.Size = new System.Drawing.Size(120, 30);
            this.joinedStatus.TabIndex = 0;
            this.joinedStatus.Text = "Enemy is not connected";
            // 
            // yourTurnText
            // 
            this.yourTurnText.AutoSize = true;
            this.yourTurnText.BackColor = System.Drawing.Color.Transparent;
            this.yourTurnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yourTurnText.ForeColor = System.Drawing.Color.Black;
            this.yourTurnText.Location = new System.Drawing.Point(960, 30);
            this.yourTurnText.Name = "yourTurnText";
            this.yourTurnText.Size = new System.Drawing.Size(120, 30);
            this.yourTurnText.TabIndex = 0;
            this.yourTurnText.Text = ""; ;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.torpedoRadioButton);
            this.groupBox1.Controls.Add(this.bombRadioButton);
            this.groupBox1.Controls.Add(this.mineRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(26, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Weapon:";
            // 
            // torpedoRadioButton
            // 
            this.torpedoRadioButton.AutoSize = true;
            this.torpedoRadioButton.Location = new System.Drawing.Point(6, 47);
            this.torpedoRadioButton.Name = "torpedo";
            this.torpedoRadioButton.Size = new System.Drawing.Size(75, 19);
            this.torpedoRadioButton.TabIndex = 1;
            this.torpedoRadioButton.TabStop = true;
            this.torpedoRadioButton.Text = "Torpedo";
            this.torpedoRadioButton.UseVisualStyleBackColor = true;
            this.torpedoRadioButton.Checked = true;
            // 
            // bombRadioButton
            // 
            this.bombRadioButton.AutoSize = true;
            this.bombRadioButton.Location = new System.Drawing.Point(6, 22);
            this.bombRadioButton.Name = "bomb";
            this.bombRadioButton.Size = new System.Drawing.Size(82, 19);
            this.bombRadioButton.TabIndex = 0;
            this.bombRadioButton.TabStop = true;
            this.bombRadioButton.Text = "Bomb";
            this.bombRadioButton.UseVisualStyleBackColor = true;
            // 
            // mineRadioButton
            // 
            this.mineRadioButton.AutoSize = true;
            this.mineRadioButton.Location = new System.Drawing.Point(6, 72);
            this.mineRadioButton.Name = "mine";
            this.mineRadioButton.Size = new System.Drawing.Size(82, 19);
            this.mineRadioButton.TabIndex = 0;
            this.mineRadioButton.TabStop = true;
            this.mineRadioButton.Text = "Mine";
            this.mineRadioButton.UseVisualStyleBackColor = true;

            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colorRedRadioButton);
            this.groupBox2.Controls.Add(this.ColorBlueRadioButton);
            this.groupBox2.Controls.Add(this.ColorGreenRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(150, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 146);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Color:";
            // 
            // colorRed
            // 
            this.colorRedRadioButton.AutoSize = true;
            this.colorRedRadioButton.Location = new System.Drawing.Point(6, 22);
            this.colorRedRadioButton.Name = "colorRed";
            this.colorRedRadioButton.Size = new System.Drawing.Size(75, 19);
            this.colorRedRadioButton.TabIndex = 1;
            this.colorRedRadioButton.TabStop = true;
            this.colorRedRadioButton.Text = "Red";
            this.colorRedRadioButton.ForeColor = Color.Red;
            this.colorRedRadioButton.UseVisualStyleBackColor = true;
            this.colorRedRadioButton.Click += VisualizationClick;
            // 
            // colorBlue
            // 
            this.ColorBlueRadioButton.AutoSize = true;
            this.ColorBlueRadioButton.Location = new System.Drawing.Point(6, 47);
            this.ColorBlueRadioButton.Name = "colorBlue";
            this.ColorBlueRadioButton.Size = new System.Drawing.Size(82, 19);
            this.ColorBlueRadioButton.TabIndex = 0;
            this.ColorBlueRadioButton.TabStop = true;
            this.ColorBlueRadioButton.ForeColor = Color.Blue;
            this.ColorBlueRadioButton.Text = "Blue";
            this.ColorBlueRadioButton.Checked = true;
            this.ColorBlueRadioButton.UseVisualStyleBackColor = true;
            this.ColorBlueRadioButton.Click += VisualizationClick;
            // 
            // colorGreen
            // 
            this.ColorGreenRadioButton.AutoSize = true;
            this.ColorGreenRadioButton.Location = new System.Drawing.Point(6, 72);
            this.ColorGreenRadioButton.Name = "colorGreen";
            this.ColorGreenRadioButton.Size = new System.Drawing.Size(75, 19);
            this.ColorGreenRadioButton.TabIndex = 1;
            this.ColorGreenRadioButton.TabStop = true;
            this.ColorGreenRadioButton.Text = "Green";
            this.ColorGreenRadioButton.ForeColor = Color.Green;
            this.ColorGreenRadioButton.UseVisualStyleBackColor = true;
            this.ColorGreenRadioButton.Click += VisualizationClick;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 938);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.yourTurnText);
            this.Controls.Add(this.yourTurn);
            this.Controls.Add(this.joinedStatus);
            this.Controls.Add(this.txtEnemy);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.shipPlaceInfo);
            this.Controls.Add(this.turnShipButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.undoButton);
            this.Name = "Game";
            this.Text = "BattleShip";
            this.Load += new System.EventHandler(this.Game_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SetClientSizeCore(1600, 2600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ColorBlue_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label txtPlayer;
        private Label shipPlaceInfo;
        private System.Windows.Forms.Label txtEnemy;
        private System.Windows.Forms.Label yourTurn;
        private System.Windows.Forms.Label joinedStatus;
        private System.Windows.Forms.Label yourTurnText;
        private System.Windows.Forms.Timer EnemyPlayTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton torpedoRadioButton;
        private System.Windows.Forms.RadioButton bombRadioButton;
        private System.Windows.Forms.RadioButton mineRadioButton;
        private System.Windows.Forms.RadioButton colorRedRadioButton;
        private System.Windows.Forms.RadioButton ColorBlueRadioButton;
        private System.Windows.Forms.RadioButton ColorGreenRadioButton;
        private System.Windows.Forms.RadioButton atomicRadioButton;
        private System.Windows.Forms.Button turnShipButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button undoButton;
    }
}