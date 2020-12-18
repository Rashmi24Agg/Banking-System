<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FTrnsfr
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
        Me.TxtAcc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAmnt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtno = New System.Windows.Forms.TextBox()
        Me.TxtDt = New System.Windows.Forms.TextBox()
        Me.Btntrnsfr = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LHome = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'TxtAcc
        '
        Me.TxtAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAcc.Location = New System.Drawing.Point(110, 202)
        Me.TxtAcc.Name = "TxtAcc"
        Me.TxtAcc.Size = New System.Drawing.Size(151, 22)
        Me.TxtAcc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Account no."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter Amount "
        '
        'TxtAmnt
        '
        Me.TxtAmnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmnt.Location = New System.Drawing.Point(110, 291)
        Me.TxtAmnt.Name = "TxtAmnt"
        Me.TxtAmnt.Size = New System.Drawing.Size(151, 22)
        Me.TxtAmnt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(201, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Date"
        '
        'Txtno
        '
        Me.Txtno.BackColor = System.Drawing.Color.White
        Me.Txtno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtno.Location = New System.Drawing.Point(42, 55)
        Me.Txtno.Name = "Txtno"
        Me.Txtno.ReadOnly = True
        Me.Txtno.Size = New System.Drawing.Size(121, 15)
        Me.Txtno.TabIndex = 6
        '
        'TxtDt
        '
        Me.TxtDt.BackColor = System.Drawing.Color.White
        Me.TxtDt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDt.Location = New System.Drawing.Point(240, 55)
        Me.TxtDt.Name = "TxtDt"
        Me.TxtDt.Size = New System.Drawing.Size(114, 15)
        Me.TxtDt.TabIndex = 7
        '
        'Btntrnsfr
        '
        Me.Btntrnsfr.BackColor = System.Drawing.Color.Black
        Me.Btntrnsfr.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btntrnsfr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btntrnsfr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btntrnsfr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btntrnsfr.Location = New System.Drawing.Point(140, 361)
        Me.Btntrnsfr.Name = "Btntrnsfr"
        Me.Btntrnsfr.Size = New System.Drawing.Size(75, 32)
        Me.Btntrnsfr.TabIndex = 8
        Me.Btntrnsfr.Text = "Transfer"
        Me.Btntrnsfr.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(276, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "* You can transfer maximum rs. 3000 at a time "
        '
        'LHome
        '
        Me.LHome.AutoSize = True
        Me.LHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHome.LinkColor = System.Drawing.Color.Black
        Me.LHome.Location = New System.Drawing.Point(321, 20)
        Me.LHome.Name = "LHome"
        Me.LHome.Size = New System.Drawing.Size(45, 16)
        Me.LHome.TabIndex = 11
        Me.LHome.TabStop = True
        Me.LHome.Text = "Home"
        '
        'FTrnsfr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.LHome
        Me.ClientSize = New System.Drawing.Size(380, 428)
        Me.Controls.Add(Me.LHome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Btntrnsfr)
        Me.Controls.Add(Me.TxtDt)
        Me.Controls.Add(Me.Txtno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtAmnt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtAcc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FTrnsfr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtAcc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAmnt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txtno As TextBox
    Friend WithEvents TxtDt As TextBox
    Friend WithEvents Btntrnsfr As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LHome As LinkLabel
End Class
