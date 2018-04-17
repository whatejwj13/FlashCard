using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlashCard.Data;
using FlashCard.Data.Models;

namespace FlashCard.Controls
{
    public partial class BoxControl : UserControl
    {
        public BoxControl()
        {
            InitializeComponent();
        }

        private void BoxControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            LoadCategories();
        }

        private void LoadCategories()
        {
            List<string> categories = DataRepository.Card.GetCategories();

            foreach (var category in categories)
                cbbCategory.Items.Add(category);
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cbbCategory.Text;

            List<Cell> cells = DataRepository.Card.GetCells(category);

            bdsCell.DataSource = cells;
        }

        private void dgvCell_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != colReview.Index || e.RowIndex < 0)
                return;

            int cellNo = (int) dgvCell[colCellNo.Index, e.RowIndex].Value;

            OnReviewClicked(cbbCategory.Text, cellNo);
        }

        #region ReviewClicked event things for C# 3.0
        public event EventHandler<ReviewClickedEventArgs> ReviewClicked;

        protected virtual void OnReviewClicked(ReviewClickedEventArgs e)
        {
            if (ReviewClicked != null)
                ReviewClicked(this, e);
        }

        private ReviewClickedEventArgs OnReviewClicked(string category  , int cellNo )
        {
            ReviewClickedEventArgs args = new ReviewClickedEventArgs(category  , cellNo );
            OnReviewClicked(args);

            return args;
        }

        private ReviewClickedEventArgs OnReviewClickedForOut()
        {
            ReviewClickedEventArgs args = new ReviewClickedEventArgs();
            OnReviewClicked(args);

            return args;
        }

        public class ReviewClickedEventArgs : EventArgs
        {
            public string Category { get; set;}  
            public int CellNo { get; set;} 

            public ReviewClickedEventArgs()
            {
            }

            public ReviewClickedEventArgs(string category  , int cellNo )
            {
                Category = category;  
                CellNo = cellNo; 
            }
        }
        #endregion
    }
}
