using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication5
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            SubscribeAllTheButtonsToOneButtonClickEvent();

        }

        private void SubscribeAllTheButtonsToOneButtonClickEvent()
        {
            foreach (Control control in layoutControl1.Controls)
            {
                if (control is SimpleButton)
                {
                    SimpleButton button = control as SimpleButton;
                    button.Click += button_Click;      
                }
            }
        }

        void button_Click(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            MessageBox.Show(button.Text + " button was clicked"); 
        }
    }
}
