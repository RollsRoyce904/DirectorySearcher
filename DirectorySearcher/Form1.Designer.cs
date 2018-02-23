namespace DirectorySearcher
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
            this.searchOne = new System.Windows.Forms.TextBox();
            this.searchTwo = new System.Windows.Forms.TextBox();
            this.searchThree = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filesBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.filePathView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchOne
            // 
            this.searchOne.Location = new System.Drawing.Point(143, 56);
            this.searchOne.Name = "searchOne";
            this.searchOne.Size = new System.Drawing.Size(154, 26);
            this.searchOne.TabIndex = 0;
            // 
            // searchTwo
            // 
            this.searchTwo.Location = new System.Drawing.Point(143, 115);
            this.searchTwo.Name = "searchTwo";
            this.searchTwo.Size = new System.Drawing.Size(154, 26);
            this.searchTwo.TabIndex = 1;
            // 
            // searchThree
            // 
            this.searchThree.Location = new System.Drawing.Point(143, 177);
            this.searchThree.Name = "searchThree";
            this.searchThree.Size = new System.Drawing.Size(154, 26);
            this.searchThree.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parameters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Text";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "File Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Output Type";
            // 
            // filesBox
            // 
            this.filesBox.FormattingEnabled = true;
            this.filesBox.HorizontalScrollbar = true;
            this.filesBox.ItemHeight = 20;
            this.filesBox.Location = new System.Drawing.Point(303, 56);
            this.filesBox.Name = "filesBox";
            this.filesBox.Size = new System.Drawing.Size(643, 404);
            this.filesBox.TabIndex = 7;
            this.filesBox.SelectedIndexChanged += new System.EventHandler(this.filesBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Files Found";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(79, 293);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 29);
            this.search.TabIndex = 9;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(210, 293);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 29);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // filePathView
            // 
            this.filePathView.AutoSize = true;
            this.filePathView.Location = new System.Drawing.Point(33, 526);
            this.filePathView.Name = "filePathView";
            this.filePathView.Size = new System.Drawing.Size(0, 20);
            this.filePathView.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 655);
            this.Controls.Add(this.filePathView);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filesBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchThree);
            this.Controls.Add(this.searchTwo);
            this.Controls.Add(this.searchOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchOne;
        private System.Windows.Forms.TextBox searchTwo;
        private System.Windows.Forms.TextBox searchThree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox filesBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label filePathView;
    }
}

