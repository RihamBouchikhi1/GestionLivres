namespace GestionLivres
{
    partial class Form1
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
            this.LBL_titre_form = new System.Windows.Forms.Label();
            this.LBL_title = new System.Windows.Forms.Label();
            this.LBL_Author = new System.Windows.Forms.Label();
            this.BTN_Delet = new System.Windows.Forms.Button();
            this.LBL_Price = new System.Windows.Forms.Label();
            this.BTN_Confirm = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Modify = new System.Windows.Forms.Button();
            this.BTN_New = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.ComboBox();
            this.Price = new System.Windows.Forms.ComboBox();
            this.Author = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LBL_titre_form
            // 
            this.LBL_titre_form.AutoSize = true;
            this.LBL_titre_form.Font = new System.Drawing.Font("Snap ITC", 15.85714F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_titre_form.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_titre_form.Location = new System.Drawing.Point(293, 9);
            this.LBL_titre_form.Name = "LBL_titre_form";
            this.LBL_titre_form.Size = new System.Drawing.Size(184, 48);
            this.LBL_titre_form.TabIndex = 0;
            this.LBL_titre_form.Text = "E-Books";
            // 
            // LBL_title
            // 
            this.LBL_title.AutoSize = true;
            this.LBL_title.Location = new System.Drawing.Point(123, 102);
            this.LBL_title.Name = "LBL_title";
            this.LBL_title.Size = new System.Drawing.Size(49, 25);
            this.LBL_title.TabIndex = 1;
            this.LBL_title.Text = "Title";
            this.LBL_title.Click += new System.EventHandler(this.LBL_title_Click);
            // 
            // LBL_Author
            // 
            this.LBL_Author.AutoSize = true;
            this.LBL_Author.Location = new System.Drawing.Point(123, 159);
            this.LBL_Author.Name = "LBL_Author";
            this.LBL_Author.Size = new System.Drawing.Size(70, 25);
            this.LBL_Author.TabIndex = 2;
            this.LBL_Author.Text = "Author";
            this.LBL_Author.Click += new System.EventHandler(this.LBL_Author_Click);
            // 
            // BTN_Delet
            // 
            this.BTN_Delet.Location = new System.Drawing.Point(323, 267);
            this.BTN_Delet.Name = "BTN_Delet";
            this.BTN_Delet.Size = new System.Drawing.Size(136, 41);
            this.BTN_Delet.TabIndex = 5;
            this.BTN_Delet.Text = "Delet";
            this.BTN_Delet.UseVisualStyleBackColor = true;
            this.BTN_Delet.Click += new System.EventHandler(this.BTN_Delet_Click);
            // 
            // LBL_Price
            // 
            this.LBL_Price.AutoSize = true;
            this.LBL_Price.Location = new System.Drawing.Point(123, 205);
            this.LBL_Price.Name = "LBL_Price";
            this.LBL_Price.Size = new System.Drawing.Size(56, 25);
            this.LBL_Price.TabIndex = 6;
            this.LBL_Price.Text = "Price";
            this.LBL_Price.Click += new System.EventHandler(this.LBL_Price_Click);
            // 
            // BTN_Confirm
            // 
            this.BTN_Confirm.Location = new System.Drawing.Point(403, 323);
            this.BTN_Confirm.Name = "BTN_Confirm";
            this.BTN_Confirm.Size = new System.Drawing.Size(136, 41);
            this.BTN_Confirm.TabIndex = 7;
            this.BTN_Confirm.Text = "Confirm";
            this.BTN_Confirm.UseVisualStyleBackColor = true;
            this.BTN_Confirm.Click += new System.EventHandler(this.BTN_Confirm_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(241, 323);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(136, 41);
            this.BTN_Cancel.TabIndex = 8;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Modify
            // 
            this.BTN_Modify.Location = new System.Drawing.Point(476, 267);
            this.BTN_Modify.Name = "BTN_Modify";
            this.BTN_Modify.Size = new System.Drawing.Size(136, 41);
            this.BTN_Modify.TabIndex = 9;
            this.BTN_Modify.Text = "Modify";
            this.BTN_Modify.UseVisualStyleBackColor = true;
            this.BTN_Modify.Click += new System.EventHandler(this.BTN_Modify_Click);
            // 
            // BTN_New
            // 
            this.BTN_New.Location = new System.Drawing.Point(170, 267);
            this.BTN_New.Name = "BTN_New";
            this.BTN_New.Size = new System.Drawing.Size(136, 41);
            this.BTN_New.TabIndex = 10;
            this.BTN_New.Text = "New";
            this.BTN_New.UseVisualStyleBackColor = true;
            this.BTN_New.Click += new System.EventHandler(this.BTN_New_Click);
            // 
            // Title
            // 
            this.Title.FormattingEnabled = true;
            this.Title.Location = new System.Drawing.Point(301, 95);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(214, 32);
            this.Title.TabIndex = 11;
            this.Title.SelectedIndexChanged += new System.EventHandler(this.Title_SelectedIndexChanged);
            // 
            // Price
            // 
            this.Price.FormattingEnabled = true;
            this.Price.Location = new System.Drawing.Point(301, 198);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(214, 32);
            this.Price.TabIndex = 12;
            this.Price.SelectedIndexChanged += new System.EventHandler(this.Price_SelectedIndexChanged);
            // 
            // Author
            // 
            this.Author.FormattingEnabled = true;
            this.Author.Location = new System.Drawing.Point(301, 152);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(214, 32);
            this.Author.TabIndex = 13;
            this.Author.SelectedIndexChanged += new System.EventHandler(this.Author_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.BTN_New);
            this.Controls.Add(this.BTN_Modify);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Confirm);
            this.Controls.Add(this.LBL_Price);
            this.Controls.Add(this.BTN_Delet);
            this.Controls.Add(this.LBL_Author);
            this.Controls.Add(this.LBL_title);
            this.Controls.Add(this.LBL_titre_form);
            this.Name = "Form1";
            this.Text = "BIBLIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_titre_form;
        private System.Windows.Forms.Label LBL_title;
        private System.Windows.Forms.Label LBL_Author;
        private System.Windows.Forms.Button BTN_Delet;
        private System.Windows.Forms.Label LBL_Price;
        private System.Windows.Forms.Button BTN_Confirm;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Modify;
        private System.Windows.Forms.Button BTN_New;
        private System.Windows.Forms.ComboBox Title;
        private System.Windows.Forms.ComboBox Price;
        private System.Windows.Forms.ComboBox Author;
    }
}

