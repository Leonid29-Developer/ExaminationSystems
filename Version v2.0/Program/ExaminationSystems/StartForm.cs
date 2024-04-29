using System;
using System.Windows.Forms;

namespace ExaminationSystems
{
    public partial class StartForm : Form
    {
        public StartForm() => InitializeComponent();

        private void Create_Button_Click(object sender, EventArgs e)
        {
            Hide(); new AddOrder().ShowDialog(); Show();
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            Hide(); new Authorization().ShowDialog(); Show();
        }
    }
}
