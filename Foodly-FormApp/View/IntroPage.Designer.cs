namespace Foodly_FormApp
{
    partial class IntroPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroPage));
            Heading = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.Font = new Font("Century Gothic", 80F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Heading.Location = new Point(471, 62);
            Heading.Name = "Heading";
            Heading.Size = new Size(399, 128);
            Heading.TabIndex = 0;
            Heading.Text = "Foodly";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 3;
            button1.Location = new Point(579, 591);
            button1.Name = "button1";
            button1.Size = new Size(200, 79);
            button1.TabIndex = 1;
            button1.Text = "Press HERE to enter";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(321, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(718, 469);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;

            // 
            // IntroPage
            // 
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1365, 729);
            Controls.Add(button1);
            Controls.Add(Heading);
            Controls.Add(pictureBox1);
            Name = "IntroPage";
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label Heading;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
