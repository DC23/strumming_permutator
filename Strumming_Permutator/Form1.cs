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
            keepBeatOne.Checked = true;
            rbFourFour.Checked = true;
            subdivisions.Value = 2;
            minSkip.Value = 1;
            maxSkip.Value = 1;
            Go();
        }

        public int NotesPerBar { get; set; }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            Go();
        }

        private void Go()
        { 
            output.Text = GenerateSequence(
                NotesPerBar,
                (int)subdivisions.Value,
                (int)minSkip.Value,
                (int)maxSkip.Value,
                keepBeatOne.Checked);
        }

        public static string GenerateSequence(int notesPerBar, int subdivisions, int minSkip = 0, int maxSkip = 0, bool keepFirstBeat = true)
        {
            // Build the full sequence
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

            // Drop some elements
            minSkip = Math.Max(0, minSkip);
            maxSkip = Math.Min(Math.Max(minSkip, maxSkip), sequence.Count);

            int start = keepFirstBeat ? 1 : 0;
            int end = sequence.Count;
            var rand = new Random();
            int numSkip = rand.Next(minSkip, maxSkip+1);

            for (int i = 0; i < numSkip; i++)
            {
                int index = rand.Next(start, end);
                sequence[index] = "_";
            }

            // convert to space-separated string
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
