using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mona
{
    public partial class About___Mona : KryptonForm
    {
        public About___Mona()
        {
            InitializeComponent();
        }

        private void btnLove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your ❤️", "Thank you!");
        }

        private void linkedinlink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/achchutharengan/");
        }
    }
}
