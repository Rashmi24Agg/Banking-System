<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDeposit
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
        Me.LDate = New System.Windows.Forms.Label()
        Me.LNo = New System.Windows.Forms.Label()
        Me.BtnDeposit = New System.Windows.Forms.Button()
        Me.LWarning = New System.Windows.Forms.Label()
        Me.TxtAmnt = New System.Windows.Forms.TextBox()
        Me.LEntr = New System.Windows.Forms.Label()
        Me.LnkLblHome = New System.Windows.Forms.LinkLabel()
        Me.TxtAcc = New System.Windows.Forms.TextBox()
        Me.TxtDt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LDate
        '
        Me.LDate.AutoSize = True
        Me.LDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDate.Location = New System.Drawing.Point(207, 117)
        Me.LDate.Name = "LDate"
        Me.LDate.Size = New System.Drawing.Size(37, 16)
        Me.LDate.TabIndex = 19
        Me.LDate.Text = "Date"
        '
        'LNo
        '
        Me.LNo.AutoSize = True
        Me.LNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNo.Location = New System.Drawing.Point(41, 117)
        Me.LNo.Name = "LNo"
        Me.LNo.Size = New System.Drawing.Size(29, 16)
        Me.LNo.TabIndex = 18
        Me.LNo.Text = "No."
        '
        'BtnDeposit
        '
        Me.BtnDeposit.BackColor = System.Drawing.Color.Black
        Me.BtnDeposit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeposit.ForeColor = System.Drawing.Color.White
        Me.BtnDeposit.Location = New System.Drawing.Point(138, 318)
        Me.BtnDeposit.Name = "BtnDeposit"
        Me.BtnDeposit.Size = New System.Drawing.Size(75, 32)
        Me.BtnDeposit.TabIndex = 17
        Me.BtnDeposit.Text = "Deposit"
        Me.BtnDeposit.UseVisualStyleBackColor = False
        '
        'LWarning
        '
        Me.LWarning.AutoSize = True
        Me.LWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LWarning.Location = New System.Drawing.Point(78, 60)
        Me.LWarning.Name = "LWarning"
        Me.LWarning.Size = New System.Drawing.Size(215, 16)
        Me.LWarning.TabIndex = 16
        Me.LWarning.Text = "* Maximum deposit amount is 3000."
        '
        'TxtAmnt
        '
        Me.TxtAmnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmnt.Location = New System.Drawing.Point(108, 238)
        Me.TxtAmnt.Name = "TxtAmnt"
        Me.TxtAmnt.Size = New System.Drawing.Size(160, 22)
        Me.TxtAmnt.TabIndex = 15
        '
        'LEntr
        '
        Me.LEntr.AutoSize = True
        Me.LEntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEntr.Location = New System.Drawing.Point(135, 196)
        Me.LEntr.Name = "LEntr"
        Me.LEntr.Size = New System.Drawing.Size(90, 16)
        Me.LEntr.TabIndex = 14
        Me.LEntr.Text = "Enter Amount "
        '
        'LnkLblHome
        '
        Me.LnkLblHome.AutoSize = True
        Me.LnkLblHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkLblHome.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LnkLblHome.Location = New System.Drawing.Point(319, 28)
        Me.LnkLblHome.Name = "LnkLblHome"
        Me.LnkLblHome.Size = New System.Drawing.Size(45, 16)
        Me.LnkLblHome.TabIndex = 21
        Me.LnkLblHome.TabStop = True
        Me.LnkLblHome.Text = "Home"
        '
        'TxtAcc
        '
        Me.TxtAcc.BackColor = System.Drawing.Color.White
        Me.TxtAcc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAcc.Location = New System.Drawing.Point(70, 118)
        Me.TxtAcc.Name = "TxtAcc"
        Me.TxtAcc.ReadOnly = True
        Me.TxtAcc.Size = New System.Drawing.Size(121, 15)
        Me.TxtAcc.TabIndex = 24
        '
        'TxtDt
        '
        Me.TxtDt.BackColor = System.Drawing.Color.White
        Me.TxtDt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDt.Location = New System.Drawing.Point(249, 118)
        Me.TxtDt.Name = "TxtDt"
        Me.TxtDt.ReadOnly = True
        Me.TxtDt.Size = New System.Drawing.Size(121, 15)
        Me.TxtDt.TabIndex = 25
        '
        'FDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.LnkLblHome
        Me.ClientSize = New System.Drawing.Size(382, 425)
        Me.Controls.Add(Me.TxtDt)
        Me.Controls.Add(Me.TxtAcc)
        Me.Controls.Add(Me.LnkLblHome)
        Me.Controls.Add(Me.LDate)
        Me.Controls.Add(Me.LNo)
        Me.Controls.Add(Me.BtnDeposit)
        Me.Controls.Add(Me.LWarning)
        Me.Controls.Add(Me.TxtAmnt)
        Me.Controls.Add(Me.LEntr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FDeposit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deposit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LDate As Label
    Friend WithEvents LNo As Label
    Friend WithEvents BtnDeposit As Button
    Friend WithEvents LWarning As Label
    Friend WithEvents TxtAmnt As TextBox
    Friend WithEvents LEntr As Label
    Friend WithEvents LnkLblHome As LinkLabel
    Friend WithEvents TxtAcc As TextBox
    Friend WithEvents TxtDt As TextBox
End Class
