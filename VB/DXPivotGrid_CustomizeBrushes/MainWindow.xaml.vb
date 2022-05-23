Imports System.Windows
Imports DXPivotGrid_CustomizeBrushes.DataSet1TableAdapters

Namespace DXPivotGrid_CustomizeBrushes

    Public Partial Class MainWindow
        Inherits Window

        Private salesPersonDataAdapter As SalesPersonTableAdapter = New SalesPersonTableAdapter()

        Public Sub New()
            Me.InitializeComponent()
            Me.pivotGridControl1.DataSource = salesPersonDataAdapter.GetData()
        End Sub
    End Class
End Namespace
