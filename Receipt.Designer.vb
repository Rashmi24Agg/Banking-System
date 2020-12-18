<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FReceipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnExt = New System.Windows.Forms.Button()
        Me.LUsrNm = New System.Windows.Forms.Label()
        Me.LAcc = New System.Windows.Forms.Label()
        Me.Lwthdrw = New System.Windows.Forms.Label()
        Me.LDpst = New System.Windows.Forms.Label()
        Me.LSrtDt = New System.Windows.Forms.Label()
        Me.LLstDt = New System.Windows.Forms.Label()
        Me.Txtunm = New System.Windows.Forms.TextBox()
        Me.Txtacc = New System.Windows.Forms.TextBox()
        Me.TxtAtDd = New System.Windows.Forms.TextBox()
        Me.TxtAtWn = New System.Windows.Forms.TextBox()
        Me.LnkLblHome = New System.Windows.Forms.LinkLabel()
        Me.LTotalBalance = New System.Windows.Forms.Label()
        Me.TxtTB = New System.Windows.Forms.TextBox()
        Me.TxtSDt = New System.Windows.Forms.TextBox()
        Me.TxtDt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnExt
        '
        Me.BtnExt.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnExt.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExt.ForeColor = System.Drawing.Color.White
        Me.BtnExt.Location = New System.Drawing.Point(193, 415)
        Me.BtnExt.Name = "BtnExt"
        Me.BtnExt.Size = New System.Drawing.Size(75, 30)
        Me.BtnExt.TabIndex = 0
        Me.BtnExt.Text = "Ok"
        Me.BtnExt.UseVisualStyleBackColor = False
        '
        'LUsrNm
        '
        Me.LUsrNm.AutoSize = True
        Me.LUsrNm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsrNm.Location = New System.Drawing.Point(118, 131)
        Me.LUsrNm.Name = "LUsrNm"
        Me.LUsrNm.Size = New System.Drawing.Size(71, 16)
        Me.LUsrNm.TabIndex = 1
        Me.LUsrNm.Text = "Username"
        '
        'LAcc
        '
        Me.LAcc.AutoSize = True
        Me.LAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAcc.Location = New System.Drawing.Point(118, 183)
        Me.LAcc.Name = "LAcc"
        Me.LAcc.Size = New System.Drawing.Size(80, 16)
        Me.LAcc.TabIndex = 2
        Me.LAcc.Text = "Account No."
        '
        'Lwthdrw
        '
        Me.Lwthdrw.AutoSize = True
        Me.Lwthdrw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lwthdrw.Location = New System.Drawing.Point(118, 235)
        Me.Lwthdrw.Name = "Lwthdrw"
        Me.Lwthdrw.Size = New System.Drawing.Size(119, 16)
        Me.Lwthdrw.TabIndex = 3
        Me.Lwthdrw.Text = "Amount Deposited"
        '
        'LDpst
        '
        Me.LDpst.AutoSize = True
        Me.LDpst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDpst.Location = New System.Drawing.Point(118, 294)
        Me.LDpst.Name = "LDpst"
        Me.LDpst.Size = New System.Drawing.Size(120, 16)
        Me.LDpst.TabIndex = 4
        Me.LDpst.Text = "Amount WithDrawn"
        '
        'LSrtDt
        '
        Me.LSrtDt.AutoSize = True
        Me.LSrtDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSrtDt.Location = New System.Drawing.Point(76, 55)
        Me.LSrtDt.Name = "LSrtDt"
        Me.LSrtDt.Size = New System.Drawing.Size(85, 16)
        Me.LSrtDt.TabIndex = 5
        Me.LSrtDt.Text = "Starting Date"
        '
        'LLstDt
        '
        Me.LLstDt.AutoSize = True
        Me.LLstDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLstDt.Location = New System.Drawing.Point(330, 55)
        Me.LLstDt.Name = "LLstDt"
        Me.LLstDt.Size = New System.Drawing.Size(26, 16)
        Me.LLstDt.TabIndex = 6
        Me.LLstDt.Text = "Till"
        '
        'Txtunm
        '
        Me.Txtunm.BackColor = System.Drawing.Color.White
        Me.Txtunm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtunm.Location = New System.Drawing.Point(278, 124)
        Me.Txtunm.Name = "Txtunm"
        Me.Txtunm.ReadOnly = True
        Me.Txtunm.Size = New System.Drawing.Size(160, 22)
        Me.Txtunm.TabIndex = 7
        '
        'Txtacc
        '
        Me.Txtacc.BackColor = System.Drawing.Color.White
        Me.Txtacc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtacc.Location = New System.Drawing.Point(278, 180)
        Me.Txtacc.Name = "Txtacc"
        Me.Txtacc.ReadOnly = True
        Me.Txtacc.Size = New System.Drawing.Size(160, 22)
        Me.Txtacc.TabIndex = 8
        '
        'TxtAtDd
        '
        Me.TxtAtDd.BackColor = System.Drawing.Color.White
        Me.TxtAtDd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAtDd.Location = New System.Drawing.Point(278, 235)
        Me.TxtAtDd.Name = "TxtAtDd"
        Me.TxtAtDd.ReadOnly = True
        Me.TxtAtDd.Size = New System.Drawing.Size(160, 22)
        Me.TxtAtDd.TabIndex = 9
        '
        'TxtAtWn
        '
        Me.TxtAtWn.BackColor = System.Drawing.Color.White
        Me.TxtAtWn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAtWn.Location = New System.Drawing.Point(278, 294)
        Me.TxtAtWn.Name = "TxtAtWn"
        Me.TxtAtWn.ReadOnly = True
        Me.TxtAtWn.Size = New System.Drawing.Size(160, 22)
        Me.TxtAtWn.TabIndex = 10
        '
        'LnkLblHome
        '
        Me.LnkLblHome.AutoSize = True
        Me.LnkLblHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkLblHome.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LnkLblHome.Location = New System.Drawing.Point(476, 23)
        Me.LnkLblHome.Name = "LnkLblHome"
        Me.LnkLblHome.Size = New System.Drawing.Size(45, 16)
        Me.LnkLblHome.TabIndex = 15
        Me.LnkLblHome.TabStop = True
        Me.LnkLblHome.Text = "Home"
        '
        'LTotalBalance
        '
        Me.LTotalBalance.AutoSize = True
        Me.LTotalBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotalBalance.Location = New System.Drawing.Point(118, 348)
        Me.LTotalBalance.Name = "LTotalBalance"
        Me.LTotalBalance.Size = New System.Drawing.Size(92, 16)
        Me.LTotalBalance.TabIndex = 16
        Me.LTotalBalance.Text = "Total Balance"
        '
        'TxtTB
        '
        Me.TxtTB.BackColor = System.Drawing.Color.White
        Me.TxtTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTB.Location = New System.Drawing.Point(278, 348)
        Me.TxtTB.Name = "TxtTB"
        Me.TxtTB.ReadOnly = True
        Me.TxtTB.Size = New System.Drawing.Size(160, 22)
        Me.TxtTB.TabIndex = 17
        '
        'TxtSDt
        '
        Me.TxtSDt.BackColor = System.Drawing.Color.White
        Me.TxtSDt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSDt.Location = New System.Drawing.Point(167, 55)
        Me.TxtSDt.Name = "TxtSDt"
        Me.TxtSDt.ReadOnly = True
        Me.TxtSDt.Size = New System.Drawing.Size(142, 15)
        Me.TxtSDt.TabIndex = 27
        '
        'TxtDt
        '
        Me.TxtDt.BackColor = System.Drawing.Color.White
        Me.TxtDt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDt.Location = New System.Drawing.Point(362, 56)
        Me.TxtDt.Name = "TxtDt"
        Me.TxtDt.ReadOnly = True
        Me.TxtDt.Size = New System.Drawing.Size(142, 15)
        Me.TxtDt.TabIndex = 28
        '
        'FReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.LnkLblHome
        Me.ClientSize = New System.Drawing.Size(548, 468)
        Me.Controls.Add(Me.TxtDt)
        Me.Controls.Add(Me.TxtSDt)
        Me.Controls.Add(Me.TxtTB)
        Me.Controls.Add(Me.LTotalBalance)
        Me.Controls.Add(Me.LnkLblHome)
        Me.Controls.Add(Me.TxtAtWn)
        Me.Controls.Add(Me.TxtAtDd)
        Me.Controls.Add(Me.Txtacc)
        Me.Controls.Add(Me.Txtunm)
        Me.Controls.Add(Me.LLstDt)
        Me.Controls.Add(Me.LSrtDt)
        Me.Controls.Add(Me.LDpst)
        Me.Controls.Add(Me.Lwthdrw)
        Me.Controls.Add(Me.LAcc)
        Me.Controls.Add(Me.LUsrNm)
        Me.Controls.Add(Me.BtnExt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExt As Button
    Friend WithEvents LUsrNm As Label
    Friend WithEvents LAcc As Label
    Friend WithEvents Lwthdrw As Label
    Friend WithEvents LDpst As Label
    Friend WithEvents LSrtDt As Label
    Friend WithEvents LLstDt As Label
    Friend WithEvents Txtunm As TextBox
    Friend WithEvents Txtacc As TextBox
    Friend WithEvents TxtAtDd As TextBox
    Friend WithEvents TxtAtWn As TextBox
    Friend WithEvents LnkLblHome As LinkLabel
    Friend WithEvents LTotalBalance As Label
    Friend WithEvents TxtTB As TextBox
    Friend WithEvents TxtSDt As TextBox
    Friend WithEvents TxtDt As TextBox
End Class
