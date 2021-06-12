
namespace InfiLibProj
{
    partial class DeleteStudentForm
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
            this.EnterIdDelete = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.StIDDelete = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeleteStudentBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // EnterIdDelete
            // 
            this.EnterIdDelete.BackColor = System.Drawing.Color.Transparent;
            this.EnterIdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterIdDelete.ForeColor = System.Drawing.Color.Black;
            this.EnterIdDelete.Location = new System.Drawing.Point(114, 88);
            this.EnterIdDelete.Name = "EnterIdDelete";
            this.EnterIdDelete.Size = new System.Drawing.Size(158, 26);
            this.EnterIdDelete.TabIndex = 63;
            this.EnterIdDelete.Text = "Enter student ID: ";
            // 
            // StIDDelete
            // 
            this.StIDDelete.BorderColor = System.Drawing.Color.Black;
            this.StIDDelete.BorderThickness = 2;
            this.StIDDelete.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StIDDelete.DefaultText = "";
            this.StIDDelete.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StIDDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StIDDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StIDDelete.DisabledState.Parent = this.StIDDelete;
            this.StIDDelete.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StIDDelete.FillColor = System.Drawing.Color.WhiteSmoke;
            this.StIDDelete.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(205)))));
            this.StIDDelete.FocusedState.Parent = this.StIDDelete;
            this.StIDDelete.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.StIDDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StIDDelete.ForeColor = System.Drawing.Color.Black;
            this.StIDDelete.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StIDDelete.HoverState.Parent = this.StIDDelete;
            this.StIDDelete.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StIDDelete.Location = new System.Drawing.Point(295, 73);
            this.StIDDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StIDDelete.Name = "StIDDelete";
            this.StIDDelete.PasswordChar = '\0';
            this.StIDDelete.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.StIDDelete.PlaceholderText = "";
            this.StIDDelete.SelectedText = "";
            this.StIDDelete.ShadowDecoration.BorderRadius = 1;
            this.StIDDelete.ShadowDecoration.Parent = this.StIDDelete;
            this.StIDDelete.Size = new System.Drawing.Size(163, 41);
            this.StIDDelete.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.StIDDelete.TabIndex = 62;
            // 
            // DeleteStudentBtn
            // 
            this.DeleteStudentBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteStudentBtn.CheckedState.Parent = this.DeleteStudentBtn;
            this.DeleteStudentBtn.CustomImages.Parent = this.DeleteStudentBtn;
            this.DeleteStudentBtn.FillColor = System.Drawing.Color.Black;
            this.DeleteStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteStudentBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteStudentBtn.HoverState.Parent = this.DeleteStudentBtn;
            this.DeleteStudentBtn.Location = new System.Drawing.Point(505, 65);
            this.DeleteStudentBtn.Name = "DeleteStudentBtn";
            this.DeleteStudentBtn.ShadowDecoration.Parent = this.DeleteStudentBtn;
            this.DeleteStudentBtn.Size = new System.Drawing.Size(204, 49);
            this.DeleteStudentBtn.TabIndex = 61;
            this.DeleteStudentBtn.Text = "DELETE";
            this.DeleteStudentBtn.Click += new System.EventHandler(this.DeleteStudentBtn_Click);
            // 
            // DeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(815, 560);
            this.Controls.Add(this.EnterIdDelete);
            this.Controls.Add(this.StIDDelete);
            this.Controls.Add(this.DeleteStudentBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteStudentForm";
            this.Text = "DeleteStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel EnterIdDelete;
        private Guna.UI2.WinForms.Guna2TextBox StIDDelete;
        private Guna.UI2.WinForms.Guna2TileButton DeleteStudentBtn;
    }
}