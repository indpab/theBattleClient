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
            this.txtRounds = new System.Windows.Forms.Label();
            this.enemyMove = new System.Windows.Forms.Label();
            this.txtHelp = new System.Windows.Forms.Label();
            this.EnemyPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.torpedoRadioButton = new System.Windows.Forms.RadioButton();
            this.bombRadioButton = new System.Windows.Forms.RadioButton();
            this.mineRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.largeRadioButton = new System.Windows.Forms.RadioButton();
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
            this.txtEnemy.ForeColor = System.Drawing.Color.White;
            this.txtEnemy.Location = new System.Drawing.Point(1450, 133);
            this.txtEnemy.Name = "txtEnemy";
            this.txtEnemy.Size = new System.Drawing.Size(38, 25);
            this.txtEnemy.TabIndex = 0;
            this.txtEnemy.Text = "00";
            // 
            // txtRounds
            // 
            this.txtRounds.AutoSize = true;
            this.txtRounds.BackColor = System.Drawing.Color.Transparent;
            this.txtRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRounds.ForeColor = System.Drawing.Color.White;
            this.txtRounds.Location = new System.Drawing.Point(833, 133);
            this.txtRounds.Name = "txtRounds";
            this.txtRounds.Size = new System.Drawing.Size(120, 25);
            this.txtRounds.TabIndex = 0;
            this.txtRounds.Text = "Round: 10";
            // 
            // enemyMove
            // 
            this.enemyMove.AutoSize = true;
            this.enemyMove.BackColor = System.Drawing.Color.Transparent;
            this.enemyMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enemyMove.ForeColor = System.Drawing.Color.White;
            this.enemyMove.Location = new System.Drawing.Point(899, 34);
            this.enemyMove.Name = "enemyMove";
            this.enemyMove.Size = new System.Drawing.Size(43, 29);
            this.enemyMove.TabIndex = 0;
            this.enemyMove.Text = "A1";
            // 
            // txtHelp
            // 
            this.txtHelp.AutoSize = true;
            this.txtHelp.BackColor = System.Drawing.Color.Transparent;
            this.txtHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHelp.ForeColor = System.Drawing.Color.White;
            this.txtHelp.Location = new System.Drawing.Point(100, 885);
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(415, 20);
            this.txtHelp.TabIndex = 0;
            this.txtHelp.Text = "1) Click on 3 different locations from above to start"; ;
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
            this.groupBox2.Controls.Add(this.smallRadioButton);
            this.groupBox2.Controls.Add(this.mediumRadioButton);
            this.groupBox2.Controls.Add(this.largeRadioButton);
            this.groupBox2.Controls.Add(this.atomicRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(150, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 146);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Ship Type:";
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(6, 22);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(75, 19);
            this.smallRadioButton.TabIndex = 1;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "Small";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(6, 47);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(82, 19);
            this.mediumRadioButton.TabIndex = 0;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // largeRadioButton
            // 
            this.largeRadioButton.AutoSize = true;
            this.largeRadioButton.Location = new System.Drawing.Point(6, 72);
            this.largeRadioButton.Name = "largeRadioButton";
            this.largeRadioButton.Size = new System.Drawing.Size(75, 19);
            this.largeRadioButton.TabIndex = 1;
            this.largeRadioButton.TabStop = true;
            this.largeRadioButton.Text = "Large";
            this.largeRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            this.atomicRadioButton.AutoSize = true;
            this.atomicRadioButton.Location = new System.Drawing.Point(6, 97);
            this.atomicRadioButton.Name = "atomicRadioButton";
            this.atomicRadioButton.Size = new System.Drawing.Size(82, 19);
            this.atomicRadioButton.TabIndex = 0;
            this.atomicRadioButton.TabStop = true;
            this.atomicRadioButton.Text = "Atomic";
            this.atomicRadioButton.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 938);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.txtRounds);
            this.Controls.Add(this.enemyMove);
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

        #endregion

        private System.Windows.Forms.Label txtPlayer;
        private Label shipPlaceInfo;
        private System.Windows.Forms.Label txtEnemy;
        private System.Windows.Forms.Label txtRounds;
        private System.Windows.Forms.Label enemyMove;
        private System.Windows.Forms.Label txtHelp;
        private System.Windows.Forms.Timer EnemyPlayTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton torpedoRadioButton;
        private System.Windows.Forms.RadioButton bombRadioButton;
        private System.Windows.Forms.RadioButton mineRadioButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton largeRadioButton;
        private System.Windows.Forms.RadioButton atomicRadioButton;
        private System.Windows.Forms.Button turnShipButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button undoButton;
    }
}