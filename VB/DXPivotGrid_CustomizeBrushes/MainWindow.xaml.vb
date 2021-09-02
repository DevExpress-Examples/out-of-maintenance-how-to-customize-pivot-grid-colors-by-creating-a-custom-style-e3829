Imports System.Windows
Imports DXPivotGrid_CustomizeBrushes.DataSet1TableAdapters

Namespace DXPivotGrid_CustomizeBrushes
	Partial Public Class MainWindow
		Inherits Window

		Private salesPersonDataAdapter As New SalesPersonTableAdapter()
		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = salesPersonDataAdapter.GetData()
		End Sub
	End Class
End Namespace
