using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlashCard.Data;

namespace FlashCard.Forms
{
    public partial class RootForm : Form
    {
        public RootForm()
        {
            InitializeComponent();
        }

        private string _formName;

        private void RootForm_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            _formName = GetType().Name;

            FormLocation formLocation = DataRepository.FormLocation.GetByPK(_formName);

            if (formLocation == null)
                return;

            Width = formLocation.Width;
            Height = formLocation.Height;
            Location = new Point(formLocation.X, formLocation.Y);
        }

        private void RootForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLocation formLocation = new FormLocation();
            formLocation.FormName = _formName;
            formLocation.X = Location.X;
            formLocation.Y = Location.Y;
            formLocation.Width = Width;
            formLocation.Height = Height;

            DataRepository.FormLocation.DeleteByPK(_formName);
            DataRepository.FormLocation.Insert(formLocation);
        }
    }
}
