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
            var sequence = GenerateSequence(NotesPerBar);
            
           

        }

        public string GenerateSequence(int notesPerBar)
        {
            throw new NotImplementedException();
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
