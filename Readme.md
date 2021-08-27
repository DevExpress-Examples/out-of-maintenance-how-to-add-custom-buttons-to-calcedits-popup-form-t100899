<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128618802/14.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T100899)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[CalcEditDescendant.cs](./CS/WindowsFormsApplication5/CalcEditDescendant.cs) (VB: [CalcEditDescendant.vb](./VB/WindowsFormsApplication5/CalcEditDescendant.vb))**
* [Form1.cs](./CS/WindowsFormsApplication5/Form1.cs) (VB: [Form1.Designer.vb](./VB/WindowsFormsApplication5/Form1.Designer.vb))
* [Form1.Designer.cs](./CS/WindowsFormsApplication5/Form1.Designer.cs) (VB: [Form1.Designer.vb](./VB/WindowsFormsApplication5/Form1.Designer.vb))
* [PopupCalcEditFormDescendant.cs](./CS/WindowsFormsApplication5/PopupCalcEditFormDescendant.cs) (VB: [PopupCalcEditFormDescendant.vb](./VB/WindowsFormsApplication5/PopupCalcEditFormDescendant.vb))
* [Program.cs](./CS/WindowsFormsApplication5/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication5/Program.vb))
* [UserControl1.cs](./CS/WindowsFormsApplication5/UserControl1.cs) (VB: [UserControl1.Designer.vb](./VB/WindowsFormsApplication5/UserControl1.Designer.vb))
* [UserControl1.Designer.cs](./CS/WindowsFormsApplication5/UserControl1.Designer.cs) (VB: [UserControl1.Designer.vb](./VB/WindowsFormsApplication5/UserControl1.Designer.vb))
<!-- default file list end -->
# How to add custom buttons to CalcEdit's popup form


<p>This example demonstrates how to add custom buttons to CalcEdit's popup form. It is necessary to create a CalcEdit descendant, override its CreatePopupForm and return a PopupCalcEditForm descendant. After that override the PopupCalcEditForm's ShowPopupForm method and add the required buttons to its Control collection.  </p>
<p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-add-custom-buttons-to-calcedits-popup-form-t100899/14.1.4+/media/794deece-4d2b-11e4-80ba-00155d624807.png"></p>

<br/>


