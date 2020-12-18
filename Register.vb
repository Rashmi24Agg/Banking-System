Imports System.Text.RegularExpressions

Public Class FRegister

    Dim dob As String

    Dim ValidDob As Boolean = False
    Dim ValidFnm As Boolean = False
    Dim ValidAge As Boolean = False
    Dim ValidLnm As Boolean = False
    Dim ValidPhn As Boolean = False

    Dim acc_no As Long
    Dim Phn As Long
    Dim UExsts As Boolean = False
    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Rashmi Gupta\Day 19-22\Banking System\Banking System\bin\Debug\User Data.accdb")

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        For i As Integer = 1900 To 2002
            ComBoxYr.Items.Add(i)
        Next

        ComBoxG.SelectedItem = ComBoxG.Items.Item(0)
        ComBoxDt.SelectedItem = ComBoxDt.Items.Item(0)
        ComBoxMnth.SelectedItem = ComBoxMnth.Items.Item(0)
        ComBoxYr.SelectedItem = ComBoxYr.Items.Item(0)

    End Sub

    Private Sub BtnRgstr_Click(sender As Object, e As EventArgs) Handles BtnRgstr.Click
        Try
            Dim sql As String = " SELECT Username FROM Transactions"
            Dim cmd As New OleDb.OleDbCommand(sql, con)
            con.Open()
            Dim rdr As OleDb.OleDbDataReader = cmd.ExecuteReader
            While rdr.Read
                If rdr("Username") = TxtUsrnm.Text.ToString Then
                    UExsts = True
                    Exit While
                End If
            End While
            rdr.Close()
        Catch ex As OleDb.OleDbException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try


        If Not TxtFnm.Text = "" Then
            For i As Integer = 0 To TxtFnm.Text.Length - 1

                If Char.IsLetter(CChar(TxtFnm.Text.ElementAt(i))) Then

                    ValidFnm = True
                Else
                    ValidFnm = False
                    Exit For
                End If
            Next
        Else
            ValidFnm = False
        End If

        If Not TxtLnm.Text = "" Then
            For i As Integer = 0 To TxtLnm.Text.Length - 1

                If Char.IsLetter(CChar(TxtLnm.Text.ElementAt(i))) Then

                    ValidLnm = True
                Else
                    ValidLnm = False
                    Exit For
                End If
            Next
        Else
            ValidLnm = False
        End If

        dob = ComBoxDt.Text + "/" + ComBoxMnth.Text + "/" + ComBoxYr.Text
        If ComBoxMnth.SelectedItem = 2 Then

            If ComBoxYr.SelectedItem Mod 400 = 0 Or (Not (ComBoxYr.SelectedItem Mod 100 = 0) And ComBoxYr.SelectedItem Mod 4 = 0) Then

                If ComBoxDt.SelectedItem < 30 Then
                    ValidDob = True
                Else
                    ValidDob = False
                End If

            ElseIf ComBoxDt.SelectedItem < 29 Then
                ValidDob = True
            Else
                ValidDob = False
            End If
        ElseIf ComBoxMnth.SelectedItem = 4 Or ComBoxMnth.SelectedItem = 6 Or ComBoxMnth.SelectedItem = 9 Or ComBoxMnth.SelectedItem = 11 Then

            If ComBoxDt.SelectedItem < 31 Then
                ValidDob = True
            Else
                ValidDob = False
            End If
        Else
            ValidDob = True
        End If

        If Not TxtAge.Text = "" Then

            For i As Integer = 0 To TxtAge.Text.Length - 1

                If Char.IsDigit(CChar(TxtAge.Text.ElementAt(i))) Then
                    ValidAge = True
                Else
                    ValidAge = False
                    Exit For
                End If
            Next
            If ValidAge Then
                Dim age As Integer = CInt(TxtAge.Text)
                Dim y As Integer = Today.Year - CInt(ComBoxYr.Text)
                If (age > 17) And y = age Then
                    ValidAge = True
                Else
                    ValidAge = False
                End If
            End If
        Else
            ValidAge = False
        End If

        If (TxtPhn.Text.Length) = 10 Then
            For i As Integer = 0 To TxtPhn.Text.Length - 1

                If Char.IsDigit(CChar(TxtPhn.Text.ElementAt(i))) Then
                    ValidPhn = True
                Else
                    ValidPhn = False
                    Exit For
                End If
            Next
        Else
            ValidPhn = False
        End If

        If Not TxtUsrnm.Text = "" Then

            If Not UExsts Then

                If Not TxtPswrd.Text = "" Then

                    If ValidFnm Then

                        If ValidLnm Then

                            If ValidDob Then

                                If Not TxtAge.Text = "" Then

                                    If ValidAge Then

                                        If ValidPhn Then

                                            Dim pattern As New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")

                                            If ((Not TxtEml.Text = "") And pattern.IsMatch(TxtEml.Text)) Then

                                                If Not TxtAdrs.Text = "" Then

                                                    Dim acc_no = Date.Now.ToString
                                                    For Each c As Char In acc_no
                                                        If c = "-" Or c = "/" Or c = "." Or c = ":" Or c = " " Then
                                                            acc_no = acc_no.Replace(c, "")
                                                        End If
                                                    Next
                                                    Me.acc_no = CLng(acc_no)
                                                    Try
                                                        Dim sql As String = "INSERT INTO Data_Table(Account_no,Username,[Password],
                                                                        First_Name,Last_Name,Date_of_Birth,Age,Gender,Phone_no,
                                                                        Email_Id,Address,Date_Created) VALUES" _
                                                                      & "(?,?,?,?,?,?,?,?,?,?,?,?)"

                                                        Dim cmd As New OleDb.OleDbCommand

                                                        con.Open()
                                                        cmd.Connection = con
                                                        cmd.CommandText = sql
                                                        Dim Sdt As Date = Date.Now
                                                        cmd.Parameters.AddWithValue("@p1", acc_no)
                                                        cmd.Parameters.AddWithValue("@p2", TxtUsrnm.Text)
                                                        cmd.Parameters.AddWithValue("@p3", TxtPswrd.Text)
                                                        cmd.Parameters.AddWithValue("@p4", TxtFnm.Text)
                                                        cmd.Parameters.AddWithValue("@p5", TxtLnm.Text)
                                                        cmd.Parameters.AddWithValue("@p6", dob)
                                                        cmd.Parameters.AddWithValue("@p7", TxtAge.Text)
                                                        cmd.Parameters.AddWithValue("@p8", ComBoxG.SelectedItem)
                                                        cmd.Parameters.AddWithValue("@p9", TxtPhn.Text)
                                                        cmd.Parameters.AddWithValue("@p10", TxtEml.Text)
                                                        cmd.Parameters.AddWithValue("@p11", TxtAdrs.Text)
                                                        cmd.Parameters.AddWithValue("@p12", Sdt.ToString)

                                                        Dim i = cmd.ExecuteNonQuery
                                                        If i > 0 Then

                                                            MsgBox("New record has been inserted successfully in Data_Table!")

                                                        Else
                                                            MsgBox("No record has been inserted successfully!")

                                                        End If
                                                        sql = " INSERT INTO Transactions(Username,Account_no) VALUES ('" & TxtUsrnm.Text & "','" & acc_no & "')"
                                                        cmd.CommandText = sql

                                                        i = cmd.ExecuteNonQuery
                                                        If i > 0 Then
                                                            MsgBox("New record has been inserted successfully in Transactions table!")
                                                            TxtUsrnm.Text = ""
                                                            TxtPswrd.Text = ""
                                                            TxtFnm.Text = ""
                                                            TxtLnm.Text = ""
                                                            TxtAge.Text = ""
                                                            TxtPhn.Text = ""
                                                            TxtEml.Text = ""
                                                            TxtAdrs.Text = ""
                                                            ComBoxG.SelectedItem = ComBoxG.Items.Item(0)
                                                            ComBoxDt.SelectedItem = ComBoxDt.Items.Item(0)
                                                            ComBoxMnth.SelectedItem = ComBoxMnth.Items.Item(0)
                                                            ComBoxYr.SelectedItem = ComBoxYr.Items.Item(0)

                                                        Else
                                                            MsgBox("No record has been inserted successfully!")

                                                        End If
                                                        con.Close()
                                                    Catch exe As Exception
                                                        MessageBox.Show(exe.Message)

                                                    Finally
                                                        con.Close()
                                                    End Try
                                                Else
                                                    MessageBox.Show("Address is required.")
                                                End If
                                            Else
                                                MessageBox.Show("Please enter a valid Email address ")
                                            End If
                                        Else
                                            MessageBox.Show("PLease enter a 10 digit no.")
                                        End If
                                    Else
                                        MessageBox.Show("PLease age as an integer equal to or more than 18 .")
                                    End If
                                Else
                                    MessageBox.Show("Age can not be empty.")
                                End If
                            Else
                                MessageBox.Show("Please enter a valid date of birth.")
                            End If
                        Else
                            MessageBox.Show("PLease enter a  Last Name composed of letters only.")
                        End If
                    Else
                        MessageBox.Show("PLease enter a First Name composed of letters only.")
                    End If
                Else
                    MessageBox.Show("PLease enter a Password.")
                End If
            Else
                MessageBox.Show("This username already exists.Please enter a new one.")
            End If
        Else
            MessageBox.Show("PLease enter a Username.")
        End If
    End Sub

    Private Sub BtnExt_Click(sender As Object, e As EventArgs) Handles BtnExt.Click
        Dim login As New FLogin()
        login.Show()
        Me.Close()
    End Sub

End Class