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
            NewCardForm form = new NewCardForm();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            //TODO : 카드가 성공적으로 추가된 경우를 처리한다.
        }

        private void uscBox_ReviewClicked(object sender, Controls.BoxControl.ReviewClickedEventArgs e)
        {
            MessageBox.Show($"Category : {e.Category}, CellNo : {e.CellNo}");
        }
    }
}
