Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data

Public Class WebForm1
    Inherits System.Web.UI.Page
    Public ds As DataSet
    Private Sub WebForm1_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            jai = New SqlConnection
            jai.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Datos_persona.mdf;Integrated Security=True"
            Dim sql As String = "select * from ciudad"
            Dim sen As New SqlDataAdapter(sql, jai)
            ds = New DataSet
            sen.Fill(ds, "Ciudad")

            TextBox1.Text = ds.Tables("Ciudad").Rows(0).Item("Id")
            TextBox2.Text = ds.Tables("Ciudad").Rows(0).Item("Nombre")
        Catch ex As Exception
            MsgBox("Error de conexión: " + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contciudad = 0
        TextBox1.Text = ds.Tables("Ciudad").Rows(contciudad).Item("Id")
        TextBox2.Text = ds.Tables("Ciudad").Rows(contciudad).Item("Nombre")
    End Sub
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contciudad = ds.Tables("Ciudad").Rows.Count
        contciudad = contciudad - 1
        TextBox1.Text = ds.Tables("Ciudad").Rows(contciudad).Item("Id")
        TextBox2.Text = ds.Tables("Ciudad").Rows(contciudad).Item("Nombre")
    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contciudad = contciudad - 1
        If contciudad < 0 Then
            contciudad = contciudad + 1
            TextBox1.Text = ds.Tables("Ciudad").Rows(contciudad).Item("Id")
            TextBox2.Text = ds.Tables("Ciudad").Rows(contciudad).Item("Nombre")
        Else
            TextBox1.Text = ds.Tables("Ciudad").Rows(contciudad).Item("Id")
            TextBox2.Text = ds.Tables("Ciudad").Rows(contciudad).Item("Nombre")
        End If
    End Sub
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contciudad = contciudad + 1
        If contciudad >= ds.Tables("Ciudad").Rows.Count Then
            contciudad = ds.Tables("Ciudad").Rows.Count
            contciudad = contciudad - 1
        End If
        TextBox1.Text = ds.Tables("Ciudad").Rows(contciudad).Item("Id")
        TextBox2.Text = ds.Tables("Ciudad").Rows(contciudad).Item("Nombre")
    End Sub
    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

        Button5.Enabled = False
        Button6.Enabled = True
        Button7.Enabled = False
        Button8.Enabled = False

        TextBox2.Focus()
    End Sub
    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call execute("insert into ciudad (Nombre) values ('" & TextBox2.Text & "')")
        Button5.Enabled = True
        Button6.Enabled = False
        Button7.Enabled = True
        Button8.Enabled = True

        contciudad = 0
        Response.Redirect("ciudad.aspx")
    End Sub
    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call execute("update ciudad set Nombre = '" & TextBox2.Text & "' where Id = " & TextBox1.Text & "")
        contciudad = 0
        Response.Redirect("ciudad.aspx")
    End Sub
    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Está seguro de eliminar la ciudad? Si la elimina desaparecerá del pais jajaja", MsgBoxStyle.YesNo, "¡Atención!") = MsgBoxResult.Yes Then
            Call execute("delete from ciudad where Id = " & TextBox1.Text & "")
            contciudad = 0
            Response.Redirect("ciudad.aspx")
        Else
            Exit Sub
        End If
    End Sub
    Private Sub WebForm1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None
    End Sub
End Class