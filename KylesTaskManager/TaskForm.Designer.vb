<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        tbDesc = New TextBox()
        tbTitle = New TextBox()
        DateTimePicker = New DateTimePicker()
        Button1 = New Button()
        Button2 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(29, 15)
        Label1.TabIndex = 0
        Label1.Text = "Title"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 1
        Label2.Text = "Description"
        ' 
        ' tbDesc
        ' 
        tbDesc.Location = New Point(12, 80)
        tbDesc.Multiline = True
        tbDesc.Name = "tbDesc"
        tbDesc.Size = New Size(349, 73)
        tbDesc.TabIndex = 2
        ' 
        ' tbTitle
        ' 
        tbTitle.Location = New Point(12, 27)
        tbTitle.Name = "tbTitle"
        tbTitle.Size = New Size(349, 23)
        tbTitle.TabIndex = 1
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.Location = New Point(12, 183)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(349, 23)
        DateTimePicker.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(77, 245)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 23)
        Button1.TabIndex = 4
        Button1.Text = "OK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(209, 245)
        Button2.Name = "Button2"
        Button2.Size = New Size(95, 23)
        Button2.TabIndex = 5
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 7
        Label3.Text = "Due Date"
        ' 
        ' TaskForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(373, 280)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker)
        Controls.Add(tbTitle)
        Controls.Add(tbDesc)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "TaskForm"
        Text = "Task "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbDesc As TextBox
    Friend WithEvents tbTitle As TextBox
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
End Class
