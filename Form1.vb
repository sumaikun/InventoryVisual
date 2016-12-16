Imports System.Data.SqlClient
Public Class Form1
    Dim prop As New Propertys
    Dim funct As New Functions
    Dim Count As Integer
    Private Sub Form1_load(sender As Object, E As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = funct.show_item
        Show_data()
        Test_Console()
    End Sub

    Private Sub Show_data()
        DataGridView1.Visible = True
        DataGridView1.Columns(3).Visible = False
        Imagen.Image = My.Resources.SIN_FOTO
        Imagen.SizeMode = PictureBoxSizeMode.StretchImage
        Codigo_lab.Visible = False
        Nombre_lab.Visible = False
        cantidad_lab.Visible = False

        Code_txbox.Visible = False
        Code_txbox.Enabled = True
        Name_txbox.Visible = False
        Storaged_txbox.Visible = False

        Guardar_btn.Visible = False
        QuitarImg_btn.Visible = True
        Cancelar_btn.Visible = False
        Eliminar_btn.Visible = True
        Modificar_btn.Visible = True
        Nuevo_btn.Visible = True
        AñadirImg_btn.Visible = True

    End Sub

    Private Sub Test_Console()
        Count = DataGridView1.Rows.Count
        Console.WriteLine("Numero de filas " & Count.ToString)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Code_txbox.Text = DataGridView1.SelectedCells.Item(0).Value
        Name_txbox.Text = DataGridView1.SelectedCells.Item(1).Value
        Storaged_txbox.Text = DataGridView1.SelectedCells.Item(2).Value

        Imagen.BackgroundImage = Nothing
        Dim i() As Byte = DataGridView1.SelectedCells.Item(3).Value
        Dim ms As New IO.MemoryStream(i)
        Imagen.Image = Image.FromStream(ms)
        Imagen.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    'cellpaintint me maneja los controles de las flechas del teclado'
    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If DataGridView1.Rows.Count <= 1 Then
            Code_txbox.Text = ""
            Name_txbox.Text = ""
            Storaged_txbox.Text = ""
            Exit Sub
        Else
            Code_txbox.Text = DataGridView1.SelectedCells.Item(0).Value
            Name_txbox.Text = DataGridView1.SelectedCells.Item(1).Value
            Storaged_txbox.Text = DataGridView1.SelectedCells.Item(2).Value

            Imagen.BackgroundImage = Nothing
            Dim i() As Byte = DataGridView1.SelectedCells.Item(3).Value
            Dim ms As New IO.MemoryStream(i)
            Imagen.Image = Image.FromStream(ms)
            Imagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Nuevo_btn_Click(sender As Object, e As EventArgs) Handles Nuevo_btn.Click
        DataGridView1.Visible = False
        Imagen.Image = My.Resources.SIN_FOTO
        Imagen.SizeMode = PictureBoxSizeMode.StretchImage

        Codigo_lab.Visible = True
        Nombre_lab.Visible = True
        cantidad_lab.Visible = True

        Code_txbox.Visible = True
        Code_txbox.Enabled = True
        Name_txbox.Visible = True
        Storaged_txbox.Visible = True

        Guardar_btn.Visible = True
        Cancelar_btn.Visible = True
        Eliminar_btn.Visible = False
        Modificar_btn.Visible = False
        Nuevo_btn.Visible = False
    End Sub
End Class