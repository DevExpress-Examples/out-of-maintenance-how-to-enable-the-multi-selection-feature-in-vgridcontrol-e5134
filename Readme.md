<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128638661/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5134)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# How to enable the Multi Selection feature in VGridControl
---
## This feature is available out-of-the-box starting with version 16.1
---
<br><strong>For earlier versions:</strong><br><br>These examples illustrate how to enable the <strong>Multi Selection</strong> feature in the <strong>VGridControl</strong>. Simply place the <strong>SelectionProvider </strong>component onto a form. Since this component implements the <strong>IExtenderProvider </strong>interface, the <strong>MultiSelect </strong><strong>property </strong>will be shown for the VGridControl in the Visual Studio Property Grid. So, you will be able to turn this option on at design time. At runtime, use the <strong>SelectionProvider.SetMultiSelect method</strong>.</p>
<br>
<p>In short, selection operates in a similar manner as in the GridControl. By holding <strong>SHIFT</strong>, you can select cell ranges while by holding <strong>CTRL</strong>, you can select individual cells. In addition, category rows can be selected as well.</p>
<p><br> In the case of a <strong>MultiEditorRow</strong>, separate cells within this row can be selected by holding <strong>CTRL</strong>. If you hold <strong>SHIFT</strong>, a whole MultiEditorRow will be selected.</p>

<br/>


