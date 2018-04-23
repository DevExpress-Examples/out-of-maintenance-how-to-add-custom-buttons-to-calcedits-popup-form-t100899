using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using System.ComponentModel;

namespace WindowsFormsApplication5
{
    [ToolboxItem(true)]
    public class CalcEditDescendant : CalcEdit
    {
        public CalcEditDescendant()
        {

        }
        protected override DevExpress.XtraEditors.Popup.PopupBaseForm CreatePopupForm()
        {
            return new PopupCalcEditFormDescendant(this); //base.CreatePopupForm();
        }
    }
}
