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
            IntroButton = new Button();
            IntroPageImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)IntroPageImage).BeginInit();
            SuspendLayout();
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.Font = new Font("Broadway", 80.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Heading.Location = new Point(384, 71);
            Heading.Name = "Heading";
            Heading.Size = new Size(434, 122);
            Heading.TabIndex = 0;
            Heading.Text = "Foodly";
            // 
            // IntroButton
            // 
            IntroButton.FlatAppearance.BorderSize = 3;
            IntroButton.Location = new Point(512, 572);
            IntroButton.Name = "IntroButton";
            IntroButton.Size = new Size(200, 79);
            IntroButton.TabIndex = 1;
            IntroButton.Text = "Press HERE to enter";
            IntroButton.UseVisualStyleBackColor = true;
            IntroButton.Click += this.IntroButton_Click;
            // 
            // IntroPageImage
            // 
            IntroPageImage.Image = (Image)resources.GetObject("IntroPageImage.Image");
            IntroPageImage.Location = new Point(249, 196);
            IntroPageImage.Name = "IntroPageImage";
            IntroPageImage.Size = new Size(718, 469);
            IntroPageImage.TabIndex = 2;
            IntroPageImage.TabStop = false;
            // 
            // IntroPage
            // 
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1184, 761);
            Controls.Add(IntroButton);
            Controls.Add(Heading);
            Controls.Add(IntroPageImage);
            Name = "IntroPage";
            Text = "Foodly";
            Load += IntroPage_Load;
            ((System.ComponentModel.ISupportInitialize)IntroPageImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label Heading;
        private Button IntroButton;
        private PictureBox IntroPageImage;
    }
}
