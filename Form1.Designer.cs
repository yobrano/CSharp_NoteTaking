namespace NoteTaker
{
    partial class NoteTakingForm
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
            this.TextLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NotesDataGrid = new System.Windows.Forms.DataGridView();
            this.TitleField = new System.Windows.Forms.TextBox();
            this.ContentsField = new System.Windows.Forms.TextBox();
            this.ContentsLabel = new System.Windows.Forms.Label();
            this.NewButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.NotesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NotesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(12, 9);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(30, 13);
            this.TextLabel.TabIndex = 0;
            this.TextLabel.Text = "Title:";
            this.TextLabel.Click += new System.EventHandler(this.TextLabel_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(114, 448);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NotesDataGrid
            // 
            this.NotesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NotesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotesDataGrid.Location = new System.Drawing.Point(431, 65);
            this.NotesDataGrid.Name = "NotesDataGrid";
            this.NotesDataGrid.Size = new System.Drawing.Size(343, 402);
            this.NotesDataGrid.TabIndex = 2;
            this.NotesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NotesDataGrid_CellContentClick);
            this.NotesDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NotesDataGrid_CellDoubleClick);
            // 
            // TitleField
            // 
            this.TitleField.Location = new System.Drawing.Point(15, 26);
            this.TitleField.Name = "TitleField";
            this.TitleField.Size = new System.Drawing.Size(275, 20);
            this.TitleField.TabIndex = 3;
            this.TitleField.TextChanged += new System.EventHandler(this.TitleField_TextChanged);
            // 
            // ContentsField
            // 
            this.ContentsField.Location = new System.Drawing.Point(12, 65);
            this.ContentsField.Multiline = true;
            this.ContentsField.Name = "ContentsField";
            this.ContentsField.Size = new System.Drawing.Size(384, 373);
            this.ContentsField.TabIndex = 4;
            this.ContentsField.Text = " ";
            this.ContentsField.TextChanged += new System.EventHandler(this.ContentsField_TextChanged);
            // 
            // ContentsLabel
            // 
            this.ContentsLabel.AutoSize = true;
            this.ContentsLabel.Location = new System.Drawing.Point(12, 49);
            this.ContentsLabel.Name = "ContentsLabel";
            this.ContentsLabel.Size = new System.Drawing.Size(52, 13);
            this.ContentsLabel.TabIndex = 5;
            this.ContentsLabel.Text = "Contents:";
            this.ContentsLabel.Click += new System.EventHandler(this.ContentsLabel_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(12, 448);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 6;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(699, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(601, 12);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 7;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Location = new System.Drawing.Point(428, 49);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(38, 13);
            this.NotesLabel.TabIndex = 9;
            this.NotesLabel.Text = "Notes:";
            this.NotesLabel.Click += new System.EventHandler(this.NotesLabel_Click);
            // 
            // NoteTakingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(789, 479);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.ContentsLabel);
            this.Controls.Add(this.ContentsField);
            this.Controls.Add(this.TitleField);
            this.Controls.Add(this.NotesDataGrid);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TextLabel);
            this.Name = "NoteTakingForm";
            this.Text = "Note Taking";
            this.Load += new System.EventHandler(this.NoteTakingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView NotesDataGrid;
        private System.Windows.Forms.TextBox TitleField;
        private System.Windows.Forms.TextBox ContentsField;
        private System.Windows.Forms.Label ContentsLabel;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label NotesLabel;
    }
}

