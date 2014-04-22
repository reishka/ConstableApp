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
        Me.txt_streetAddress = New System.Windows.Forms.TextBox()
        Me.txt_City = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_businessName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chk_FirstNotice = New System.Windows.Forms.CheckBox()
        Me.chk_FinalNotice = New System.Windows.Forms.CheckBox()
        Me.txt_zip = New System.Windows.Forms.MaskedTextBox()
        Me.chk_Envelope = New System.Windows.Forms.CheckBox()
        Me.txt_state = New System.Windows.Forms.TextBox()
        Me.btn_Create = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_fName = New System.Windows.Forms.TextBox()
        Me.txt_lName = New System.Windows.Forms.TextBox()
        Me.dtp_warrantEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_warrantAmount = New System.Windows.Forms.TextBox()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_WarrantNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_streetAddress
        '
        Me.txt_streetAddress.Location = New System.Drawing.Point(13, 186)
        Me.txt_streetAddress.Name = "txt_streetAddress"
        Me.txt_streetAddress.Size = New System.Drawing.Size(297, 20)
        Me.txt_streetAddress.TabIndex = 6
        '
        'txt_City
        '
        Me.txt_City.Location = New System.Drawing.Point(13, 225)
        Me.txt_City.Name = "txt_City"
        Me.txt_City.Size = New System.Drawing.Size(145, 20)
        Me.txt_City.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Business Name"
        '
        'txt_businessName
        '
        Me.txt_businessName.Location = New System.Drawing.Point(13, 147)
        Me.txt_businessName.Name = "txt_businessName"
        Me.txt_businessName.Size = New System.Drawing.Size(297, 20)
        Me.txt_businessName.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Street Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "City"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(166, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "State"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(218, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "ZIP"
        '
        'chk_FirstNotice
        '
        Me.chk_FirstNotice.AutoSize = True
        Me.chk_FirstNotice.Location = New System.Drawing.Point(15, 274)
        Me.chk_FirstNotice.Name = "chk_FirstNotice"
        Me.chk_FirstNotice.Size = New System.Drawing.Size(144, 17)
        Me.chk_FirstNotice.TabIndex = 11
        Me.chk_FirstNotice.Text = "Create/Print Initial Notice"
        Me.chk_FirstNotice.UseVisualStyleBackColor = True
        '
        'chk_FinalNotice
        '
        Me.chk_FinalNotice.AutoSize = True
        Me.chk_FinalNotice.Location = New System.Drawing.Point(15, 297)
        Me.chk_FinalNotice.Name = "chk_FinalNotice"
        Me.chk_FinalNotice.Size = New System.Drawing.Size(142, 17)
        Me.chk_FinalNotice.TabIndex = 12
        Me.chk_FinalNotice.Text = "Create/Print Final Notice"
        Me.chk_FinalNotice.UseVisualStyleBackColor = True
        '
        'txt_zip
        '
        Me.txt_zip.Location = New System.Drawing.Point(221, 225)
        Me.txt_zip.Mask = "00000"
        Me.txt_zip.Name = "txt_zip"
        Me.txt_zip.Size = New System.Drawing.Size(89, 20)
        Me.txt_zip.TabIndex = 9
        Me.txt_zip.ValidatingType = GetType(Integer)
        '
        'chk_Envelope
        '
        Me.chk_Envelope.AutoSize = True
        Me.chk_Envelope.Location = New System.Drawing.Point(165, 274)
        Me.chk_Envelope.Name = "chk_Envelope"
        Me.chk_Envelope.Size = New System.Drawing.Size(105, 17)
        Me.chk_Envelope.TabIndex = 13
        Me.chk_Envelope.Text = "Create Envelope"
        Me.chk_Envelope.UseVisualStyleBackColor = True
        '
        'txt_state
        '
        Me.txt_state.Location = New System.Drawing.Point(169, 225)
        Me.txt_state.Name = "txt_state"
        Me.txt_state.Size = New System.Drawing.Size(38, 20)
        Me.txt_state.TabIndex = 8
        '
        'btn_Create
        '
        Me.btn_Create.Location = New System.Drawing.Point(234, 331)
        Me.btn_Create.Name = "btn_Create"
        Me.btn_Create.Size = New System.Drawing.Size(75, 23)
        Me.btn_Create.TabIndex = 14
        Me.btn_Create.Text = "Create"
        Me.btn_Create.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "First Name"
        '
        'txt_fName
        '
        Me.txt_fName.Location = New System.Drawing.Point(13, 108)
        Me.txt_fName.Name = "txt_fName"
        Me.txt_fName.Size = New System.Drawing.Size(145, 20)
        Me.txt_fName.TabIndex = 3
        '
        'txt_lName
        '
        Me.txt_lName.Location = New System.Drawing.Point(165, 108)
        Me.txt_lName.Name = "txt_lName"
        Me.txt_lName.Size = New System.Drawing.Size(145, 20)
        Me.txt_lName.TabIndex = 4
        '
        'dtp_warrantEnd
        '
        Me.dtp_warrantEnd.Location = New System.Drawing.Point(13, 66)
        Me.dtp_warrantEnd.Name = "dtp_warrantEnd"
        Me.dtp_warrantEnd.Size = New System.Drawing.Size(194, 20)
        Me.dtp_warrantEnd.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Warrant valid until:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(225, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Warrant Amount"
        '
        'txt_warrantAmount
        '
        Me.txt_warrantAmount.Location = New System.Drawing.Point(226, 66)
        Me.txt_warrantAmount.Name = "txt_warrantAmount"
        Me.txt_warrantAmount.Size = New System.Drawing.Size(84, 20)
        Me.txt_warrantAmount.TabIndex = 2
        '
        'dtp_date
        '
        Me.dtp_date.Location = New System.Drawing.Point(13, 27)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(194, 20)
        Me.dtp_date.TabIndex = 0
        '
        'txt_WarrantNumber
        '
        Me.txt_WarrantNumber.Location = New System.Drawing.Point(228, 27)
        Me.txt_WarrantNumber.Mask = "0000-0000"
        Me.txt_WarrantNumber.Name = "txt_WarrantNumber"
        Me.txt_WarrantNumber.Size = New System.Drawing.Size(82, 20)
        Me.txt_WarrantNumber.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Warrant Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Today's Date"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 366)
        Me.Controls.Add(Me.dtp_warrantEnd)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_warrantAmount)
        Me.Controls.Add(Me.btn_Create)
        Me.Controls.Add(Me.txt_state)
        Me.Controls.Add(Me.chk_Envelope)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.txt_zip)
        Me.Controls.Add(Me.chk_FinalNotice)
        Me.Controls.Add(Me.chk_FirstNotice)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_businessName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_lName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_WarrantNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_City)
        Me.Controls.Add(Me.txt_streetAddress)
        Me.Controls.Add(Me.txt_fName)
        Me.Name = "Form1"
        Me.Text = "Notice Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_streetAddress As System.Windows.Forms.TextBox
    Friend WithEvents txt_City As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_businessName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chk_FirstNotice As System.Windows.Forms.CheckBox
    Friend WithEvents chk_FinalNotice As System.Windows.Forms.CheckBox
    Friend WithEvents txt_zip As System.Windows.Forms.MaskedTextBox
    Friend WithEvents chk_Envelope As System.Windows.Forms.CheckBox
    Friend WithEvents txt_state As System.Windows.Forms.TextBox
    Friend WithEvents btn_Create As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_fName As System.Windows.Forms.TextBox
    Friend WithEvents txt_lName As System.Windows.Forms.TextBox
    Friend WithEvents dtp_warrantEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_warrantAmount As System.Windows.Forms.TextBox
    Friend WithEvents dtp_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_WarrantNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
