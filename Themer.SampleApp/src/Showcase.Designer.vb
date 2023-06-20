
Imports System

Namespace Themer.Sample
    Partial Class Showcase
        ''' <summary>
        ''' Gerekli tasarımcı değişkeni.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Kullanılan tüm kaynakları temizleyin.
        ''' </summary>
        ''' <paramname="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer üretilen kod"

        ''' <summary>
        ''' Tasarımcı desteği için gerekli metot - bu metodun 
        ''' içeriğini kod düzenleyici ile değiştirmeyin.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.lbl = New System.Windows.Forms.Label()
            Me.guna2HtmlToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
            Me.guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
            Me.guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
            Me.guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
            Me.guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
            Me.guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
            Me.guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
            Me.guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
            Me.guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
            Me.guna2ToggleSwitch1 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
            Me.guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.guna2ResizeForm1 = New Guna.UI2.WinForms.Guna2ResizeForm(Me.components)
            Me.guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lbl
            '
            Me.lbl.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
            Me.lbl.Location = New System.Drawing.Point(199, 78)
            Me.lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lbl.Name = "lbl"
            Me.lbl.Size = New System.Drawing.Size(142, 42)
            Me.lbl.TabIndex = 0
            Me.lbl.Text = "Themer"
            Me.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'guna2HtmlToolTip1
            '
            Me.guna2HtmlToolTip1.AllowLinksHandling = True
            Me.guna2HtmlToolTip1.BackColor = System.Drawing.Color.Black
            Me.guna2HtmlToolTip1.BorderColor = System.Drawing.Color.DarkSlateBlue
            Me.guna2HtmlToolTip1.ForeColor = System.Drawing.Color.White
            Me.guna2HtmlToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
            Me.guna2HtmlToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
            '
            'guna2ControlBox1
            '
            Me.guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.guna2ControlBox1.Animated = True
            Me.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
            Me.guna2ControlBox1.BorderRadius = 3
            Me.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
            Me.guna2ControlBox1.IconColor = System.Drawing.Color.White
            Me.guna2ControlBox1.Location = New System.Drawing.Point(644, 12)
            Me.guna2ControlBox1.Name = "guna2ControlBox1"
            Me.guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
            Me.guna2ControlBox1.TabIndex = 10
            Me.guna2HtmlToolTip1.SetToolTip(Me.guna2ControlBox1, "Exit")
            '
            'guna2ControlBox2
            '
            Me.guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.guna2ControlBox2.Animated = True
            Me.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
            Me.guna2ControlBox2.BorderRadius = 3
            Me.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
            Me.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
            Me.guna2ControlBox2.IconColor = System.Drawing.Color.White
            Me.guna2ControlBox2.Location = New System.Drawing.Point(593, 12)
            Me.guna2ControlBox2.Name = "guna2ControlBox2"
            Me.guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
            Me.guna2ControlBox2.TabIndex = 11
            Me.guna2HtmlToolTip1.SetToolTip(Me.guna2ControlBox2, "Minimize")
            '
            'guna2Button5
            '
            Me.guna2Button5.Animated = True
            Me.guna2Button5.BorderRadius = 11
            Me.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.guna2Button5.FillColor = System.Drawing.Color.Transparent
            Me.guna2Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.guna2Button5.ForeColor = System.Drawing.Color.White
            Me.guna2Button5.Location = New System.Drawing.Point(3, 225)
            Me.guna2Button5.Name = "guna2Button5"
            Me.guna2Button5.Size = New System.Drawing.Size(49, 38)
            Me.guna2Button5.TabIndex = 12
            Me.guna2HtmlToolTip1.SetToolTip(Me.guna2Button5, "Whats this?")
            '
            'guna2Button4
            '
            Me.guna2Button4.Animated = True
            Me.guna2Button4.BorderRadius = 11
            Me.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.guna2Button4.FillColor = System.Drawing.Color.Transparent
            Me.guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.guna2Button4.ForeColor = System.Drawing.Color.White
            Me.guna2Button4.Location = New System.Drawing.Point(330, 123)
            Me.guna2Button4.Name = "guna2Button4"
            Me.guna2Button4.Size = New System.Drawing.Size(49, 38)
            Me.guna2Button4.TabIndex = 9
            Me.guna2HtmlToolTip1.SetToolTip(Me.guna2Button4, "None")
            '
            'guna2Button3
            '
            Me.guna2Button3.Animated = True
            Me.guna2Button3.BorderRadius = 11
            Me.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.guna2Button3.FillColor = System.Drawing.Color.Transparent
            Me.guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.guna2Button3.ForeColor = System.Drawing.Color.White
            Me.guna2Button3.Location = New System.Drawing.Point(275, 123)
            Me.guna2Button3.Name = "guna2Button3"
            Me.guna2Button3.Size = New System.Drawing.Size(49, 38)
            Me.guna2Button3.TabIndex = 8
            Me.guna2HtmlToolTip1.SetToolTip(Me.guna2Button3, "Transparent")
            '
            'guna2Button2
            '
            Me.guna2Button2.Animated = True
            Me.guna2Button2.BorderRadius = 11
            Me.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.guna2Button2.FillColor = System.Drawing.Color.Transparent
            Me.guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.guna2Button2.ForeColor = System.Drawing.Color.White
            Me.guna2Button2.Location = New System.Drawing.Point(220, 123)
            Me.guna2Button2.Name = "guna2Button2"
            Me.guna2Button2.Size = New System.Drawing.Size(49, 38)
            Me.guna2Button2.TabIndex = 7
            Me.guna2HtmlToolTip1.SetToolTip(Me.guna2Button2, "Aero Glass")
            '
            'guna2Button1
            '
            Me.guna2Button1.Animated = True
            Me.guna2Button1.BorderRadius = 11
            Me.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.guna2Button1.FillColor = System.Drawing.Color.Transparent
            Me.guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.guna2Button1.ForeColor = System.Drawing.Color.White
            Me.guna2Button1.Location = New System.Drawing.Point(165, 123)
            Me.guna2Button1.Name = "guna2Button1"
            Me.guna2Button1.Size = New System.Drawing.Size(49, 38)
            Me.guna2Button1.TabIndex = 6
            Me.guna2HtmlToolTip1.SetToolTip(Me.guna2Button1, "Acrylic")
            '
            'guna2Button6
            '
            Me.guna2Button6.Animated = True
            Me.guna2Button6.BorderRadius = 11
            Me.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.guna2Button6.FillColor = System.Drawing.Color.Transparent
            Me.guna2Button6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.guna2Button6.ForeColor = System.Drawing.Color.White
            Me.guna2Button6.Location = New System.Drawing.Point(525, 225)
            Me.guna2Button6.Name = "guna2Button6"
            Me.guna2Button6.Size = New System.Drawing.Size(49, 38)
            Me.guna2Button6.TabIndex = 13
            Me.guna2HtmlToolTip1.SetToolTip(Me.guna2Button6, "Follow my github :)")
            '
            'guna2ToggleSwitch1
            '
            Me.guna2ToggleSwitch1.Animated = True
            Me.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White
            Me.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White
            Me.guna2ToggleSwitch1.Location = New System.Drawing.Point(307, 365)
            Me.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1"
            Me.guna2ToggleSwitch1.Size = New System.Drawing.Size(47, 20)
            Me.guna2ToggleSwitch1.TabIndex = 15
            Me.guna2HtmlToolTip1.SetToolTip(Me.guna2ToggleSwitch1, "Free Mode")
            Me.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White
            Me.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White
            '
            'guna2Panel1
            '
            Me.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.guna2Panel1.Controls.Add(Me.guna2Button6)
            Me.guna2Panel1.Controls.Add(Me.guna2Button5)
            Me.guna2Panel1.Controls.Add(Me.guna2Button1)
            Me.guna2Panel1.Controls.Add(Me.guna2Button2)
            Me.guna2Panel1.Controls.Add(Me.guna2Button3)
            Me.guna2Panel1.Controls.Add(Me.guna2Button4)
            Me.guna2Panel1.Controls.Add(Me.lbl)
            Me.guna2Panel1.Location = New System.Drawing.Point(62, 85)
            Me.guna2Panel1.Name = "guna2Panel1"
            Me.guna2Panel1.Size = New System.Drawing.Size(577, 274)
            Me.guna2Panel1.TabIndex = 14
            '
            'guna2ResizeForm1
            '
            Me.guna2ResizeForm1.TargetForm = Me
            '
            'Showcase
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(701, 408)
            Me.Controls.Add(Me.guna2ToggleSwitch1)
            Me.Controls.Add(Me.guna2ControlBox2)
            Me.Controls.Add(Me.guna2ControlBox1)
            Me.Controls.Add(Me.guna2Panel1)
            Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Showcase"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Themer"
            Me.guna2Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private lbl As Windows.Forms.Label
        Private guna2Button1 As Guna.UI2.WinForms.Guna2Button
        Private guna2HtmlToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
        Private guna2Button2 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button3 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button4 As Guna.UI2.WinForms.Guna2Button
        Private guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
        Private guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
        Private guna2Button5 As Guna.UI2.WinForms.Guna2Button
        Private guna2Button6 As Guna.UI2.WinForms.Guna2Button
        Private guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Private guna2ResizeForm1 As Guna.UI2.WinForms.Guna2ResizeForm
        Private guna2ToggleSwitch1 As Guna.UI2.WinForms.Guna2ToggleSwitch
    End Class
End Namespace
