<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        lblresult = New Label()
        txtfirstnum = New TextBox()
        txtsecondnum = New TextBox()
        Btndivide = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Location = New Point(12, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaption
        Label2.Location = New Point(12, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 0
        Label2.Text = "Second Number:"
        ' 
        ' lblresult
        ' 
        lblresult.AutoSize = True
        lblresult.Location = New Point(12, 150)
        lblresult.Name = "lblresult"
        lblresult.Size = New Size(46, 15)
        lblresult.TabIndex = 3
        lblresult.Text = "Answer"
        ' 
        ' txtfirstnum
        ' 
        txtfirstnum.BackColor = SystemColors.Control
        txtfirstnum.Location = New Point(12, 42)
        txtfirstnum.Name = "txtfirstnum"
        txtfirstnum.Size = New Size(100, 23)
        txtfirstnum.TabIndex = 1
        ' 
        ' txtsecondnum
        ' 
        txtsecondnum.BackColor = SystemColors.Control
        txtsecondnum.Location = New Point(12, 86)
        txtsecondnum.Name = "txtsecondnum"
        txtsecondnum.Size = New Size(100, 23)
        txtsecondnum.TabIndex = 2
        ' 
        ' Btndivide
        ' 
        Btndivide.BackColor = SystemColors.ActiveCaption
        Btndivide.Location = New Point(12, 115)
        Btndivide.Name = "Btndivide"
        Btndivide.Size = New Size(75, 23)
        Btndivide.TabIndex = 3
        Btndivide.Text = "Divide"
        Btndivide.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AcceptButton = Btndivide
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._0_UYsniZNijTgsZ3JT
        ClientSize = New Size(800, 450)
        Controls.Add(Btndivide)
        Controls.Add(txtsecondnum)
        Controls.Add(txtfirstnum)
        Controls.Add(lblresult)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblresult As Label
    Friend WithEvents txtfirstnum As TextBox
    Friend WithEvents txtsecondnum As TextBox
    Friend WithEvents Btndivide As Button
End Class
