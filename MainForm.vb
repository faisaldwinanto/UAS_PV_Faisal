Imports System.IO

Public Class MainForm
    Private devices As New List(Of Device)

    ' Load form dan baca data dari file
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadDevicesFromFile()
        DisplayDevices()
    End Sub

    ' Procedure untuk membaca data perangkat dari file
    Private Sub ReadDevicesFromFile()
        Try
            devices.Clear()
            If File.Exists("devices.csv") Then
                Dim lines As String() = File.ReadAllLines("devices.csv")
                For Each line In lines
                    Dim parts As String() = line.Split(","c)
                    If parts.Length = 3 Then
                        devices.Add(New Device() With {
                            .Name = parts(0),
                            .Room = parts(1),
                            .Location = parts(2)
                        })
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal membaca file: " & ex.Message)
        End Try
    End Sub

    ' Procedure untuk menampilkan daftar perangkat di ListBox
    Private Sub DisplayDevices()
        ListBox1.Items.Clear()
        For Each device In devices
            ' Format each item with name, room, and location
            Dim deviceInfo As String = $"{device.Name} - Ruangan: {device.Room}, Lokasi: {device.Location}"
            ListBox1.Items.Add(deviceInfo)
        Next
    End Sub

    ' Procedure untuk menyimpan data perangkat ke file
    Private Sub SaveDevicesToFile()
        Try
            Dim lines As New List(Of String)
            For Each device In devices
                lines.Add(String.Format("{0},{1},{2}", device.Name, device.Room, device.Location))
            Next
            File.WriteAllLines("devices.csv", lines.ToArray())
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan file: " & ex.Message)
        End Try
    End Sub

    ' Tombol untuk membuka form tambah perangkat
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim addForm As New AddDeviceForm(devices)
        If addForm.ShowDialog() = DialogResult.OK Then
            DisplayDevices()
            SaveDevicesToFile()
        End If
    End Sub

    ' Tombol untuk membuka form edit perangkat
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If ListBox1.SelectedIndex <> -1 Then
            Dim editForm As New EditDeviceForm(devices(ListBox1.SelectedIndex), devices)
            If editForm.ShowDialog() = DialogResult.OK Then
                DisplayDevices()
                SaveDevicesToFile()
            End If
        Else
            MessageBox.Show("Pilih perangkat untuk diedit.")
        End If
    End Sub

    ' Tombol untuk menghapus perangkat
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If ListBox1.SelectedIndex <> -1 Then
            Dim result = MessageBox.Show("Apakah Anda yakin ingin menghapus perangkat ini?", "Konfirmasi", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                devices.RemoveAt(ListBox1.SelectedIndex)
                DisplayDevices()
                SaveDevicesToFile()
            End If
        Else
            MessageBox.Show("Pilih perangkat untuk dihapus.")
        End If
    End Sub
End Class

' Kelas Device didefinisikan di sini untuk memastikan dikenali oleh MainForm
Public Class Device
    Public Property Name As String
    Public Property Room As String
    Public Property Location As String
End Class