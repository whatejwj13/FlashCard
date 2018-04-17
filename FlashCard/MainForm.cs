using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlashCard.Forms;

namespace FlashCard
{
    public partial class MainForm : RootForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {

        }

        private void uscBox_ReviewClicked(object sender, Controls.BoxControl.ReviewClickedEventArgs e)
        {
            MessageBox.Show($"Category : {e.Category}, CellNo : {e.CellNo}");
        }
    }
}
