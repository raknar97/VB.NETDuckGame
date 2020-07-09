Public Class Patos

    ''atributos

    Dim WithEvents pct As PictureBox
    Dim WithEvents MiTimer As New Timer

    Dim x, y, tam, indice As Integer


    ''funciones




    ''constructor
    Sub New(pnl As Panel, i As Integer)

        Dim aleatorio As New Random


        'indice del array de objeto
        indice = i

        tam = pnl.Width

        x = tam - 76
        y = aleatorio.Next(0, pnl.Height - 70)
        pct = New PictureBox
        pct.Size = New System.Drawing.Size(72, 76)
        pct.Location = New System.Drawing.Point(x, y)
        pct.Image = Image.FromFile(Application.StartupPath & "\pato.gif")
        pct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage

        pnl.Controls.Add(pct)
        AddHandler pct.Click, AddressOf parar_pato

        MiTimer.Interval = 150
        MiTimer.Start()


    End Sub


    Sub mover_Pato() Handles MiTimer.Tick
        x = pct.Location.X
        y = pct.Location.Y
        If x < 0 Then x = tam

        ''
        pct.Location = New Point(x - 10, y)
    End Sub
    Sub matar_pajaro()
        Me.finalize()
    End Sub
    Protected Overrides Sub finalize()
        ''eliminar todos los parametros influibles en el objeto
        MiTimer.Stop()
        pct.Dispose()
    End Sub
    Sub parar_pato() Handles pct.Click
        MiTimer.Stop()
        Form1.nud.Value = indice
    End Sub


End Class
