using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strumming_Permutator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int NotesPerBar { get; set; }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            var sequence = GenerateSequence(NotesPerBar, 1);
        }

        public static string GenerateSequence(int notesPerBar, int subdivisions)
        {
            List<string> sequence = new List<string>();
            for (int i = 1; i <= notesPerBar; i++)
            {
                sequence.Add(i.ToString());
                
                if (subdivisions == 2)
                {
                    sequence.Add("+");
                }

                if (subdivisions == 3)
                {
                    sequence.Add("+");
                    sequence.Add("a");
                }

                if (subdivisions == 4)
                {
                    sequence.Add("e");
                    sequence.Add("+");
                    sequence.Add("a");
                }
            }

            return string.Join(" ", sequence);
        }

        private void RbThreeFour_CheckedChanged(object sender, EventArgs e)
        {
            NotesPerBar = 3;
        }

        private void RbFourFour_CheckedChanged(object sender, EventArgs e)
        {
            NotesPerBar = 4;
        }

        private void RbSixEight_CheckedChanged(object sender, EventArgs e)
        {
            NotesPerBar = 6;
        }
    }
}
