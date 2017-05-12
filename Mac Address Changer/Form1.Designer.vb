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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.combo_network = New System.Windows.Forms.ComboBox()
        Me.label_mactext = New System.Windows.Forms.Label()
        Me.mac_text = New System.Windows.Forms.TextBox()
        Me.bt_update = New System.Windows.Forms.Button()
        Me.bt_defaultmac = New System.Windows.Forms.Button()
        Me.MacInputLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 220)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(120, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Invictus Profile - Weeke"
        '
        'combo_network
        '
        Me.combo_network.FormattingEnabled = True
        Me.combo_network.Location = New System.Drawing.Point(11, 12)
        Me.combo_network.Name = "combo_network"
        Me.combo_network.Size = New System.Drawing.Size(390, 21)
        Me.combo_network.TabIndex = 2
        '
        'label_mactext
        '
        Me.label_mactext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_mactext.Location = New System.Drawing.Point(11, 139)
        Me.label_mactext.Name = "label_mactext"
        Me.label_mactext.Size = New System.Drawing.Size(389, 81)
        Me.label_mactext.TabIndex = 3
        '
        'mac_text
        '
        Me.mac_text.Location = New System.Drawing.Point(144, 39)
        Me.mac_text.Name = "mac_text"
        Me.mac_text.Size = New System.Drawing.Size(257, 20)
        Me.mac_text.TabIndex = 4
        '
        'bt_update
        '
        Me.bt_update.Location = New System.Drawing.Point(11, 94)
        Me.bt_update.Name = "bt_update"
        Me.bt_update.Size = New System.Drawing.Size(127, 23)
        Me.bt_update.TabIndex = 5
        Me.bt_update.Text = "Get New Mac Address"
        Me.bt_update.UseVisualStyleBackColor = True
        '
        'bt_defaultmac
        '
        Me.bt_defaultmac.Location = New System.Drawing.Point(11, 65)
        Me.bt_defaultmac.Name = "bt_defaultmac"
        Me.bt_defaultmac.Size = New System.Drawing.Size(127, 23)
        Me.bt_defaultmac.TabIndex = 6
        Me.bt_defaultmac.Text = "Reset Mac Address"
        Me.bt_defaultmac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_defaultmac.UseVisualStyleBackColor = True
        '
        'MacInputLabel
        '
        Me.MacInputLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MacInputLabel.Location = New System.Drawing.Point(8, 39)
        Me.MacInputLabel.Name = "MacInputLabel"
        Me.MacInputLabel.Size = New System.Drawing.Size(130, 23)
        Me.MacInputLabel.TabIndex = 7
        Me.MacInputLabel.Text = "New Mac Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "This is your default mac address"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(407, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 50)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "To get a mac address to change to use this site: http://www.miniwebtool.com/mac-a" &
    "ddress-generator"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(407, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Must be formatted like: B9:99:75:CA:F4:C5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 243)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MacInputLabel)
        Me.Controls.Add(Me.bt_defaultmac)
        Me.Controls.Add(Me.bt_update)
        Me.Controls.Add(Me.mac_text)
        Me.Controls.Add(Me.label_mactext)
        Me.Controls.Add(Me.combo_network)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Name = "Form1"
        Me.Text = "Mac Address Changer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents combo_network As ComboBox
    Friend WithEvents label_mactext As Label
    Friend WithEvents mac_text As TextBox
    Friend WithEvents bt_update As Button
    Friend WithEvents bt_defaultmac As Button
    Friend WithEvents MacInputLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
