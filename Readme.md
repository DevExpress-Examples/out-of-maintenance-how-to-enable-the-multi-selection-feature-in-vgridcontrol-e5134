# How to enable the Multi Selection feature in VGridControl


<p><strong>This feature is a</strong><strong>vailab</strong><strong>l</strong><strong>e</strong><strong> out-of-the-box</strong><strong> starting from version 16.1</strong><strong>. <br></strong><br><strong>For earlier versions:</strong><br><br>These examples illustrate how to enable the <strong>Multi Selection</strong> feature in the <strong>VGridControl</strong>. Simply place the <strong>SelectionProvider </strong>component onto a form. Since this component implements the <strong>IExtenderProvider </strong>interface, the <strong>MultiSelect </strong><strong>property </strong>will be shown for the VGridControl in the Visual Studio Property Grid. So, you will be able to turn this option on at design time. At runtime, use the <strong>SelectionProvider.SetMultiSelect method</strong>.</p>
<br>
<p>In short, selection operates in a similar manner as in the GridControl. By holding <strong>SHIFT</strong>, you can select cell ranges while by holding <strong>CTRL</strong>, you can select individual cells. In addition, category rows can be selected as well.</p>
<p><br> In the case of a <strong>MultiEditorRow</strong>, separate cells within this row can be selected by holding <strong>CTRL</strong>. If you hold <strong>SHIFT</strong>, a whole MultiEditorRow will be selected.</p>

<br/>


