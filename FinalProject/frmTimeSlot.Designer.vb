<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeSlot
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblGuests = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblOutstanding2 = New System.Windows.Forms.Label()
        Me.lblNextEntry2 = New System.Windows.Forms.Label()
        Me.lblNextEntry = New System.Windows.Forms.Label()
        Me.lblOutstanding = New System.Windows.Forms.Label()
        Me.btnIssueTicket = New System.Windows.Forms.Button()
        Me.lstTicketsIssued = New System.Windows.Forms.ListBox()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblGuests)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(38, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 81)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guests with the following tickets may now enter:"
        '
        'lblGuests
        '
        Me.lblGuests.AutoSize = True
        Me.lblGuests.Location = New System.Drawing.Point(20, 38)
        Me.lblGuests.Name = "lblGuests"
        Me.lblGuests.Size = New System.Drawing.Size(0, 17)
        Me.lblGuests.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblOutstanding2)
        Me.GroupBox2.Controls.Add(Me.lblNextEntry2)
        Me.GroupBox2.Controls.Add(Me.lblNextEntry)
        Me.GroupBox2.Controls.Add(Me.lblOutstanding)
        Me.GroupBox2.Controls.Add(Me.btnIssueTicket)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(38, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 210)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ticket Availability"
        '
        'lblOutstanding2
        '
        Me.lblOutstanding2.AutoSize = True
        Me.lblOutstanding2.Location = New System.Drawing.Point(233, 49)
        Me.lblOutstanding2.Name = "lblOutstanding2"
        Me.lblOutstanding2.Size = New System.Drawing.Size(0, 17)
        Me.lblOutstanding2.TabIndex = 4
        '
        'lblNextEntry2
        '
        Me.lblNextEntry2.AutoSize = True
        Me.lblNextEntry2.Location = New System.Drawing.Point(233, 106)
        Me.lblNextEntry2.Name = "lblNextEntry2"
        Me.lblNextEntry2.Size = New System.Drawing.Size(0, 17)
        Me.lblNextEntry2.TabIndex = 3
        '
        'lblNextEntry
        '
        Me.lblNextEntry.AutoSize = True
        Me.lblNextEntry.Location = New System.Drawing.Point(23, 106)
        Me.lblNextEntry.Name = "lblNextEntry"
        Me.lblNextEntry.Size = New System.Drawing.Size(142, 17)
        Me.lblNextEntry.TabIndex = 2
        Me.lblNextEntry.Text = "Next available entry: "
        '
        'lblOutstanding
        '
        Me.lblOutstanding.AutoSize = True
        Me.lblOutstanding.Location = New System.Drawing.Point(23, 49)
        Me.lblOutstanding.Name = "lblOutstanding"
        Me.lblOutstanding.Size = New System.Drawing.Size(171, 17)
        Me.lblOutstanding.TabIndex = 1
        Me.lblOutstanding.Text = "Total tickets outstanding: "
        '
        'btnIssueTicket
        '
        Me.btnIssueTicket.Location = New System.Drawing.Point(6, 154)
        Me.btnIssueTicket.Name = "btnIssueTicket"
        Me.btnIssueTicket.Size = New System.Drawing.Size(230, 35)
        Me.btnIssueTicket.TabIndex = 0
        Me.btnIssueTicket.Text = "Issue Ticket"
        Me.btnIssueTicket.UseVisualStyleBackColor = True
        '
        'lstTicketsIssued
        '
        Me.lstTicketsIssued.Font = New System.Drawing.Font("Georgia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTicketsIssued.FormattingEnabled = True
        Me.lstTicketsIssued.ItemHeight = 16
        Me.lstTicketsIssued.Location = New System.Drawing.Point(38, 382)
        Me.lstTicketsIssued.Name = "lstTicketsIssued"
        Me.lstTicketsIssued.Size = New System.Drawing.Size(520, 212)
        Me.lstTicketsIssued.TabIndex = 2
        '
        'btnOptions
        '
        Me.btnOptions.Font = New System.Drawing.Font("Georgia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.Location = New System.Drawing.Point(38, 617)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(124, 35)
        Me.btnOptions.TabIndex = 3
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Georgia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(434, 617)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 35)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmTimeSlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 664)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.lstTicketsIssued)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTimeSlot"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnIssueTicket As Button
    Friend WithEvents lstTicketsIssued As ListBox
    Friend WithEvents btnOptions As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblGuests As Label
    Friend WithEvents lblOutstanding2 As Label
    Friend WithEvents lblNextEntry2 As Label
    Friend WithEvents lblNextEntry As Label
    Friend WithEvents lblOutstanding As Label
End Class
