Public Class TaskForm
    Public Property MyTask As New KylesTask()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MyTask.Title = tbTitle.Text
        MyTask.Description = tbDesc.Text
        MyTask.DueDate = DateTimePicker.Value

        Me.DialogResult = DialogResult.OK

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub TaskForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim isUninitialized As Boolean = String.IsNullOrEmpty(MyTask.Title) AndAlso
                                 String.IsNullOrEmpty(MyTask.Description) AndAlso
                                 MyTask.DueDate = DateTime.MinValue

        If Not isUninitialized Then
            tbTitle.Text = MyTask.Title
            tbDesc.Text = MyTask.Description
            DateTimePicker.Value = MyTask.DueDate
        End If
    End Sub
End Class