<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Imagen = New System.Windows.Forms.PictureBox()
        Me.Code_txbox = New System.Windows.Forms.TextBox()
        Me.Name_txbox = New System.Windows.Forms.TextBox()
        Me.Storaged_txbox = New System.Windows.Forms.TextBox()
        Me.Guardar_btn = New System.Windows.Forms.Button()
        Me.AñadirImg_btn = New System.Windows.Forms.Button()
        Me.QuitarImg_btn = New System.Windows.Forms.Button()
        Me.Cancelar_btn = New System.Windows.Forms.Button()
        Me.Eliminar_btn = New System.Windows.Forms.Button()
        Me.Nuevo_btn = New System.Windows.Forms.Button()
        Me.Modificar_btn = New System.Windows.Forms.Button()
        Me.Codigo_lab = New System.Windows.Forms.Label()
        Me.Nombre_lab = New System.Windows.Forms.Label()
        Me.cantidad_lab = New System.Windows.Forms.Label()
        Me.FileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Cambiar_btn = New System.Windows.Forms.Button()
        Me.id_txbox = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(329, 149)
        Me.DataGridView1.TabIndex = 0
        '
        'Imagen
        '
        Me.Imagen.Image = Global.WindowsApplication1.My.Resources.Resources.SIN_FOTO
        Me.Imagen.Location = New System.Drawing.Point(382, 21)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(131, 149)
        Me.Imagen.TabIndex = 1
        Me.Imagen.TabStop = False
        '
        'Code_txbox
        '
        Me.Code_txbox.Location = New System.Drawing.Point(21, 53)
        Me.Code_txbox.Name = "Code_txbox"
        Me.Code_txbox.Size = New System.Drawing.Size(223, 20)
        Me.Code_txbox.TabIndex = 2
        '
        'Name_txbox
        '
        Me.Name_txbox.Location = New System.Drawing.Point(21, 94)
        Me.Name_txbox.Name = "Name_txbox"
        Me.Name_txbox.Size = New System.Drawing.Size(223, 20)
        Me.Name_txbox.TabIndex = 3
        '
        'Storaged_txbox
        '
        Me.Storaged_txbox.Location = New System.Drawing.Point(21, 135)
        Me.Storaged_txbox.Name = "Storaged_txbox"
        Me.Storaged_txbox.Size = New System.Drawing.Size(147, 20)
        Me.Storaged_txbox.TabIndex = 4
        '
        'Guardar_btn
        '
        Me.Guardar_btn.Location = New System.Drawing.Point(12, 194)
        Me.Guardar_btn.Name = "Guardar_btn"
        Me.Guardar_btn.Size = New System.Drawing.Size(75, 23)
        Me.Guardar_btn.TabIndex = 5
        Me.Guardar_btn.Text = "Guardar"
        Me.Guardar_btn.UseVisualStyleBackColor = True
        '
        'AñadirImg_btn
        '
        Me.AñadirImg_btn.Location = New System.Drawing.Point(382, 194)
        Me.AñadirImg_btn.Name = "AñadirImg_btn"
        Me.AñadirImg_btn.Size = New System.Drawing.Size(66, 23)
        Me.AñadirImg_btn.TabIndex = 6
        Me.AñadirImg_btn.Text = "Añadir"
        Me.AñadirImg_btn.UseVisualStyleBackColor = True
        '
        'QuitarImg_btn
        '
        Me.QuitarImg_btn.Location = New System.Drawing.Point(454, 194)
        Me.QuitarImg_btn.Name = "QuitarImg_btn"
        Me.QuitarImg_btn.Size = New System.Drawing.Size(59, 23)
        Me.QuitarImg_btn.TabIndex = 7
        Me.QuitarImg_btn.Text = "Quitar"
        Me.QuitarImg_btn.UseVisualStyleBackColor = True
        '
        'Cancelar_btn
        '
        Me.Cancelar_btn.Location = New System.Drawing.Point(102, 194)
        Me.Cancelar_btn.Name = "Cancelar_btn"
        Me.Cancelar_btn.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar_btn.TabIndex = 8
        Me.Cancelar_btn.Text = "Cancelar"
        Me.Cancelar_btn.UseVisualStyleBackColor = True
        '
        'Eliminar_btn
        '
        Me.Eliminar_btn.Location = New System.Drawing.Point(183, 194)
        Me.Eliminar_btn.Name = "Eliminar_btn"
        Me.Eliminar_btn.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar_btn.TabIndex = 9
        Me.Eliminar_btn.Text = "Eliminar"
        Me.Eliminar_btn.UseVisualStyleBackColor = True
        '
        'Nuevo_btn
        '
        Me.Nuevo_btn.Location = New System.Drawing.Point(12, 194)
        Me.Nuevo_btn.Name = "Nuevo_btn"
        Me.Nuevo_btn.Size = New System.Drawing.Size(75, 23)
        Me.Nuevo_btn.TabIndex = 10
        Me.Nuevo_btn.Text = "Nuevo"
        Me.Nuevo_btn.UseVisualStyleBackColor = True
        '
        'Modificar_btn
        '
        Me.Modificar_btn.Location = New System.Drawing.Point(102, 194)
        Me.Modificar_btn.Name = "Modificar_btn"
        Me.Modificar_btn.Size = New System.Drawing.Size(75, 23)
        Me.Modificar_btn.TabIndex = 11
        Me.Modificar_btn.Text = "Modificar"
        Me.Modificar_btn.UseVisualStyleBackColor = True
        '
        'Codigo_lab
        '
        Me.Codigo_lab.AutoSize = True
        Me.Codigo_lab.Location = New System.Drawing.Point(18, 37)
        Me.Codigo_lab.Name = "Codigo_lab"
        Me.Codigo_lab.Size = New System.Drawing.Size(40, 13)
        Me.Codigo_lab.TabIndex = 12
        Me.Codigo_lab.Text = "Codigo"
        '
        'Nombre_lab
        '
        Me.Nombre_lab.AutoSize = True
        Me.Nombre_lab.Location = New System.Drawing.Point(18, 78)
        Me.Nombre_lab.Name = "Nombre_lab"
        Me.Nombre_lab.Size = New System.Drawing.Size(44, 13)
        Me.Nombre_lab.TabIndex = 13
        Me.Nombre_lab.Text = "Nombre"
        '
        'cantidad_lab
        '
        Me.cantidad_lab.AutoSize = True
        Me.cantidad_lab.Location = New System.Drawing.Point(18, 117)
        Me.cantidad_lab.Name = "cantidad_lab"
        Me.cantidad_lab.Size = New System.Drawing.Size(49, 13)
        Me.cantidad_lab.TabIndex = 14
        Me.cantidad_lab.Text = "Cantidad"
        '
        'FileDialog
        '
        Me.FileDialog.FileName = "OpenFileDialog1"
        '
        'Cambiar_btn
        '
        Me.Cambiar_btn.Location = New System.Drawing.Point(12, 194)
        Me.Cambiar_btn.Name = "Cambiar_btn"
        Me.Cambiar_btn.Size = New System.Drawing.Size(75, 23)
        Me.Cambiar_btn.TabIndex = 15
        Me.Cambiar_btn.Text = "Cambiar"
        Me.Cambiar_btn.UseVisualStyleBackColor = True
        '
        'id_txbox
        '
        Me.id_txbox.Location = New System.Drawing.Point(272, 62)
        Me.id_txbox.Name = "id_txbox"
        Me.id_txbox.Size = New System.Drawing.Size(26, 20)
        Me.id_txbox.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 229)
        Me.Controls.Add(Me.id_txbox)
        Me.Controls.Add(Me.Cambiar_btn)
        Me.Controls.Add(Me.cantidad_lab)
        Me.Controls.Add(Me.Nombre_lab)
        Me.Controls.Add(Me.Codigo_lab)
        Me.Controls.Add(Me.Modificar_btn)
        Me.Controls.Add(Me.Nuevo_btn)
        Me.Controls.Add(Me.Eliminar_btn)
        Me.Controls.Add(Me.Cancelar_btn)
        Me.Controls.Add(Me.QuitarImg_btn)
        Me.Controls.Add(Me.AñadirImg_btn)
        Me.Controls.Add(Me.Guardar_btn)
        Me.Controls.Add(Me.Storaged_txbox)
        Me.Controls.Add(Me.Name_txbox)
        Me.Controls.Add(Me.Code_txbox)
        Me.Controls.Add(Me.Imagen)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Imagen As PictureBox
    Friend WithEvents Code_txbox As TextBox
    Friend WithEvents Name_txbox As TextBox
    Friend WithEvents Storaged_txbox As TextBox
    Friend WithEvents Guardar_btn As Button
    Friend WithEvents AñadirImg_btn As Button
    Friend WithEvents QuitarImg_btn As Button
    Friend WithEvents Cancelar_btn As Button
    Friend WithEvents Eliminar_btn As Button
    Friend WithEvents Nuevo_btn As Button
    Friend WithEvents Modificar_btn As Button
    Friend WithEvents Codigo_lab As Label
    Friend WithEvents Nombre_lab As Label
    Friend WithEvents cantidad_lab As Label
    Friend WithEvents FileDialog As OpenFileDialog
    Friend WithEvents Cambiar_btn As Button
    Friend WithEvents id_txbox As TextBox
End Class
