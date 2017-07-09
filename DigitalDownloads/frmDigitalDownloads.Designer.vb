<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDigitalDownloads
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
        Me.lblDigitalDownloads = New System.Windows.Forms.Label()
        Me.lbl99CentPerDownload = New System.Windows.Forms.Label()
        Me.lblNumberOfDownloads = New System.Windows.Forms.Label()
        Me.lblTotalCostOfDownloads = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picHeadphones = New System.Windows.Forms.PictureBox()
        Me.txtNumberOfSongDownloads = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCalculateCost = New System.Windows.Forms.Button()
        CType(Me.picHeadphones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDigitalDownloads
        '
        Me.lblDigitalDownloads.AutoSize = True
        Me.lblDigitalDownloads.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigitalDownloads.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblDigitalDownloads.Location = New System.Drawing.Point(55, 38)
        Me.lblDigitalDownloads.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDigitalDownloads.Name = "lblDigitalDownloads"
        Me.lblDigitalDownloads.Size = New System.Drawing.Size(208, 24)
        Me.lblDigitalDownloads.TabIndex = 0
        Me.lblDigitalDownloads.Text = "Digital Downloads"
        '
        'lbl99CentPerDownload
        '
        Me.lbl99CentPerDownload.AutoSize = True
        Me.lbl99CentPerDownload.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl99CentPerDownload.Location = New System.Drawing.Point(80, 66)
        Me.lbl99CentPerDownload.Name = "lbl99CentPerDownload"
        Me.lbl99CentPerDownload.Size = New System.Drawing.Size(155, 20)
        Me.lbl99CentPerDownload.TabIndex = 1
        Me.lbl99CentPerDownload.Text = "$0.99 per Download"
        '
        'lblNumberOfDownloads
        '
        Me.lblNumberOfDownloads.AutoSize = True
        Me.lblNumberOfDownloads.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfDownloads.Location = New System.Drawing.Point(41, 122)
        Me.lblNumberOfDownloads.Name = "lblNumberOfDownloads"
        Me.lblNumberOfDownloads.Size = New System.Drawing.Size(177, 20)
        Me.lblNumberOfDownloads.TabIndex = 2
        Me.lblNumberOfDownloads.Text = "Number of Downloads:"
        '
        'lblTotalCostOfDownloads
        '
        Me.lblTotalCostOfDownloads.AutoSize = True
        Me.lblTotalCostOfDownloads.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostOfDownloads.Location = New System.Drawing.Point(41, 153)
        Me.lblTotalCostOfDownloads.Name = "lblTotalCostOfDownloads"
        Me.lblTotalCostOfDownloads.Size = New System.Drawing.Size(189, 20)
        Me.lblTotalCostOfDownloads.TabIndex = 3
        Me.lblTotalCostOfDownloads.Text = "Total Cost of Downloads:"
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnClear.Location = New System.Drawing.Point(110, 206)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnExit.Location = New System.Drawing.Point(210, 206)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picHeadphones
        '
        Me.picHeadphones.Image = Global.DigitalDownloads.My.Resources.Resources.Music
        Me.picHeadphones.Location = New System.Drawing.Point(-1, 241)
        Me.picHeadphones.Name = "picHeadphones"
        Me.picHeadphones.Size = New System.Drawing.Size(321, 168)
        Me.picHeadphones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHeadphones.TabIndex = 7
        Me.picHeadphones.TabStop = False
        '
        'txtNumberOfSongDownloads
        '
        Me.txtNumberOfSongDownloads.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfSongDownloads.Location = New System.Drawing.Point(238, 119)
        Me.txtNumberOfSongDownloads.Name = "txtNumberOfSongDownloads"
        Me.txtNumberOfSongDownloads.Size = New System.Drawing.Size(35, 26)
        Me.txtNumberOfSongDownloads.TabIndex = 8
        Me.txtNumberOfSongDownloads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(233, 153)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 20)
        Me.lblTotalCost.TabIndex = 9
        '
        'btnCalculateCost
        '
        Me.btnCalculateCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateCost.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnCalculateCost.Location = New System.Drawing.Point(9, 206)
        Me.btnCalculateCost.Name = "btnCalculateCost"
        Me.btnCalculateCost.Size = New System.Drawing.Size(99, 23)
        Me.btnCalculateCost.TabIndex = 10
        Me.btnCalculateCost.Text = "Calculate Cost"
        Me.btnCalculateCost.UseVisualStyleBackColor = True
        '
        'frmDigitalDownloads
        '
        Me.AcceptButton = Me.btnCalculateCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(319, 412)
        Me.Controls.Add(Me.btnCalculateCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.txtNumberOfSongDownloads)
        Me.Controls.Add(Me.picHeadphones)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTotalCostOfDownloads)
        Me.Controls.Add(Me.lblNumberOfDownloads)
        Me.Controls.Add(Me.lbl99CentPerDownload)
        Me.Controls.Add(Me.lblDigitalDownloads)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmDigitalDownloads"
        Me.Text = "Download Music"
        CType(Me.picHeadphones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDigitalDownloads As System.Windows.Forms.Label
    Friend WithEvents lbl99CentPerDownload As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfDownloads As System.Windows.Forms.Label
    Friend WithEvents lblTotalCostOfDownloads As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picHeadphones As System.Windows.Forms.PictureBox
    Friend WithEvents txtNumberOfSongDownloads As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents btnCalculateCost As System.Windows.Forms.Button

End Class
