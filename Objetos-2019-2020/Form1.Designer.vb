<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pnlPatos = New System.Windows.Forms.Panel()
        Me.nud = New System.Windows.Forms.NumericUpDown()
        Me.btnMatar = New System.Windows.Forms.Button()
        CType(Me.nud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(76, 46)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 0
        Me.btnCrear.Text = "Crear Objeto"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(671, 46)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pnlPatos
        '
        Me.pnlPatos.Location = New System.Drawing.Point(76, 119)
        Me.pnlPatos.Name = "pnlPatos"
        Me.pnlPatos.Size = New System.Drawing.Size(670, 280)
        Me.pnlPatos.TabIndex = 1
        '
        'nud
        '
        Me.nud.Location = New System.Drawing.Point(346, 405)
        Me.nud.Name = "nud"
        Me.nud.Size = New System.Drawing.Size(100, 20)
        Me.nud.TabIndex = 2
        '
        'btnMatar
        '
        Me.btnMatar.Location = New System.Drawing.Point(244, 402)
        Me.btnMatar.Name = "btnMatar"
        Me.btnMatar.Size = New System.Drawing.Size(96, 23)
        Me.btnMatar.TabIndex = 3
        Me.btnMatar.Text = "Matar al pajaro"
        Me.btnMatar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMatar)
        Me.Controls.Add(Me.nud)
        Me.Controls.Add(Me.pnlPatos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCrear)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCrear As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents pnlPatos As Panel
    Friend WithEvents nud As NumericUpDown
    Friend WithEvents btnMatar As Button
End Class
