Public Class FWthdrl
    Dim uname As String
    Dim acc_no As String
    Dim dAmnt As Integer
    Dim wAmnt As Integer
    Dim bal As Integer
    Dim ValidAmnt As Boolean = True
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

    Private Sub FWthdrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtAcc.Text = Me.acc_no
        TxtDt.Text = Date.Now.Day.ToString + "-" + Date.Now.Month.ToString + "-" + Date.Now.Year.ToString
    End Sub

    Private Sub BtnWthdraw_Click(sender As Object, e As EventArgs) Handles BtnWthdraw.Click
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
                If CInt(TxtAmnt.Text) <= 3000 Then
                    If CInt(TxtAmnt.Text) <= bal Then
                        wAmnt += CInt(TxtAmnt.Text)
                        bal = bal - CInt(TxtAmnt.Text)

                        Try
                            Dim sql As String = "UPDATE Transactions SET Withdrawn_Amount= @da, Total_Balance = @tb WHERE Account_no = '" & acc_no & "'"
                            Dim cmd As New OleDb.OleDbCommand(sql, con)
                            cmd.Parameters.AddWithValue("@da", wAmnt)
                            cmd.Parameters.AddWithValue("@tb", bal)
                            con.Open()

                            Dim i = cmd.ExecuteNonQuery()
                            If i > 0 Then
                                MessageBox.Show("Amount withdrawn successfully.")
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
                    Else
                        MessageBox.Show("This amount is higher than your current balance.")
                    End If
                Else
                    MessageBox.Show("Invalid amount.")
                End If
            Else
                MessageBox.Show("The withdrwal amount limit is 3000.")
            End If
            Else
            MessageBox.Show("Please enter amount as a positive integer only.")
        End If

    End Sub

    Private Sub LnkLblHome_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkLblHome.LinkClicked
        Dim menu As New FMenu(uname, acc_no, dAmnt, wAmnt, bal, Sdt)
        menu.Show()
        LnkLblHome.LinkVisited = True

        Me.Close()
    End Sub
End Class