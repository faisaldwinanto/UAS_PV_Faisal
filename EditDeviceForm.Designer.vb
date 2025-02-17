<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditDeviceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtRoom = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnUpdate = New Button()
        cmbLocation = New ComboBox()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(127, 17)
        txtName.Name = "txtName"
        txtName.Size = New Size(185, 23)
        txtName.TabIndex = 0
        ' 
        ' txtRoom
        ' 
        txtRoom.Location = New Point(127, 61)
        txtRoom.Name = "txtRoom"
        txtRoom.Size = New Size(185, 23)
        txtRoom.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 15)
        Label1.TabIndex = 3
        Label1.Text = "Nama Perangkat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 4
        Label2.Text = "Ruangan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 5
        Label3.Text = "Lokus"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(237, 168)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' cmbLocation
        ' 
        cmbLocation.FormattingEnabled = True
        cmbLocation.Location = New Point(127, 107)
        cmbLocation.Name = "cmbLocation"
        cmbLocation.Size = New Size(185, 23)
        cmbLocation.TabIndex = 7
        ' 
        ' EditDeviceForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(342, 225)
        Controls.Add(cmbLocation)
        Controls.Add(btnUpdate)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtRoom)
        Controls.Add(txtName)
        Name = "EditDeviceForm"
        Text = "EditDeviceForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtRoom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cmbLocation As ComboBox
End Class
