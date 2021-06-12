
namespace InfiLibProj
{
    partial class DeleteBookForm
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
            this.EnterBookIdDelete = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BookIDDelete = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeleteBookBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // EnterBookIdDelete
            // 
            this.EnterBookIdDelete.BackColor = System.Drawing.Color.Transparent;
            this.EnterBookIdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterBookIdDelete.ForeColor = System.Drawing.Color.Black;
            this.EnterBookIdDelete.Location = new System.Drawing.Point(114, 88);
            this.EnterBookIdDelete.Name = "EnterBookIdDelete";
            this.EnterBookIdDelete.Size = new System.Drawing.Size(137, 26);
            this.EnterBookIdDelete.TabIndex = 66;
            this.EnterBookIdDelete.Text = "Enter Book ID: ";
            // 
            // BookIDDelete
            // 
            this.BookIDDelete.BorderColor = System.Drawing.Color.Black;
            this.BookIDDelete.BorderThickness = 2;
            this.BookIDDelete.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookIDDelete.DefaultText = "";
            this.BookIDDelete.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BookIDDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BookIDDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookIDDelete.DisabledState.Parent = this.BookIDDelete;
            this.BookIDDelete.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookIDDelete.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BookIDDelete.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.BookIDDelete.FocusedState.Parent = this.BookIDDelete;
            this.BookIDDelete.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.BookIDDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIDDelete.ForeColor = System.Drawing.Color.Black;
            this.BookIDDelete.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookIDDelete.HoverState.Parent = this.BookIDDelete;
            this.BookIDDelete.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BookIDDelete.Location = new System.Drawing.Point(280, 73);
            this.BookIDDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BookIDDelete.Name = "BookIDDelete";
            this.BookIDDelete.PasswordChar = '\0';
            this.BookIDDelete.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.BookIDDelete.PlaceholderText = "";
            this.BookIDDelete.SelectedText = "";
            this.BookIDDelete.ShadowDecoration.BorderRadius = 1;
            this.BookIDDelete.ShadowDecoration.Parent = this.BookIDDelete;
            this.BookIDDelete.Size = new System.Drawing.Size(163, 41);
            this.BookIDDelete.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.BookIDDelete.TabIndex = 65;
            // 
            // DeleteBookBtn
            // 
            this.DeleteBookBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBookBtn.CheckedState.Parent = this.DeleteBookBtn;
            this.DeleteBookBtn.CustomImages.Parent = this.DeleteBookBtn;
            this.DeleteBookBtn.FillColor = System.Drawing.Color.Black;
            this.DeleteBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBookBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBookBtn.HoverState.Parent = this.DeleteBookBtn;
            this.DeleteBookBtn.Location = new System.Drawing.Point(482, 65);
            this.DeleteBookBtn.Name = "DeleteBookBtn";
            this.DeleteBookBtn.ShadowDecoration.Parent = this.DeleteBookBtn;
            this.DeleteBookBtn.Size = new System.Drawing.Size(204, 49);
            this.DeleteBookBtn.TabIndex = 64;
            this.DeleteBookBtn.Text = "DELETE";
            this.DeleteBookBtn.Click += new System.EventHandler(this.DeleteBookBtn_Click);
            // 
            // DeleteBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(815, 560);
            this.Controls.Add(this.EnterBookIdDelete);
            this.Controls.Add(this.BookIDDelete);
            this.Controls.Add(this.DeleteBookBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteBookForm";
            this.Text = "DeleteBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel EnterBookIdDelete;
        private Guna.UI2.WinForms.Guna2TextBox BookIDDelete;
        private Guna.UI2.WinForms.Guna2TileButton DeleteBookBtn;
    }
}