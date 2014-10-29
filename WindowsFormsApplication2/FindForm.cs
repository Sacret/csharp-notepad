using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }
        // Создаем перечисление, возвращающее параметр FindCondition
        public RichTextBoxFinds FindCondition
        {
            get
            {
                //Выбраны два чекбокса
                if (MatchCase.Checked && MatchWhole.Checked)
                {
                    // Возвращаем свойство MatchCase и WholeWord 
                    return RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord;
                }
                //Выбран один чекбокс
                if (MatchCase.Checked)
                {
                    // Возвращаем свойство MatchCase
                    return RichTextBoxFinds.MatchCase;
                }
                //Выбран другой чекбокс
                if (MatchWhole.Checked)
                {
                    // Возвращаем свойство WholeWord
                    return RichTextBoxFinds.WholeWord;
                }
                //Не выбран ни один чекбокс
                return RichTextBoxFinds.None;
            }
        }
        // Для поиска
        public string FindText
        {
            get { return txtFind.Text; }
            set { txtFind.Text = value; }
        }
       
    }
}
