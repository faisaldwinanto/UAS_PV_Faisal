Public Class AddDeviceForm
    Private devices As List(Of Device)

    Public Sub New(ByRef deviceList As List(Of Device))
        InitializeComponent()
        Me.devices = deviceList

        ' Populate ComboBox with locations
        cmbLocation.Items.Add("Data Center 1")
        cmbLocation.Items.Add("Data Center 2")
        cmbLocation.SelectedIndex = 0 ' Default to first item
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not String.IsNullOrEmpty(txtName.Text) AndAlso cmbLocation.SelectedItem IsNot Nothing Then
            devices.Add(New Device() With {
                .Name = txtName.Text,
                .Room = txtRoom.Text,
                .Location = cmbLocation.SelectedItem.ToString()
            })
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Nama perangkat harus diisi dan lokasi harus dipilih.")
        End If
    End Sub
End Class