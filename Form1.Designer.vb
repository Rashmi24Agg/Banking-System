<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LUsrNm = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUsrNm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnLgn = New System.Windows.Forms.Button()
        Me.BtnRgstr = New System.Windows.Forms.Button()
        Me.TxtPswrd = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LUsrNm
        '
        Me.LUsrNm.AutoSize = True
        Me.LUsrNm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsrNm.Location = New System.Drawing.Point(86, 80)
        Me.LUsrNm.Name = "LUsrNm"
        Me.LUsrNm.Size = New System.Drawing.Size(71, 16)
        Me.LUsrNm.TabIndex = 0
        Me.LUsrNm.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'TxtUsrNm
        '
        Me.TxtUsrNm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsrNm.Location = New System.Drawing.Point(201, 80)
        Me.TxtUsrNm.Name = "TxtUsrNm"
        Me.TxtUsrNm.Size = New System.Drawing.Size(100, 22)
        Me.TxtUsrNm.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "New User ? Click to Register."
        '
        'BtnLgn
        '
        Me.BtnLgn.BackColor = System.Drawing.Color.Black
        Me.BtnLgn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnLgn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLgn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLgn.ForeColor = System.Drawing.Color.White
        Me.BtnLgn.Location = New System.Drawing.Point(142, 221)
        Me.BtnLgn.Name = "BtnLgn"
        Me.BtnLgn.Size = New System.Drawing.Size(75, 32)
        Me.BtnLgn.TabIndex = 5
        Me.BtnLgn.Text = "Login"
        Me.BtnLgn.UseVisualStyleBackColor = False
        '
        'BtnRgstr
        '
        Me.BtnRgstr.BackColor = System.Drawing.Color.Black
        Me.BtnRgstr.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnRgstr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRgstr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRgstr.ForeColor = System.Drawing.Color.White
        Me.BtnRgstr.Location = New System.Drawing.Point(100, 336)
        Me.BtnRgstr.Name = "BtnRgstr"
        Me.BtnRgstr.Size = New System.Drawing.Size(75, 32)
        Me.BtnRgstr.TabIndex = 6
        Me.BtnRgstr.Text = "Register"
        Me.BtnRgstr.UseVisualStyleBackColor = False
        '
        'TxtPswrd
        '
        Me.TxtPswrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPswrd.Location = New System.Drawing.Point(201, 156)
        Me.TxtPswrd.Name = "TxtPswrd"
        Me.TxtPswrd.Size = New System.Drawing.Size(100, 22)
        Me.TxtPswrd.TabIndex = 3
        Me.TxtPswrd.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(201, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(383, 423)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnRgstr)
        Me.Controls.Add(Me.BtnLgn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPswrd)
        Me.Controls.Add(Me.TxtUsrNm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LUsrNm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Banking System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LUsrNm As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsrNm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnLgn As Button
    Friend WithEvents BtnRgstr As Button
    Friend WithEvents TxtPswrd As TextBox
    Friend WithEvents Button1 As Button
End Class
