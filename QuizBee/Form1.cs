using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuizBee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int easy = 0, average = 0, difficult = 0, totalscore = 0, points1 = 0, points2 = 0, points3 = 0;

        private void questions()
        {
            //EASY QUESTIONS
            if (easy == 1)
            {
                label2.Text = easy + ".) What is the largest planet in our solar system?";
                radioButton1.Text = "Earth"; radioButton2.Text = "Jupiter"; radioButton3.Text = "Saturn"; radioButton4.Text = "Mars";
            }
            else if (easy == 2)
            {
                label2.Text = easy + ".) What is the largest ocean on Earth?";
                radioButton1.Text = "Atlantic Ocean"; radioButton2.Text = "Indian Ocean"; radioButton3.Text = "Southern Ocean"; radioButton4.Text = "Pacific Ocean";
            }
            else if (easy == 3)
            {
                label2.Text = easy + ".) What is the largest organ in the human body?";
                radioButton1.Text = "Heart"; radioButton2.Text = "Liver"; radioButton3.Text = "Skin"; radioButton4.Text = "Brain";
            }
            else if (easy == 4)
            {
                label2.Text = easy + ".) What is the chemical symbol for water?";
                radioButton1.Text = "H2O"; radioButton2.Text = "CO2"; radioButton3.Text = "O2"; radioButton4.Text = "NaCl";
            }
            else if (easy == 5)
            {
                label2.Text = easy + ".) Which of the following is a primary color?";
                radioButton1.Text = "Green"; radioButton2.Text = "Orange"; radioButton3.Text = "Purple"; radioButton4.Text = "Red";
            }
            //AVERAGE QUESTIONS
            else if (average == 1)
            {
                label2.Text = average + ".)  In computer science, what does the acronym \"HTML\" stand for?";
                radioButton1.Text = "HyperText Markup Language"; radioButton2.Text = "High-Level Programming Language"; radioButton3.Text = "Human-Machine Learning"; radioButton4.Text = "Hyperlink and Text Management Language";
            }
            else if (average == 2)
            {
                label2.Text = average + ".) Which element has the chemical symbol \"O\"?";
                radioButton1.Text = "Oxygen"; radioButton2.Text = "Osmium"; radioButton3.Text = "Oganesson"; radioButton4.Text = "Odium";
            }
            else if (average == 3)
            {
                label2.Text = average + ".) In which year did the Titanic sink?";
                radioButton1.Text = "1905"; radioButton2.Text = "1912"; radioButton3.Text = "1920"; radioButton4.Text = "1931";
            }
            else if (average == 4)
            {
                label2.Text = average + ".) What is the process of a caterpillar transforming into a butterfly called?";
                radioButton1.Text = "Metamorphosis"; radioButton2.Text = "Photosynthesis"; radioButton3.Text = "Germination"; radioButton4.Text = "Evolution";
            }
            else if (average == 5)
            {
                label2.Text = average + ".) What is the largest internal organ in the human body?";
                radioButton1.Text = "Heart"; radioButton2.Text = "Liver"; radioButton3.Text = "Kidney"; radioButton4.Text = "Lungs";
            }
            //DIFFICULT QUESTIONS
            else if (difficult == 1)
            {
                label2.Text = difficult + ".) What is the chemical symbol for gold?";
                radioButton1.Text = "Au"; radioButton2.Text = "Ag"; radioButton3.Text = "Fe"; radioButton4.Text = "Hg";
            }
            else if (difficult == 2)
            {
                label2.Text = difficult + ".) Who wrote the play \"Romeo and Juliet\"?";
                radioButton1.Text = "Mark Twain"; radioButton2.Text = "Charles Dickens"; radioButton3.Text = "Jane Austen"; radioButton4.Text = "William Shakespeare";
            }
            else if (difficult == 3)
            {
                label2.Text = difficult + ".) What is the process by which plants make their own food using sunlight?";
                radioButton1.Text = "Transpiration"; radioButton2.Text = "Respiration"; radioButton3.Text = "Photosynthesis"; radioButton4.Text = "Fermentation";
            }
            else if (difficult == 4)
            {
                label2.Text = difficult + ".) In computer science, what does the acronym \"URL\" stand for?";
                radioButton1.Text = "Universal Resource Locator"; radioButton2.Text = "Uniform Resource Locator"; radioButton3.Text = "Unified Resource Language"; radioButton4.Text = "Universal Retrieval Language";
            }
            else if (difficult == 5)
            {
                label2.Text = difficult + ".) Which planet is known as the \"Red Planet\" in our solar system?";
                radioButton1.Text = "Mars"; radioButton2.Text = "Jupiter"; radioButton3.Text = "Saturn"; radioButton4.Text = "Venus";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            easy++;
            button1.Enabled = false; button2.Visible = false; button3.Visible = false; button4.Visible = false; button5.Visible = false;
            panel1.Visible = true; 
            questions();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            label1.Visible = true; button1.Visible = true; button2.Visible = true; button3.Visible = true; button4.Visible = true; button5.Visible = true;
            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            average++;
            button2.Enabled = false; button1.Visible = false; button3.Visible = false; button4.Visible = false; button5.Visible = false;
            panel1.Visible = true; 
            questions();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            difficult++;
            button3.Enabled = false; button1.Visible = false; button2.Visible = false; button4.Visible = false; button5.Visible = false;
            panel1.Visible = true; 
            questions();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            label1.Visible = false; button1.Visible = false; button2.Visible = false; button3.Visible = false; button4.Visible = false; button5.Visible = false;
            panel2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anthony P. Amiluddin\nBSCS - 1A\nSubject in C#");
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label25.Visible = false;
            button5.Enabled = false; button7.Visible = false;
            groupBox1.Visible = false; groupBox2.Visible = false; groupBox3.Visible = false;
            panel1.Visible = false; panel2.Visible = false;
            label2.MaximumSize = new Size(465, 0);
            label2.AutoSize = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (easy == 1 || easy == 2 || easy == 3 || easy == 4 || easy == 5)
            {
                if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
                {
                    if (easy == 1) { if (radioButton2.Checked) { totalscore++; points1++; label6.Text = "1.) Correct"; MessageBox.Show("Correct! You gained 1 point."); } else { label6.Text = "1.) Wrong"; MessageBox.Show("Wrong!"); } }
                    if (easy == 2) { if (radioButton4.Checked) { totalscore++; points1++; label7.Text = "2.) Correct"; MessageBox.Show("Correct! You gained 1 point."); } else { label7.Text = "2.) Wrong"; MessageBox.Show("Wrong!"); } }
                    if (easy == 3) { if (radioButton3.Checked) { totalscore++; points1++; label8.Text = "3.) Correct"; MessageBox.Show("Correct! You gained 1 point."); } else { label8.Text = "3.) Wrong"; MessageBox.Show("Wrong!"); } }
                    if (easy == 4) { if (radioButton1.Checked) { totalscore++; points1++; label9.Text = "4.) Correct"; MessageBox.Show("Correct! You gained 1 point."); } else { label9.Text = "4.) Wrong"; MessageBox.Show("Wrong!"); } }
                    if (easy == 5) { if (radioButton4.Checked) { totalscore++; points1++; label10.Text = "5.) Correct"; MessageBox.Show("Correct! You gained 1 point."); } else { label10.Text = "5.) Wrong"; MessageBox.Show("Wrong!"); } }
                    easy++; questions(); radioButton1.Checked = false; radioButton2.Checked = false; radioButton3.Checked = false; radioButton4.Checked = false;
                }
                else { MessageBox.Show("Please select an answer."); }
                if (easy == 6) { panel1.Visible = false; groupBox1.Visible = true; label21.Visible = false; button2.Visible = true; button3.Visible = true; button4.Visible = true; button5.Visible = true; label22.Text = "Points Gained: " + points1; }
            }
            if (average == 1 || average == 2 || average == 3 || average == 4 || average == 5)
            {
                if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
                {
                    if (average == 1) { if (radioButton1.Checked) { totalscore += 3; points2 += 3; label11.Text = "1.) Correct"; MessageBox.Show("Correct! You gained 3 points."); } else { label11.Text = "1.) Wrong"; MessageBox.Show("Wrong!"); } }
                    if (average == 2) { if (radioButton1.Checked) { totalscore += 3; points2 += 3; label12.Text = "2.) Correct"; MessageBox.Show("Correct! You gained 3 points."); } else { label12.Text = "2.) Wrong"; MessageBox.Show("Wrong!"); } }
                    if (average == 3) { if (radioButton2.Checked) { totalscore += 3; points2 += 3; label13.Text = "3.) Correct"; MessageBox.Show("Correct! You gained 3 points."); } else { label13.Text = "3.) Wrong"; MessageBox.Show("Wrong!"); } }
                    if (average == 4) { if (radioButton1.Checked) { totalscore += 3; points2 += 3; label14.Text = "4.) Correct"; MessageBox.Show("Correct! You gained 3 points."); } else { label14.Text = "4.) Wrong"; MessageBox.Show("Wrong!"); } }
                    if (average == 5) { if (radioButton2.Checked) { totalscore += 3; points2 += 3; label15.Text = "5.) Correct"; MessageBox.Show("Correct! You gained 3 points."); } else { label15.Text = "5.) Wrong"; MessageBox.Show("Wrong!"); } }
                    average++; questions(); radioButton1.Checked = false; radioButton2.Checked = false; radioButton3.Checked = false; radioButton4.Checked = false; 
                }
                else { MessageBox.Show("Please select an answer."); }
                if (average == 6) { panel1.Visible = false; groupBox2.Visible = true; label21.Visible = false; button1.Visible = true; button3.Visible = true; button4.Visible = true; button5.Visible = true; label23.Text = "Points Gained: " + points2; }
            }
            if (difficult == 1 || difficult == 2 || difficult == 3 || difficult == 4 || difficult == 5)
            {
                if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
                {
                    if (difficult == 1) { if (radioButton1.Checked) { totalscore += 5; points3 += 5; label16.Text = "1.) Correct"; MessageBox.Show("Correct! You gained 5 points."); } else { label16.Text = "1.) Wrong"; MessageBox.Show("Wrong!"); } }
                    if (difficult == 2) { if (radioButton4.Checked) { totalscore += 5; points3 += 5; label17.Text = "2.) Correct"; MessageBox.Show("Correct! You gained 5 points."); } else { label17.Text = "2.) Wrong"; MessageBox.Show("Wrong!"); } }
                    if (difficult == 3) { if (radioButton3.Checked) { totalscore += 5; points3 += 5; label18.Text = "3.) Correct"; MessageBox.Show("Correct! You gained 5 points."); } else { label18.Text = "3.) Wrong"; MessageBox.Show("Wrong!"); } }
                    if (difficult == 4) { if (radioButton2.Checked) { totalscore += 5; points3 += 5; label19.Text = "4.) Correct"; MessageBox.Show("Correct! You gained 5 points."); } else { label19.Text = "4.) Wrong"; MessageBox.Show("Wrong!"); } }
                    if (difficult == 5) { if (radioButton1.Checked) { totalscore += 5; points3 += 5; label20.Text = "5.) Correct"; MessageBox.Show("Correct! You gained 5 points."); } else { label20.Text = "5.) Wrong"; MessageBox.Show("Wrong!"); } }
                    difficult++; questions(); radioButton1.Checked = false; radioButton2.Checked = false; radioButton3.Checked = false; radioButton4.Checked = false;
                }
                else { MessageBox.Show("Please select an answer."); }
                if (difficult == 6) { panel1.Visible = false; groupBox3.Visible = true; label21.Visible = false; button1.Visible = true; button2.Visible = true; button4.Visible = true; button5.Visible = true; label24.Text = "Points Gained: " + points3; }
            }
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false)
            {
                button5.Enabled = true;
            }
            if (easy == 6 && average == 6 && difficult == 6) { label25.Text = "Total Score: " + totalscore; label25.Visible = true; }
        }
    }
}
