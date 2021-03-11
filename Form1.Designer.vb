<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_npm = New System.Windows.Forms.TextBox()
        Me.txt_npm_update = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nama_update = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nama_delete = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_npm_delete = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.btn_insert)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.txt_npm)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 313)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CREATE"
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(21, 256)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(256, 23)
        Me.btn_insert.TabIndex = 4
        Me.btn_insert.Text = "TAMBAH DATA"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Masukan Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Masukan NPM"
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(21, 110)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(256, 23)
        Me.txt_nama.TabIndex = 1
        '
        'txt_npm
        '
        Me.txt_npm.Location = New System.Drawing.Point(21, 56)
        Me.txt_npm.Name = "txt_npm"
        Me.txt_npm.Size = New System.Drawing.Size(256, 23)
        Me.txt_npm.TabIndex = 0
        '
        'txt_npm_update
        '
        Me.txt_npm_update.Location = New System.Drawing.Point(17, 56)
        Me.txt_npm_update.Name = "txt_npm_update"
        Me.txt_npm_update.Size = New System.Drawing.Size(256, 23)
        Me.txt_npm_update.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Masukan NPM"
        '
        'txt_nama_update
        '
        Me.txt_nama_update.Location = New System.Drawing.Point(17, 110)
        Me.txt_nama_update.Name = "txt_nama_update"
        Me.txt_nama_update.Size = New System.Drawing.Size(256, 23)
        Me.txt_nama_update.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Salmon
        Me.GroupBox2.Controls.Add(Me.btn_update)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_nama_update)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_npm_update)
        Me.GroupBox2.Location = New System.Drawing.Point(420, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 313)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "UPDATE"
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(17, 252)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(256, 23)
        Me.btn_update.TabIndex = 5
        Me.btn_update.Text = "UPDATE DATA"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Masukan Nama"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightSalmon
        Me.GroupBox3.Controls.Add(Me.btn_delete)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_nama_delete)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_npm_delete)
        Me.GroupBox3.Location = New System.Drawing.Point(751, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(291, 313)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DELETE"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(17, 252)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(256, 23)
        Me.btn_delete.TabIndex = 5
        Me.btn_delete.Text = "DELETE DATA"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Masukan Nama"
        '
        'txt_nama_delete
        '
        Me.txt_nama_delete.Location = New System.Drawing.Point(17, 110)
        Me.txt_nama_delete.Name = "txt_nama_delete"
        Me.txt_nama_delete.Size = New System.Drawing.Size(256, 23)
        Me.txt_nama_delete.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Masukan NPM"
        '
        'txt_npm_delete
        '
        Me.txt_npm_delete.Location = New System.Drawing.Point(17, 56)
        Me.txt_npm_delete.Name = "txt_npm_delete"
        Me.txt_npm_delete.Size = New System.Drawing.Size(256, 23)
        Me.txt_npm_delete.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("SimSun", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(471, -1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 97)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "CUD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(629, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 27)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "mysql"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1101, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "CUD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_insert As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_npm As TextBox
    Friend WithEvents txt_npm_update As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nama_update As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_update As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nama_delete As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_npm_delete As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
