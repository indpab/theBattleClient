using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheBattleShipClient
{
    partial class Game
    {
        int xxy = 10;
        char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        int startx = 87;
        int butx = 87, buty = 240;
        int offset = 3;

        void AddButton(string name, EventHandler e)
        {
            Button btn = new Button();

            btn.BackColor = Color.White;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Font = new Font("Courier", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn.Name = name;
            btn.Text = name;
            btn.UseVisualStyleBackColor = false;
            btn.Location = new Point(butx, buty);
            btn.Size = new Size(63, 47);
            btn.Click += new EventHandler(e);
            this.Controls.Add(btn);
            if (butx < startx + (btn.Width + offset) * (xxy - 1))
                butx += offset + btn.Width;
            else
            {
                butx = startx;
                buty += btn.Height + offset-1;
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

        private void test(object sender, EventArgs e)
        {

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            xxy = RoomResponse.Size;
            for (int i = 0; i < xxy; i++)
            {
                for (int j = 0; j < xxy; j++)
                {
                    AddButton(String.Format("{0}{1}", letters[i], j + 1), test);
                }
            }
            butx = startx + (630) + 138;
            startx = butx;
            buty = 240;
            for (int i = 0; i < xxy; i++)
            {
                for (int j = 0; j < xxy; j++)
                {
                    AddButton(String.Format("{0}{1}", letters[i], j + 1), test);
                }
            }


            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.EnemyLocationListBox = new System.Windows.Forms.ComboBox();
            this.txtPlayer = new System.Windows.Forms.Label();
            this.txtEnemy = new System.Windows.Forms.Label();
            this.txtRounds = new System.Windows.Forms.Label();
            this.enemyMove = new System.Windows.Forms.Label();
            this.txtHelp = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.EnemyPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.destroyerRadioButton = new System.Windows.Forms.RadioButton();
            this.submarineRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnemyLocationListBox
            // 
            this.EnemyLocationListBox.BackColor = System.Drawing.Color.PaleGreen;
            this.EnemyLocationListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnemyLocationListBox.DropDownWidth = 95;
            this.EnemyLocationListBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EnemyLocationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnemyLocationListBox.FormattingEnabled = true;
            this.EnemyLocationListBox.IntegralHeight = false;
            this.EnemyLocationListBox.Location = new System.Drawing.Point(186, 30);
            this.EnemyLocationListBox.Name = "EnemyLocationListBox";
            this.EnemyLocationListBox.Size = new System.Drawing.Size(88, 33);
            this.EnemyLocationListBox.TabIndex = 1;
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
            this.txtHelp.Text = "1) Click on 3 different locations from above to start";;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button16.Location = new System.Drawing.Point(490, 259);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(84, 69);
            this.button16.TabIndex = 2;
            this.button16.Text = "Attack";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // EnemyPlayTimer
            // 
            this.EnemyPlayTimer.Interval = 1000;
            this.EnemyPlayTimer.Tick += new System.EventHandler(this.EnemyPlayTimerEvent);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.destroyerRadioButton);
            this.groupBox1.Controls.Add(this.submarineRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(26, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Ship Type:";
            // 
            // destroyerRadioButton
            // 
            this.destroyerRadioButton.AutoSize = true;
            this.destroyerRadioButton.Location = new System.Drawing.Point(6, 47);
            this.destroyerRadioButton.Name = "destroyerRadioButton";
            this.destroyerRadioButton.Size = new System.Drawing.Size(75, 19);
            this.destroyerRadioButton.TabIndex = 1;
            this.destroyerRadioButton.TabStop = true;
            this.destroyerRadioButton.Text = "Destroyer";
            this.destroyerRadioButton.UseVisualStyleBackColor = true;
            // 
            // submarineRadioButton
            // 
            this.submarineRadioButton.AutoSize = true;
            this.submarineRadioButton.Location = new System.Drawing.Point(6, 22);
            this.submarineRadioButton.Name = "submarineRadioButton";
            this.submarineRadioButton.Size = new System.Drawing.Size(82, 19);
            this.submarineRadioButton.TabIndex = 0;
            this.submarineRadioButton.TabStop = true;
            this.submarineRadioButton.Text = "Submarine";
            this.submarineRadioButton.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1786, 938);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.z4);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.EnemyLocationListBox);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.txtRounds);
            this.Controls.Add(this.enemyMove);
            this.Controls.Add(this.txtEnemy);
            this.Controls.Add(this.txtPlayer);
            this.Name = "Game";
            this.Text = "BattleShip";
            this.Load += new System.EventHandler(this.Game_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SetClientSizeCore(1600, 2600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPlayer;
        private System.Windows.Forms.Label txtEnemy;
        private System.Windows.Forms.Label txtRounds;
        private System.Windows.Forms.Label enemyMove;
        private System.Windows.Forms.Label txtHelp;
        private System.Windows.Forms.ComboBox EnemyLocationListBox;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Timer EnemyPlayTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton destroyerRadioButton;
        private System.Windows.Forms.RadioButton submarineRadioButton;
    }
}