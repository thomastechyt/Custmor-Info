Public Class Form1
    Private Sub CustmorTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustmorTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustmorTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustmorinfoDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustmorinfoDataSet.CustmorTable' table. You can move, or remove it, as needed.
        Me.CustmorTableTableAdapter.Fill(Me.CustmorinfoDataSet.CustmorTable)

    End Sub
End Class
