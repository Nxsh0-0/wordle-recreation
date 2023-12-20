using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace word_game
{
    public partial class Form1 : Form
    {
        List <string> wordlist = new List <string> ();
        static Random rnd = new Random ();
        static string mainword = "";
       static TextBox[] letters = new TextBox[mainword.Length];
       static int lives = 5;
      static  Label live_counter = new Label();
        static bool gameover = false;
        static Image GOimage = word_game.Properties.Resources.gameover;
        static Image WINimage = word_game.Properties.Resources.gameover;
        static char[] wordcheck = mainword.ToCharArray();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                   
                StreamReader file = new StreamReader("../../resources/ukenglish.Txt");
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    if (ln.Length > 3 && ln.Length < 7) wordlist.Add(ln);
                }
                file.Close();
                mainword = wordlist[rnd.Next(wordlist.Count)];
                wordcheck = mainword.ToCharArray();


            live_counter.Location = new Point(50, 50);
                live_counter.Size = new Size(200, 200);
                live_counter.Text = "lives left: " + lives.ToString();
                live_counter.Font = new Font("Source Code Pro", 20, FontStyle.Bold);
                this.Controls.Add(live_counter);


                letters = new TextBox[mainword.Length];

                for (int i = 0; i < mainword.Length; i++)
                {
                    letters[i] = new TextBox();
                    string name = "letter" + (i + 1).ToString();
                    letters[i].Name = name;
                    letters[i].Text = "";
                    letters[i].Font = new Font("Source Code Pro", 45, FontStyle.Bold);
                    letters[i].MinimumSize = new Size(100, 100);
                    letters[i].Location = new Point(50 + (i * 100), 250);
                    letters[i].Size = new Size(100, 100);
                    letters[i].BackColor = Color.Black;
                    letters[i].ForeColor = Color.White;
                    letters[i].MaxLength = 1;
                    letters[i].Visible = true;
                    letters[i].KeyDown += new KeyEventHandler(letters_changed);
                    this.Controls.Add(letters[i]);
                }
            
            

            
            
        }
        public void letters_changed(object sender, KeyEventArgs e)
        {       
            var button = sender;
         
                if (e.KeyCode == Keys.Enter)
                {
                int match = 0;
                for(int i = 0; i<mainword.Length; i++)
                {
                    char letter = Char.Parse(letters[i].Text);
                    if (letter == mainword[i]) match++;
                }
                if(match == mainword.Length)
                {
                    WIN.Visible = true;
                    WIN.BringToFront();
                    YES.Visible = true;
                    tryagain.Visible = true;
                }

               else if (lives > 0)
                {
                    lives--;
                    live_counter.Text = "lives left: " + lives.ToString();
                    
                    for (int i = 0; i < mainword.Length; i++)
                    {
                        if (letters[i].Text != null)
                        {
                            char letter = Char.Parse(letters[i].Text);
                            if (letter == mainword[i])
                            {
                                letters[i].BackColor = Color.Green;
                                wordcheck[i] = ' '; //wordcheck checks for repeating letters in the word
                            }
                            else if (mainword.Contains(letter) && wordcheck.Contains(letter))
                            {
                                letters[i].BackColor = Color.Yellow; letters[i].Text = ""; wordcheck[i] = ' ';
                                if (letter == 'a') { textBox1.Visible = true; textBox1.BackColor = letters[i].BackColor; }
                                else if (letter == 'b') { textBox2.Visible = true; textBox2.BackColor = letters[i].BackColor; }
                                else if (letter == 'c') { textBox3.Visible = true; textBox3.BackColor = letters[i].BackColor; }
                                else if (letter == 'd') { textBox4.Visible = true; textBox4.BackColor = letters[i].BackColor; }
                                else if (letter == 'e') { textBox5.Visible = true; textBox5.BackColor = letters[i].BackColor; }
                                else if (letter == 'f') { textBox6.Visible = true; textBox6.BackColor = letters[i].BackColor; }
                                else if (letter == 'g') { textBox7.Visible = true; textBox7.BackColor = letters[i].BackColor; }
                                else if (letter == 'h') { textBox8.Visible = true; textBox8.BackColor = letters[i].BackColor; }
                                else if (letter == 'i') { textBox9.Visible = true; textBox9.BackColor = letters[i].BackColor; }
                                else if (letter == 'j') { textBox10.Visible = true; textBox10.BackColor = letters[i].BackColor; }
                                else if (letter == 'k') { textBox11.Visible = true; textBox11.BackColor = letters[i].BackColor; }
                                else if (letter == 'l') { textBox12.Visible = true; textBox12.BackColor = letters[i].BackColor; }
                                else if (letter == 'm') { textBox13.Visible = true; textBox13.BackColor = letters[i].BackColor; }
                                else if (letter == 'n') { textBox14.Visible = true; textBox14.BackColor = letters[i].BackColor; }
                                else if (letter == 'o') { textBox15.Visible = true; textBox15.BackColor = letters[i].BackColor; }
                                else if (letter == 'p') { textBox16.Visible = true; textBox16.BackColor = letters[i].BackColor; }
                                else if (letter == 'q') { textBox17.Visible = true; textBox17.BackColor = letters[i].BackColor; }
                                else if (letter == 'r') { textBox18.Visible = true; textBox18.BackColor = letters[i].BackColor; }
                                else if (letter == 's') { textBox19.Visible = true; textBox19.BackColor = letters[i].BackColor; }
                                else if (letter == 't') { textBox20.Visible = true; textBox20.BackColor = letters[i].BackColor; }
                                else if (letter == 'u') { textBox21.Visible = true; textBox21.BackColor = letters[i].BackColor; }
                                else if (letter == 'v') { textBox22.Visible = true; textBox22.BackColor = letters[i].BackColor; }
                                else if (letter == 'w') { textBox23.Visible = true; textBox23.BackColor = letters[i].BackColor; }
                                else if (letter == 'x') { textBox24.Visible = true; textBox24.BackColor = letters[i].BackColor; }
                                else if (letter == 'y') { textBox25.Visible = true; textBox25.BackColor = letters[i].BackColor; }
                                else textBox26.Visible = true; textBox26.BackColor = letters[i].BackColor;

                            }
                            else if (mainword.Contains(letter) == false)
                            {
                                letters[i].BackColor = Color.Red; letters[i].Text = "";
                                if (letter == 'a') { textBox1.Visible = true; textBox1.BackColor = letters[i].BackColor; }
                                else if (letter == 'b') { textBox2.Visible = true; textBox2.BackColor = letters[i].BackColor; }
                                else if (letter == 'c') { textBox3.Visible = true; textBox3.BackColor = letters[i].BackColor; }
                                else if (letter == 'd') { textBox4.Visible = true; textBox4.BackColor = letters[i].BackColor; }
                                else if (letter == 'e') { textBox5.Visible = true; textBox5.BackColor = letters[i].BackColor; }
                                else if (letter == 'f') { textBox6.Visible = true; textBox6.BackColor = letters[i].BackColor; }
                                else if (letter == 'g') { textBox7.Visible = true; textBox7.BackColor = letters[i].BackColor; }
                                else if (letter == 'h') { textBox8.Visible = true; textBox8.BackColor = letters[i].BackColor; }
                                else if (letter == 'i') { textBox9.Visible = true; textBox9.BackColor = letters[i].BackColor; }
                                else if (letter == 'j') { textBox10.Visible = true; textBox10.BackColor = letters[i].BackColor; }
                                else if (letter == 'k') { textBox11.Visible = true; textBox11.BackColor = letters[i].BackColor; }
                                else if (letter == 'l') { textBox12.Visible = true; textBox12.BackColor = letters[i].BackColor; }
                                else if (letter == 'm') { textBox13.Visible = true; textBox13.BackColor = letters[i].BackColor; }
                                else if (letter == 'n') { textBox14.Visible = true; textBox14.BackColor = letters[i].BackColor; }
                                else if (letter == 'o') { textBox15.Visible = true; textBox15.BackColor = letters[i].BackColor; }
                                else if (letter == 'p') { textBox16.Visible = true; textBox16.BackColor = letters[i].BackColor; }
                                else if (letter == 'q') { textBox17.Visible = true; textBox17.BackColor = letters[i].BackColor; }
                                else if (letter == 'r') { textBox18.Visible = true; textBox18.BackColor = letters[i].BackColor; }
                                else if (letter == 's') { textBox19.Visible = true; textBox19.BackColor = letters[i].BackColor; }
                                else if (letter == 't') { textBox20.Visible = true; textBox20.BackColor = letters[i].BackColor; }
                                else if (letter == 'u') { textBox21.Visible = true; textBox21.BackColor = letters[i].BackColor; }
                                else if (letter == 'v') { textBox22.Visible = true; textBox22.BackColor = letters[i].BackColor; }
                                else if (letter == 'w') { textBox23.Visible = true; textBox23.BackColor = letters[i].BackColor; }
                                else if (letter == 'x') { textBox24.Visible = true; textBox24.BackColor = letters[i].BackColor; }
                                else if (letter == 'y') { textBox25.Visible = true; textBox25.BackColor = letters[i].BackColor; }
                                else textBox26.Visible = true; textBox26.BackColor = letters[i].BackColor;
                            }
                        }
                    }
                }
                else
                {
                    live_counter.Text = "GAME OVER";
                    GOscr.Visible = true;
                    YES.Visible = true;
                    tryagain.Visible = true;
                    Label answer = new Label();
                    answer.Text = "The correct word was: " + mainword;
                    answer.Location = new Point(332, 402);
                    answer.Size = new Size(200, 350);
                    answer.BringToFront();
                    answer.Font = new Font("Source Code Pro", 15, FontStyle.Bold);
                    this.Controls.Add(answer); 

                }

            }               
            
        }

        private void YES_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
