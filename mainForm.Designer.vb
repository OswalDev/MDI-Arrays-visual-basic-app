<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIArrays
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
        TabControl1 = New TabControl()
        TabInscription = New TabPage()
        BtnRegisterStudent = New Button()
        TextBox2 = New TextBox()
        Label2 = New Label()
        lblName = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TabPage2 = New TabPage()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        txtGrade02 = New TextBox()
        txtGrade03 = New TextBox()
        txtGrade01 = New TextBox()
        BtnRegisterGrade = New Button()
        Label4 = New Label()
        inputIdGradeRegister = New TextBox()
        Label3 = New Label()
        TabPage3 = New TabPage()
        inputIdGradeRemove = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        BtnRemoveStudent = New Button()
        TabPage4 = New TabPage()
        BttnRefresh = New Button()
        Label10 = New Label()
        ListView1 = New ListView()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        TabPage5 = New TabPage()
        Label11 = New Label()
        BttnRemoveIndexId = New Button()
        TabControl1.SuspendLayout()
        TabInscription.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        TabPage5.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabInscription)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Location = New Point(2, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(486, 342)
        TabControl1.TabIndex = 1
        TabControl1.Tag = ""
        ' 
        ' TabInscription
        ' 
        TabInscription.Controls.Add(BtnRegisterStudent)
        TabInscription.Controls.Add(TextBox2)
        TabInscription.Controls.Add(Label2)
        TabInscription.Controls.Add(lblName)
        TabInscription.Controls.Add(Label1)
        TabInscription.Controls.Add(TextBox1)
        TabInscription.Location = New Point(4, 24)
        TabInscription.Name = "TabInscription"
        TabInscription.Padding = New Padding(3)
        TabInscription.Size = New Size(478, 314)
        TabInscription.TabIndex = 0
        TabInscription.Text = "Inscripción"
        TabInscription.UseVisualStyleBackColor = True
        ' 
        ' BtnRegisterStudent
        ' 
        BtnRegisterStudent.Location = New Point(185, 224)
        BtnRegisterStudent.Name = "BtnRegisterStudent"
        BtnRegisterStudent.Size = New Size(102, 33)
        BtnRegisterStudent.TabIndex = 5
        BtnRegisterStudent.Text = "Registrar"
        BtnRegisterStudent.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(222, 144)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(136, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 17)
        Label2.TabIndex = 3
        Label2.Text = "Cédula: "
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblName.Location = New Point(136, 93)
        lblName.Name = "lblName"
        lblName.Size = New Size(64, 17)
        lblName.TabIndex = 2
        lblName.Text = "Nombre: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(176, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 21)
        Label1.TabIndex = 1
        Label1.Text = "Inscribir alumno"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(222, 92)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(txtGrade02)
        TabPage2.Controls.Add(txtGrade03)
        TabPage2.Controls.Add(txtGrade01)
        TabPage2.Controls.Add(BtnRegisterGrade)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(inputIdGradeRegister)
        TabPage2.Controls.Add(Label3)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(478, 314)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Registro de notas"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(319, 149)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 15)
        Label7.TabIndex = 14
        Label7.Text = "Nota 03:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(176, 149)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 15)
        Label6.TabIndex = 13
        Label6.Text = "Nota 02: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(29, 151)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 15)
        Label5.TabIndex = 12
        Label5.Text = "Nota 01: "
        ' 
        ' txtGrade02
        ' 
        txtGrade02.Location = New Point(231, 146)
        txtGrade02.Name = "txtGrade02"
        txtGrade02.Size = New Size(58, 23)
        txtGrade02.TabIndex = 11
        ' 
        ' txtGrade03
        ' 
        txtGrade03.Location = New Point(376, 146)
        txtGrade03.Name = "txtGrade03"
        txtGrade03.Size = New Size(58, 23)
        txtGrade03.TabIndex = 10
        ' 
        ' txtGrade01
        ' 
        txtGrade01.Location = New Point(94, 146)
        txtGrade01.Name = "txtGrade01"
        txtGrade01.Size = New Size(58, 23)
        txtGrade01.TabIndex = 9
        ' 
        ' BtnRegisterGrade
        ' 
        BtnRegisterGrade.Location = New Point(176, 250)
        BtnRegisterGrade.Name = "BtnRegisterGrade"
        BtnRegisterGrade.Size = New Size(113, 39)
        BtnRegisterGrade.TabIndex = 8
        BtnRegisterGrade.Text = "Registrar"
        BtnRegisterGrade.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(151, 29)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 20)
        Label4.TabIndex = 2
        Label4.Text = "Registro de notas"
        ' 
        ' inputIdGradeRegister
        ' 
        inputIdGradeRegister.Location = New Point(191, 80)
        inputIdGradeRegister.Name = "inputIdGradeRegister"
        inputIdGradeRegister.Size = New Size(100, 23)
        inputIdGradeRegister.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(132, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 0
        Label3.Text = "Cédula: "
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(inputIdGradeRemove)
        TabPage3.Controls.Add(Label9)
        TabPage3.Controls.Add(Label8)
        TabPage3.Controls.Add(BtnRemoveStudent)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(478, 314)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Retiro"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' inputIdGradeRemove
        ' 
        inputIdGradeRemove.Location = New Point(190, 104)
        inputIdGradeRemove.Name = "inputIdGradeRemove"
        inputIdGradeRemove.Size = New Size(100, 23)
        inputIdGradeRemove.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(122, 107)
        Label9.Name = "Label9"
        Label9.Size = New Size(47, 15)
        Label9.TabIndex = 2
        Label9.Text = "Cédula:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(147, 29)
        Label8.Name = "Label8"
        Label8.Size = New Size(143, 20)
        Label8.TabIndex = 1
        Label8.Text = "Retiro de estudiante"
        ' 
        ' BtnRemoveStudent
        ' 
        BtnRemoveStudent.Location = New Point(175, 212)
        BtnRemoveStudent.Name = "BtnRemoveStudent"
        BtnRemoveStudent.Size = New Size(93, 35)
        BtnRemoveStudent.TabIndex = 0
        BtnRemoveStudent.Text = "Retirar"
        BtnRemoveStudent.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(BttnRefresh)
        TabPage4.Controls.Add(Label10)
        TabPage4.Controls.Add(ListView1)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(478, 314)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Alumnos con promedio mayor a 12"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' BttnRefresh
        ' 
        BttnRefresh.Location = New Point(318, 15)
        BttnRefresh.Name = "BttnRefresh"
        BttnRefresh.Size = New Size(75, 23)
        BttnRefresh.TabIndex = 2
        BttnRefresh.Text = "Refresh"
        BttnRefresh.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(158, 15)
        Label10.Name = "Label10"
        Label10.Size = New Size(122, 20)
        Label10.TabIndex = 1
        Label10.Text = "Mejores alumnos"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader2, ColumnHeader3, ColumnHeader4})
        ListView1.Location = New Point(17, 50)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(429, 253)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Nombre"
        ColumnHeader2.Width = 120
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Cédula"
        ColumnHeader3.Width = 120
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Promedio"
        ColumnHeader4.Width = 120
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(Label11)
        TabPage5.Controls.Add(BttnRemoveIndexId)
        TabPage5.Location = New Point(4, 24)
        TabPage5.Name = "TabPage5"
        TabPage5.Size = New Size(478, 314)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Eliminar"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(88, 51)
        Label11.Name = "Label11"
        Label11.Size = New Size(272, 20)
        Label11.TabIndex = 2
        Label11.Text = "Eliminar alumnos con inicio de cédula 2"
        ' 
        ' BttnRemoveIndexId
        ' 
        BttnRemoveIndexId.Location = New Point(135, 137)
        BttnRemoveIndexId.Name = "BttnRemoveIndexId"
        BttnRemoveIndexId.Size = New Size(146, 47)
        BttnRemoveIndexId.TabIndex = 0
        BttnRemoveIndexId.Text = "Eliminar"
        BttnRemoveIndexId.UseVisualStyleBackColor = True
        ' 
        ' MDIArrays
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(488, 339)
        Controls.Add(TabControl1)
        IsMdiContainer = True
        Name = "MDIArrays"
        Text = "Sistema de Manejo de Notas"
        TabControl1.ResumeLayout(False)
        TabInscription.ResumeLayout(False)
        TabInscription.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabInscription As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnRegisterStudent As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents inputIdGradeRegister As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnRegisterGrade As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGrade02 As TextBox
    Friend WithEvents txtGrade03 As TextBox
    Friend WithEvents txtGrade01 As TextBox
    Friend WithEvents inputIdGradeRemove As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnRemoveStudent As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents BttnRefresh As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents BttnRemoveIndexId As Button
End Class
