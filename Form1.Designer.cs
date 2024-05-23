namespace CatProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            buttonShow = new Button();
            buttonShowSelectedBreed = new Button();
            buttonShowBreedColor = new Button();
            buttonAllfourCriteria = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(662, 281);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(36, 323);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(248, 323);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.Sorted = true;
            comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(434, 323);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 3;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(644, 323);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 4;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(51, 405);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(121, 42);
            buttonShow.TabIndex = 5;
            buttonShow.Text = "Show All";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // buttonShowSelectedBreed
            // 
            buttonShowSelectedBreed.Location = new Point(232, 405);
            buttonShowSelectedBreed.Name = "buttonShowSelectedBreed";
            buttonShowSelectedBreed.Size = new Size(121, 42);
            buttonShowSelectedBreed.TabIndex = 6;
            buttonShowSelectedBreed.Text = "Show Selected Breed";
            buttonShowSelectedBreed.UseVisualStyleBackColor = true;
            buttonShowSelectedBreed.Click += buttonShowSelectedBreed_Click;
            // 
            // buttonShowBreedColor
            // 
            buttonShowBreedColor.Location = new Point(409, 405);
            buttonShowBreedColor.Name = "buttonShowBreedColor";
            buttonShowBreedColor.Size = new Size(121, 42);
            buttonShowBreedColor.TabIndex = 7;
            buttonShowBreedColor.Text = "Show Selected Breed and Color";
            buttonShowBreedColor.UseVisualStyleBackColor = true;
            buttonShowBreedColor.Click += buttonShowBreedColor_Click;
            // 
            // buttonAllfourCriteria
            // 
            buttonAllfourCriteria.Location = new Point(599, 405);
            buttonAllfourCriteria.Name = "buttonAllfourCriteria";
            buttonAllfourCriteria.Size = new Size(121, 42);
            buttonAllfourCriteria.TabIndex = 8;
            buttonAllfourCriteria.Text = "Show Selected All 4 Criteria";
            buttonAllfourCriteria.UseVisualStyleBackColor = true;
            buttonAllfourCriteria.Click += buttonAllfourCriteria_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 541);
            Controls.Add(buttonAllfourCriteria);
            Controls.Add(buttonShowBreedColor);
            Controls.Add(buttonShowSelectedBreed);
            Controls.Add(buttonShow);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Cat Types";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button buttonShow;
        private Button buttonShowSelectedBreed;
        private Button buttonShowBreedColor;
        private Button buttonAllfourCriteria;
    }
}
