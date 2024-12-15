using Foodly_FormApp.View;

namespace Foodly_FormApp
{
    public partial class IntroPage : Form
    {
        public IntroPage()
        {
            InitializeComponent();
        }

  

        private void IntroPage_Load(object sender, EventArgs e)
        {

        }

        private void IntroButton_Click(object sender, EventArgs e)
        {
            new MainPage().Show();
            this.Hide();
            
        }
    }
}
