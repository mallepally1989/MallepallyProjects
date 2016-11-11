using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Coromandel
{
    public partial class Welcome_Screen : Coromandel.Coromandel_MasterPage
    {

        public Welcome_Screen()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Location_Selection objLocSel = new Location_Selection();
            this.Hide();
            objLocSel.Show();
        }

        private void Welcome_Screen_Load(object sender, EventArgs e)
        {

        }

      
        
      
    }
}
