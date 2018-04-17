#region
using System;
using System.Windows.Forms;
#endregion

namespace FlashCard.Forms
{
    public partial class NewCardForm : RootForm
    {
        public NewCardForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (fbdFolder.ShowDialog() != DialogResult.OK)
                return;

            MessageBox.Show(fbdFolder.SelectedPath);
        }
    }
}