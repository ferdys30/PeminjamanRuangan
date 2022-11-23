Public Class Main

    Private Sub MenuBar_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuBar.MouseClick
        MenuList.Visible = True
        MenuBar.Visible = False
    End Sub

    Private Sub CloseBar_MouseClick(sender As Object, e As MouseEventArgs) Handles CloseBar.MouseClick
        MenuList.Visible = False
        MenuBar.Visible = True
    End Sub

    Private Sub Menu1_MouseClick(sender As Object, e As MouseEventArgs) Handles Menu1.MouseClick
        highligh1.Visible = True
        highligh2.Visible = False
        highligh3.Visible = False
        highligh4.Visible = False
        highligh5.Visible = False
        layer1.Visible = True
        layer2.Visible = False
        Layer3.Visible = False
        Layer4.Visible = False
        Layer5.Visible = False
    End Sub

    Private Sub Menu2_MouseClick(sender As Object, e As MouseEventArgs) Handles Menu2.MouseClick
        highligh1.Visible = False
        highligh2.Visible = True
        highligh3.Visible = False
        highligh4.Visible = False
        highligh5.Visible = False
        layer1.Visible = False
        layer2.Visible = True
        Layer3.Visible = False
        Layer4.Visible = False
        Layer5.Visible = False
    End Sub

    Private Sub Menu3_MouseClick(sender As Object, e As MouseEventArgs) Handles Menu3.MouseClick
        highligh1.Visible = False
        highligh2.Visible = False
        highligh3.Visible = True
        highligh4.Visible = False
        highligh5.Visible = False
        layer1.Visible = False
        layer2.Visible = False
        Layer3.Visible = True
        Layer4.Visible = False
        Layer5.Visible = False
    End Sub

    Private Sub Menu4_MouseClick(sender As Object, e As MouseEventArgs) Handles Menu4.MouseClick
        highligh1.Visible = False
        highligh2.Visible = False
        highligh3.Visible = False
        highligh4.Visible = True
        highligh5.Visible = False
        layer1.Visible = False
        layer2.Visible = False
        Layer3.Visible = False
        Layer4.Visible = True
        Layer5.Visible = False
    End Sub

    Private Sub Menu5_MouseClick(sender As Object, e As MouseEventArgs) Handles Menu5.MouseClick
        highligh1.Visible = False
        highligh2.Visible = False
        highligh3.Visible = False
        highligh4.Visible = False
        highligh5.Visible = True
        layer1.Visible = False
        layer2.Visible = False
        Layer3.Visible = False
        Layer4.Visible = False
        Layer5.Visible = True
    End Sub

End Class