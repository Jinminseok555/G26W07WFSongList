namespace G26W07WFSongList {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            listSong = new ListBox();
            txtTitle = new TextBox();
            txtArtist = new TextBox();
            txtRating = new TextBox();
            btnAdd = new Button();
            txtSelected = new TextBox();
            btnDelete = new Button();
            txtFilter = new TextBox();
            SuspendLayout();
            // 
            // listSong
            // 
            listSong.FormattingEnabled = true;
            listSong.Location = new Point(12, 75);
            listSong.Name = "listSong";
            listSong.Size = new Size(760, 394);
            listSong.TabIndex = 0;
            listSong.SelectedIndexChanged += OnChanged;
            listSong.DoubleClick += OnYouTube;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 478);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "제목";
            txtTitle.Size = new Size(362, 35);
            txtTitle.TabIndex = 1;
            txtTitle.TextChanged += textBox1_TextChanged;
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(380, 478);
            txtArtist.Name = "txtArtist";
            txtArtist.PlaceholderText = "가수";
            txtArtist.Size = new Size(179, 35);
            txtArtist.TabIndex = 2;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(565, 477);
            txtRating.MaxLength = 1;
            txtRating.Name = "txtRating";
            txtRating.PlaceholderText = "평점";
            txtRating.Size = new Size(100, 35);
            txtRating.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(672, 478);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OnAdd;
            // 
            // txtSelected
            // 
            txtSelected.Location = new Point(12, 519);
            txtSelected.Name = "txtSelected";
            txtSelected.PlaceholderText = "삭제를 위한 선택된 노래";
            txtSelected.Size = new Size(653, 35);
            txtSelected.TabIndex = 5;
            txtSelected.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(672, 518);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += OnDelete;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(12, 12);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = "제목 또는 가수 검색";
            txtFilter.Size = new Size(760, 35);
            txtFilter.TabIndex = 7;
            txtFilter.TextChanged += OnFilterChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 584);
            Controls.Add(txtFilter);
            Controls.Add(btnDelete);
            Controls.Add(txtSelected);
            Controls.Add(btnAdd);
            Controls.Add(txtRating);
            Controls.Add(txtArtist);
            Controls.Add(txtTitle);
            Controls.Add(listSong);
            Name = "Form1";
            Text = "애창곡";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listSong;
        private TextBox txtTitle;
        private TextBox txtArtist;
        private TextBox txtRating;
        private Button btnAdd;
        private TextBox txtSelected;
        private Button btnDelete;
        private TextBox txtFilter;
    }
}
