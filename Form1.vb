
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports Microsoft.SqlServer

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End

    End Sub

    Private Sub ListenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListenToolStripMenuItem.Click

        Dim Server As New TcpListener(IPAddress.Any, TextBox1.Text)
        Server.Start()

        While True
            Dim client As TcpClient = Server.AcceptTcpClient
        End While

        Label6.Text = "Connected !"

    End Sub
End Class
