Public Class FTrnsfr
    Dim uname As String
    Dim acc_no As String
    Dim ValidAmnt As Boolean = True
    Dim dAmnt As Integer
    Dim bal As Integer
    Dim wAmnt As Integer
    Dim tAmnt As Integer
    Dim tbal As Integer
    Dim Sdt As String
    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Rashmi Gupta\Day 19-22\Banking System\Banking System\bin\Debug\User Data.accdb")

    Public Sub New(uname As String, acc_no As String, dAmnt As Integer, wAmnt As Integer, bal As Integer, d As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.uname = uname
        Me.acc_no = acc_no
        Me.dAmnt = dAmnt
        Me.wAmnt = wAmnt
        Me.bal = bal
        Sdt = d
    End Sub

    Private Sub FTrnsfr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtno.Text = acc_no
        TxtDt.Text = Date.Now.Day.ToString + "-" + Date.Now.Month.ToString + "-" + Date.Now.Year.ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btntrnsfr.Click
        For i As Integer = 0 To TxtAmnt.Text.Length - 1

            If Not TxtAmnt.Text = "" And Char.IsDigit(CChar(TxtAmnt.Text.ElementAt(i))) Then

                ValidAmnt = True
            Else
                ValidAmnt = False
                Exit For
            End If
        Next
        If ValidAmnt Then
            If CInt(TxtAmnt.Text) > 0 Then
                If CInt(TxtAmnt.Text) <= bal Then
                    If CInt(TxtAmnt.Text) <= 3000 Then
                        Try
                            Dim sql As String = " SELECT * FROM Transactions WHERE Account_no = '" & TxtAcc.Text & "'"
                            Dim cmd As New OleDb.OleDbCommand(sql, con)
                            con.Open()
                            Dim rdr As OleDb.OleDbDataReader = cmd.ExecuteReader
                            While rdr.Read

                                tAmnt = CInt(rdr("Deposited_Amount"))

                                tbal = CInt(rdr("Total_Balance"))

                            End While
                            rdr.Close()
                        Catch ex As OleDb.OleDbException
                            MessageBox.Show(ex.Message)
                        Finally
                            con.Close()
                        End Try

                        Try
                            Dim sql As String = "UPDATE Transactions SET Deposited_Amount= @da, Total_Balance = @tb WHERE Account_no = '" & TxtAcc.Text & "'"
                            Dim cmd As New OleDb.OleDbCommand(sql, con)
                            tAmnt += CInt(TxtAmnt.Text)
                            tbal += CInt(TxtAmnt.Text)
                            cmd.Parameters.AddWithValue("@da", tAmnt)
                            cmd.Parameters.AddWithValue("@tb", tbal)
                            con.Open()

                            Dim i = cmd.ExecuteNonQuery()
                            If i > 0 Then
                                MessageBox.Show("Amount transferred successfully.")
                                TxtAcc.Text = ""
                                TxtAmnt.Text = ""
                            Else
                                MessageBox.Show("Please retry.")
                            End If
                            con.Close()

                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        Finally
                            con.Close()
                        End Try

                        Try
                            Dim sql As String = "UPDATE Transactions SET Withdrawn_Amount= @wa, Total_Balance = @tb WHERE Account_no = '" & acc_no & "'"
                            Dim cmd As New OleDb.OleDbCommand(sql, con)
                            wAmnt += CInt(TxtAmnt.Text)
                            bal -= CInt(TxtAmnt.Text)
                            cmd.Parameters.AddWithValue("@wa", wAmnt)
                            cmd.Parameters.AddWithValue("@tb", bal)
                            con.Open()

                            Dim i = cmd.ExecuteNonQuery()
                            If i > 0 Then
                                MessageBox.Show("Amount deducted successfully from your account.")

                            Else
                                MessageBox.Show("Please retry.")
                            End If
                            con.Close()

                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        Finally
                            con.Close()
                        End Try
                    Else
                        MessageBox.Show("Please enter an amount less than or equal 3000.")
                    End If
                Else
                    MessageBox.Show("This amount is higher than your current balance.")
                End If
            Else
                MessageBox.Show("Invalid amount.")
            End If
        Else
            MessageBox.Show("Please enter amount as a positive integer only.")

        End If
    End Sub

    Private Sub TxtDt_TextChanged(sender As Object, e As EventArgs) Handles TxtDt.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LHome.LinkClicked
        Dim menu As New FMenu(uname, acc_no, dAmnt, wAmnt, bal, Sdt)
        menu.Show()
        LHome.LinkVisited = True
        Me.Close()
    End Sub
End Class