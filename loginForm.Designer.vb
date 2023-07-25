<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        BtnLogin = New Button()
        Label1 = New Label()
        inputUsername = New TextBox()
        inputPassword = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(145, 194)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(75, 23)
        BtnLogin.TabIndex = 0
        BtnLogin.Text = "Ingresar"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(133, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 1
        Label1.Text = "Inicia Sesión"
        ' 
        ' inputUsername
        ' 
        inputUsername.Location = New Point(145, 70)
        inputUsername.Name = "inputUsername"
        inputUsername.Size = New Size(100, 23)
        inputUsername.TabIndex = 2
        ' 
        ' inputPassword
        ' 
        inputPassword.Location = New Point(145, 117)
        inputPassword.Name = "inputPassword"
        inputPassword.Size = New Size(100, 23)
        inputPassword.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(74, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 4
        Label2.Text = "usuario: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(74, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 15)
        Label3.TabIndex = 5
        Label3.Text = "contraseña: "
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(364, 229)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(inputPassword)
        Controls.Add(inputUsername)
        Controls.Add(Label1)
        Controls.Add(BtnLogin)
        Name = "loginForm"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents inputUsername As TextBox
    Friend WithEvents inputPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
