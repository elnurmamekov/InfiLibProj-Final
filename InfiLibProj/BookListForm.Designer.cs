
namespace InfiLibProj
{
    partial class BookListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookListForm));
            this.BookGenreInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BookAuthorInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BookNameInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SearchBtnBookList = new Guna.UI2.WinForms.Guna2TileButton();
            this.EnterlableBookList = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SearchLineBookList = new Guna.UI2.WinForms.Guna2TextBox();
            this.BookPictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.DataGridBookList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BookSearchRadioAuthor = new Guna.UI2.WinForms.Guna2RadioButton();
            this.BookSearchRadioBookName = new Guna.UI2.WinForms.Guna2RadioButton();
            this.BookSearchRadioId = new Guna.UI2.WinForms.Guna2RadioButton();
            this.BookSearchRadioGenre = new Guna.UI2.WinForms.Guna2RadioButton();
            this.BookIdInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.hide = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.BookSearchIssueRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.BookIssueInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BookListShowAllButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // BookGenreInfo
            // 
            this.BookGenreInfo.BackColor = System.Drawing.Color.Transparent;
            this.BookGenreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.BookGenreInfo.Location = new System.Drawing.Point(982, 449);
            this.BookGenreInfo.Name = "BookGenreInfo";
            this.BookGenreInfo.Size = new System.Drawing.Size(53, 22);
            this.BookGenreInfo.TabIndex = 80;
            this.BookGenreInfo.Text = "Genre";
            // 
            // BookAuthorInfo
            // 
            this.BookAuthorInfo.BackColor = System.Drawing.Color.Transparent;
            this.BookAuthorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.BookAuthorInfo.Location = new System.Drawing.Point(986, 421);
            this.BookAuthorInfo.Name = "BookAuthorInfo";
            this.BookAuthorInfo.Size = new System.Drawing.Size(57, 22);
            this.BookAuthorInfo.TabIndex = 79;
            this.BookAuthorInfo.Text = "Author";
            // 
            // BookNameInfo
            // 
            this.BookNameInfo.BackColor = System.Drawing.Color.Transparent;
            this.BookNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.BookNameInfo.Location = new System.Drawing.Point(978, 393);
            this.BookNameInfo.Name = "BookNameInfo";
            this.BookNameInfo.Size = new System.Drawing.Size(93, 22);
            this.BookNameInfo.TabIndex = 78;
            this.BookNameInfo.Text = "Book name";
            // 
            // SearchBtnBookList
            // 
            this.SearchBtnBookList.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtnBookList.BorderRadius = 5;
            this.SearchBtnBookList.CheckedState.Parent = this.SearchBtnBookList;
            this.SearchBtnBookList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtnBookList.CustomImages.Parent = this.SearchBtnBookList;
            this.SearchBtnBookList.FillColor = System.Drawing.Color.SeaGreen;
            this.SearchBtnBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtnBookList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchBtnBookList.HoverState.Parent = this.SearchBtnBookList;
            this.SearchBtnBookList.Location = new System.Drawing.Point(696, 30);
            this.SearchBtnBookList.Name = "SearchBtnBookList";
            this.SearchBtnBookList.ShadowDecoration.Parent = this.SearchBtnBookList;
            this.SearchBtnBookList.Size = new System.Drawing.Size(160, 40);
            this.SearchBtnBookList.TabIndex = 77;
            this.SearchBtnBookList.Text = "Search";
            this.SearchBtnBookList.Click += new System.EventHandler(this.SearchBtnBookList_Click);
            // 
            // EnterlableBookList
            // 
            this.EnterlableBookList.BackColor = System.Drawing.Color.Transparent;
            this.EnterlableBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterlableBookList.ForeColor = System.Drawing.Color.Black;
            this.EnterlableBookList.Location = new System.Drawing.Point(33, 45);
            this.EnterlableBookList.Name = "EnterlableBookList";
            this.EnterlableBookList.Size = new System.Drawing.Size(121, 26);
            this.EnterlableBookList.TabIndex = 76;
            this.EnterlableBookList.Text = "Enter Book\'s";
            // 
            // SearchLineBookList
            // 
            this.SearchLineBookList.BorderColor = System.Drawing.Color.Black;
            this.SearchLineBookList.BorderThickness = 2;
            this.SearchLineBookList.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchLineBookList.DefaultText = "";
            this.SearchLineBookList.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchLineBookList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchLineBookList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchLineBookList.DisabledState.Parent = this.SearchLineBookList;
            this.SearchLineBookList.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchLineBookList.FillColor = System.Drawing.Color.Silver;
            this.SearchLineBookList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.SearchLineBookList.FocusedState.Parent = this.SearchLineBookList;
            this.SearchLineBookList.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.SearchLineBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLineBookList.ForeColor = System.Drawing.Color.Black;
            this.SearchLineBookList.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchLineBookList.HoverState.Parent = this.SearchLineBookList;
            this.SearchLineBookList.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchLineBookList.Location = new System.Drawing.Point(382, 30);
            this.SearchLineBookList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SearchLineBookList.Name = "SearchLineBookList";
            this.SearchLineBookList.PasswordChar = '\0';
            this.SearchLineBookList.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.SearchLineBookList.PlaceholderText = "";
            this.SearchLineBookList.SelectedText = "";
            this.SearchLineBookList.ShadowDecoration.BorderRadius = 1;
            this.SearchLineBookList.ShadowDecoration.Parent = this.SearchLineBookList;
            this.SearchLineBookList.Size = new System.Drawing.Size(268, 41);
            this.SearchLineBookList.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SearchLineBookList.TabIndex = 75;
            // 
            // BookPictureBoxInfo
            // 
            this.BookPictureBoxInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.BookPictureBoxInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BookPictureBoxInfo.Location = new System.Drawing.Point(918, 157);
            this.BookPictureBoxInfo.Name = "BookPictureBoxInfo";
            this.BookPictureBoxInfo.Size = new System.Drawing.Size(213, 182);
            this.BookPictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookPictureBoxInfo.TabIndex = 74;
            this.BookPictureBoxInfo.TabStop = false;
            // 
            // DataGridBookList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridBookList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridBookList.BackgroundColor = System.Drawing.Color.White;
            this.DataGridBookList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridBookList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridBookList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridBookList.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridBookList.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridBookList.EnableHeadersVisualStyles = false;
            this.DataGridBookList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridBookList.Location = new System.Drawing.Point(33, 157);
            this.DataGridBookList.Name = "DataGridBookList";
            this.DataGridBookList.RowHeadersVisible = false;
            this.DataGridBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridBookList.Size = new System.Drawing.Size(857, 350);
            this.DataGridBookList.TabIndex = 73;
            this.DataGridBookList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridBookList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridBookList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridBookList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridBookList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridBookList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridBookList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridBookList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridBookList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridBookList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridBookList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridBookList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridBookList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridBookList.ThemeStyle.HeaderStyle.Height = 30;
            this.DataGridBookList.ThemeStyle.ReadOnly = false;
            this.DataGridBookList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridBookList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridBookList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridBookList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridBookList.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridBookList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridBookList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridBookList_CellContentClick);
            // 
            // BookSearchRadioAuthor
            // 
            this.BookSearchRadioAuthor.AutoSize = true;
            this.BookSearchRadioAuthor.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookSearchRadioAuthor.CheckedState.BorderThickness = 0;
            this.BookSearchRadioAuthor.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookSearchRadioAuthor.CheckedState.InnerColor = System.Drawing.Color.White;
            this.BookSearchRadioAuthor.CheckedState.InnerOffset = -4;
            this.BookSearchRadioAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookSearchRadioAuthor.Location = new System.Drawing.Point(168, 46);
            this.BookSearchRadioAuthor.Name = "BookSearchRadioAuthor";
            this.BookSearchRadioAuthor.Size = new System.Drawing.Size(79, 24);
            this.BookSearchRadioAuthor.TabIndex = 83;
            this.BookSearchRadioAuthor.Text = "author";
            this.BookSearchRadioAuthor.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BookSearchRadioAuthor.UncheckedState.BorderThickness = 2;
            this.BookSearchRadioAuthor.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.BookSearchRadioAuthor.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // BookSearchRadioBookName
            // 
            this.BookSearchRadioBookName.AutoSize = true;
            this.BookSearchRadioBookName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookSearchRadioBookName.CheckedState.BorderThickness = 0;
            this.BookSearchRadioBookName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookSearchRadioBookName.CheckedState.InnerColor = System.Drawing.Color.White;
            this.BookSearchRadioBookName.CheckedState.InnerOffset = -4;
            this.BookSearchRadioBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookSearchRadioBookName.Location = new System.Drawing.Point(253, 17);
            this.BookSearchRadioBookName.Name = "BookSearchRadioBookName";
            this.BookSearchRadioBookName.Size = new System.Drawing.Size(115, 24);
            this.BookSearchRadioBookName.TabIndex = 82;
            this.BookSearchRadioBookName.Text = "book name";
            this.BookSearchRadioBookName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BookSearchRadioBookName.UncheckedState.BorderThickness = 2;
            this.BookSearchRadioBookName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.BookSearchRadioBookName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // BookSearchRadioId
            // 
            this.BookSearchRadioId.AutoSize = true;
            this.BookSearchRadioId.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookSearchRadioId.CheckedState.BorderThickness = 0;
            this.BookSearchRadioId.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookSearchRadioId.CheckedState.InnerColor = System.Drawing.Color.White;
            this.BookSearchRadioId.CheckedState.InnerOffset = -4;
            this.BookSearchRadioId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookSearchRadioId.Location = new System.Drawing.Point(168, 16);
            this.BookSearchRadioId.Name = "BookSearchRadioId";
            this.BookSearchRadioId.Size = new System.Drawing.Size(46, 24);
            this.BookSearchRadioId.TabIndex = 81;
            this.BookSearchRadioId.Text = "ID";
            this.BookSearchRadioId.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BookSearchRadioId.UncheckedState.BorderThickness = 2;
            this.BookSearchRadioId.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.BookSearchRadioId.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // BookSearchRadioGenre
            // 
            this.BookSearchRadioGenre.AutoSize = true;
            this.BookSearchRadioGenre.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookSearchRadioGenre.CheckedState.BorderThickness = 0;
            this.BookSearchRadioGenre.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookSearchRadioGenre.CheckedState.InnerColor = System.Drawing.Color.White;
            this.BookSearchRadioGenre.CheckedState.InnerOffset = -4;
            this.BookSearchRadioGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookSearchRadioGenre.Location = new System.Drawing.Point(253, 47);
            this.BookSearchRadioGenre.Name = "BookSearchRadioGenre";
            this.BookSearchRadioGenre.Size = new System.Drawing.Size(73, 24);
            this.BookSearchRadioGenre.TabIndex = 84;
            this.BookSearchRadioGenre.Text = "genre";
            this.BookSearchRadioGenre.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BookSearchRadioGenre.UncheckedState.BorderThickness = 2;
            this.BookSearchRadioGenre.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.BookSearchRadioGenre.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // BookIdInfo
            // 
            this.BookIdInfo.BackColor = System.Drawing.Color.Transparent;
            this.BookIdInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.BookIdInfo.Location = new System.Drawing.Point(950, 365);
            this.BookIdInfo.Name = "BookIdInfo";
            this.BookIdInfo.Size = new System.Drawing.Size(22, 22);
            this.BookIdInfo.TabIndex = 85;
            this.BookIdInfo.Text = "ID";
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hide.Image = ((System.Drawing.Image)(resources.GetObject("hide.Image")));
            this.hide.Location = new System.Drawing.Point(1105, 0);
            this.hide.Name = "hide";
            this.hide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.hide.ShadowDecoration.Parent = this.hide;
            this.hide.Size = new System.Drawing.Size(30, 20);
            this.hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hide.TabIndex = 87;
            this.hide.TabStop = false;
            this.hide.UseTransparentBackground = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(1135, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitBtn.ShadowDecoration.Parent = this.ExitBtn;
            this.ExitBtn.Size = new System.Drawing.Size(30, 20);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBtn.TabIndex = 86;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BookSearchIssueRadio
            // 
            this.BookSearchIssueRadio.AutoSize = true;
            this.BookSearchIssueRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookSearchIssueRadio.CheckedState.BorderThickness = 0;
            this.BookSearchIssueRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookSearchIssueRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.BookSearchIssueRadio.CheckedState.InnerOffset = -4;
            this.BookSearchIssueRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookSearchIssueRadio.Location = new System.Drawing.Point(168, 76);
            this.BookSearchIssueRadio.Name = "BookSearchIssueRadio";
            this.BookSearchIssueRadio.Size = new System.Drawing.Size(124, 24);
            this.BookSearchIssueRadio.TabIndex = 88;
            this.BookSearchIssueRadio.Text = "issue status";
            this.BookSearchIssueRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BookSearchIssueRadio.UncheckedState.BorderThickness = 2;
            this.BookSearchIssueRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.BookSearchIssueRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // BookIssueInfo
            // 
            this.BookIssueInfo.BackColor = System.Drawing.Color.Transparent;
            this.BookIssueInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.BookIssueInfo.Location = new System.Drawing.Point(1030, 477);
            this.BookIssueInfo.Name = "BookIssueInfo";
            this.BookIssueInfo.Size = new System.Drawing.Size(105, 22);
            this.BookIssueInfo.TabIndex = 89;
            this.BookIssueInfo.Text = "Issue Status";
            // 
            // BookListShowAllButton
            // 
            this.BookListShowAllButton.BackColor = System.Drawing.Color.Transparent;
            this.BookListShowAllButton.BorderRadius = 5;
            this.BookListShowAllButton.CheckedState.Parent = this.BookListShowAllButton;
            this.BookListShowAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookListShowAllButton.CustomImages.Parent = this.BookListShowAllButton;
            this.BookListShowAllButton.FillColor = System.Drawing.Color.SeaGreen;
            this.BookListShowAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookListShowAllButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BookListShowAllButton.HoverState.Parent = this.BookListShowAllButton;
            this.BookListShowAllButton.Location = new System.Drawing.Point(696, 76);
            this.BookListShowAllButton.Name = "BookListShowAllButton";
            this.BookListShowAllButton.ShadowDecoration.Parent = this.BookListShowAllButton;
            this.BookListShowAllButton.Size = new System.Drawing.Size(160, 40);
            this.BookListShowAllButton.TabIndex = 90;
            this.BookListShowAllButton.Text = "ShowAll";
            this.BookListShowAllButton.Click += new System.EventHandler(this.BookListShowAllButton_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(918, 365);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(27, 22);
            this.guna2HtmlLabel1.TabIndex = 91;
            this.guna2HtmlLabel1.Text = "ID:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(918, 393);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(54, 22);
            this.guna2HtmlLabel2.TabIndex = 92;
            this.guna2HtmlLabel2.Text = "Name:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Maroon;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(918, 421);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(62, 22);
            this.guna2HtmlLabel3.TabIndex = 93;
            this.guna2HtmlLabel3.Text = "Author:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Maroon;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(918, 449);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(58, 22);
            this.guna2HtmlLabel4.TabIndex = 94;
            this.guna2HtmlLabel4.Text = "Genre:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Maroon;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(918, 477);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(110, 22);
            this.guna2HtmlLabel5.TabIndex = 95;
            this.guna2HtmlLabel5.Text = "Issue Status:";
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1164, 528);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.BookListShowAllButton);
            this.Controls.Add(this.BookIssueInfo);
            this.Controls.Add(this.BookSearchIssueRadio);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BookIdInfo);
            this.Controls.Add(this.BookSearchRadioGenre);
            this.Controls.Add(this.BookSearchRadioAuthor);
            this.Controls.Add(this.BookSearchRadioBookName);
            this.Controls.Add(this.BookSearchRadioId);
            this.Controls.Add(this.BookGenreInfo);
            this.Controls.Add(this.BookAuthorInfo);
            this.Controls.Add(this.BookNameInfo);
            this.Controls.Add(this.SearchBtnBookList);
            this.Controls.Add(this.EnterlableBookList);
            this.Controls.Add(this.SearchLineBookList);
            this.Controls.Add(this.BookPictureBoxInfo);
            this.Controls.Add(this.DataGridBookList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookListForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookListForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookListForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel BookGenreInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel BookAuthorInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel BookNameInfo;
        private Guna.UI2.WinForms.Guna2TileButton SearchBtnBookList;
        private Guna.UI2.WinForms.Guna2HtmlLabel EnterlableBookList;
        private Guna.UI2.WinForms.Guna2TextBox SearchLineBookList;
        private System.Windows.Forms.PictureBox BookPictureBoxInfo;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridBookList;
        private Guna.UI2.WinForms.Guna2RadioButton BookSearchRadioAuthor;
        private Guna.UI2.WinForms.Guna2RadioButton BookSearchRadioBookName;
        private Guna.UI2.WinForms.Guna2RadioButton BookSearchRadioId;
        private Guna.UI2.WinForms.Guna2RadioButton BookSearchRadioGenre;
        private Guna.UI2.WinForms.Guna2HtmlLabel BookIdInfo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox hide;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ExitBtn;
        private Guna.UI2.WinForms.Guna2RadioButton BookSearchIssueRadio;
        private Guna.UI2.WinForms.Guna2HtmlLabel BookIssueInfo;
        private Guna.UI2.WinForms.Guna2TileButton BookListShowAllButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}