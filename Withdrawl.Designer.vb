<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FWthdrl
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
        Me.LEntr = New System.Windows.Forms.Label()
        Me.TxtAmnt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnWthdraw = New System.Windows.Forms.Button()
        Me.LNo = New System.Windows.Forms.Label()
        Me.LDate = New System.Windows.Forms.Label()
        Me.LnkLblHome = New System.Windows.Forms.LinkLabel()
        Me.TxtAcc = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TxtDt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LEntr
        '
        Me.LEntr.AutoSize = True
        Me.LEntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEntr.Location = New System.Drawing.Point(144, 183)
        Me.LEntr.Name = "LEntr"
        Me.LEntr.Size = New System.Drawing.Size(90, 16)
        Me.LEntr.TabIndex = 0
        Me.LEntr.Text = "Enter Amount "
        '
        'TxtAmnt
        '
        Me.TxtAmnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmnt.Location = New System.Drawing.Point(105, 219)
        Me.TxtAmnt.Name = "TxtAmnt"
        Me.TxtAmnt.Size = New System.Drawing.Size(160, 22)
        Me.TxtAmnt.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "* Maximum withdrawl amount is 3000."
        '
        'BtnWthdraw
        '
        Me.BtnWthdraw.BackColor = System.Drawing.Color.Black
        Me.BtnWthdraw.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnWthdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnWthdraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWthdraw.ForeColor = System.Drawing.Color.White
        Me.BtnWthdraw.Location = New System.Drawing.Point(134, 304)
        Me.BtnWthdraw.Name = "BtnWthdraw"
        Me.BtnWthdraw.Size = New System.Drawing.Size(75, 35)
        Me.BtnWthdraw.TabIndex = 10
        Me.BtnWthdraw.Text = "Withdraw"
        Me.BtnWthdraw.UseVisualStyleBackColor = False
        '
        'LNo
        '
        Me.LNo.AutoSize = True
        Me.LNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNo.Location = New System.Drawing.Point(26, 116)
        Me.LNo.Name = "LNo"
        Me.LNo.Size = New System.Drawing.Size(29, 16)
        Me.LNo.TabIndex = 11
        Me.LNo.Text = "No."
        '
        'LDate
        '
        Me.LDate.AutoSize = True
        Me.LDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDate.Location = New System.Drawing.Point(207, 116)
        Me.LDate.Name = "LDate"
        Me.LDate.Size = New System.Drawing.Size(37, 16)
        Me.LDate.TabIndex = 12
        Me.LDate.Text = "Date"
        '
        'LnkLblHome
        '
        Me.LnkLblHome.AutoSize = True
        Me.LnkLblHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkLblHome.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LnkLblHome.Location = New System.Drawing.Point(300, 20)
        Me.LnkLblHome.Name = "LnkLblHome"
        Me.LnkLblHome.Size = New System.Drawing.Size(45, 16)
        Me.LnkLblHome.TabIndex = 14
        Me.LnkLblHome.TabStop = True
        Me.LnkLblHome.Text = "Home"
        '
        'TxtAcc
        '
        Me.TxtAcc.BackColor = System.Drawing.Color.White
        Me.TxtAcc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAcc.Location = New System.Drawing.Point(56, 116)
        Me.TxtAcc.Name = "TxtAcc"
        Me.TxtAcc.ReadOnly = True
        Me.TxtAcc.Size = New System.Drawing.Size(121, 15)
        Me.TxtAcc.TabIndex = 15
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(240, 124)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 15)
        Me.TextBox2.TabIndex = 16
        '
        'TxtDt
        '
        Me.TxtDt.BackColor = System.Drawing.Color.White
        Me.TxtDt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDt.Location = New System.Drawing.Point(250, 117)
        Me.TxtDt.Name = "TxtDt"
        Me.TxtDt.ReadOnly = True
        Me.TxtDt.Size = New System.Drawing.Size(92, 15)
        Me.TxtDt.TabIndex = 17
        '
        'FWthdrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.LnkLblHome
        Me.ClientSize = New System.Drawing.Size(384, 385)
        Me.Controls.Add(Me.TxtDt)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TxtAcc)
        Me.Controls.Add(Me.LnkLblHome)
        Me.Controls.Add(Me.LDate)
        Me.Controls.Add(Me.LNo)
        Me.Controls.Add(Me.BtnWthdraw)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtAmnt)
        Me.Controls.Add(Me.LEntr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FWthdrl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Withdrawl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LEntr As Label
    Friend WithEvents TxtAmnt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnWthdraw As Button
    Friend WithEvents LNo As Label
    Friend WithEvents LDate As Label
    Friend WithEvents LnkLblHome As LinkLabel
    Friend WithEvents TxtAcc As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TxtDt As TextBox
End Class
