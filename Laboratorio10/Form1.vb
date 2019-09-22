Public Class laboratorio10

    'Desarrollado por Antonios Sarmiento
    'Desarrollado por Alexis Calderon
    Dim c1, c2, c3, c4 As Int16
    Dim montoTotal As Single = 0
    Const multabase As Single = 50.0

    Private Sub Laboratorio10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c1 = 0
        c2 = 0
        c3 = 0
        c4 = 0
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim multa As Single = 0
        Dim diferenciaDeMulta As Single
        Try
            If (IsNumeric(txtLimiteDeVelocidad.Text) And IsNumeric(txtVelocicdaReal.Text)) Then
                If (Val(txtLimiteDeVelocidad.Text) < Val(txtVelocicdaReal.Text)) Then

                    diferenciaDeMulta = (Val(txtVelocicdaReal.Text) - Val(txtLimiteDeVelocidad.Text)) * 2.5
                    multa = multabase + diferenciaDeMulta

                    If (Val(txtCuadrante.Text) <> 1 And Val(txtCuadrante.Text) <> 2 And Val(txtCuadrante.Text) <> 3 And Val(txtCuadrante.Text) <> 4) Then
                        MsgBox("Ingrese el numero de la avenida y asegure que sea 1,2,3 o 4")
                    Else
                        Select Case Val(txtCuadrante.Text)
                            Case 1
                                F_Resultados.txtCuadranteShow.Text = F_Resultados.txtCuadranteShow.Text + "Ave.Frangipani" + vbCrLf
                                c1 += 1
                            Case 2
                                F_Resultados.txtCuadranteShow.Text = F_Resultados.txtCuadranteShow.Text + "Ave.Manuel Espinosa Batista" + vbCrLf
                                c2 += 1
                            Case 3
                                F_Resultados.txtCuadranteShow.Text = F_Resultados.txtCuadranteShow.Text + "Vía Argentina" + vbCrLf
                                c3 += 1
                            Case 4
                                F_Resultados.txtCuadranteShow.Text = F_Resultados.txtCuadranteShow.Text + "Ave. Centenario" + vbCrLf
                                c4 += 1
                        End Select

                        montoTotal += multa
                        F_Resultados.txtNplacashow.Text = F_Resultados.txtNplacashow.Text + txtPlaca.Text + vbCrLf
                        F_Resultados.txtLimiteShow.Text = F_Resultados.txtLimiteShow.Text + txtLimiteDeVelocidad.Text + vbCrLf
                        F_Resultados.txtVelocidadShow.Text = F_Resultados.txtVelocidadShow.Text + txtVelocicdaReal.Text + vbCrLf
                        F_Resultados.txtMultasShow.Text = F_Resultados.txtMultasShow.Text & multa & vbCrLf
                        F_Resultados.txtTotal.Text = montoTotal

                    End If
                Else
                    MsgBox("No hay una infraccion de velocidad")
                End If
            Else
                MsgBox("Revise los campos y corrija, ingrese solo numeros en las velocidaddes")
            End If
        Catch ex As Exception
            MsgBox("Revise los campos y corrija, ingrese solo numeros en las velocidaddes")
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        F_Resultados.Show()

        F_Resultados.lblTotalc1.Text = F_Resultados.lblTotalc1.Text & c1
        F_Resultados.lblTotalc2.Text = F_Resultados.lblTotalc2.Text & c2
        F_Resultados.lblTotalc3.Text = F_Resultados.lblTotalc3.Text & c3
        F_Resultados.lblTotalc4.Text = F_Resultados.lblTotalc4.Text & c4
    End Sub
End Class
