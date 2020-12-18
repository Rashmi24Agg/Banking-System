<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMenu
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
        Me.LName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEnqr = New System.Windows.Forms.Button()
        Me.BtnDeposit = New System.Windows.Forms.Button()
        Me.BtnWthdrw = New System.Windows.Forms.Button()
        Me.BtnTrnsfr = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnLgt = New System.Windows.Forms.Button()
        Me.Txtunm = New System.Windows.Forms.TextBox()
        Me.TxtAcc = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LName
        '
        Me.LName.AutoSize = True
        Me.LName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName.Location = New System.Drawing.Point(230, 97)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(69, 16)
        Me.LName.TabIndex = 0
        Me.LName.Text = "Welcome "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Account no."
        '
        'BtnEnqr
        '
        Me.BtnEnqr.BackColor = System.Drawing.Color.Black
        Me.BtnEnqr.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnEnqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnqr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEnqr.Location = New System.Drawing.Point(8, 20)
        Me.BtnEnqr.Name = "BtnEnqr"
        Me.BtnEnqr.Size = New System.Drawing.Size(126, 43)
        Me.BtnEnqr.TabIndex = 0
        Me.BtnEnqr.Text = "Balance Info."
        Me.BtnEnqr.UseVisualStyleBackColor = False
        '
        'BtnDeposit
        '
        Me.BtnDeposit.BackColor = System.Drawing.Color.Black
        Me.BtnDeposit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeposit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnDeposit.Location = New System.Drawing.Point(6, 86)
        Me.BtnDeposit.Name = "BtnDeposit"
        Me.BtnDeposit.Size = New System.Drawing.Size(126, 44)
        Me.BtnDeposit.TabIndex = 1
        Me.BtnDeposit.Text = "Deposit"
        Me.BtnDeposit.UseVisualStyleBackColor = False
        '
        'BtnWthdrw
        '
        Me.BtnWthdrw.BackColor = System.Drawing.Color.Black
        Me.BtnWthdrw.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnWthdrw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnWthdrw.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnWthdrw.Location = New System.Drawing.Point(6, 150)
        Me.BtnWthdrw.Name = "BtnWthdrw"
        Me.BtnWthdrw.Size = New System.Drawing.Size(126, 45)
        Me.BtnWthdrw.TabIndex = 2
        Me.BtnWthdrw.Text = "Withdraw"
        Me.BtnWthdrw.UseVisualStyleBackColor = False
        '
        'BtnTrnsfr
        '
        Me.BtnTrnsfr.BackColor = System.Drawing.Color.Black
        Me.BtnTrnsfr.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnTrnsfr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTrnsfr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnTrnsfr.Location = New System.Drawing.Point(6, 212)
        Me.BtnTrnsfr.Name = "BtnTrnsfr"
        Me.BtnTrnsfr.Size = New System.Drawing.Size(126, 43)
        Me.BtnTrnsfr.TabIndex = 3
        Me.BtnTrnsfr.Text = "Transfer"
        Me.BtnTrnsfr.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnTrnsfr)
        Me.GroupBox1.Controls.Add(Me.BtnWthdrw)
        Me.GroupBox1.Controls.Add(Me.BtnDeposit)
        Me.GroupBox1.Controls.Add(Me.BtnEnqr)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 261)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transactions"
        '
        'BtnLgt
        '
        Me.BtnLgt.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLgt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnLgt.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnLgt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLgt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLgt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLgt.Location = New System.Drawing.Point(287, 241)
        Me.BtnLgt.Name = "BtnLgt"
        Me.BtnLgt.Size = New System.Drawing.Size(75, 32)
        Me.BtnLgt.TabIndex = 4
        Me.BtnLgt.Text = "LogOut"
        Me.BtnLgt.UseVisualStyleBackColor = False
        '
        'Txtunm
        '
        Me.Txtunm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtunm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtunm.Location = New System.Drawing.Point(305, 97)
        Me.Txtunm.Name = "Txtunm"
        Me.Txtunm.ReadOnly = True
        Me.Txtunm.Size = New System.Drawing.Size(121, 15)
        Me.Txtunm.TabIndex = 25
        '
        'TxtAcc
        '
        Me.TxtAcc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAcc.Location = New System.Drawing.Point(313, 165)
        Me.TxtAcc.Name = "TxtAcc"
        Me.TxtAcc.ReadOnly = True
        Me.TxtAcc.Size = New System.Drawing.Size(142, 15)
        Me.TxtAcc.TabIndex = 26
        '
        'FMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnLgt
        Me.ClientSize = New System.Drawing.Size(467, 350)
        Me.Controls.Add(Me.TxtAcc)
        Me.Controls.Add(Me.Txtunm)
        Me.Controls.Add(Me.BtnLgt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEnqr As Button
    Friend WithEvents BtnDeposit As Button
    Friend WithEvents BtnWthdrw As Button
    Friend WithEvents BtnTrnsfr As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnLgt As Button
    Friend WithEvents Txtunm As TextBox
    Friend WithEvents TxtAcc As TextBox
End Class
