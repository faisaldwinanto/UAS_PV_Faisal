<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        ListBox1 = New ListBox()
        Label1 = New Label()
        BtnAdd = New Button()
        BtnDelete = New Button()
        BtnEdit = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(34, 82)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(334, 214)
        ListBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(88, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 15)
        Label1.TabIndex = 1
        Label1.Text = "Manajemen Perangkat Pusat Data"
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Location = New Point(34, 302)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(75, 23)
        BtnAdd.TabIndex = 2
        BtnAdd.Text = "Add"
        BtnAdd.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(117, 302)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(75, 23)
        BtnDelete.TabIndex = 3
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' BtnEdit
        ' 
        BtnEdit.Location = New Point(198, 302)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(75, 23)
        BtnEdit.TabIndex = 4
        BtnEdit.Text = "Edit"
        BtnEdit.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(392, 450)
        Controls.Add(BtnEdit)
        Controls.Add(BtnDelete)
        Controls.Add(BtnAdd)
        Controls.Add(Label1)
        Controls.Add(ListBox1)
        Name = "MainForm"
        Text = "MainForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
End Class
