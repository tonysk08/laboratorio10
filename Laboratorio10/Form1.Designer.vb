<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class laboratorio10
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
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.txtCuadrante = New System.Windows.Forms.TextBox()
        Me.txtLimiteDeVelocidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVelocicdaReal = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(26, 35)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(165, 20)
        Me.txtPlaca.TabIndex = 0
        '
        'txtCuadrante
        '
        Me.txtCuadrante.Location = New System.Drawing.Point(281, 35)
        Me.txtCuadrante.Name = "txtCuadrante"
        Me.txtCuadrante.Size = New System.Drawing.Size(131, 20)
        Me.txtCuadrante.TabIndex = 1
        '
        'txtLimiteDeVelocidad
        '
        Me.txtLimiteDeVelocidad.Location = New System.Drawing.Point(26, 86)
        Me.txtLimiteDeVelocidad.Name = "txtLimiteDeVelocidad"
        Me.txtLimiteDeVelocidad.Size = New System.Drawing.Size(165, 20)
        Me.txtLimiteDeVelocidad.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Numero de placa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cuadrante de la infraccion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Limite de Velocidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Velocidad Real"
        '
        'txtVelocicdaReal
        '
        Me.txtVelocicdaReal.Location = New System.Drawing.Point(26, 141)
        Me.txtVelocicdaReal.Name = "txtVelocicdaReal"
        Me.txtVelocicdaReal.Size = New System.Drawing.Size(165, 20)
        Me.txtVelocicdaReal.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(128, 226)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(111, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Agregar multa"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(245, 226)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(111, 23)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 52)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "1:Ave.Frangipani " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2:  Ave.Manuel Espinosa Batista " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3: Vía Argentina " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4. Ave. C" &
    "entenario"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(278, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Ingrese solo el numero de la avenida"
        '
        'laboratorio10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 289)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtVelocicdaReal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLimiteDeVelocidad)
        Me.Controls.Add(Me.txtCuadrante)
        Me.Controls.Add(Me.txtPlaca)
        Me.Name = "laboratorio10"
        Me.Text = "Laboratorio 10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents txtCuadrante As TextBox
    Friend WithEvents txtLimiteDeVelocidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVelocicdaReal As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
