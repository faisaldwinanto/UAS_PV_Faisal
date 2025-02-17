<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDeviceForm
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
        txtName = New TextBox()
        txtRoom = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnSave = New Button()
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
        ' btnSave
        ' 
        btnSave.Location = New Point(237, 168)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 6
        btnSave.Text = "Simpan"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' cmbLocation
        ' 
        cmbLocation.FormattingEnabled = True
        cmbLocation.Location = New Point(132, 104)
        cmbLocation.Name = "cmbLocation"
        cmbLocation.Size = New Size(180, 23)
        cmbLocation.TabIndex = 7
        ' 
        ' AddDeviceForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(327, 206)
        Controls.Add(cmbLocation)
        Controls.Add(btnSave)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtRoom)
        Controls.Add(txtName)
        Name = "AddDeviceForm"
        Text = "AddDeviceForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtRoom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents cmbLocation As ComboBox
End Class
