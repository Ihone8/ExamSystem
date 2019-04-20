using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamSystem.Services;
using ExamSystem.Models;
using System.Threading.Tasks;
using System.Threading;
namespace ExamSystem
{
    public partial class frmExam : Form
    {

        QuestionService _QuestionService = new QuestionService();
        ChoiseService _ChoiseService = new ChoiseService();
        private RadioButton RadioButton;
        private QUESTION _question;
        private int Count = 0;
        private List<QUESTION> AllQuestions;
        private List<Button> buttons;
        public frmExam()
        {
            InitializeComponent();
            AllQuestions = _QuestionService.GetList().ToList();
            for (int i = 0; i < AllQuestions.Count; i++)
            {
                Button btn = new Button();
                btn.Height = 40;
                btn.Text = (i + 1).ToString();
                btn.Tag = AllQuestions[i];
                btn.BackColor = AllQuestions[i].Choises.Where(o => o.IsCheck == 0).Count() > 0 ? Color.White : Color.Orange;
                btn.Font = new Font(Font.FontFamily, 17);
                btn.Click += MyButtonClick;
                tableQuestions.Controls.Add(btn);
            }
        }

        private void frmExam_Load(object sender, EventArgs e)
        {
            _question = AllQuestions[Count];
            this.Text = $"咸鱼考试 -- {_question.Categroy.Name}";
            BindFormData(_question);
        }

        public void BindFormData(QUESTION question)
        {
            lblQuestionName.Text = $"{Count + 1}、{question.Name}";
            rbA.Text = $"A: {question.Choises[0].Name}";
            rbA.Checked = question.Choises[0].IsCheck == 0 ? true : false;
            rbB.Text = $"B: {question.Choises[1].Name}";
            rbB.Checked = question.Choises[1].IsCheck == 0 ? true : false;
            rbC.Text = $"C: {question.Choises[2].Name}";
            rbC.Checked = question.Choises[2].IsCheck == 0 ? true : false;
            rbD.Text = $"D: {question.Choises[3].Name}";
            rbD.Checked = question.Choises[3].IsCheck == 0 ? true : false;
        }

        private void MyButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Count = Convert.ToInt32(btn.Text) - 1;
            _question = btn.Tag as QUESTION;
            if (_question.Choises.Where(o => o.IsCheck == 0).Count() > 0)
            {
                btn.BackColor = Color.White;
            }
            BindFormData(_question);

        }
        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            ChangeAnswer(rbA);
        }
        public void ChangeAnswer(RadioButton radioButton)
        {
            if (radioButton.Checked)
            {
                var chiose = _question.Choises.Where(o => o.Name == radioButton.Text.Split(':')[1].Trim()).FirstOrDefault();
                if (chiose != null)
                {
                    chiose.IsCheck = 0;
                    var list = _question.Choises.Where(o => o.Id != chiose.Id).ToList();
                    list.ForEach(o => o.IsCheck = 1);
                    _ChoiseService.Update(chiose);
                    _ChoiseService.Update(list);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Count++;
            if (Count >= AllQuestions.Count)
            {
                Count = 0;
                _question = AllQuestions[Count];
                BindFormData(_question);
                //MessageBox.Show("已经最后一题呢。", "考试提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _question = AllQuestions[Count];
                BindFormData(_question);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Count >= AllQuestions.Count)
            {
                Count = 0;
                _question = AllQuestions[Count];
                BindFormData(_question);
            }
            else
            {
                Count--;
                if (Count < 0)
                {
                    Count = AllQuestions.Count - 1;
                    _question = AllQuestions[Count];
                    BindFormData(_question);
                }
                else
                {
                    _question = AllQuestions[Count];
                    BindFormData(_question);
                }
            }
        }
        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            ChangeAnswer(rbB);
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            ChangeAnswer(rbC);
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            ChangeAnswer(rbD);
        }

    }
}
