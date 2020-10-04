using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_is_Hard {
    public partial class WordFrequency : Form {
        public WordFrequency() {
            InitializeComponent();
        }

        private void AnswerTextBox_TextChanged(object sender, EventArgs e) {

        }





        private void button1_Click(object sender, EventArgs e) {
            aaa();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
        }
        string InputText;
        string[] splitText;
        Dictionary<string, int> words = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);

        void aaa() {
            AnswerTextBox.Clear();
            words.Clear();

            InputText = textBox1.Text;
            splitText = InputText.Split(' ', ',', '.', '/', ';', '[', ']', '-', '=', '_', '+', '{', '}', '|', '\\', ':', '<', '>', '?', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '\'', '\n', '\t', '\"', '\r','\f','\v', (char)StringSplitOptions.RemoveEmptyEntries);

            foreach(string child in splitText) {
                int cc = 0;
                words.TryGetValue(child, out cc);

                cc++;
                words[child] = cc;
            }
            var sortedDict = from entry in words orderby entry.Value ascending select entry;

            //foreach(string child in sortedDict) { 
            foreach(KeyValuePair<string, int> child in sortedDict) {
                    AnswerTextBox.AppendText(child.Key + " = " + child.Value + Environment.NewLine);
            }

        }


    }

}
