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
            minSkip.Value = 0;
            maxSkip.Value = 0;
        }

        public int NotesPerBar { get; set; } = 4;

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            Go();
        }

        private void Go()
        {
            var sequence = GenerateSequence(
                NotesPerBar,
                (int)subdivisions.Value,
                (int)minSkip.Value,
                (int)maxSkip.Value,
                keepBeatOne.Checked,
                (int)numSubdivisionVariations.Value,
                (int)variantSubdivisions.Value);

            output.Text = sequence.Item2;
            outputFullSequence.Text = sequence.Item1;
        }

        public static Tuple<string, string> GenerateSequence(
            int notesPerBar,
            int subdivisions,
            int minSkip = 0,
            int maxSkip = 0,
            bool keepFirstBeat = true,
            int variantSubdivisionChance = 0,
            int variantSubdivisions = 0)
        {
            // make sure the chance is in range
            variantSubdivisionChance = Math.Max(Math.Min(variantSubdivisionChance, 100), 0);

            var rand = new Random();

            // Build the full sequence
            List<string> sequence = new List<string>();
            for (int i = 1; i <= notesPerBar; i++)
            {
                int beatSubdivision = rand.Next(0, 100) < variantSubdivisionChance ? variantSubdivisions : subdivisions;

                sequence.Add(i.ToString());

                if (beatSubdivision == 2)
                {
                    sequence.Add("+");
                }

                if (beatSubdivision == 3)
                {
                    sequence.Add("+");
                    sequence.Add("a");
                }

                if (beatSubdivision == 4)
                {
                    sequence.Add("e");
                    sequence.Add("+");
                    sequence.Add("a");
                }
            }

            string fullSequence = string.Join(" ", sequence);

            // Drop some elements
            int start = keepFirstBeat ? 1 : 0;
            int end = sequence.Count;
            int numSkippableBeats = end - start;
            minSkip = Math.Min(Math.Max(0, minSkip), numSkippableBeats);
            maxSkip = Math.Min(Math.Max(minSkip, maxSkip), numSkippableBeats);

            // Choose the number of items to drop, making sure to not exceed the number of available elements
            int numSkip = rand.Next(minSkip, maxSkip + 1);

            // Create a list of sequence indicies, shuffle it
            var indicies = Enumerable.Range(start, end - start).ToList().OrderBy(x => rand.NextDouble()).ToArray();

            // take numSkip from the start to skip
            for (int i = 0; i < numSkip; i++)
                sequence[indicies[i]] = "_";

            // convert to space-separated string
            return Tuple.Create(fullSequence, string.Join(" ", sequence));
        }

        private void RbThreeFour_CheckedChanged(object sender, EventArgs e)
        {
            NotesPerBar = 3;
            Go();
        }

        private void RbFourFour_CheckedChanged(object sender, EventArgs e)
        {
            NotesPerBar = 4;
            Go();
        }

        private void RbSixEight_CheckedChanged(object sender, EventArgs e)
        {
            NotesPerBar = 6;
            Go();
        }

        private void Subdivisions_ValueChanged(object sender, EventArgs e)
        {
            Go();
        }

        private void MinSkip_ValueChanged(object sender, EventArgs e)
        {
            Go();
        }

        private void MaxSkip_ValueChanged(object sender, EventArgs e)
        {
            Go();
        }

        private void KeepBeatOne_CheckedChanged(object sender, EventArgs e)
        {
            Go();
        }

        private void SubstituteBeat_CheckedChanged(object sender, EventArgs e)
        {
            Go();
        }

        private void NumSubdivisionVariations_ValueChanged(object sender, EventArgs e)
        {
            Go();
        }

        private void VariantSubdivisions_ValueChanged(object sender, EventArgs e)
        {
            Go();
        }
    }
}
