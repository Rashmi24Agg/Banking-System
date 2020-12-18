<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRegister
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
        Me.LFnm = New System.Windows.Forms.Label()
        Me.LLstNm = New System.Windows.Forms.Label()
        Me.LDoB = New System.Windows.Forms.Label()
        Me.LGndr = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LEml = New System.Windows.Forms.Label()
        Me.BtnRgstr = New System.Windows.Forms.Button()
        Me.BtnExt = New System.Windows.Forms.Button()
        Me.LAdrs = New System.Windows.Forms.Label()
        Me.TxtFnm = New System.Windows.Forms.TextBox()
        Me.TxtLnm = New System.Windows.Forms.TextBox()
        Me.TxtPhn = New System.Windows.Forms.TextBox()
        Me.TxtEml = New System.Windows.Forms.TextBox()
        Me.TxtAdrs = New System.Windows.Forms.RichTextBox()
        Me.ComBoxDt = New System.Windows.Forms.ComboBox()
        Me.ComBoxMnth = New System.Windows.Forms.ComboBox()
        Me.ComBoxYr = New System.Windows.Forms.ComboBox()
        Me.ComBoxG = New System.Windows.Forms.ComboBox()
        Me.LPswrd = New System.Windows.Forms.Label()
        Me.Lusrnm = New System.Windows.Forms.Label()
        Me.TxtPswrd = New System.Windows.Forms.TextBox()
        Me.TxtUsrnm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAge = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LFnm
        '
        Me.LFnm.AutoSize = True
        Me.LFnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFnm.Location = New System.Drawing.Point(92, 170)
        Me.LFnm.Name = "LFnm"
        Me.LFnm.Size = New System.Drawing.Size(73, 16)
        Me.LFnm.TabIndex = 0
        Me.LFnm.Text = "First Name"
        '
        'LLstNm
        '
        Me.LLstNm.AutoSize = True
        Me.LLstNm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLstNm.Location = New System.Drawing.Point(92, 220)
        Me.LLstNm.Name = "LLstNm"
        Me.LLstNm.Size = New System.Drawing.Size(73, 16)
        Me.LLstNm.TabIndex = 2
        Me.LLstNm.Text = "Last Name"
        '
        'LDoB
        '
        Me.LDoB.AutoSize = True
        Me.LDoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDoB.Location = New System.Drawing.Point(92, 284)
        Me.LDoB.Name = "LDoB"
        Me.LDoB.Size = New System.Drawing.Size(80, 16)
        Me.LDoB.TabIndex = 5
        Me.LDoB.Text = "Date of Birth"
        '
        'LGndr
        '
        Me.LGndr.AutoSize = True
        Me.LGndr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LGndr.Location = New System.Drawing.Point(92, 396)
        Me.LGndr.Name = "LGndr"
        Me.LGndr.Size = New System.Drawing.Size(53, 16)
        Me.LGndr.TabIndex = 6
        Me.LGndr.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(92, 450)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Phone no."
        '
        'LEml
        '
        Me.LEml.AutoSize = True
        Me.LEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEml.Location = New System.Drawing.Point(92, 507)
        Me.LEml.Name = "LEml"
        Me.LEml.Size = New System.Drawing.Size(56, 16)
        Me.LEml.TabIndex = 8
        Me.LEml.Text = "Email Id"
        '
        'BtnRgstr
        '
        Me.BtnRgstr.BackColor = System.Drawing.Color.Black
        Me.BtnRgstr.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnRgstr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRgstr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRgstr.ForeColor = System.Drawing.Color.White
        Me.BtnRgstr.Location = New System.Drawing.Point(137, 663)
        Me.BtnRgstr.Name = "BtnRgstr"
        Me.BtnRgstr.Size = New System.Drawing.Size(75, 32)
        Me.BtnRgstr.TabIndex = 9
        Me.BtnRgstr.Text = "Register"
        Me.BtnRgstr.UseVisualStyleBackColor = False
        '
        'BtnExt
        '
        Me.BtnExt.BackColor = System.Drawing.Color.Black
        Me.BtnExt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExt.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExt.ForeColor = System.Drawing.Color.White
        Me.BtnExt.Location = New System.Drawing.Point(344, 663)
        Me.BtnExt.Name = "BtnExt"
        Me.BtnExt.Size = New System.Drawing.Size(75, 32)
        Me.BtnExt.TabIndex = 10
        Me.BtnExt.Text = "Cancel"
        Me.BtnExt.UseVisualStyleBackColor = False
        '
        'LAdrs
        '
        Me.LAdrs.AutoSize = True
        Me.LAdrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAdrs.Location = New System.Drawing.Point(92, 562)
        Me.LAdrs.Name = "LAdrs"
        Me.LAdrs.Size = New System.Drawing.Size(59, 16)
        Me.LAdrs.TabIndex = 11
        Me.LAdrs.Text = "Address"
        '
        'TxtFnm
        '
        Me.TxtFnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFnm.Location = New System.Drawing.Point(268, 169)
        Me.TxtFnm.Name = "TxtFnm"
        Me.TxtFnm.Size = New System.Drawing.Size(219, 22)
        Me.TxtFnm.TabIndex = 12
        '
        'TxtLnm
        '
        Me.TxtLnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLnm.Location = New System.Drawing.Point(268, 222)
        Me.TxtLnm.Name = "TxtLnm"
        Me.TxtLnm.Size = New System.Drawing.Size(219, 22)
        Me.TxtLnm.TabIndex = 14
        '
        'TxtPhn
        '
        Me.TxtPhn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhn.Location = New System.Drawing.Point(268, 450)
        Me.TxtPhn.Name = "TxtPhn"
        Me.TxtPhn.Size = New System.Drawing.Size(121, 22)
        Me.TxtPhn.TabIndex = 19
        '
        'TxtEml
        '
        Me.TxtEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEml.Location = New System.Drawing.Point(268, 504)
        Me.TxtEml.Name = "TxtEml"
        Me.TxtEml.Size = New System.Drawing.Size(219, 22)
        Me.TxtEml.TabIndex = 20
        '
        'TxtAdrs
        '
        Me.TxtAdrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdrs.Location = New System.Drawing.Point(268, 562)
        Me.TxtAdrs.Name = "TxtAdrs"
        Me.TxtAdrs.Size = New System.Drawing.Size(219, 50)
        Me.TxtAdrs.TabIndex = 21
        Me.TxtAdrs.Text = ""
        '
        'ComBoxDt
        '
        Me.ComBoxDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBoxDt.FormattingEnabled = True
        Me.ComBoxDt.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComBoxDt.Location = New System.Drawing.Point(268, 284)
        Me.ComBoxDt.Name = "ComBoxDt"
        Me.ComBoxDt.Size = New System.Drawing.Size(51, 24)
        Me.ComBoxDt.TabIndex = 22
        '
        'ComBoxMnth
        '
        Me.ComBoxMnth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBoxMnth.FormattingEnabled = True
        Me.ComBoxMnth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ComBoxMnth.Location = New System.Drawing.Point(325, 284)
        Me.ComBoxMnth.Name = "ComBoxMnth"
        Me.ComBoxMnth.Size = New System.Drawing.Size(45, 24)
        Me.ComBoxMnth.TabIndex = 23
        '
        'ComBoxYr
        '
        Me.ComBoxYr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBoxYr.FormattingEnabled = True
        Me.ComBoxYr.Location = New System.Drawing.Point(376, 284)
        Me.ComBoxYr.Name = "ComBoxYr"
        Me.ComBoxYr.Size = New System.Drawing.Size(111, 24)
        Me.ComBoxYr.TabIndex = 24
        '
        'ComBoxG
        '
        Me.ComBoxG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBoxG.FormattingEnabled = True
        Me.ComBoxG.Items.AddRange(New Object() {"Female", "Male", "Other"})
        Me.ComBoxG.Location = New System.Drawing.Point(268, 396)
        Me.ComBoxG.Name = "ComBoxG"
        Me.ComBoxG.Size = New System.Drawing.Size(102, 24)
        Me.ComBoxG.TabIndex = 25
        '
        'LPswrd
        '
        Me.LPswrd.AutoSize = True
        Me.LPswrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPswrd.Location = New System.Drawing.Point(92, 117)
        Me.LPswrd.Name = "LPswrd"
        Me.LPswrd.Size = New System.Drawing.Size(68, 16)
        Me.LPswrd.TabIndex = 26
        Me.LPswrd.Text = "Password"
        '
        'Lusrnm
        '
        Me.Lusrnm.AutoSize = True
        Me.Lusrnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lusrnm.Location = New System.Drawing.Point(91, 69)
        Me.Lusrnm.Name = "Lusrnm"
        Me.Lusrnm.Size = New System.Drawing.Size(71, 16)
        Me.Lusrnm.TabIndex = 27
        Me.Lusrnm.Text = "Username"
        '
        'TxtPswrd
        '
        Me.TxtPswrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPswrd.Location = New System.Drawing.Point(268, 117)
        Me.TxtPswrd.Name = "TxtPswrd"
        Me.TxtPswrd.Size = New System.Drawing.Size(219, 22)
        Me.TxtPswrd.TabIndex = 28
        Me.TxtPswrd.UseSystemPasswordChar = True
        '
        'TxtUsrnm
        '
        Me.TxtUsrnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsrnm.Location = New System.Drawing.Point(268, 69)
        Me.TxtUsrnm.Name = "TxtUsrnm"
        Me.TxtUsrnm.Size = New System.Drawing.Size(219, 22)
        Me.TxtUsrnm.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Age"
        '
        'TxtAge
        '
        Me.TxtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.Location = New System.Drawing.Point(268, 344)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(51, 22)
        Me.TxtAge.TabIndex = 31
        '
        'FRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BtnExt
        Me.ClientSize = New System.Drawing.Size(578, 741)
        Me.Controls.Add(Me.TxtAge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtUsrnm)
        Me.Controls.Add(Me.TxtPswrd)
        Me.Controls.Add(Me.Lusrnm)
        Me.Controls.Add(Me.LPswrd)
        Me.Controls.Add(Me.ComBoxG)
        Me.Controls.Add(Me.ComBoxYr)
        Me.Controls.Add(Me.ComBoxMnth)
        Me.Controls.Add(Me.ComBoxDt)
        Me.Controls.Add(Me.TxtAdrs)
        Me.Controls.Add(Me.TxtEml)
        Me.Controls.Add(Me.TxtPhn)
        Me.Controls.Add(Me.TxtLnm)
        Me.Controls.Add(Me.TxtFnm)
        Me.Controls.Add(Me.LAdrs)
        Me.Controls.Add(Me.BtnExt)
        Me.Controls.Add(Me.BtnRgstr)
        Me.Controls.Add(Me.LEml)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LGndr)
        Me.Controls.Add(Me.LDoB)
        Me.Controls.Add(Me.LLstNm)
        Me.Controls.Add(Me.LFnm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LFnm As Label
    Friend WithEvents LLstNm As Label
    Friend WithEvents LDoB As Label
    Friend WithEvents LGndr As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LEml As Label
    Friend WithEvents BtnRgstr As Button
    Friend WithEvents BtnExt As Button
    Friend WithEvents LAdrs As Label
    Friend WithEvents TxtFnm As TextBox
    Friend WithEvents TxtLnm As TextBox
    Friend WithEvents TxtPhn As TextBox
    Friend WithEvents TxtEml As TextBox
    Friend WithEvents TxtAdrs As RichTextBox
    Friend WithEvents ComBoxDt As ComboBox
    Friend WithEvents ComBoxMnth As ComboBox
    Friend WithEvents ComBoxYr As ComboBox
    Friend WithEvents ComBoxG As ComboBox
    Friend WithEvents LPswrd As Label
    Friend WithEvents Lusrnm As Label
    Friend WithEvents TxtPswrd As TextBox
    Friend WithEvents TxtUsrnm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAge As TextBox
End Class
