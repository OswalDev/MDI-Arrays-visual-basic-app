Imports System
Imports System.Data.SqlClient
Imports System.Data

Public Class MDIArrays
    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Me.Text = "Sistema de Registro de Estudiantes"
        Dim LoginForm As New loginForm
        Dim loginResult = LoginForm.ShowDialog()
        'Me.IsMdiContainer = True ' Convertimos a este componente en un MDI
        'LoginForm.MdiParent = Me

        ' Si el usuario cierra el Login Form antes de iniciar sesión, la aplicación entera se cierra como modo de seguridad
        If loginResult = DialogResult.Cancel Then
            Application.Exit()
        End If

    End Sub

    ' Funcion de registro de estudiante
    Private Sub BtnRegisterStudent_Click(sender As Object, e As EventArgs) Handles BtnRegisterStudent.Click
        Try
            ' Interactuando con la base de datos SQL
            Dim sql As String = "INSERT INTO students_table (name, personal_id) VALUES (@name, @personal_id)"
            Dim checkDuplicateSql As String = "SELECT COUNT(*) FROM students_table WHERE personal_id = @personal_id"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(checkDuplicateSql, connection)
                    connection.Open()
                    command.Parameters.AddWithValue("@name", TextBox1.Text)
                    command.Parameters.AddWithValue("@personal_id", TextBox2.Text)

                    Dim duplicateCount As Integer = CInt(command.ExecuteScalar())

                    If duplicateCount > 0 Then
                        ' Ya existe un alumno con la misma cédula
                        MessageBox.Show("Esta cédula ya está registrada en la base de datos.")
                        Return ' Exit the function to prevent inserting the duplicate student
                    End If
                End Using

                Using command As New SqlCommand(sql, connection)
                    ' El estudiante no es un duplicado, se procede con la inserción
                    command.Parameters.AddWithValue("@name", TextBox1.Text)
                    command.Parameters.AddWithValue("@personal_id", TextBox2.Text)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Alumno añadido exitosamente.")
                    Else
                        MessageBox.Show("Error al añadir usuario.")
                    End If
                End Using
            End Using

            ' Si no hay excepciones el codigo continua normalmente.

        Catch ex As Exception
            ' Maneja excepciones customizadas
            MessageBox.Show("Excepción customizada: " & ex.Message)
        End Try
    End Sub

    ' Funcion de registro de calificaciones
    Private Sub BtnRegisterGrade_Click(sender As Object, e As EventArgs) Handles BtnRegisterGrade.Click
        Try
            Dim sqlCheckStudent As String = "SELECT COUNT(*) FROM students_table WHERE personal_id = @personal_id"
            Dim sqlUpdateGrade As String = "UPDATE students_table SET grade_01 = @grade_01, grade_02 = @grade_02, grade_03 = @grade_03, average = (@grade_01 + @grade_02 + @grade_03) / 3.0 WHERE name = @name AND personal_id = @personal_id"

            Using connection As New SqlConnection(connectionString)
                Using commandCheckStudent As New SqlCommand(sqlCheckStudent, connection)
                    connection.Open()

                    commandCheckStudent.Parameters.AddWithValue("@personal_id", inputIdGradeRegister.Text)

                    Dim studentExists As Integer = CInt(commandCheckStudent.ExecuteScalar())

                    If studentExists = 0 Then
                        ' El estudiante con la identificación personal dada no existe en la base de datos
                        MessageBox.Show("No se encontró un estudiante con este ID personal en la base de datos.")
                        Return ' Salir de la función para evitar la actualización de estudiantes no existentes
                    End If
                End Using

                Using commandUpdateGrade As New SqlCommand(sqlUpdateGrade, connection)
                    ' Obtenemos los valores de calificación de los TextBoxes
                    Dim grade01 As Double = 0.0
                    Dim grade02 As Double = 0.0
                    Dim grade03 As Double = 0.0

                    If Double.TryParse(txtGrade01.Text, grade01) AndAlso
                       Double.TryParse(txtGrade02.Text, grade02) AndAlso
                       Double.TryParse(txtGrade03.Text, grade03) Then
                        ' Agrega los valores de calificación a los parámetros
                        commandUpdateGrade.Parameters.AddWithValue("@name", TextBox1.Text)
                        commandUpdateGrade.Parameters.AddWithValue("@personal_id", TextBox2.Text)
                        commandUpdateGrade.Parameters.AddWithValue("@grade_01", grade01)
                        commandUpdateGrade.Parameters.AddWithValue("@grade_02", grade02)
                        commandUpdateGrade.Parameters.AddWithValue("@grade_03", grade03)

                        Dim rowsAffected As Integer = commandUpdateGrade.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Calificaciones actualizadas exitosamente.")
                        Else
                            MessageBox.Show("No se encontró el estudiante para actualizar sus calificaciones.")
                        End If
                    Else
                        MessageBox.Show("Ingrese calificaciones válidas para los campos.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Excepción personalizada: " & ex.Message)
        End Try
    End Sub

    ' Funcion de retiro de estudiante
    Private Sub BtnRemoveStudent_Click(sender As Object, e As EventArgs) Handles BtnRemoveStudent.Click
        Try
            ' Interactuando con la base de datos SQL
            Dim sql As String = "DELETE FROM students_table WHERE personal_id = @idToDelete"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(sql, connection)
                    connection.Open()
                    command.Parameters.AddWithValue("@idToDelete", inputIdGradeRemove.Text)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' La operación DELETE fue exitosa, el alumno fue eliminado de la base de datos.
                        MessageBox.Show("Alumno eliminado exitosamente")
                    Else
                        ' La operación DELETE fue fallida, el alumno con la cédula dada no fue econtrado.
                        MessageBox.Show("Alumno con Cédula " & inputIdGradeRemove.Text & " no fue encontrado.")
                    End If
                End Using
            End Using

            ' Si no hay excepciones el codigo continua normalmente.

        Catch ex As Exception
            ' Maneja excepciones customizadas
            MessageBox.Show("Excepción customizada: " & ex.Message)
        End Try
    End Sub

    ' Funcion de busqueda de estudiantes con promedio mayor a 12
    Private Sub BttnRefresh_Click(sender As Object, e As EventArgs) Handles BttnRefresh.Click
        Try
            Dim sql As String = "SELECT name, personal_id, average FROM students_table WHERE average > 12"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(sql, connection)
                    connection.Open()

                    ' Crea un DataTable para almacenar el resultado de la consulta SQL
                    Dim dataTable As New DataTable()

                    ' Ejecuta la consulta y complete el DataTable con el resultado
                    Using dataAdapter As New SqlDataAdapter(command)
                        dataAdapter.Fill(dataTable)
                    End Using

                    ' Clear existing items from ListView1
                    ListView1.Items.Clear()

                    ' Populate ListView1 with the data from the DataTable
                    For Each row As DataRow In dataTable.Rows
                        Dim name As String = row("name").ToString()
                        Dim personalId As String = row("personal_id").ToString()
                        Dim average As Double = Convert.ToDouble(row("average"))

                        Dim item As New ListViewItem(name)
                        item.SubItems.Add(personalId)
                        item.SubItems.Add(average.ToString("0.00")) ' Formato promedio con dos decimales

                        ListView1.Items.Add(item)
                    Next
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Excepción personalizada: " & ex.Message)
        End Try
    End Sub

    ' Funcion de elminación de estudiantes con inicio de cédula 2
    Private Sub BttnRemoveIndexId_Click(sender As Object, e As EventArgs) Handles BttnRemoveIndexId.Click
        Try
            ' Consulta SQL para eliminar elementos de Students_table donde personal_id comienza con 2
            Dim sql As String = "DELETE FROM students_table WHERE personal_id LIKE '2%'"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(sql, connection)
                    connection.Open()

                    ' Ejecutar la consulta DELETE
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Registros eliminados exitosamente.")
                    Else
                        MessageBox.Show("No se encontraron registros para eliminar.")
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Excepción personalizada: " & ex.Message)
        End Try
    End Sub

End Class