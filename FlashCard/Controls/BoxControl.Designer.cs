namespace FlashCard.Controls
{
    partial class BoxControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.dgvCell = new System.Windows.Forms.DataGridView();
            this.bdsCell = new System.Windows.Forms.BindingSource(this.components);
            this.colCellNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReview = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCell)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCategory
            // 
            this.cbbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(3, 3);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(396, 20);
            this.cbbCategory.TabIndex = 2;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // dgvCell
            // 
            this.dgvCell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCell.AutoGenerateColumns = false;
            this.dgvCell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCell.ColumnHeadersVisible = false;
            this.dgvCell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCellNo,
            this.cardCountDataGridViewTextBoxColumn,
            this.colReview});
            this.dgvCell.DataSource = this.bdsCell;
            this.dgvCell.Location = new System.Drawing.Point(3, 29);
            this.dgvCell.MultiSelect = false;
            this.dgvCell.Name = "dgvCell";
            this.dgvCell.RowHeadersVisible = false;
            this.dgvCell.RowTemplate.Height = 23;
            this.dgvCell.Size = new System.Drawing.Size(396, 363);
            this.dgvCell.TabIndex = 3;
            this.dgvCell.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCell_CellClick);
            // 
            // bdsCell
            // 
            this.bdsCell.DataSource = typeof(FlashCard.Data.Models.Cell);
            // 
            // colCellNo
            // 
            this.colCellNo.DataPropertyName = "CellNo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.colCellNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCellNo.HeaderText = "CellNo";
            this.colCellNo.Name = "colCellNo";
            this.colCellNo.ReadOnly = true;
            // 
            // cardCountDataGridViewTextBoxColumn
            // 
            this.cardCountDataGridViewTextBoxColumn.DataPropertyName = "CardCount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cardCountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cardCountDataGridViewTextBoxColumn.HeaderText = "CardCount";
            this.cardCountDataGridViewTextBoxColumn.Name = "cardCountDataGridViewTextBoxColumn";
            this.cardCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colReview
            // 
            this.colReview.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colReview.HeaderText = "";
            this.colReview.Name = "colReview";
            this.colReview.Text = "Review";
            this.colReview.UseColumnTextForButtonValue = true;
            this.colReview.Width = 60;
            // 
            // BoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCell);
            this.Controls.Add(this.cbbCategory);
            this.Name = "BoxControl";
            this.Size = new System.Drawing.Size(402, 395);
            this.Load += new System.EventHandler(this.BoxControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.DataGridView dgvCell;
        private System.Windows.Forms.BindingSource bdsCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCellNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn colReview;
    }
}
