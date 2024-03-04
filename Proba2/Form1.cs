using System.Reflection;

namespace Proba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void futtat_button_Click(object sender, EventArgs e)
        {
            int egyik = int.Parse(egyik_textbox.Text);
            int masik = int.Parse(masik_textbox.Text);
            int ki = egyik + masik;
            MessageBox.Show(ki.ToString());

        }
    }
}
