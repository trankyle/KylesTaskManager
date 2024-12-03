Imports Newtonsoft.Json
Imports System.IO


Public Class TaskManagerForm
    Private taskList As New List(Of KylesTask)()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewTasks.SelectedIndexChanged

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim taskForm As New TaskForm()
        If taskForm.ShowDialog() = DialogResult.OK Then

            taskList.Add(taskForm.MyTask)
            Debug.WriteLine("Title: " & taskForm.MyTask.Title)
            UpdateTaskListView()
        End If

    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If listViewTasks.SelectedItems.Count > 0 Then
            Dim index As Integer = listViewTasks.SelectedItems(0).Index
            Dim selectedTask As KylesTask = taskList(index)

            Dim taskForm As New TaskForm()
            taskForm.MyTask = selectedTask
            If taskForm.ShowDialog() = DialogResult.OK Then
                taskList(index) = taskForm.MyTask
                UpdateTaskListView()
            End If
        Else
            MessageBox.Show("Please select a task to edit.")
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If listViewTasks.SelectedItems.Count > 0 Then
            Dim index As Integer = listViewTasks.SelectedItems(0).Index
            taskList.RemoveAt(index)
            UpdateTaskListView()
        Else
            MessageBox.Show("Please select a task to delete.")
        End If
    End Sub
    Private Sub UpdateTaskListView()
        listViewTasks.Items.Clear()
        For Each task In taskList
            Dim item As New ListViewItem(task.Title)
            item.SubItems.Add(task.Description)
            item.SubItems.Add(task.DueDate.ToShortDateString())
            listViewTasks.Items.Add(item)
        Next
    End Sub
    Private Sub SaveTasksToFile(filePath As String)
        Dim json As String = JsonConvert.SerializeObject(taskList)
        File.WriteAllText(filePath, json)
    End Sub
    Private Sub LoadTasksFromFile(filePath As String)
        Dim json As String = File.ReadAllText(filePath)
        taskList = JsonConvert.DeserializeObject(Of List(Of KylesTask))(json)
        UpdateTaskListView()
    End Sub
    Private Sub saveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveTasksToFile("tasks.json")
    End Sub
    Private Sub loadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        LoadTasksFromFile("tasks.json")
    End Sub
    Private Sub aboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Created by Kyle Tran", "About")
    End Sub


End Class
