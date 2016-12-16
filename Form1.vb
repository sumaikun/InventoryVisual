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
        DataGridView1.Columns(4).Visible = False
        Imagen.Image = My.Resources.SIN_FOTO
        Imagen.SizeMode = PictureBoxSizeMode.StretchImage
        Codigo_lab.Visible = False
        Nombre_lab.Visible = False
        cantidad_lab.Visible = False

        Code_txbox.Visible = False
        Code_txbox.Enabled = True
        Name_txbox.Visible = False
        Storaged_txbox.Visible = False
        id_txbox.Visible = False


        Guardar_btn.Visible = False
        QuitarImg_btn.Visible = True
        Cancelar_btn.Visible = False
        Eliminar_btn.Visible = True
        Modificar_btn.Visible = True
        Nuevo_btn.Visible = True
        AñadirImg_btn.Visible = True
        Cambiar_btn.Visible = False

        AñadirImg_btn.Enabled = False
        QuitarImg_btn.Enabled = False

        Code_txbox.Text = ""
        Name_txbox.Text = ""
        Storaged_txbox.Text = ""
    End Sub

    Private Sub Test_Console()
        Count = DataGridView1.Rows.Count
        Console.WriteLine("Numero de filas " & Count.ToString)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        id_txbox.Text = DataGridView1.SelectedCells.Item(0).Value
        Code_txbox.Text = DataGridView1.SelectedCells.Item(1).Value
        Name_txbox.Text = DataGridView1.SelectedCells.Item(2).Value
        Storaged_txbox.Text = DataGridView1.SelectedCells.Item(3).Value

        Imagen.BackgroundImage = Nothing
        If IsDBNull(DataGridView1.SelectedCells.Item(4).Value) Then
            Imagen.Image = My.Resources.SIN_FOTO
            Imagen.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            Dim i() As Byte = DataGridView1.SelectedCells.Item(4).Value
            Dim ms As New IO.MemoryStream(i)
            Imagen.Image = Image.FromStream(ms)
            Imagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If


    End Sub

    'cellpaintint me maneja los controles de las flechas del teclado'
    'Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
    'If DataGridView1.Rows.Count = 1 Then
    '       Code_txbox.Text = ""
    '      Name_txbox.Text = ""
    '     Storaged_txbox.Text = ""
    'Exit Sub
    'Else
    '       Code_txbox.Text = DataGridView1.SelectedCells.Item(0).Value
    '      Name_txbox.Text = DataGridView1.SelectedCells.Item(1).Value
    '     Storaged_txbox.Text = DataGridView1.SelectedCells.Item(2).Value
    '
    '       Imagen.BackgroundImage = Nothing
    'Dim i() As Byte = DataGridView1.SelectedCells.Item(3).Value
    'Dim ms As New IO.MemoryStream(i)
    '       Imagen.Image = Image.FromStream(ms)
    '      Imagen.SizeMode = PictureBoxSizeMode.StretchImage
    'End If
    'End Sub

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

        AñadirImg_btn.Enabled = True
        QuitarImg_btn.Enabled = True

        Code_txbox.Focus()
    End Sub

    Private Sub Cancelar_btn_Click(sender As Object, e As EventArgs) Handles Cancelar_btn.Click
        Show_data()
    End Sub

    Private Sub AñadirImg_btn_Click(sender As Object, e As EventArgs) Handles AñadirImg_btn.Click

        If FileDialog.ShowDialog() = DialogResult.OK Then
            Imagen.BackgroundImage = Nothing
            Imagen.Image = New Bitmap(FileDialog.FileName)
            Imagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Guardar_btn_Click(sender As Object, e As EventArgs) Handles Guardar_btn.Click
        If Me.ValidateChildren = True And Code_txbox.Text <> "" And Name_txbox.Text <> "" And Storaged_txbox.Text <> "" Then
            Try
                prop.code = Code_txbox.Text
                prop.name = Name_txbox.Text
                prop.storaged = Storaged_txbox.Text

                Dim ms As New IO.MemoryStream()

                If Imagen.Image Is Nothing Then
                    Imagen.Image = My.Resources.SIN_FOTO
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                Else
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                End If
                prop.pic = ms.GetBuffer

                If funct.add_item(prop) Then
                    MessageBox.Show("Producto Guardado correctamente", "Guardando Producto")
                    DataGridView1.DataSource = funct.show_item
                    Show_data()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Debe rellenar todos los campos", "Guardando Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Modificar_btn_Click(sender As Object, e As EventArgs) Handles Modificar_btn.Click
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("La tabla está vacía", "No se puede modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        DataGridView1.Visible = False

        Codigo_lab.Visible = True
        Nombre_lab.Visible = True
        cantidad_lab.Visible = True

        Code_txbox.Visible = True
        Code_txbox.Enabled = True
        Name_txbox.Visible = True
        Storaged_txbox.Visible = True

        Guardar_btn.Visible = False
        Cancelar_btn.Visible = True
        Eliminar_btn.Visible = False
        Modificar_btn.Visible = False
        Nuevo_btn.Visible = False
        Cambiar_btn.Visible = True

        AñadirImg_btn.Enabled = True
        QuitarImg_btn.Enabled = True

        Code_txbox.Focus()
    End Sub

    Private Sub Cambiar_Click(sender As Object, e As EventArgs) Handles Cambiar_btn.Click
        If Me.ValidateChildren = True And Code_txbox.Text <> "" And Name_txbox.Text <> "" And Storaged_txbox.Text <> "" Then
            Try
                prop.code = Code_txbox.Text
                prop.name = Name_txbox.Text
                prop.storaged = Storaged_txbox.Text

                Dim ms As New IO.MemoryStream()

                If Imagen.Image Is Nothing Then
                    Imagen.Image = My.Resources.SIN_FOTO
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                Else
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                End If
                prop.pic = ms.GetBuffer


                If funct.edit_item(prop) Then
                    MessageBox.Show("Producto Editado correctamente", "Guardando Item")
                    DataGridView1.DataSource = funct.show_item
                    Show_data()
                Else
                    MessageBox.Show("Error editando Items", "Guardando Item")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Debe rellenar todos los campos", "Guardando Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Eliminar_btn_Click(sender As Object, e As EventArgs) Handles Eliminar_btn.Click
        Dim result As DialogResult

        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("La tabla está vacía", "Eliminando Item", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        result = MessageBox.Show("¿Seguro que desea eliminar este producto?", "Eliminando Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If Me.ValidateChildren = True And Code_txbox.Text <> "" Then

                Try
                    prop.code = Code_txbox.Text

                    If funct.delete_item(prop) Then
                        MessageBox.Show("Item eliminadoo correctamente", "Eliminando Item")
                        DataGridView1.DataSource = funct.show_item
                        Show_data()
                        If DataGridView1.Rows.Count = 0 Then
                            Code_txbox.Text = ""
                            Name_txbox.Text = ""
                            Storaged_txbox.Text = ""
                            Imagen.Image = My.Resources.SIN_FOTO
                        End If
                    Else
                        MessageBox.Show("Item no encontrado", "Eliminando Item", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

End Class