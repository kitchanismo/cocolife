Module MovePanel

    Public pos As Point

    Function GetLocation(ByVal e As Control) As Point
        Dim i As Point
        i.X = Cursor.Position.X - e.Location.X
        i.Y = Cursor.Position.Y - e.Location.Y
        Return i
    End Function

    Function SetLocation(ByVal i As Point, ByVal e As System.Drawing.Point) As Point
        Dim p As New Point
        p = e
        p.X = p.X - i.X
        p.Y = p.Y - i.Y
        Return p
    End Function

End Module
