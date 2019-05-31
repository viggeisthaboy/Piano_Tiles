namespace piano_tiles
{
    partial class PianoTiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PianoTiles));
            this.btnTile1 = new System.Windows.Forms.Button();
            this.btnTile2 = new System.Windows.Forms.Button();
            this.btnTile3 = new System.Windows.Forms.Button();
            this.btnTile4 = new System.Windows.Forms.Button();
            this.btnStartPianoTiles = new System.Windows.Forms.Button();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.tmrGameOver = new System.Windows.Forms.Timer(this.components);
            this.pnlMoveForm = new System.Windows.Forms.Panel();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnBasenAvForm1 = new System.Windows.Forms.Button();
            this.btnUnPause = new System.Windows.Forms.Button();
            this.btnVolumeOn = new System.Windows.Forms.Button();
            this.btnVolumeOff = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnMinimizeWindow = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.pnlMoveForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTile1
            // 
            this.btnTile1.BackColor = System.Drawing.Color.Black;
            this.btnTile1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTile1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTile1.Location = new System.Drawing.Point(28, 32);
            this.btnTile1.Name = "btnTile1";
            this.btnTile1.Size = new System.Drawing.Size(80, 80);
            this.btnTile1.TabIndex = 0;
            this.btnTile1.Tag = "Tiles";
            this.btnTile1.UseVisualStyleBackColor = false;
            this.btnTile1.Click += new System.EventHandler(this.btnTile1_Click);
            // 
            // btnTile2
            // 
            this.btnTile2.BackColor = System.Drawing.Color.Black;
            this.btnTile2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTile2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTile2.Location = new System.Drawing.Point(173, 32);
            this.btnTile2.Name = "btnTile2";
            this.btnTile2.Size = new System.Drawing.Size(80, 80);
            this.btnTile2.TabIndex = 1;
            this.btnTile2.Tag = "Tiles";
            this.btnTile2.UseVisualStyleBackColor = false;
            this.btnTile2.Click += new System.EventHandler(this.btnTile2_Click);
            // 
            // btnTile3
            // 
            this.btnTile3.BackColor = System.Drawing.Color.Black;
            this.btnTile3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTile3.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTile3.Location = new System.Drawing.Point(323, 32);
            this.btnTile3.Name = "btnTile3";
            this.btnTile3.Size = new System.Drawing.Size(80, 80);
            this.btnTile3.TabIndex = 2;
            this.btnTile3.Tag = "Tiles";
            this.btnTile3.UseVisualStyleBackColor = false;
            this.btnTile3.Click += new System.EventHandler(this.btnTile3_Click);
            // 
            // btnTile4
            // 
            this.btnTile4.BackColor = System.Drawing.Color.Black;
            this.btnTile4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTile4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTile4.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTile4.Location = new System.Drawing.Point(489, 32);
            this.btnTile4.Name = "btnTile4";
            this.btnTile4.Size = new System.Drawing.Size(80, 80);
            this.btnTile4.TabIndex = 3;
            this.btnTile4.Tag = "Tiles";
            this.btnTile4.UseVisualStyleBackColor = false;
            this.btnTile4.Click += new System.EventHandler(this.btnTile4_Click);
            // 
            // btnStartPianoTiles
            // 
            this.btnStartPianoTiles.BackColor = System.Drawing.Color.DarkRed;
            this.btnStartPianoTiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartPianoTiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartPianoTiles.Location = new System.Drawing.Point(222, 256);
            this.btnStartPianoTiles.Name = "btnStartPianoTiles";
            this.btnStartPianoTiles.Size = new System.Drawing.Size(150, 54);
            this.btnStartPianoTiles.TabIndex = 4;
            this.btnStartPianoTiles.Text = "Start";
            this.btnStartPianoTiles.UseVisualStyleBackColor = false;
            this.btnStartPianoTiles.Click += new System.EventHandler(this.btnStartPianoTiles_Click);
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 10;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // tmrGameOver
            // 
            this.tmrGameOver.Interval = 200;
            this.tmrGameOver.Tick += new System.EventHandler(this.tmrGameOver_Tick);
            // 
            // pnlMoveForm
            // 
            this.pnlMoveForm.BackColor = System.Drawing.Color.DarkRed;
            this.pnlMoveForm.Controls.Add(this.btnInformation);
            this.pnlMoveForm.Controls.Add(this.btnMinimizeWindow);
            this.pnlMoveForm.Controls.Add(this.btnCloseWindow);
            this.pnlMoveForm.Controls.Add(this.btnVolumeOff);
            this.pnlMoveForm.Controls.Add(this.btnVolumeOn);
            this.pnlMoveForm.Controls.Add(this.lblSpeed);
            this.pnlMoveForm.Controls.Add(this.lblHighScore);
            this.pnlMoveForm.Controls.Add(this.lblScore);
            this.pnlMoveForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMoveForm.Location = new System.Drawing.Point(0, 0);
            this.pnlMoveForm.Name = "pnlMoveForm";
            this.pnlMoveForm.Size = new System.Drawing.Size(588, 50);
            this.pnlMoveForm.TabIndex = 5;
            this.pnlMoveForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMoveForm_MouseDown);
            this.pnlMoveForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMoveForm_MouseMove);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(377, 15);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(64, 21);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "Speed:";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(208, 15);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(109, 21);
            this.lblHighScore.TabIndex = 1;
            this.lblHighScore.Text = "High Score: 0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(82, 15);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(61, 21);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: ";
            // 
            // btnBasenAvForm1
            // 
            this.btnBasenAvForm1.Location = new System.Drawing.Point(0, 577);
            this.btnBasenAvForm1.Name = "btnBasenAvForm1";
            this.btnBasenAvForm1.Size = new System.Drawing.Size(588, 14);
            this.btnBasenAvForm1.TabIndex = 6;
            this.btnBasenAvForm1.UseVisualStyleBackColor = true;
            // 
            // btnUnPause
            // 
            this.btnUnPause.BackColor = System.Drawing.Color.DarkRed;
            this.btnUnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnPause.Enabled = false;
            this.btnUnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnPause.Location = new System.Drawing.Point(222, 256);
            this.btnUnPause.Name = "btnUnPause";
            this.btnUnPause.Size = new System.Drawing.Size(150, 54);
            this.btnUnPause.TabIndex = 7;
            this.btnUnPause.Text = "Unpause";
            this.btnUnPause.UseVisualStyleBackColor = false;
            this.btnUnPause.Visible = false;
            this.btnUnPause.Click += new System.EventHandler(this.btnUnPause_Click);
            // 
            // btnVolumeOn
            // 
            this.btnVolumeOn.BackColor = System.Drawing.Color.DarkRed;
            this.btnVolumeOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolumeOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumeOn.ForeColor = System.Drawing.Color.DarkRed;
            this.btnVolumeOn.Image = ((System.Drawing.Image)(resources.GetObject("btnVolumeOn.Image")));
            this.btnVolumeOn.Location = new System.Drawing.Point(10, 10);
            this.btnVolumeOn.Name = "btnVolumeOn";
            this.btnVolumeOn.Size = new System.Drawing.Size(29, 29);
            this.btnVolumeOn.TabIndex = 8;
            this.btnVolumeOn.UseVisualStyleBackColor = false;
            this.btnVolumeOn.Click += new System.EventHandler(this.btnVolumeOn_Click);
            // 
            // btnVolumeOff
            // 
            this.btnVolumeOff.BackColor = System.Drawing.Color.DarkRed;
            this.btnVolumeOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolumeOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumeOff.ForeColor = System.Drawing.Color.DarkRed;
            this.btnVolumeOff.Image = ((System.Drawing.Image)(resources.GetObject("btnVolumeOff.Image")));
            this.btnVolumeOff.Location = new System.Drawing.Point(10, 10);
            this.btnVolumeOff.Name = "btnVolumeOff";
            this.btnVolumeOff.Size = new System.Drawing.Size(29, 29);
            this.btnVolumeOff.TabIndex = 9;
            this.btnVolumeOff.UseVisualStyleBackColor = false;
            this.btnVolumeOff.Visible = false;
            this.btnVolumeOff.Click += new System.EventHandler(this.btnVolumeOff_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.BackColor = System.Drawing.Color.DarkRed;
            this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseWindow.Image")));
            this.btnCloseWindow.Location = new System.Drawing.Point(549, 10);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(29, 29);
            this.btnCloseWindow.TabIndex = 10;
            this.btnCloseWindow.UseVisualStyleBackColor = false;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // btnMinimizeWindow
            // 
            this.btnMinimizeWindow.BackColor = System.Drawing.Color.DarkRed;
            this.btnMinimizeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeWindow.ForeColor = System.Drawing.Color.DarkRed;
            this.btnMinimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizeWindow.Image")));
            this.btnMinimizeWindow.Location = new System.Drawing.Point(515, 12);
            this.btnMinimizeWindow.Name = "btnMinimizeWindow";
            this.btnMinimizeWindow.Size = new System.Drawing.Size(29, 29);
            this.btnMinimizeWindow.TabIndex = 11;
            this.btnMinimizeWindow.UseVisualStyleBackColor = false;
            this.btnMinimizeWindow.Click += new System.EventHandler(this.btnMinimizeWindow_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.BackColor = System.Drawing.Color.DarkRed;
            this.btnInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.ForeColor = System.Drawing.Color.DarkRed;
            this.btnInformation.Image = ((System.Drawing.Image)(resources.GetObject("btnInformation.Image")));
            this.btnInformation.Location = new System.Drawing.Point(481, 10);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(29, 29);
            this.btnInformation.TabIndex = 12;
            this.btnInformation.UseVisualStyleBackColor = false;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // PianoTiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 497);
            this.Controls.Add(this.btnUnPause);
            this.Controls.Add(this.btnBasenAvForm1);
            this.Controls.Add(this.pnlMoveForm);
            this.Controls.Add(this.btnStartPianoTiles);
            this.Controls.Add(this.btnTile4);
            this.Controls.Add(this.btnTile3);
            this.Controls.Add(this.btnTile2);
            this.Controls.Add(this.btnTile1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PianoTiles";
            this.Text = "Piano Tiles";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.pnlMoveForm.ResumeLayout(false);
            this.pnlMoveForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTile1;
        private System.Windows.Forms.Button btnTile2;
        private System.Windows.Forms.Button btnTile3;
        private System.Windows.Forms.Button btnTile4;
        private System.Windows.Forms.Button btnStartPianoTiles;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Timer tmrGameOver;
        private System.Windows.Forms.Panel pnlMoveForm;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Button btnBasenAvForm1;
        private System.Windows.Forms.Button btnUnPause;
        private System.Windows.Forms.Button btnVolumeOn;
        private System.Windows.Forms.Button btnVolumeOff;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnMinimizeWindow;
    }
}

