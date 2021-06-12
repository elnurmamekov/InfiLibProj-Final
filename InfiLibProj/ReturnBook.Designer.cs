
namespace InfiLibProj
{
    partial class ReturnBook
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.returnBookIssueId = new Guna.UI2.WinForms.Guna2TextBox();
            this.returnBookReturnDate = new System.Windows.Forms.DateTimePicker();
            this.returnBookDataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.returnBookUpdateBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.returnBookEntryId = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.returnBookDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.CheckedState.Parent = this.AddBtn;
            this.AddBtn.CustomImages.Parent = this.AddBtn;
            this.AddBtn.FillColor = System.Drawing.Color.Black;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddBtn.HoverState.Parent = this.AddBtn;
            this.AddBtn.Location = new System.Drawing.Point(27, 161);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.ShadowDecoration.Parent = this.AddBtn;
            this.AddBtn.Size = new System.Drawing.Size(272, 56);
            this.AddBtn.TabIndex = 16;
            this.AddBtn.Text = "ADD";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(456, 76);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(111, 24);
            this.guna2HtmlLabel2.TabIndex = 20;
            this.guna2HtmlLabel2.Text = "Return Date";
            // 
            // returnBookIssueId
            // 
            this.returnBookIssueId.BorderColor = System.Drawing.Color.Black;
            this.returnBookIssueId.BorderThickness = 2;
            this.returnBookIssueId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.returnBookIssueId.DefaultText = "";
            this.returnBookIssueId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.returnBookIssueId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.returnBookIssueId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.returnBookIssueId.DisabledState.Parent = this.returnBookIssueId;
            this.returnBookIssueId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.returnBookIssueId.FillColor = System.Drawing.Color.WhiteSmoke;
            this.returnBookIssueId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.returnBookIssueId.FocusedState.Parent = this.returnBookIssueId;
            this.returnBookIssueId.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.returnBookIssueId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookIssueId.ForeColor = System.Drawing.Color.Black;
            this.returnBookIssueId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.returnBookIssueId.HoverState.Parent = this.returnBookIssueId;
            this.returnBookIssueId.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.returnBookIssueId.Location = new System.Drawing.Point(258, 53);
            this.returnBookIssueId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.returnBookIssueId.Name = "returnBookIssueId";
            this.returnBookIssueId.PasswordChar = '\0';
            this.returnBookIssueId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.returnBookIssueId.PlaceholderText = "Issue ID";
            this.returnBookIssueId.SelectedText = "";
            this.returnBookIssueId.ShadowDecoration.BorderRadius = 1;
            this.returnBookIssueId.ShadowDecoration.Parent = this.returnBookIssueId;
            this.returnBookIssueId.Size = new System.Drawing.Size(140, 47);
            this.returnBookIssueId.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.returnBookIssueId.TabIndex = 17;
            // 
            // returnBookReturnDate
            // 
            this.returnBookReturnDate.CustomFormat = "yyyy-MM-dd";
            this.returnBookReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.returnBookReturnDate.Location = new System.Drawing.Point(604, 80);
            this.returnBookReturnDate.Name = "returnBookReturnDate";
            this.returnBookReturnDate.Size = new System.Drawing.Size(200, 20);
            this.returnBookReturnDate.TabIndex = 23;
            // 
            // returnBookDataTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.returnBookDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.returnBookDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.returnBookDataTable.BackgroundColor = System.Drawing.Color.White;
            this.returnBookDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.returnBookDataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.returnBookDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.returnBookDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.returnBookDataTable.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.returnBookDataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.returnBookDataTable.EnableHeadersVisualStyles = false;
            this.returnBookDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.returnBookDataTable.Location = new System.Drawing.Point(26, 270);
            this.returnBookDataTable.Name = "returnBookDataTable";
            this.returnBookDataTable.RowHeadersVisible = false;
            this.returnBookDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.returnBookDataTable.Size = new System.Drawing.Size(778, 288);
            this.returnBookDataTable.TabIndex = 24;
            this.returnBookDataTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.returnBookDataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.returnBookDataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.returnBookDataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.returnBookDataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.returnBookDataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.returnBookDataTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.returnBookDataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.returnBookDataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.returnBookDataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.returnBookDataTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.returnBookDataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.returnBookDataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.returnBookDataTable.ThemeStyle.HeaderStyle.Height = 30;
            this.returnBookDataTable.ThemeStyle.ReadOnly = false;
            this.returnBookDataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.returnBookDataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.returnBookDataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.returnBookDataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.returnBookDataTable.ThemeStyle.RowsStyle.Height = 22;
            this.returnBookDataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.returnBookDataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // returnBookUpdateBtn
            // 
            this.returnBookUpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.returnBookUpdateBtn.CheckedState.Parent = this.returnBookUpdateBtn;
            this.returnBookUpdateBtn.CustomImages.Parent = this.returnBookUpdateBtn;
            this.returnBookUpdateBtn.FillColor = System.Drawing.Color.Black;
            this.returnBookUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookUpdateBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.returnBookUpdateBtn.HoverState.Parent = this.returnBookUpdateBtn;
            this.returnBookUpdateBtn.Location = new System.Drawing.Point(358, 161);
            this.returnBookUpdateBtn.Name = "returnBookUpdateBtn";
            this.returnBookUpdateBtn.ShadowDecoration.Parent = this.returnBookUpdateBtn;
            this.returnBookUpdateBtn.Size = new System.Drawing.Size(272, 56);
            this.returnBookUpdateBtn.TabIndex = 34;
            this.returnBookUpdateBtn.Text = "UPDATE";
            this.returnBookUpdateBtn.Click += new System.EventHandler(this.returnBookUpdateBtn_Click);
            // 
            // returnBookEntryId
            // 
            this.returnBookEntryId.BorderColor = System.Drawing.Color.Black;
            this.returnBookEntryId.BorderThickness = 2;
            this.returnBookEntryId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.returnBookEntryId.DefaultText = "";
            this.returnBookEntryId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.returnBookEntryId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.returnBookEntryId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.returnBookEntryId.DisabledState.Parent = this.returnBookEntryId;
            this.returnBookEntryId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.returnBookEntryId.FillColor = System.Drawing.Color.WhiteSmoke;
            this.returnBookEntryId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.returnBookEntryId.FocusedState.Parent = this.returnBookEntryId;
            this.returnBookEntryId.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.returnBookEntryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookEntryId.ForeColor = System.Drawing.Color.Black;
            this.returnBookEntryId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.returnBookEntryId.HoverState.Parent = this.returnBookEntryId;
            this.returnBookEntryId.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.returnBookEntryId.Location = new System.Drawing.Point(27, 53);
            this.returnBookEntryId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.returnBookEntryId.Name = "returnBookEntryId";
            this.returnBookEntryId.PasswordChar = '\0';
            this.returnBookEntryId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.returnBookEntryId.PlaceholderText = "Return Entry ID";
            this.returnBookEntryId.SelectedText = "";
            this.returnBookEntryId.ShadowDecoration.BorderRadius = 1;
            this.returnBookEntryId.ShadowDecoration.Parent = this.returnBookEntryId;
            this.returnBookEntryId.Size = new System.Drawing.Size(159, 47);
            this.returnBookEntryId.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.returnBookEntryId.TabIndex = 35;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(830, 570);
            this.Controls.Add(this.returnBookEntryId);
            this.Controls.Add(this.returnBookUpdateBtn);
            this.Controls.Add(this.returnBookDataTable);
            this.Controls.Add(this.returnBookReturnDate);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.returnBookIssueId);
            this.Controls.Add(this.AddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            ((System.ComponentModel.ISupportInitialize)(this.returnBookDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TileButton AddBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox returnBookIssueId;
        private System.Windows.Forms.DateTimePicker returnBookReturnDate;
        private Guna.UI2.WinForms.Guna2DataGridView returnBookDataTable;
        private Guna.UI2.WinForms.Guna2TileButton returnBookUpdateBtn;
        private Guna.UI2.WinForms.Guna2TextBox returnBookEntryId;
    }
}