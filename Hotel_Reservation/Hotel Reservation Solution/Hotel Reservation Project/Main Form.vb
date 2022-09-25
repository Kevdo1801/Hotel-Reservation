'Hotel Reservation Project
'Kevin Do and Tyler Wheeler
'September 25, 2022

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Add our Constants in
        Const dblDBLMember As Double = 140
        Const dblDBLRegular As Double = 145
        Const dblKingMember As Double = 150
        Const dblKingRegular As Double = 160
        Const dblQueenMember As Double = 170
        Const dblQueenRegular As Double = 180
        Const intMaxOccupancy As Integer = 5
        Const dblFee As Double = 12.5
        Const dblPromo As Double = 0.15
        Const dblTaxRate As Double = 0.1425
        Const dblAAA As Double = 0.06
        Const dblCorporate As Double = 0.08
        Const dblGov As Double = 0.1

        'Add our Variables in
        Dim dblRoomsAsRequired As Double
        Dim intQueenNights, intKingNights, intKingRooms, intQueenRooms, intDoubleNight, intDoubleRoom, intChildren, intAdults, intTotalRooms, intTotalGuests, intTotalNights As Integer

        'TryParse our variables to numbers 
        Integer.TryParse(txtKingNights.Text, intKingNights)
        Integer.TryParse(txtQueenNights.Text, intQueenNights)
        Integer.TryParse(txtKingRooms.Text, intKingRooms)
        Integer.TryParse(txtQueenRooms.Text, intQueenRooms)
        Integer.TryParse(txtDblRooms.Text, intDoubleRoom)
        Integer.TryParse(txtDblNights.Text, intDoubleNight)
        Integer.TryParse(lstChildren.SelectedItem.ToString, intChildren)
        Integer.TryParse(lstAdults.SelectedItem.ToString, intAdults)
    End Sub
End Class
