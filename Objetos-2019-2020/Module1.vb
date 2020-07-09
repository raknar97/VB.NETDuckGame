Module Module1
    Dim MisPatos() As Patos

    Dim num_patos As Integer


    Sub crear_Patos(pnl As Panel)
        ReDim Preserve MisPatos(num_patos)
        MisPatos(num_patos) = New Patos(pnl, num_patos)

        num_patos += 1
    End Sub
    Sub matar_pajaros(i As Integer)
        MisPatos(i).matar_pajaro()
    End Sub

End Module
