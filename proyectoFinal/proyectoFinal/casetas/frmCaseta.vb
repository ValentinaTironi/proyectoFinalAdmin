﻿Public Class frmCaseta

    Private Sub btnAlimentar_Click(sender As Object, e As EventArgs) Handles btnSuspender.Click
        MsgBox("¿Está seguro que desea susender el servicio?", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        openForm(frmCasetas)
    End Sub

    Private Sub btnAlimentar_Click_1(sender As Object, e As EventArgs) Handles btnAlimentar.Click
        MsgBox("Se activó el sistema de aliemtación con éxito", MsgBoxStyle.Information)
    End Sub

    Private Sub btnServirAgua_Click(sender As Object, e As EventArgs) Handles btnServirAgua.Click
        MsgBox("Se activó el sistema de hidratación con éxito", MsgBoxStyle.Information)
    End Sub

    Private Sub btnDesinfectar_Click(sender As Object, e As EventArgs) Handles btnDesinfectar.Click
        MsgBox("Se activó el sistema de desinfección con éxito", MsgBoxStyle.Information)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        MsgBox("Antes de eliminar la caseta, es necesario asignarle una al cliente")
        frmEditarAsociacionCliente.lblid_cliente.Text = lblid_cliente.Text
        frmEditarAsociacionCliente.lblid_perro.Text = lblid_perro.Text
        frmEditarAsociacionCliente.lblcaseta_vieja.Text = lblid.Text

        frmEditarAsociacionCliente.ShowDialog()
    End Sub
End Class