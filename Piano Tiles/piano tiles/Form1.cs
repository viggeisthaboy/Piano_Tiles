using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace piano_tiles
{
    public partial class PianoTiles : Form
    {
        Point lastClick;
        double speed = 2;
        int score = 0;
        int highscore = 0;
        int[] currentLocationY = new int[4];
        Random slump = new Random();
        int tile1XLocation = 28;
        int tile2XLocation = 173;
        int tile3XLocation = 323;
        int tile4XLocation = 489;
        double FörvararSpeed = 0;
        int Pausat = 0;
        int SpelaDennaLåt = -1;

        public PianoTiles()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        void StartGame()
        {
            //Fixar så Tilesen syns och placeringar. Endast den tilen som är längst ner är aktiverad.
            score = 0;
            btnStartPianoTiles.Visible = false;
            btnTile1.Location = new Point(28, -80);
            btnTile2.Location = new Point(173, -230);
            btnTile3.Location = new Point(323, -380);
            btnTile4.Location = new Point(489, -530);
            currentLocationY[0] = -80;
            currentLocationY[1] = -230;
            currentLocationY[2] = -380;
            currentLocationY[3] = -530;
            btnTile1.Enabled = true;
            btnTile2.Enabled = false;
            btnTile3.Enabled = false;
            btnTile4.Enabled = false;
            tmrGame.Enabled = true;
        }

        private void btnStartPianoTiles_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            //Gör vädren där Tilesen ska vara varje 20 milisekund för att få dem att åka neråt.
            for (int i = 0; i < 4; i++)
            {
                currentLocationY[i] = currentLocationY[i] + (int)speed;
            }
            //Gör så Tilesen rör sig neråt med hastigheten "speed" per 20 milisekunder.
            btnTile1.Location = new Point(tile1XLocation, (currentLocationY[0]));
            btnTile2.Location = new Point(tile2XLocation, ((currentLocationY[1])));
            btnTile3.Location = new Point(tile3XLocation, ((currentLocationY[2])));
            btnTile4.Location = new Point(tile4XLocation, ((currentLocationY[3])));
            //Visar nuvarande poäng samt snabbheten Tilesen rör sig som heltal.
            lblScore.Text = ("Score: " + score);
            lblSpeed.Text = ("Speed: " + (int)speed);

            //Detta gör så att den Tilen längst till vänster ska heta Q, andra W, tredje E & fjärde R
            if (tile1XLocation == 28)
            {
                btnTile1.Text = "Q";
            }
            else if (tile1XLocation == 173)
            {
                btnTile1.Text = "W";
            }
            else if (tile1XLocation == 323)
            {
                btnTile1.Text = "E";
            }
            else if (tile1XLocation == 489)
            {
                btnTile1.Text = "R";
            }

            if (tile2XLocation == 28)
            {
                btnTile2.Text = "Q";
            }
            else if (tile2XLocation == 173)
            {
                btnTile2.Text = "W";
            }
            else if (tile2XLocation == 323)
            {
                btnTile2.Text = "E";
            }
            else if (tile2XLocation == 489)
            {
                btnTile2.Text = "R";
            }

            if (tile3XLocation == 28)
            {
                btnTile3.Text = "Q";
            }
            else if (tile3XLocation == 173)
            {
                btnTile3.Text = "W";
            }
            else if (tile3XLocation == 323)
            {
                btnTile3.Text = "E";
            }
            else if (tile3XLocation == 489)
            {
                btnTile3.Text = "R";
            }

            if (tile4XLocation == 28)
            {
                btnTile4.Text = "Q";
            }
            else if (tile4XLocation == 173)
            {
                btnTile4.Text = "W";
            }
            else if (tile4XLocation == 323)
            {
                btnTile4.Text = "E";
            }
            else if (tile4XLocation == 489)
            {
                btnTile4.Text = "R";
            }

            //Om Tilesen kolliderar med en button jag lade ut under form, körs metoden GameOver()
            if (btnTile1.Bounds.IntersectsWith(btnBasenAvForm1.Bounds))
            {
                GameOver();
            }
            if (btnTile2.Bounds.IntersectsWith(btnBasenAvForm1.Bounds))
            {
                GameOver();
            }
            if (btnTile3.Bounds.IntersectsWith(btnBasenAvForm1.Bounds))
            {
                GameOver();
            }
            if (btnTile4.Bounds.IntersectsWith(btnBasenAvForm1.Bounds))
            {
                GameOver();
            }
        }

        void TileEttClicked()
        {

            PlaySound();
            score = score + 1;
            speed = speed + 0.025;
            btnTile2.Enabled = true;
            btnTile1.Enabled = false;

            //Här flyttas tilen som blev klickad. I detta fall Tile1, upp 100 pixlar över den tile som är längst upp. Detta gör så inte tilesen åker ojämt men istället håller 100 pixlar avstånd.
            currentLocationY[0] = (-150 + currentLocationY[3]);

            //Här slumpas ett tal mellan 1-4 och sparas i rndTile1 för att användas nedan.
            int rndTile1 = slump.Next(1, 5);

            //Här flyttas tilen som blev klickad. I detta fall Tile1, x-leds med hjälp av rnd som slumpar mellan 1-4
            if (rndTile1 == 1)
            {
                tile1XLocation = 28;
            }

            else if (rndTile1 == 2)
            {
                tile1XLocation = 173;
            }

            else if (rndTile1 == 3)
            {
                tile1XLocation = 323;
            }

            else
            {
                tile1XLocation = 489;
            }
        }

        private void btnTile1_Click(object sender, EventArgs e)
        {
            TileEttClicked();
        }

        void TileTvåClicked()
        {

            PlaySound();
            score = score + 1;
            speed = speed + 0.025;
            btnTile3.Enabled = true;
            btnTile2.Enabled = false;
            // Tile 1 ska alltid över tile4 då det alltid är den som kommer vara högst när tile1 klickas. Tile 2 ska alltid över Tile 1 då det är den som blir högst. Tile 3 över 2 & Tile 4 över 3.
            currentLocationY[1] = (currentLocationY[0] - 150);
            int rndTile2 = slump.Next(1, 5);

            if (rndTile2 == 1)
            {
                tile2XLocation = 28;
            }

            else if (rndTile2 == 2)
            {
                tile2XLocation = 173;
            }

            else if (rndTile2 == 3)
            {
                tile2XLocation = 323;
            }

            else
            {
                tile2XLocation = 489;
            }
        }

        private void btnTile2_Click(object sender, EventArgs e)
        {
            TileTvåClicked();
        }

        void TileTreClicked()
        {

            PlaySound();
            score = score + 1;
            speed = speed + 0.025;
            btnTile4.Enabled = true;
            btnTile3.Enabled = false;
            currentLocationY[2] = (currentLocationY[1] - 150);

            int rndTile3 = slump.Next(1, 5);

            if (rndTile3 == 1)
            {
                tile3XLocation = 28;
            }

            else if (rndTile3 == 2)
            {
                tile3XLocation = 173;
            }

            else if (rndTile3 == 3)
            {
                tile3XLocation = 323;
            }

            else
            {
                tile3XLocation = 489;
            }
        }

        private void btnTile3_Click(object sender, EventArgs e)
        {
            TileTreClicked();
        }

        void TileFyraClicked()
        {

            PlaySound();
            score = score + 1;
            speed = speed + 0.025;
            btnTile1.Enabled = true;
            btnTile4.Enabled = false;
            currentLocationY[3] = (currentLocationY[2] - 150);

            int rndTile4 = slump.Next(1, 5);

            if (rndTile4 == 1)
            {
                tile4XLocation = 28;
            }

            else if (rndTile4 == 2)
            {
                tile4XLocation = 173;
            }

            else if (rndTile4 == 3)
            {
                tile4XLocation = 323;
            }

            else
            {
                tile4XLocation = 489;
            }
        }

        private void btnTile4_Click(object sender, EventArgs e)
        {
            TileFyraClicked();
        }

        void GameOver()
        {
            //Gör så man inte förlorar om igen när man klickar något och har förlorat
            btnTile1.Enabled = false;
            btnTile2.Enabled = false;
            btnTile3.Enabled = false;
            btnTile4.Enabled = false;
            //Gör så låten börjar om
            SpelaDennaLåt = -1;
            // Här ser den till så highscore fungerar.
            if (score > highscore)
            {
                highscore = score;
                lblHighScore.Text = ("High Score: " + highscore);
            }
            speed = 2;
            tmrGame.Enabled = false;
            //Detta görs få man kan se färgen bytas istället för system.threading.thread.sleep(); Då det inte fungerad.
            tmrGameOver.Enabled = true;
            this.BackColor = Color.DarkRed;
        }

        private void tmrGameOver_Tick(object sender, EventArgs e)
        {
            //Efter 0.2 sekunder byts färgen om igen till vitt.
            this.BackColor = Color.White;
            btnStartPianoTiles.Visible = true;
            tmrGameOver.Enabled = false;
        }

        void Pause()
        {
            //Gör så spelet pausas.
            Pausat = 1;
            FörvararSpeed = speed;
            speed = 0;
            btnTile1.Enabled = false;
            btnTile2.Enabled = false;
            btnTile3.Enabled = false;
            btnTile4.Enabled = false;
            btnUnPause.Visible = true;
            btnUnPause.Enabled = true;
        }

        void UnPause()
        {
            //Gör så spelet börjar igen.
            Pausat = 0;
            speed = FörvararSpeed;
            btnTile1.Enabled = true;
            btnTile2.Enabled = true;
            btnTile3.Enabled = true;
            btnTile4.Enabled = true;
            btnUnPause.Visible = false;
            btnUnPause.Enabled = false;
        }

        private void btnUnPause_Click(object sender, EventArgs e)
        {
            UnPause();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //om man klickar på form1 istället för btnTilesen så förlorar man
            GameOver();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (btnTile1.Enabled == true || btnTile2.Enabled == true || btnTile3.Enabled == true || btnTile4.Enabled == true)
            {
                //Detta gör så du kan använda Q, W, E & R som ett alternativ istället för att klicka på tilesen.
                if (keyData == Keys.Q)
                {
                    //Om den Tilen som är längst ner heter Q så blir den klickad.
                    if (btnTile1.Text == "Q" && btnTile1.Enabled == true)
                    {
                        TileEttClicked();
                    }
                    else if (btnTile2.Text == "Q" && btnTile2.Enabled == true)
                    {
                        TileTvåClicked();
                    }
                    else if (btnTile3.Text == "Q" && btnTile3.Enabled == true)
                    {
                        TileTreClicked();
                    }
                    else if (btnTile4.Text == "Q" && btnTile4.Enabled == true)
                    {
                        TileFyraClicked();
                    }
                    else
                    {
                        //om du klickar på Q fast den längst ner inte hette det så körs GameOver.
                        GameOver();
                    }

                    //Gör så ProcessCmdKey slutar köras.
                    return true;
                }
                else if (keyData == Keys.W)
                {
                    //Samma fast med W
                    if (btnTile1.Text == "W" && btnTile1.Enabled == true)
                    {
                        TileEttClicked();
                    }
                    else if (btnTile2.Text == "W" && btnTile2.Enabled == true)
                    {
                        TileTvåClicked();
                    }
                    else if (btnTile3.Text == "W" && btnTile3.Enabled == true)
                    {
                        TileTreClicked();
                    }
                    else if (btnTile4.Text == "W" && btnTile4.Enabled == true)
                    {
                        TileFyraClicked();
                    }
                    else
                    {
                        //Samma fast med W
                        GameOver();
                    }
                    return true;
                }
                else if (keyData == Keys.E)
                {
                    if (btnTile1.Text == "E" && btnTile1.Enabled == true)
                    {
                        TileEttClicked();
                    }
                    else if (btnTile2.Text == "E" && btnTile2.Enabled == true)
                    {
                        TileTvåClicked();
                    }
                    else if (btnTile3.Text == "E" && btnTile3.Enabled == true)
                    {
                        TileTreClicked();
                    }
                    else if (btnTile4.Text == "E" && btnTile4.Enabled == true)
                    {
                        TileFyraClicked();
                    }
                    else
                    {
                        GameOver();
                    }
                    return true;
                }
                else if (keyData == Keys.R)
                {
                    if (btnTile1.Text == "R" && btnTile1.Enabled == true)
                    {
                        TileEttClicked();
                    }
                    else if (btnTile2.Text == "R" && btnTile2.Enabled == true)
                    {
                        TileTvåClicked();
                    }
                    else if (btnTile3.Text == "R" && btnTile3.Enabled == true)
                    {
                        TileTreClicked();
                    }
                    else if (btnTile4.Text == "R" && btnTile4.Enabled == true)
                    {
                        TileFyraClicked();
                    }
                    else
                    {
                        GameOver();
                    }
                    return true;
                }

                //Däremot om man klickar Escape så pausas/Unpausas pianotiles.
                else if (keyData == Keys.Escape)
                {
                    if (Pausat == 1)
                    {
                        UnPause();
                    }
                    else
                    {
                        Pause();
                    }

                    return true;
                }

                else if (keyData == Keys.Enter)
                {
                    if (btnStartPianoTiles.Visible == true)
                    {
                        StartGame();
                    }
                    else if (btnUnPause.Visible == true)
                    {
                        UnPause();
                    }
                    else
                    {
                        GameOver();
                    }

                    return true;
                }
                else
                {
                    //Om du klickar någon knapp som inte är Q,W,E,R eller Escape/enter så körs GameOver.
                    GameOver();
                    return true;
                }
            }

            //Gör så man inte förlorar om man klickar knappar när det är pausat, samt escape och enter unpausar
            else
            {
                //Däremot om man klickar Escape så pausas/Unpausas pianotiles.
                if (keyData == Keys.Escape)
                {
                    if (Pausat == 1)
                    {
                        UnPause();
                    }
                    else
                    {
                        Pause();
                    }

                    return true;
                }

                else if (keyData == Keys.Enter)
                {
                    if (btnStartPianoTiles.Visible == true)
                    {
                        StartGame();
                    }
                    else if (btnUnPause.Visible == true)
                    {
                        UnPause();
                    }
                }
            }
            return true;
        }

        private void pnlMoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            //Tagit från internet men lastClick är en point som sparar Location där du klickar ner & används nedanför.
            lastClick = e.Location;
        }

        private void pnlMoveForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Detta gör så man kan flytta omkring formen när man drar i panelMoveForm
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void btnVolumeOn_Click(object sender, EventArgs e)
        {
            //Gör så musiken inte spelas upp.
            btnVolumeOn.Visible = false;
            btnVolumeOff.Visible = true;
        }

        private void btnVolumeOff_Click(object sender, EventArgs e)
        {
            //Gör så musiken spelas upp igen.
            btnVolumeOn.Visible = true;
            btnVolumeOff.Visible = false;
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            //Information om hur man spelar och använder kontrollerna.
            MessageBox.Show("Press on the black tiles that appear on the screen. If you miss and/or press next to a tile, you lose." + "\r\n" + "Press 'Escape' to pause/unpause the game." + "\r\n" + "You can turn off sound by clicking on the sound icon on the top left of the screen." + "\r\n" + "Minimize the window by clicking on the line on the top right of the screen." + "\r\n" + "Exit the window by clicking on the X on the top right of the screen", "How to play", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMinimizeWindow_Click(object sender, EventArgs e)
        {
            //Minimizar form1.
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            //Stänger av programmet
            this.Close();
        }

        void PlaySound()
        {

            if (btnVolumeOn.Visible == true)
            {

                SpelaDennaLåt += +1;

                if (SpelaDennaLåt == 17)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven18);
                    Fur_Elise.Play();
                    SpelaDennaLåt = -1;
                }
                else if (SpelaDennaLåt == 16)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven17);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 15)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven16);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 14)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven15);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 13)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven14);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 12)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven13);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 11)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven12);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 10)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven11);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 9)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven10);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 8)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven9);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 7)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven8);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 6)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven7);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 5)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven6);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 4)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven5);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 3)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven4);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 2)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven3);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 1)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven2);
                    Fur_Elise.Play();
                }
                else if (SpelaDennaLåt == 0)
                {
                    SoundPlayer Fur_Elise = new SoundPlayer(piano_tiles.Properties.Resources.beethoven1);
                    Fur_Elise.Play();
                }
            }

            else
            {
                return;
            }
        }
    }
}