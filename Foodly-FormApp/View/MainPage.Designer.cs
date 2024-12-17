namespace Foodly_FormApp.View
{
    partial class MainPage
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
            MenuItemsButton = new Button();
            TablesButton = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // MenuItemsButton
            // 
            MenuItemsButton.Location = new Point(5, 30);
            MenuItemsButton.Name = "MenuItemsButton";
            MenuItemsButton.Size = new Size(150, 50);
            MenuItemsButton.TabIndex = 0;
            MenuItemsButton.Text = "Menu Items";
            MenuItemsButton.UseVisualStyleBackColor = true;
            // 
            // TablesButton
            // 
            TablesButton.Location = new Point(5, 90);
            TablesButton.Name = "TablesButton";
            TablesButton.Size = new Size(150, 50);
            TablesButton.TabIndex = 1;
            TablesButton.Text = "Tables";
            TablesButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(5, 150);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 2;
            button1.Text = "Settings";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MenuItemsButton);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(TablesButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(160, 210);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Navigation";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(groupBox1);
            Name = "MainPage";
            Text = "MainPage";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion


        private Button MenuItemsButton;
        private Button TablesButton;
        private Button button1;
        private GroupBox groupBox1;
    }
}