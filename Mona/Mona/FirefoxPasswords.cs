using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mona
{
    public partial class FirefoxPasswords : KryptonForm
    {        
        public FirefoxPasswords()
        {
            InitializeComponent();
        }        
        private void FirefoxPasswords_Load(object sender, EventArgs e)
        {
            FireFox fireFox = new FireFox();
            IEnumerable<CredentialModel> dt = fireFox.ReadPasswords();
            kryptonDataGridView1.DataSource = dt;
        }
    }
    
}

