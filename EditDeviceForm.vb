Public Class EditDeviceForm
    Private selectedDevice As Device
    Private devices As List(Of Device)
    Private deviceIndex As Integer

    Public Sub New(device As Device, ByRef deviceList As List(Of Device))
        InitializeComponent()
        Me.selectedDevice = device
        Me.devices = deviceList
        Me.deviceIndex = devices.IndexOf(device)

        ' Populate ComboBox with locations
        cmbLocation.Items.Add("Data Center 1")
        cmbLocation.Items.Add("Data Center 2")

        ' Show initial data in TextBox and select current location in ComboBox
        txtName.Text = device.Name
        txtRoom.Text = device.Room
        cmbLocation.SelectedItem = device.Location ' Select the correct location if it exists
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not String.IsNullOrEmpty(txtName.Text) AndAlso cmbLocation.SelectedItem IsNot Nothing Then
            ' Update device data in the list
            devices(deviceIndex).Name = txtName.Text
            devices(deviceIndex).Room = txtRoom.Text
            devices(deviceIndex).Location = cmbLocation.SelectedItem.ToString()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Nama perangkat harus diisi dan lokasi harus dipilih.")
        End If
    End Sub
End Class