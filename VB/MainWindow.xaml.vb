Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace How_to_Drag_and_Drop_Between_GridControls

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.gridControl1.ItemsSource = Staff.GetStaff1()
            Me.gridControl2.ItemsSource = Staff.GetStaff2()
        End Sub

        Private Sub OnDragRecordOver(ByVal sender As Object, ByVal e As DragRecordOverEventArgs)
            If e.IsFromOutside AndAlso GetType(Employee).IsAssignableFrom(e.GetRecordType()) Then
                e.Effects = DragDropEffects.Move
                e.Handled = True
            End If
        End Sub
    End Class
End Namespace
