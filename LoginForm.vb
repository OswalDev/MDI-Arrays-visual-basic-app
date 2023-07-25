Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Public Class loginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            ' Interactuando con la base de datos SQL
            Dim sql As String = "SELECT * FROM users_table WHERE username= '" & inputUsername.Text & "' and password='" & inputPassword.Text & "' "

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(sql, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    ' Rellena la tabla en la base de datos
                    adapter.Fill(dataTable)

                    ' Si dataTable se ha cargado correctamente
                    If (dataTable.Rows.Count > 0) Then
                        ' Si las credenciales son correctas
                        isLoggedIn = True
                        Me.DialogResult = DialogResult.OK ' Retornando OK como resultado del Inicio de sesión
                        Me.Close()
                    Else
                        ' Si las credenciales son incorrectas
                        MessageBox.Show("credenciales incorrectas", "Error")
                    End If

                    ' se abre conección con la base de datos
                    connection.Open()


                    ' se cierra conección con la base de datos
                    connection.Close()
                End Using
            End Using

            ' Si no hay excepciones, el codigo se ejecuta normalmente.

        Catch ex As Exception
            ' Maneja excepciones externas
            MessageBox.Show("Excepción customizada: " & ex.Message)
        End Try
    End Sub

End Class