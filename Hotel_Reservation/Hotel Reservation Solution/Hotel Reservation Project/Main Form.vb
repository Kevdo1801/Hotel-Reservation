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
        intTotalNights = intKingNights + intQueenNights + intDoubleNight
        intTotalGuests = intChildren + intAdults
        intTotalRooms = intKingRooms + intQueenRooms + intDoubleRoom

        'Add message box error
        dblRoomsAsRequired = intTotalGuests / intMaxOccupancy
        If intTotalRooms < dblRoomsAsRequired Then
            MessageBox.Show("Sorry, you have reached the maximum allowed guests per room.", "Allowed capacity per room is 5 guests, please reserve additional rooms as needed.", MessageBoxIcon.Information)
        Else
            Dim dblTotalCharge As Double
            Dim dblTaxAmt As Double
            Dim dblFeeAmt As Double
            Dim dblKingCharge As Double
            Dim dblQueenCharge As Double
            Dim dblDoubleCharge As Double
            Dim dblSubRoomCharge As Double

            'Start adding our code for our check boxes

            If chkKingBed.Checked Then
                If radKingMemberR.Checked Then
                    dblKingCharge = intKingRooms * intKingNights * dblKingMember
                Else
                    dblKingCharge = intKingNights * intKingRooms * dblKingRegular
                End If
            End If

            If chkQueenBed.Checked Then
                If radQueenMemberR.Checked Then
                    dblQueenCharge = intQueenNights * intQueenRooms * dblQueenMember
                Else
                    dblQueenCharge = intQueenNights * intQueenRooms * dblQueenRegular
                End If
            End If

            If chkDblBed.Checked Then
                If radDblMemberR.Checked Then
                    dblDoubleCharge = intDoubleNight * intDoubleRoom * dblDBLMember
                Else
                    dblDoubleCharge = intDoubleRoom * intDoubleNight * dblDBLRegular
                End If
            End If

            'Now add all the discounts for sub charge/rooms


        End If

    End Sub
End Class
