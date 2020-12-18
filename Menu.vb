Public Class FMenu
    Dim acc_no As String
    Dim uname As String
    Dim dAmnt As Integer
    Dim wAmnt As Integer
    Dim bal As Integer
    Dim Sdt As String
    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Rashmi Gupta\Day 19-22\Banking System\Banking System\bin\Debug\User Data.accdb")

    Public Sub New(uname As String, acc_no As String, dAmnt As Integer, wAmnt As Integer, bal As Integer, d As String)

        ' This call is required by the designer.
        InitializeComponent()

        Me.acc_no = acc_no
        Me.uname = uname
        Me.acc_no = acc_no
        Me.dAmnt = dAmnt
        Me.wAmnt = wAmnt
        Me.bal = bal
        Sdt = d
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Txtunm.Text = Me.uname
        TxtAcc.Text = Me.acc_no

        ' Dim tempTable As New DataTable("abc")
        'Try
        '    Using oAdapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
        '        oAdapter.Fill(tempTable)
        '    End Using
        '    'oConn.Close()
        '    '
        'Catch ex As OleDb.OleDbException
        'Finally
        '    'oTempConn.Close()
        'End Try

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '   con.Close()
        'End Try
    End Sub


    Private Sub BtnEnqr_Click(sender As Object, e As EventArgs) Handles BtnEnqr.Click

        Dim enqr As New FReceipt(uname, acc_no, dAmnt, wAmnt, bal, Sdt)
        enqr.Show()
        Me.Close()
    End Sub

    Private Sub BtnDeposit_Click(sender As Object, e As EventArgs) Handles BtnDeposit.Click
        Dim dpst As New FDeposit(uname, acc_no, dAmnt, wAmnt, bal, Sdt)
        dpst.Show()
        Me.Close()
    End Sub

    Private Sub BtnWthdrw_Click(sender As Object, e As EventArgs) Handles BtnWthdrw.Click

        Dim wdraw As New FWthdrl(uname, acc_no, dAmnt, wAmnt, bal, Sdt)
        wdraw.Show()
        Me.Close()

    End Sub

    Private Sub BtnExt_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnLgt_Click(sender As Object, e As EventArgs) Handles BtnLgt.Click
        acc_no = ""
        uname = ""
        Sdt = ""
        dAmnt = 0
        wAmnt = 0
        bal = 0
        Dim form As New FLogin()
        form.Show()
        Me.Close()
    End Sub

    Private Sub BtnTrnsfr_Click(sender As Object, e As EventArgs) Handles BtnTrnsfr.Click

        Dim trnsfr As New FTrnsfr(uname, acc_no, dAmnt, wAmnt, bal, Sdt)
        trnsfr.Show()
        Me.Close()
    End Sub


End Class