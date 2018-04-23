using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors;
using System.Drawing;

namespace WindowsFormsApplication5
{
    public class PopupCalcEditFormDescendant : PopupCalcEditForm
    {
        UserControl1 userControl;
        public PopupCalcEditFormDescendant(PopupBaseEdit ownerEdit)
            : base(ownerEdit)
        {
            userControl = new UserControl1();
           
        }
        public override void ShowPopupForm()
        {

            this.Height += userControl.Height;
            userControl.Dock = System.Windows.Forms.DockStyle.Bottom; 
            this.Controls.Add(userControl);
            base.ShowPopupForm();
        }
    }
}
