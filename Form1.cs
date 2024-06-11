using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Create an array of questions
        string[] questions = { "What is POP3 port number ? ", "What is IMAP port number ?", "What is SMTP port number ?",
            "What is RDP port number ?", "What is FTP port number ?","What is DNS port number ?", "What is Telnet port number ?",
        "What is DHCP Port number ?", "What is NetBios port number ?", "What is SFTP port number ?", "What is LDAP port number ?",
        "What is SNMP port number ?", "What is SMB port number ?", "What is HTTP port number ?", "What is HTTPS port number ?"};

        //create an array of options
        //5 questions 
        //5 options
        //the last option will be the correct answer
        //and we will use it to check if the user selected the correct answer
        string[,] options = new string[15, 5] {
            {"110","2650","2648","2645","110"},
            {"67","143","68","54","143"},
            {"132","25","147","146","25"},
            {"2334","3388","3345","3389","3389"},
            {"87","45","21","16","21"},
            {"53","45","21","16","53"},
            {"53","23","21","16","23"},
            {"53","67","21","16","67"},
            {"137","130","210","160","137"},
            {"53","23","22","16","22"},
            {"532","389","210","165","389"},
            {"133","232","212","161","161"},
            {"445","234","212","165","445"},
            {"93","83","27","80","80"},
            {"87","443","449","448","443"},
        };

        int index = 0;
        int correct = 0;
        //int correctMove = 4;

        //Function to check if the user has selected the correct answer
        public void checkAnswer(RadioButton rbt)
        {
            if (rbt.Text.Equals(options[index, 4]))
            {
                correct++;
                rbt.BackColor = Color.Green;
            }
            else
            {
                rbt.BackColor = Color.Red;
            }
           
            index++;
            

        }

        //Function to uncheck radiobuttons
        public void uncheck()
        {
            answer1rbt.Checked = false;
            answer2rbt.Checked = false;
            answer3rbt.Checked = false;
            answer4rbt.Checked = false;
        }
        //Function to change radiobuttons backcolor and color
        public void resetRadio()
        {
            foreach(Control c in this.Controls)
            {
                if(c is RadioButton)
                {
                    RadioButton rbt = (RadioButton)c;
                    rbt.BackColor = Color.White;
                    rbt.ForeColor = Color.Black;
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

            //Display the question
            QuestionsRtb.Text = questions[index];

            //Display options
            answer1rbt.Text = options[index, 0];
            answer2rbt.Text = options[index, 1];
            answer3rbt.Text = options[index, 2];
            answer4rbt.Text = options[index, 3];
            
            uncheck();


        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            resetRadio();

            if (nextbtn.Text.Equals("Restart The Quiz"))
            {
                index = 0;
                correct = 0;
                QuestionsRtb.BackColor = Color.Aquamarine;
                QuestionsRtb.ForeColor = Color.Blue;
                nextbtn.Text = "Next";

            }
            if(index == questions.Length)
            {
                QuestionsRtb.Text = "Your score :" + correct + " / " + questions.Length;

                if(correct >= questions.Length / 2)
                {
                    QuestionsRtb.BackColor = Color.Bisque;
                    QuestionsRtb.ForeColor = Color.BurlyWood;
                }
                else
                {
                    QuestionsRtb.BackColor = Color.Coral;
                    QuestionsRtb.ForeColor = Color.Crimson;
                }
                nextbtn.Text = "Restart The Quiz";
            }
            else
            {
              

                //uncheck radiobuttons
                uncheck();

                //Display the question
                QuestionsRtb.Text = questions[index];

                //Display options
                answer1rbt.Text = options[index, 0];
                answer2rbt.Text = options[index, 1];
                answer3rbt.Text = options[index, 2];
                answer4rbt.Text = options[index, 3];

                if(index == questions.Length - 1)
                {
                    nextbtn.Text = "Almost Time For Results";
                }

            }

             
        }

        private void answer1rbt_Click(object sender, EventArgs e)
        {
            checkAnswer(answer1rbt);
            
        }

        private void answer2rbt_Click(object sender, EventArgs e)
        {
            checkAnswer(answer2rbt);
        }

        private void answer3rbt_Click(object sender, EventArgs e)
        {
            checkAnswer(answer3rbt);
        }

        private void answer4rbt_Click(object sender, EventArgs e)
        {
            checkAnswer(answer4rbt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
