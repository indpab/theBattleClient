namespace TheBattleShipClient
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.EnemyLocationListBox = new System.Windows.Forms.ComboBox();
            this.txtPlayer = new System.Windows.Forms.Label();
            this.txtEnemy = new System.Windows.Forms.Label();
            this.txtRounds = new System.Windows.Forms.Label();
            this.enemyMove = new System.Windows.Forms.Label();
            this.txtHelp = new System.Windows.Forms.Label();
            this.w1 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.w2 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
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
            this.txtHelp.Text = "1) Click on 3 different locations from above to start";
            // 
            // w1
            // 
            this.w1.BackColor = System.Drawing.Color.White;
            this.w1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.w1.Location = new System.Drawing.Point(100, 289);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(68, 53);
            this.w1.TabIndex = 2;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = false;
            this.w1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // w3
            // 
            this.w3.BackColor = System.Drawing.Color.White;
            this.w3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.w3.Location = new System.Drawing.Point(247, 290);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(68, 53);
            this.w3.TabIndex = 2;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = false;
            this.w3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // w2
            // 
            this.w2.BackColor = System.Drawing.Color.White;
            this.w2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.w2.Location = new System.Drawing.Point(173, 289);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(68, 53);
            this.w2.TabIndex = 2;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = false;
            this.w2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // w4
            // 
            this.w4.BackColor = System.Drawing.Color.White;
            this.w4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.w4.Location = new System.Drawing.Point(320, 289);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(68, 53);
            this.w4.TabIndex = 2;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = false;
            this.w4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // x1
            // 
            this.x1.BackColor = System.Drawing.Color.White;
            this.x1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.x1.Location = new System.Drawing.Point(99, 346);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(68, 53);
            this.x1.TabIndex = 2;
            this.x1.Text = "X1";
            this.x1.UseVisualStyleBackColor = false;
            this.x1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // x3
            // 
            this.x3.BackColor = System.Drawing.Color.White;
            this.x3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.x3.Location = new System.Drawing.Point(247, 346);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(68, 53);
            this.x3.TabIndex = 2;
            this.x3.Text = "X3";
            this.x3.UseVisualStyleBackColor = false;
            this.x3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // x4
            // 
            this.x4.BackColor = System.Drawing.Color.White;
            this.x4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.x4.Location = new System.Drawing.Point(320, 347);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(68, 53);
            this.x4.TabIndex = 2;
            this.x4.Text = "X4";
            this.x4.UseVisualStyleBackColor = false;
            this.x4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // x2
            // 
            this.x2.BackColor = System.Drawing.Color.White;
            this.x2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.x2.Location = new System.Drawing.Point(173, 346);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(68, 53);
            this.x2.TabIndex = 2;
            this.x2.Text = "X2";
            this.x2.UseVisualStyleBackColor = false;
            this.x2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // y1
            // 
            this.y1.BackColor = System.Drawing.Color.White;
            this.y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.y1.Location = new System.Drawing.Point(99, 405);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(68, 53);
            this.y1.TabIndex = 2;
            this.y1.Text = "Y1";
            this.y1.UseVisualStyleBackColor = false;
            this.y1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // y3
            // 
            this.y3.BackColor = System.Drawing.Color.White;
            this.y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.y3.Location = new System.Drawing.Point(247, 405);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(68, 53);
            this.y3.TabIndex = 2;
            this.y3.Text = "Y3";
            this.y3.UseVisualStyleBackColor = false;
            this.y3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // y4
            // 
            this.y4.BackColor = System.Drawing.Color.White;
            this.y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.y4.Location = new System.Drawing.Point(320, 405);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(68, 53);
            this.y4.TabIndex = 2;
            this.y4.Text = "Y4";
            this.y4.UseVisualStyleBackColor = false;
            this.y4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // y2
            // 
            this.y2.BackColor = System.Drawing.Color.White;
            this.y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.y2.Location = new System.Drawing.Point(173, 405);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(68, 53);
            this.y2.TabIndex = 2;
            this.y2.Text = "Y2";
            this.y2.UseVisualStyleBackColor = false;
            this.y2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
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
            // z1
            // 
            this.z1.BackColor = System.Drawing.Color.White;
            this.z1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.z1.Location = new System.Drawing.Point(99, 463);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(68, 53);
            this.z1.TabIndex = 2;
            this.z1.Text = "Z1";
            this.z1.UseVisualStyleBackColor = false;
            this.z1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // z3
            // 
            this.z3.BackColor = System.Drawing.Color.White;
            this.z3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.z3.Location = new System.Drawing.Point(247, 462);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(68, 53);
            this.z3.TabIndex = 2;
            this.z3.Text = "Z3";
            this.z3.UseVisualStyleBackColor = false;
            this.z3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // z4
            // 
            this.z4.BackColor = System.Drawing.Color.White;
            this.z4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.z4.Location = new System.Drawing.Point(321, 462);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(68, 53);
            this.z4.TabIndex = 2;
            this.z4.Text = "Z4";
            this.z4.UseVisualStyleBackColor = false;
            this.z4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // z2
            // 
            this.z2.BackColor = System.Drawing.Color.White;
            this.z2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.z2.Location = new System.Drawing.Point(173, 463);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(68, 53);
            this.z2.TabIndex = 2;
            this.z2.Text = "Z2";
            this.z2.UseVisualStyleBackColor = false;
            this.z2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.Color.White;
            this.a1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a1.Location = new System.Drawing.Point(955, 289);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(68, 53);
            this.a1.TabIndex = 2;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = false;
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.Color.White;
            this.a3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a3.Location = new System.Drawing.Point(1103, 288);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(68, 53);
            this.a3.TabIndex = 2;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = false;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.White;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b1.Location = new System.Drawing.Point(955, 347);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(68, 53);
            this.b1.TabIndex = 2;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = false;
            // 
            // a4
            // 
            this.a4.BackColor = System.Drawing.Color.White;
            this.a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a4.Location = new System.Drawing.Point(1177, 288);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(68, 53);
            this.a4.TabIndex = 2;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = false;
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.Color.White;
            this.c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c1.Location = new System.Drawing.Point(955, 405);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(68, 53);
            this.c1.TabIndex = 2;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = false;
            // 
            // d1
            // 
            this.d1.BackColor = System.Drawing.Color.White;
            this.d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.d1.Location = new System.Drawing.Point(955, 462);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(68, 53);
            this.d1.TabIndex = 2;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = false;
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.White;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b3.Location = new System.Drawing.Point(1103, 347);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(68, 53);
            this.b3.TabIndex = 2;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = false;
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.White;
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b4.Location = new System.Drawing.Point(1177, 347);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(68, 53);
            this.b4.TabIndex = 2;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = false;
            // 
            // c3
            // 
            this.c3.BackColor = System.Drawing.Color.White;
            this.c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c3.Location = new System.Drawing.Point(1103, 405);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(68, 53);
            this.c3.TabIndex = 2;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = false;
            // 
            // d3
            // 
            this.d3.BackColor = System.Drawing.Color.White;
            this.d3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.d3.Location = new System.Drawing.Point(1103, 462);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(68, 53);
            this.d3.TabIndex = 2;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = false;
            // 
            // c4
            // 
            this.c4.BackColor = System.Drawing.Color.White;
            this.c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c4.Location = new System.Drawing.Point(1177, 405);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(68, 53);
            this.c4.TabIndex = 2;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = false;
            // 
            // d4
            // 
            this.d4.BackColor = System.Drawing.Color.White;
            this.d4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.d4.Location = new System.Drawing.Point(1177, 462);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(68, 53);
            this.d4.TabIndex = 2;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = false;
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.Color.White;
            this.a2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a2.Location = new System.Drawing.Point(1029, 288);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(68, 53);
            this.a2.TabIndex = 2;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = false;
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.White;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b2.Location = new System.Drawing.Point(1029, 347);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(68, 53);
            this.b2.TabIndex = 2;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = false;
            // 
            // c2
            // 
            this.c2.BackColor = System.Drawing.Color.White;
            this.c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c2.Location = new System.Drawing.Point(1029, 405);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(68, 53);
            this.c2.TabIndex = 2;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = false;
            // 
            // d2
            // 
            this.d2.BackColor = System.Drawing.Color.White;
            this.d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.d2.Location = new System.Drawing.Point(1029, 462);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(68, 53);
            this.d2.TabIndex = 2;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = false;
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAttack.Location = new System.Drawing.Point(299, 26);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(84, 42);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.AttackButtonEvent);
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