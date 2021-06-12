
namespace InfiLibProj
{
    partial class EditBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBookForm));
            this.SearchBtnEdit = new Guna.UI2.WinForms.Guna2TileButton();
            this.EnterIDEdit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BookIDEdit = new Guna.UI2.WinForms.Guna2TextBox();
            this.SelectBtnEdit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BookImageLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.EditPictureBox = new System.Windows.Forms.PictureBox();
            this.BookDescriptionBoxEdit = new Guna.UI2.WinForms.Guna2TextBox();
            this.genreLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GenreComboBoxEdit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AuthorLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AuthorComboBoxEdit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BookNameEdit = new Guna.UI2.WinForms.Guna2TextBox();
            this.EditBookBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BookIssueEdit = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtnEdit
            // 
            this.SearchBtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtnEdit.BorderRadius = 5;
            this.SearchBtnEdit.CheckedState.Parent = this.SearchBtnEdit;
            this.SearchBtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtnEdit.CustomImages.Parent = this.SearchBtnEdit;
            this.SearchBtnEdit.FillColor = System.Drawing.Color.SeaGreen;
            this.SearchBtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchBtnEdit.HoverState.Parent = this.SearchBtnEdit;
            this.SearchBtnEdit.Location = new System.Drawing.Point(286, 38);
            this.SearchBtnEdit.Name = "SearchBtnEdit";
            this.SearchBtnEdit.ShadowDecoration.Parent = this.SearchBtnEdit;
            this.SearchBtnEdit.Size = new System.Drawing.Size(160, 40);
            this.SearchBtnEdit.TabIndex = 64;
            this.SearchBtnEdit.Text = "Search";
            this.SearchBtnEdit.Click += new System.EventHandler(this.SearchBtnEdit_Click);
            // 
            // EnterIDEdit
            // 
            this.EnterIDEdit.BackColor = System.Drawing.Color.Transparent;
            this.EnterIDEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterIDEdit.ForeColor = System.Drawing.Color.Black;
            this.EnterIDEdit.Location = new System.Drawing.Point(50, 52);
            this.EnterIDEdit.Name = "EnterIDEdit";
            this.EnterIDEdit.Size = new System.Drawing.Size(136, 26);
            this.EnterIDEdit.TabIndex = 63;
            this.EnterIDEdit.Text = "Enter book ID: ";
            // 
            // BookIDEdit
            // 
            this.BookIDEdit.BorderColor = System.Drawing.Color.Black;
            this.BookIDEdit.BorderThickness = 2;
            this.BookIDEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookIDEdit.DefaultText = "";
            this.BookIDEdit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BookIDEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BookIDEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookIDEdit.DisabledState.Parent = this.BookIDEdit;
            this.BookIDEdit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookIDEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BookIDEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.BookIDEdit.FocusedState.Parent = this.BookIDEdit;
            this.BookIDEdit.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.BookIDEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIDEdit.ForeColor = System.Drawing.Color.Black;
            this.BookIDEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookIDEdit.HoverState.Parent = this.BookIDEdit;
            this.BookIDEdit.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookIDEdit.Location = new System.Drawing.Point(194, 37);
            this.BookIDEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BookIDEdit.Name = "BookIDEdit";
            this.BookIDEdit.PasswordChar = '\0';
            this.BookIDEdit.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.BookIDEdit.PlaceholderText = "";
            this.BookIDEdit.SelectedText = "";
            this.BookIDEdit.ShadowDecoration.BorderRadius = 1;
            this.BookIDEdit.ShadowDecoration.Parent = this.BookIDEdit;
            this.BookIDEdit.Size = new System.Drawing.Size(75, 41);
            this.BookIDEdit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.BookIDEdit.TabIndex = 62;
            // 
            // SelectBtnEdit
            // 
            this.SelectBtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.SelectBtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectBtnEdit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SelectBtnEdit.Location = new System.Drawing.Point(427, 533);
            this.SelectBtnEdit.Name = "SelectBtnEdit";
            this.SelectBtnEdit.Size = new System.Drawing.Size(226, 22);
            this.SelectBtnEdit.TabIndex = 73;
            this.SelectBtnEdit.Text = "Select picture from device...";
            this.SelectBtnEdit.Click += new System.EventHandler(this.SelectBtnEdit_Click);
            // 
            // BookImageLabel
            // 
            this.BookImageLabel.BackColor = System.Drawing.Color.Transparent;
            this.BookImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookImageLabel.ForeColor = System.Drawing.Color.Gray;
            this.BookImageLabel.Location = new System.Drawing.Point(427, 325);
            this.BookImageLabel.Name = "BookImageLabel";
            this.BookImageLabel.Size = new System.Drawing.Size(114, 26);
            this.BookImageLabel.TabIndex = 72;
            this.BookImageLabel.Text = "Book cover:";
            // 
            // EditPictureBox
            // 
            this.EditPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditPictureBox.BackgroundImage")));
            this.EditPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditPictureBox.Location = new System.Drawing.Point(427, 357);
            this.EditPictureBox.Name = "EditPictureBox";
            this.EditPictureBox.Size = new System.Drawing.Size(193, 170);
            this.EditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditPictureBox.TabIndex = 71;
            this.EditPictureBox.TabStop = false;
            // 
            // BookDescriptionBoxEdit
            // 
            this.BookDescriptionBoxEdit.BorderColor = System.Drawing.Color.Black;
            this.BookDescriptionBoxEdit.BorderThickness = 2;
            this.BookDescriptionBoxEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookDescriptionBoxEdit.DefaultText = "";
            this.BookDescriptionBoxEdit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BookDescriptionBoxEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BookDescriptionBoxEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookDescriptionBoxEdit.DisabledState.Parent = this.BookDescriptionBoxEdit;
            this.BookDescriptionBoxEdit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookDescriptionBoxEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BookDescriptionBoxEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.BookDescriptionBoxEdit.FocusedState.Parent = this.BookDescriptionBoxEdit;
            this.BookDescriptionBoxEdit.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.BookDescriptionBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookDescriptionBoxEdit.ForeColor = System.Drawing.Color.Black;
            this.BookDescriptionBoxEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookDescriptionBoxEdit.HoverState.Parent = this.BookDescriptionBoxEdit;
            this.BookDescriptionBoxEdit.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookDescriptionBoxEdit.Location = new System.Drawing.Point(427, 113);
            this.BookDescriptionBoxEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BookDescriptionBoxEdit.Multiline = true;
            this.BookDescriptionBoxEdit.Name = "BookDescriptionBoxEdit";
            this.BookDescriptionBoxEdit.PasswordChar = '\0';
            this.BookDescriptionBoxEdit.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.BookDescriptionBoxEdit.PlaceholderText = "Description";
            this.BookDescriptionBoxEdit.SelectedText = "";
            this.BookDescriptionBoxEdit.ShadowDecoration.BorderRadius = 1;
            this.BookDescriptionBoxEdit.ShadowDecoration.Parent = this.BookDescriptionBoxEdit;
            this.BookDescriptionBoxEdit.Size = new System.Drawing.Size(347, 170);
            this.BookDescriptionBoxEdit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.BookDescriptionBoxEdit.TabIndex = 70;
            // 
            // genreLabel
            // 
            this.genreLabel.BackColor = System.Drawing.Color.Transparent;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreLabel.ForeColor = System.Drawing.Color.Gray;
            this.genreLabel.Location = new System.Drawing.Point(50, 330);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(67, 26);
            this.genreLabel.TabIndex = 69;
            this.genreLabel.Text = "Genre:";
            // 
            // GenreComboBoxEdit
            // 
            this.GenreComboBoxEdit.Animated = true;
            this.GenreComboBoxEdit.BackColor = System.Drawing.Color.Transparent;
            this.GenreComboBoxEdit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenreComboBoxEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBoxEdit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenreComboBoxEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenreComboBoxEdit.FocusedState.Parent = this.GenreComboBoxEdit;
            this.GenreComboBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.GenreComboBoxEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.GenreComboBoxEdit.HoverState.Parent = this.GenreComboBoxEdit;
            this.GenreComboBoxEdit.ItemHeight = 30;
            this.GenreComboBoxEdit.ItemsAppearance.Parent = this.GenreComboBoxEdit;
            this.GenreComboBoxEdit.Location = new System.Drawing.Point(128, 325);
            this.GenreComboBoxEdit.Name = "GenreComboBoxEdit";
            this.GenreComboBoxEdit.ShadowDecoration.Parent = this.GenreComboBoxEdit;
            this.GenreComboBoxEdit.Size = new System.Drawing.Size(247, 36);
            this.GenreComboBoxEdit.TabIndex = 68;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.ForeColor = System.Drawing.Color.Gray;
            this.AuthorLabel.Location = new System.Drawing.Point(50, 252);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(71, 26);
            this.AuthorLabel.TabIndex = 67;
            this.AuthorLabel.Text = "Author:";
            // 
            // AuthorComboBoxEdit
            // 
            this.AuthorComboBoxEdit.Animated = true;
            this.AuthorComboBoxEdit.BackColor = System.Drawing.Color.Transparent;
            this.AuthorComboBoxEdit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AuthorComboBoxEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorComboBoxEdit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AuthorComboBoxEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AuthorComboBoxEdit.FocusedState.Parent = this.AuthorComboBoxEdit;
            this.AuthorComboBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.AuthorComboBoxEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AuthorComboBoxEdit.HoverState.Parent = this.AuthorComboBoxEdit;
            this.AuthorComboBoxEdit.ItemHeight = 30;
            this.AuthorComboBoxEdit.ItemsAppearance.Parent = this.AuthorComboBoxEdit;
            this.AuthorComboBoxEdit.Location = new System.Drawing.Point(128, 247);
            this.AuthorComboBoxEdit.Name = "AuthorComboBoxEdit";
            this.AuthorComboBoxEdit.ShadowDecoration.Parent = this.AuthorComboBoxEdit;
            this.AuthorComboBoxEdit.Size = new System.Drawing.Size(247, 36);
            this.AuthorComboBoxEdit.TabIndex = 66;
            // 
            // BookNameEdit
            // 
            this.BookNameEdit.BorderColor = System.Drawing.Color.Black;
            this.BookNameEdit.BorderThickness = 2;
            this.BookNameEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookNameEdit.DefaultText = "";
            this.BookNameEdit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BookNameEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BookNameEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookNameEdit.DisabledState.Parent = this.BookNameEdit;
            this.BookNameEdit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookNameEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BookNameEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.BookNameEdit.FocusedState.Parent = this.BookNameEdit;
            this.BookNameEdit.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.BookNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameEdit.ForeColor = System.Drawing.Color.Black;
            this.BookNameEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookNameEdit.HoverState.Parent = this.BookNameEdit;
            this.BookNameEdit.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookNameEdit.Location = new System.Drawing.Point(50, 113);
            this.BookNameEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BookNameEdit.Name = "BookNameEdit";
            this.BookNameEdit.PasswordChar = '\0';
            this.BookNameEdit.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.BookNameEdit.PlaceholderText = "Book name";
            this.BookNameEdit.SelectedText = "";
            this.BookNameEdit.ShadowDecoration.BorderRadius = 1;
            this.BookNameEdit.ShadowDecoration.Parent = this.BookNameEdit;
            this.BookNameEdit.Size = new System.Drawing.Size(325, 40);
            this.BookNameEdit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.BookNameEdit.TabIndex = 65;
            // 
            // EditBookBtn
            // 
            this.EditBookBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditBookBtn.CheckedState.Parent = this.EditBookBtn;
            this.EditBookBtn.CustomImages.Parent = this.EditBookBtn;
            this.EditBookBtn.FillColor = System.Drawing.Color.Black;
            this.EditBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBookBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EditBookBtn.HoverState.Parent = this.EditBookBtn;
            this.EditBookBtn.Location = new System.Drawing.Point(101, 494);
            this.EditBookBtn.Name = "EditBookBtn";
            this.EditBookBtn.ShadowDecoration.Parent = this.EditBookBtn;
            this.EditBookBtn.Size = new System.Drawing.Size(236, 61);
            this.EditBookBtn.TabIndex = 74;
            this.EditBookBtn.Text = "Edit Book Info";
            this.EditBookBtn.Click += new System.EventHandler(this.EditBookBtn_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(50, 410);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(70, 26);
            this.guna2HtmlLabel1.TabIndex = 75;
            this.guna2HtmlLabel1.Text = "Issued:";
            // 
            // BookIssueEdit
            // 
            this.BookIssueEdit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookIssueEdit.CheckedState.BorderRadius = 2;
            this.BookIssueEdit.CheckedState.BorderThickness = 0;
            this.BookIssueEdit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookIssueEdit.CheckedState.Parent = this.BookIssueEdit;
            this.BookIssueEdit.Location = new System.Drawing.Point(128, 401);
            this.BookIssueEdit.Name = "BookIssueEdit";
            this.BookIssueEdit.ShadowDecoration.Parent = this.BookIssueEdit;
            this.BookIssueEdit.Size = new System.Drawing.Size(33, 35);
            this.BookIssueEdit.TabIndex = 76;
            this.BookIssueEdit.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BookIssueEdit.UncheckedState.BorderRadius = 2;
            this.BookIssueEdit.UncheckedState.BorderThickness = 0;
            this.BookIssueEdit.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BookIssueEdit.UncheckedState.Parent = this.BookIssueEdit;
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.BookIssueEdit);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.EditBookBtn);
            this.Controls.Add(this.SelectBtnEdit);
            this.Controls.Add(this.BookImageLabel);
            this.Controls.Add(this.EditPictureBox);
            this.Controls.Add(this.BookDescriptionBoxEdit);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.GenreComboBoxEdit);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.AuthorComboBoxEdit);
            this.Controls.Add(this.BookNameEdit);
            this.Controls.Add(this.SearchBtnEdit);
            this.Controls.Add(this.EnterIDEdit);
            this.Controls.Add(this.BookIDEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditBookForm";
            this.Text = "EditBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton SearchBtnEdit;
        private Guna.UI2.WinForms.Guna2HtmlLabel EnterIDEdit;
        private Guna.UI2.WinForms.Guna2TextBox BookIDEdit;
        private Guna.UI2.WinForms.Guna2HtmlLabel SelectBtnEdit;
        private Guna.UI2.WinForms.Guna2HtmlLabel BookImageLabel;
        private System.Windows.Forms.PictureBox EditPictureBox;
        private Guna.UI2.WinForms.Guna2TextBox BookDescriptionBoxEdit;
        private Guna.UI2.WinForms.Guna2HtmlLabel genreLabel;
        private Guna.UI2.WinForms.Guna2ComboBox GenreComboBoxEdit;
        private Guna.UI2.WinForms.Guna2HtmlLabel AuthorLabel;
        private Guna.UI2.WinForms.Guna2ComboBox AuthorComboBoxEdit;
        private Guna.UI2.WinForms.Guna2TextBox BookNameEdit;
        private Guna.UI2.WinForms.Guna2TileButton EditBookBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox BookIssueEdit;
    }
}