
namespace InfiLibProj
{
    partial class EditStudentForm
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
            this.EditStudentBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.SelectBtnEdit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GenderLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.StGenderEdit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.EditPictureBox = new System.Windows.Forms.PictureBox();
            this.StEmailEdit = new Guna.UI2.WinForms.Guna2TextBox();
            this.StPhoneEdit = new Guna.UI2.WinForms.Guna2TextBox();
            this.StLNameEdit = new Guna.UI2.WinForms.Guna2TextBox();
            this.StFNameEdit = new Guna.UI2.WinForms.Guna2TextBox();
            this.StIDEdit = new Guna.UI2.WinForms.Guna2TextBox();
            this.EnterIDEdit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SearchBtnEdit = new Guna.UI2.WinForms.Guna2TileButton();
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EditStudentBtn
            // 
            this.EditStudentBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditStudentBtn.CheckedState.Parent = this.EditStudentBtn;
            this.EditStudentBtn.CustomImages.Parent = this.EditStudentBtn;
            this.EditStudentBtn.FillColor = System.Drawing.Color.Black;
            this.EditStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStudentBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EditStudentBtn.HoverState.Parent = this.EditStudentBtn;
            this.EditStudentBtn.Location = new System.Drawing.Point(292, 477);
            this.EditStudentBtn.Name = "EditStudentBtn";
            this.EditStudentBtn.ShadowDecoration.Parent = this.EditStudentBtn;
            this.EditStudentBtn.Size = new System.Drawing.Size(268, 61);
            this.EditStudentBtn.TabIndex = 58;
            this.EditStudentBtn.Text = "Edit Student Info";
            this.EditStudentBtn.Click += new System.EventHandler(this.EditStudentBtn_Click);
            // 
            // SelectBtnEdit
            // 
            this.SelectBtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.SelectBtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectBtnEdit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SelectBtnEdit.Location = new System.Drawing.Point(463, 413);
            this.SelectBtnEdit.Name = "SelectBtnEdit";
            this.SelectBtnEdit.Size = new System.Drawing.Size(226, 22);
            this.SelectBtnEdit.TabIndex = 57;
            this.SelectBtnEdit.Text = "Select picture from device...";
            this.SelectBtnEdit.Click += new System.EventHandler(this.SelectBtnEdit_Click);
            // 
            // GenderLabel
            // 
            this.GenderLabel.BackColor = System.Drawing.Color.Transparent;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.GenderLabel.ForeColor = System.Drawing.Color.Gray;
            this.GenderLabel.Location = new System.Drawing.Point(148, 201);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(63, 22);
            this.GenderLabel.TabIndex = 56;
            this.GenderLabel.Text = "Gender";
            // 
            // StGenderEdit
            // 
            this.StGenderEdit.Animated = true;
            this.StGenderEdit.BackColor = System.Drawing.Color.Transparent;
            this.StGenderEdit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StGenderEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StGenderEdit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StGenderEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StGenderEdit.FocusedState.Parent = this.StGenderEdit;
            this.StGenderEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold);
            this.StGenderEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.StGenderEdit.HoverState.Parent = this.StGenderEdit;
            this.StGenderEdit.ItemHeight = 30;
            this.StGenderEdit.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.StGenderEdit.ItemsAppearance.Parent = this.StGenderEdit;
            this.StGenderEdit.Location = new System.Drawing.Point(137, 229);
            this.StGenderEdit.Name = "StGenderEdit";
            this.StGenderEdit.ShadowDecoration.Parent = this.StGenderEdit;
            this.StGenderEdit.Size = new System.Drawing.Size(179, 36);
            this.StGenderEdit.TabIndex = 55;
            // 
            // EditPictureBox
            // 
            this.EditPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.EditPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditPictureBox.Location = new System.Drawing.Point(453, 188);
            this.EditPictureBox.Name = "EditPictureBox";
            this.EditPictureBox.Size = new System.Drawing.Size(241, 219);
            this.EditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditPictureBox.TabIndex = 54;
            this.EditPictureBox.TabStop = false;
            // 
            // StEmailEdit
            // 
            this.StEmailEdit.BorderColor = System.Drawing.Color.Black;
            this.StEmailEdit.BorderThickness = 2;
            this.StEmailEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StEmailEdit.DefaultText = "";
            this.StEmailEdit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StEmailEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StEmailEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StEmailEdit.DisabledState.Parent = this.StEmailEdit;
            this.StEmailEdit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StEmailEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.StEmailEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.StEmailEdit.FocusedState.Parent = this.StEmailEdit;
            this.StEmailEdit.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.StEmailEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StEmailEdit.ForeColor = System.Drawing.Color.Black;
            this.StEmailEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StEmailEdit.HoverState.Parent = this.StEmailEdit;
            this.StEmailEdit.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StEmailEdit.Location = new System.Drawing.Point(137, 305);
            this.StEmailEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StEmailEdit.Name = "StEmailEdit";
            this.StEmailEdit.PasswordChar = '\0';
            this.StEmailEdit.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.StEmailEdit.PlaceholderText = "Email";
            this.StEmailEdit.SelectedText = "";
            this.StEmailEdit.ShadowDecoration.BorderRadius = 1;
            this.StEmailEdit.ShadowDecoration.Parent = this.StEmailEdit;
            this.StEmailEdit.Size = new System.Drawing.Size(251, 40);
            this.StEmailEdit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.StEmailEdit.TabIndex = 53;
            // 
            // StPhoneEdit
            // 
            this.StPhoneEdit.BorderColor = System.Drawing.Color.Black;
            this.StPhoneEdit.BorderThickness = 2;
            this.StPhoneEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StPhoneEdit.DefaultText = "";
            this.StPhoneEdit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StPhoneEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StPhoneEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StPhoneEdit.DisabledState.Parent = this.StPhoneEdit;
            this.StPhoneEdit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StPhoneEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.StPhoneEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.StPhoneEdit.FocusedState.Parent = this.StPhoneEdit;
            this.StPhoneEdit.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.StPhoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StPhoneEdit.ForeColor = System.Drawing.Color.Black;
            this.StPhoneEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StPhoneEdit.HoverState.Parent = this.StPhoneEdit;
            this.StPhoneEdit.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StPhoneEdit.Location = new System.Drawing.Point(137, 395);
            this.StPhoneEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StPhoneEdit.MaxLength = 12;
            this.StPhoneEdit.Name = "StPhoneEdit";
            this.StPhoneEdit.PasswordChar = '\0';
            this.StPhoneEdit.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.StPhoneEdit.PlaceholderText = "Phone Number";
            this.StPhoneEdit.SelectedText = "";
            this.StPhoneEdit.ShadowDecoration.BorderRadius = 1;
            this.StPhoneEdit.ShadowDecoration.Parent = this.StPhoneEdit;
            this.StPhoneEdit.Size = new System.Drawing.Size(251, 40);
            this.StPhoneEdit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.StPhoneEdit.TabIndex = 52;
            // 
            // StLNameEdit
            // 
            this.StLNameEdit.BorderColor = System.Drawing.Color.Black;
            this.StLNameEdit.BorderThickness = 2;
            this.StLNameEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StLNameEdit.DefaultText = "";
            this.StLNameEdit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StLNameEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StLNameEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StLNameEdit.DisabledState.Parent = this.StLNameEdit;
            this.StLNameEdit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StLNameEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.StLNameEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.StLNameEdit.FocusedState.Parent = this.StLNameEdit;
            this.StLNameEdit.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.StLNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StLNameEdit.ForeColor = System.Drawing.Color.Black;
            this.StLNameEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StLNameEdit.HoverState.Parent = this.StLNameEdit;
            this.StLNameEdit.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StLNameEdit.Location = new System.Drawing.Point(445, 120);
            this.StLNameEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StLNameEdit.Name = "StLNameEdit";
            this.StLNameEdit.PasswordChar = '\0';
            this.StLNameEdit.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.StLNameEdit.PlaceholderText = "Last name";
            this.StLNameEdit.SelectedText = "";
            this.StLNameEdit.ShadowDecoration.BorderRadius = 1;
            this.StLNameEdit.ShadowDecoration.Parent = this.StLNameEdit;
            this.StLNameEdit.Size = new System.Drawing.Size(256, 40);
            this.StLNameEdit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.StLNameEdit.TabIndex = 51;
            // 
            // StFNameEdit
            // 
            this.StFNameEdit.BorderColor = System.Drawing.Color.Black;
            this.StFNameEdit.BorderThickness = 2;
            this.StFNameEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StFNameEdit.DefaultText = "";
            this.StFNameEdit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StFNameEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StFNameEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StFNameEdit.DisabledState.Parent = this.StFNameEdit;
            this.StFNameEdit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StFNameEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.StFNameEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.StFNameEdit.FocusedState.Parent = this.StFNameEdit;
            this.StFNameEdit.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.StFNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StFNameEdit.ForeColor = System.Drawing.Color.Black;
            this.StFNameEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StFNameEdit.HoverState.Parent = this.StFNameEdit;
            this.StFNameEdit.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StFNameEdit.Location = new System.Drawing.Point(137, 120);
            this.StFNameEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StFNameEdit.Name = "StFNameEdit";
            this.StFNameEdit.PasswordChar = '\0';
            this.StFNameEdit.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.StFNameEdit.PlaceholderText = "First name";
            this.StFNameEdit.SelectedText = "";
            this.StFNameEdit.ShadowDecoration.BorderRadius = 1;
            this.StFNameEdit.ShadowDecoration.Parent = this.StFNameEdit;
            this.StFNameEdit.Size = new System.Drawing.Size(251, 40);
            this.StFNameEdit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.StFNameEdit.TabIndex = 50;
            // 
            // StIDEdit
            // 
            this.StIDEdit.BorderColor = System.Drawing.Color.Black;
            this.StIDEdit.BorderThickness = 2;
            this.StIDEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StIDEdit.DefaultText = "";
            this.StIDEdit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StIDEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StIDEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StIDEdit.DisabledState.Parent = this.StIDEdit;
            this.StIDEdit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StIDEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.StIDEdit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.StIDEdit.FocusedState.Parent = this.StIDEdit;
            this.StIDEdit.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.StIDEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StIDEdit.ForeColor = System.Drawing.Color.Black;
            this.StIDEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StIDEdit.HoverState.Parent = this.StIDEdit;
            this.StIDEdit.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StIDEdit.Location = new System.Drawing.Point(313, 37);
            this.StIDEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StIDEdit.Name = "StIDEdit";
            this.StIDEdit.PasswordChar = '\0';
            this.StIDEdit.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.StIDEdit.PlaceholderText = "";
            this.StIDEdit.SelectedText = "";
            this.StIDEdit.ShadowDecoration.BorderRadius = 1;
            this.StIDEdit.ShadowDecoration.Parent = this.StIDEdit;
            this.StIDEdit.Size = new System.Drawing.Size(190, 41);
            this.StIDEdit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.StIDEdit.TabIndex = 59;
            // 
            // EnterIDEdit
            // 
            this.EnterIDEdit.BackColor = System.Drawing.Color.Transparent;
            this.EnterIDEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterIDEdit.ForeColor = System.Drawing.Color.Black;
            this.EnterIDEdit.Location = new System.Drawing.Point(137, 52);
            this.EnterIDEdit.Name = "EnterIDEdit";
            this.EnterIDEdit.Size = new System.Drawing.Size(158, 26);
            this.EnterIDEdit.TabIndex = 60;
            this.EnterIDEdit.Text = "Enter student ID: ";
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
            this.SearchBtnEdit.Location = new System.Drawing.Point(541, 38);
            this.SearchBtnEdit.Name = "SearchBtnEdit";
            this.SearchBtnEdit.ShadowDecoration.Parent = this.SearchBtnEdit;
            this.SearchBtnEdit.Size = new System.Drawing.Size(160, 40);
            this.SearchBtnEdit.TabIndex = 61;
            this.SearchBtnEdit.Text = "Search";
            this.SearchBtnEdit.Click += new System.EventHandler(this.SearchBtnEdit_Click);
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(814, 561);
            this.Controls.Add(this.SearchBtnEdit);
            this.Controls.Add(this.EnterIDEdit);
            this.Controls.Add(this.StIDEdit);
            this.Controls.Add(this.EditStudentBtn);
            this.Controls.Add(this.SelectBtnEdit);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.StGenderEdit);
            this.Controls.Add(this.EditPictureBox);
            this.Controls.Add(this.StEmailEdit);
            this.Controls.Add(this.StPhoneEdit);
            this.Controls.Add(this.StLNameEdit);
            this.Controls.Add(this.StFNameEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditStudentForm";
            this.Text = "EditStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton EditStudentBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel SelectBtnEdit;
        private Guna.UI2.WinForms.Guna2HtmlLabel GenderLabel;
        private Guna.UI2.WinForms.Guna2ComboBox StGenderEdit;
        private System.Windows.Forms.PictureBox EditPictureBox;
        private Guna.UI2.WinForms.Guna2TextBox StEmailEdit;
        private Guna.UI2.WinForms.Guna2TextBox StPhoneEdit;
        private Guna.UI2.WinForms.Guna2TextBox StLNameEdit;
        private Guna.UI2.WinForms.Guna2TextBox StFNameEdit;
        private Guna.UI2.WinForms.Guna2TextBox StIDEdit;
        private Guna.UI2.WinForms.Guna2HtmlLabel EnterIDEdit;
        private Guna.UI2.WinForms.Guna2TileButton SearchBtnEdit;
    }
}