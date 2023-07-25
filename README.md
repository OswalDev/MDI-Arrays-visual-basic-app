# MDI-Arrays-visual-basic-app
Student CRUD System using dataTypes

# Archivo de la base de datos
Dentro de la carpeta del projecto se encuentra un archivo .BACPAC llamado "serverBackup" que contiene la base de datos SQL

# Nombre de la base de datos
MDIArray

# Modificar SQL string de conección
Para modificar el String de la Base de datos ubicar el archivo llamado GlobalVariables.vb que maneja la variable de conección y modificarla con su cadena de conección

# Tablas SQL
Existen dos tablas sql creadas para este proyecto "dbo.students_table" que se encarga de almacenar los estudiantes y "dob.users_table" que se encarga de almancenar las sesiones de superusuarios que tienen acceso al sistema

# Funcionalidades del programa
La aplicación se encuentra contenida en un componente MDI haciendo uso de tabs para manejar diferentes ventanas en un mismo componente

[-] LoginForm : Iniciar sesión con las credenciales de superusuario
Dentro de MainForm.vb se encuentras las siguientes funciones en forma de sub-pestañas:

[-] Inscripción : Registrar a un nuevo alumno(evalua si ya el alumno fue registrado por número de cédula)
[-] Registro de notas : Registrar notas de un alumno ya existente en la base de datos(evalua si el alumno está registrado por número de cédula)
[-] Retiro : Remover alumno de la base de datos(evalua si el alumno existe en la base de datos)
[-] Alumnos con promedio mayor a 12: Generar una lista de alumnos con promedio mayor a 12pts
[-] Eliminar: Eliminar a alumnos cuyo primer digito de cédula sea 2

# Credenciales por defecto
[-] usuario: admin
[-] contraseña: admin

# ¿Cómo iniciar la aplicación?
[1] Descarga el projecto
[2] Abrir con Visual Studio o cualquier otro editor de texto
[3] Cambiar el string de conneción a base de datos para correrlo en local
[4] Correr el projecto configurandolo para correr "WinFormsAppMID"
