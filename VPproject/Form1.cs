using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPproject
{
    public partial class Form1 : Form
    {
        static List<Question> questions = new List<Question>();
        static int questionNumber = 0;
        static int currentQuestionID = 0;
        static Question currentQuestion;
        static List<Question> easyQuestions = new List<Question>();
        static List<Question> advancedQuestions = new List<Question>();
        static List<Question> hardQuestions = new List<Question>();
        static int questionID = 0;
        static List<int> alreadyChosen;
        public Form1()
        {
            readQuestions();
           
            questions = easyQuestions;
            InitializeComponent();
            newQuestion();
            
        }

        public void newQuestion()
        {
            questionNumber += 1;
            setActiveQuestion(questionNumber);
            if (questionNumber == 6)
            {
                questions = advancedQuestions;
            }
            if(questionNumber == 11)
            {
                questions = hardQuestions;
            }

            if (questionNumber == 16)
            {
                string promptValue = Prompt.ShowDialog("You win! Do you want to play again?", "123");
                if (promptValue == "NO")
                {
                    this.Close();
                }
                else if (promptValue == "OK")
                {
                    Random rnd = new Random();
                    questionNumber = 0;
                    currentQuestionID = currentQuestionID = rnd.Next(1, easyQuestions.Count);
                    questions = easyQuestions;
                    newQuestion();
                }
            }
            else
            {
                currentQuestion = (Question)questions.Where(question => question.id == currentQuestionID).FirstOrDefault();
                setQuestionText(currentQuestion.QuestionText);
                setAnswers(currentQuestion.answers);
            }
        }

        public bool checkIfCorrect(int selAns)
        {
            if (currentQuestion.answers[selAns] == currentQuestion.correctAnswer)
            {
                return true;
            }
            else return false;
        }
        private void answer1_Click(object sender, EventArgs e)
        {
            int selAns = 1;
            bool correct = checkIfCorrect(selAns - 1);

            if (correct)
            {
                Random rnd = new Random();
                if (questionNumber <= 5)
                {
                    currentQuestionID = rnd.Next(1, easyQuestions.Count);
                }
                if (questionNumber >= 5 && questionNumber <= 10)
                {
                    currentQuestionID = rnd.Next(1, advancedQuestions.Count);
                }
                if (questionNumber >= 10)
                {
                    currentQuestionID = rnd.Next(1, hardQuestions.Count);
                }
                newQuestion();
            }
            else
            {
                string promptValue = Prompt.ShowDialog("You louse. Do you want to start over?", "123");
                if (promptValue == "NO")
                {
                    this.Close();
                }
                else if (promptValue == "OK")
                {
                    Random rnd = new Random();
                    questionNumber = 0;
                    currentQuestionID = currentQuestionID = rnd.Next(1, easyQuestions.Count);
                    questions = easyQuestions;
                    newQuestion();
                }
            }
        }
        private void answer1_MouseEnter(object sender, EventArgs e)
        {
            this.answer1.BackColor = Color.Green;
        }
        private void answer1_MouseLeave(object sender, EventArgs e)
        {
            this.answer1.BackColor = Color.Black;
        }

        private void answer2_Click(object sender, EventArgs e)
        {
            int selAns = 2;
            bool correct = checkIfCorrect(selAns - 1);

            if (correct)
            {
                Random rnd = new Random();
                if (questionNumber <= 5)
                {
                    currentQuestionID = rnd.Next(1, easyQuestions.Count);
                }
                if (questionNumber >= 5 && questionNumber <= 10)
                {
                    currentQuestionID = rnd.Next(1, advancedQuestions.Count);
                }
                if (questionNumber >= 10)
                {
                    currentQuestionID = rnd.Next(1, hardQuestions.Count);
                }
                newQuestion();
            }
            else
            {
                string promptValue = Prompt.ShowDialog("You louse. Do you want to start over?", "123");
                if (promptValue == "NO")
                {
                    this.Close();
                }
                else if (promptValue == "OK")
                {
                    Random rnd = new Random();
                    questionNumber = 0;
                    currentQuestionID = currentQuestionID = rnd.Next(1, easyQuestions.Count);
                    questions = easyQuestions;
                    newQuestion();
                }
            }
        }
        private void answer2_MouseEnter(object sender, EventArgs e)
        {
            this.answer2.BackColor = Color.Green;
        }
        private void answer2_MouseLeave(object sender, EventArgs e)
        {
            this.answer2.BackColor = Color.Black;
        }

        private void answer3_Click(object sender, EventArgs e)
        {
            int selAns = 3;
            bool correct = checkIfCorrect(selAns - 1);

            if (correct)
            {
                Random rnd = new Random();
                if (questionNumber <= 5)
                {
                    currentQuestionID = rnd.Next(1, easyQuestions.Count);
                }
                if (questionNumber >= 5 && questionNumber <= 10)
                {
                    currentQuestionID = rnd.Next(1, advancedQuestions.Count);
                }
                if (questionNumber >= 10)
                {
                    currentQuestionID = rnd.Next(1, hardQuestions.Count);
                }
                newQuestion();
            }
            else
            {
                string promptValue = Prompt.ShowDialog("You louse. Do you want to start over?", "123");
                if (promptValue == "NO")
                {
                    this.Close();
                }
                else if (promptValue == "OK")
                {
                    Random rnd = new Random();
                    questionNumber = 0;
                    currentQuestionID = currentQuestionID = rnd.Next(1, easyQuestions.Count);
                    questions = easyQuestions;
                    newQuestion();
                }
            }
        }
        private void answer3_MouseEnter(object sender, EventArgs e)
        {
            this.answer3.BackColor = Color.Green;
        }
        private void answer3_MouseLeave(object sender, EventArgs e)
        {
            this.answer3.BackColor = Color.Black;
        }

        private void answer4_Click(object sender, EventArgs e)
        {
            int selAns = 4;
            bool correct = checkIfCorrect(selAns - 1);

            if (correct)
            {
                Random rnd = new Random();
                if (questionNumber <= 5)
                {
                    currentQuestionID = rnd.Next(1, easyQuestions.Count);
                }
                if (questionNumber >= 5 && questionNumber <= 10)
                {
                    currentQuestionID = rnd.Next(1, advancedQuestions.Count);
                }
                if (questionNumber >= 10)
                {
                    currentQuestionID = rnd.Next(1, hardQuestions.Count);
                }
                newQuestion();
            }
            else
            {
                string promptValue = Prompt.ShowDialog("You louse. Do you want to start over?", "123");
                if (promptValue == "NO")
                {
                    this.Close();
                }
                else if (promptValue == "OK")
                {
                    Random rnd = new Random();
                    questionNumber = 0;
                    currentQuestionID = currentQuestionID = rnd.Next(1, easyQuestions.Count);
                    questions = easyQuestions;
                    newQuestion();
                }
            }
        }
        private void answer4_MouseEnter(object sender, EventArgs e)
        {
            this.answer4.BackColor = Color.Green;
        }
        private void answer4_MouseLeave(object sender, EventArgs e)
        {
            this.answer4.BackColor = Color.Black;
        }
        public void readQuestions() {
            string[] easyQuestionLines = System.IO.File.ReadAllLines(@"..\\..\\easyQuestions.txt");
            Question eq;
            for(int i =0; i < easyQuestionLines.Length; i+=7)
            {
                string[] ans = new string[4] { easyQuestionLines[i+1], easyQuestionLines[i + 2], easyQuestionLines[i + 3], easyQuestionLines[i + 4] };
                eq = new Question(questionID,easyQuestionLines[i], ans, easyQuestionLines[i+5]);
                questionID++;
                easyQuestions.Add(eq);
            }
            questionID = 0;
            string[] advancedQuestionLines = System.IO.File.ReadAllLines(@"..\\..\\advancedQuestions.txt");
            Question aq;
            for (int i = 0; i < advancedQuestionLines.Length; i += 7)
            {
                string[] ans = new string[4] { advancedQuestionLines[i + 1], advancedQuestionLines[i + 2], advancedQuestionLines[i + 3], advancedQuestionLines[i + 4] };
                aq = new Question(questionID, advancedQuestionLines[i], ans, advancedQuestionLines[i + 5]);
                questionID++;
                advancedQuestions.Add(aq);
            }
            questionID = 0;
            string[] hardQuestionLines = System.IO.File.ReadAllLines(@"..\\..\\hardQuestions.txt");
            Question hq;
            for (int i = 0; i < hardQuestionLines.Length; i += 7)
            {
                string[] ans = new string[4] { hardQuestionLines[i + 1], hardQuestionLines[i + 2], hardQuestionLines[i + 3], hardQuestionLines[i + 4] };
                hq = new Question(questionID, hardQuestionLines[i], ans, hardQuestionLines[i + 5]);
                questionID++;
                hardQuestions.Add(hq);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int correct = 1;
            for (int i = 0; i < 4; i++)
            {
                if (currentQuestion.answers[i] == currentQuestion.correctAnswer)
                    correct = i;
            }

            List<int> n = new List<int>();
            n.Add(1);
            n.Add(2);
            n.Add(3);
            n.Add(4);
            n.RemoveAt(correct);
            Random rnd = new Random();
            int first = rnd.Next(0, n.Count);
            n.RemoveAt(first);

            if(n[0]==1 || n[1]==1)
            {
                this.answer1.Text = "";
            }
            if (n[0] == 2 || n[1] == 2)
            {
                this.answer2.Text = "";
            }
            if (n[0] == 3 || n[1] == 3)
            {
                this.answer3.Text = "";
            }
            if (n[0] == 4 || n[1] == 4)
            {
                this.answer4.Text = "";
            }
            this.button1.Enabled = false;
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string val;
            if (questionNumber <= 5)
            {
                val = currentQuestion.correctAnswer + "  90%";
            }
            else if (questionNumber >= 5 && questionNumber <= 10)
            {
                val = currentQuestion.correctAnswer + "  70%";
            }
            else
            {
                val = currentQuestion.correctAnswer + "  50%";
            }
            string promptValue = Prompt.ShowDialog(val , "123");
            this.button2.Enabled = false;
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.ForeColor = System.Drawing.Color.Yellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int correct = 1;
            for (int i = 0; i < 4; i++)
            {
                if (currentQuestion.answers[i] == currentQuestion.correctAnswer)
                    correct = i;
            }
            string[] s = new string[4] { "A: ", "B: ", "C: ", "D: " };
            Random rnd = new Random();
            int win1 = rnd.Next(70, 100);
            s[correct] += win1 + "%";
            List<int> n = new List<int>();
            n.Add(1);
            n.Add(2);
            n.Add(3);
            n.Add(4);
            n.RemoveAt(correct);
            int next = rnd.Next(0, n.Count);
            int win2 = (100 - win1);
            s[n[next]-1] += win2 + "%";
            string promptValue = Prompt.ShowDialog(String.Join(" " ,s) , "123");
            this.button3.Enabled = false;
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.ForeColor = System.Drawing.Color.Yellow;
        }
    }
    class Question {
        public int id;
        public string QuestionText;
        public string[] answers;
        public string correctAnswer;
        public Question(int _id, string _QuestionText, string[] _answers, string _correctAnswer) {
            id = _id;
            QuestionText = _QuestionText;
            answers = _answers;
            correctAnswer = _correctAnswer;
        }
    }
}
