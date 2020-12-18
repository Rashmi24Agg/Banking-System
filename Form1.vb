Public Class FLogin

    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Rashmi Gupta\Day 19-22\Banking System\Banking System\bin\Debug\User Data.accdb")
    Dim uname As String
    Dim pswrd As String
    Dim acc_no As String
    Dim dAmnt As Integer
    Dim wAmnt As Integer
    Dim bal As Integer
    Dim Sdt As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnLgn_Click(sender As Object, e As EventArgs) Handles BtnLgn.Click
        uname = Trim(TxtUsrNm.Text)
        pswrd = Trim(TxtPswrd.Text)
        If Not (uname = "" Or pswrd = "") Then
            Try
                Dim sql As String = "SELECT Account_no,Date_Created FROM Data_Table WHERE Username='" & uname & "' AND Password='" & pswrd & "'"
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = con
                cmd.CommandText = sql
                con.Open()

                Dim rdr As OleDb.OleDbDataReader = cmd.ExecuteReader

                If rdr.Read() Then
                    acc_no = rdr("Account_no")
                    Sdt = rdr("Date_Created").ToString
                    rdr.Close()
                    Try
                        Dim q As String = " SELECT * FROM Transactions WHERE Account_no = '" & acc_no & "'"
                        cmd.CommandText = q
                        Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader
                        While reader.Read
                            uname = reader("Username")
                            dAmnt = CInt(reader("Deposited_Amount"))
                            wAmnt = CInt(reader("Withdrawn_Amount"))
                            bal = CInt(reader("Total_Balance"))

                        End While
                        reader.Close()
                        Dim menuform As FMenu
                        menuform = New FMenu(uname, acc_no, dAmnt, wAmnt, bal, Sdt)
                        menuform.Show()
                        Me.Visible = False
                    Catch ex As OleDb.OleDbException
                        MessageBox.Show(ex.Message)

                    End Try
                Else
                    MessageBox.Show("Please enter correct Username and Password")
                End If
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try

            TxtUsrNm.Text = ""
            TxtPswrd.Text = ""

        Else
            MessageBox.Show("Both fields are required to fill.")

        End If
    End Sub

    Private Sub BtnRgstr_Click(sender As Object, e As EventArgs) Handles BtnRgstr.Click
        Dim Rgstr As New FRegister
        Rgstr.Show()
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
