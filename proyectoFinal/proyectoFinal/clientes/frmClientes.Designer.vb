﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.lvwClientes = New System.Windows.Forms.ListView()
        Me.columnId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnNombreCompleto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnNombreUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnCedula = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvwClientes
        '
        Me.lvwClientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnId, Me.columnNombreCompleto, Me.columnEmail, Me.columnNombreUsuario, Me.ColumnCedula})
        Me.lvwClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwClientes.FullRowSelect = True
        Me.lvwClientes.Location = New System.Drawing.Point(12, 84)
        Me.lvwClientes.Name = "lvwClientes"
        Me.lvwClientes.Size = New System.Drawing.Size(747, 199)
        Me.lvwClientes.TabIndex = 10
        Me.lvwClientes.UseCompatibleStateImageBehavior = False
        Me.lvwClientes.View = System.Windows.Forms.View.Details
        '
        'columnId
        '
        Me.columnId.Text = "ID"
        Me.columnId.Width = 39
        '
        'columnNombreCompleto
        '
        Me.columnNombreCompleto.Text = "Nombre Completo"
        Me.columnNombreCompleto.Width = 231
        '
        'columnEmail
        '
        Me.columnEmail.Text = "Email"
        Me.columnEmail.Width = 205
        '
        'columnNombreUsuario
        '
        Me.columnNombreUsuario.Text = "Nombre de Usuario"
        Me.columnNombreUsuario.Width = 149
        '
        'ColumnCedula
        '
        Me.ColumnCedula.Text = "Cédula"
        Me.ColumnCedula.Width = 116
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Todos los Clientes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(709, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(50, 41)
        Me.btnAgregar.TabIndex = 42
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(771, 306)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvwClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClientes"
        Me.Tag = ""
        Me.Text = "Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvwClientes As ListView
    Friend WithEvents columnId As ColumnHeader
    Friend WithEvents columnNombreCompleto As ColumnHeader
    Friend WithEvents columnEmail As ColumnHeader
    Friend WithEvents columnNombreUsuario As ColumnHeader
    Friend WithEvents ColumnCedula As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAgregar As Button
End Class
