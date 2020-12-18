Public Class FReceipt
    Dim acc_no As String
    Dim uname As String
    Dim dAmnt As Integer
    Dim wAmnt As Integer
    Dim bal As Integer
    Dim Sdt As String
    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Rashmi Gupta\Day 19-22\Banking System\Banking System\bin\Debug\User Data.accdb")

    Public Sub New(uname As String, acc_no As String, dAmnt As Integer, wAmnt As Integer, bal As Integer, d As Date)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.uname = uname
        Me.acc_no = acc_no
        Me.dAmnt = dAmnt
        Me.wAmnt = wAmnt
        Me.bal = bal
        Sdt = d.Day.ToString + "-" + d.Month.ToString + "-" + d.Year.ToString
    End Sub

    Private Sub FReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtunm.Text = uname
        Txtacc.Text = acc_no
        TxtAtDd.Text = dAmnt
        TxtAtWn.Text = wAmnt
        TxtTB.Text = bal
        TxtSDt.Text = Sdt
        TxtDt.Text = Date.Now.Day.ToString + "-" + Date.Now.Month.ToString + "-" + Date.Now.Year.ToString

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnExt.Click
        Dim menu As New FMenu(uname, acc_no, dAmnt, wAmnt, bal, Sdt)
        menu.Show()
        Me.Close()
    End Sub

    Private Sub LnkLblHome_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkLblHome.LinkClicked
        Dim menu As New FMenu(uname, acc_no, dAmnt, wAmnt, bal, Sdt)
        menu.Show()
        LnkLblHome.LinkVisited = True
        Me.Close()
    End Sub

End Class