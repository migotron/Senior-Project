Public Class UserInputModule
    Public Shared User As New Person

    Private isSaved As Boolean = False

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If fName.Text.Length <> 0 And lName.Text.Length <> 0 Then
            User.setUserInfo(CType(fName.Text, String), CType(lName.Text, String), CType(age.Text, Double), CType(gender.Text, Double), CType(dsi.Text, Double))
            fName.ReadOnly = True
            lName.ReadOnly = True
            age.ReadOnly = True
            gender.ReadOnly = True
            dsi.ReadOnly = True
            Label17.Visible = True
            street.Visible = True
            Label11.Visible = True
            city.Visible = True
            Label10.Visible = True
            state.Visible = True
            Label9.Visible = True
            zipcode.Visible = True
        Else
            MessageBox.Show("Please fill out your name correctly!")
        End If

        If (IsNumeric(zipcode.Text) And zipcode.Text.Length = 5) Then
            User.setUserAddress(CType(street.Text, String), CType(city.Text, String), CType(state.Text, String), CType(zipcode.Text, Double))
            street.ReadOnly = True
            city.ReadOnly = True
            state.ReadOnly = True
            zipcode.ReadOnly = True

            If Not waist.Visible Then
                Dim oform As MeasurementHelp
                oform = New MeasurementHelp()
                oform.Show()
            End If

            Label8.Visible = True
            heightfeet.Visible = True
            Label18.Visible = True
            heightinches.Visible = True
            Label13.Visible = True

            Label7.Visible = True
            weight.Visible = True
            Label6.Visible = True
            chest.Visible = True
            Label5.Visible = True
            waist.Visible = True
            If (gender.Value = 0) Then
                Label16.Visible = True
                hips.Visible = True
                Label15.Visible = True
                forearm.Visible = True
                Label14.Visible = True
                wrist.Visible = True


            Else
                hips.Text = 1
                forearm.Text = 1
                wrist.Text = 1

            End If
        Else
            If zipcode.TextLength <> 0 And Not IsNumeric(zipcode.Text) Then
                MessageBox.Show("Please enter a valid 5 digit numeric value for your zip code!")
            End If
        End If

        If (heightfeet.Value > 0) And (IsNumeric(wrist.Text) And wrist.Text.Length <> 0) And (IsNumeric(weight.Text) And weight.Text.Length <> 0) And (IsNumeric(waist.Text) And waist.Text.Length <> 0) And (IsNumeric(hips.Text) And hips.Text.Length <> 0) And (IsNumeric(forearm.Text) And forearm.Text.Length <> 0) And (IsNumeric(chest.Text) And chest.Text.Length <> 0) Then
            User.setUserBodyInfo(CType(heightfeet.Text, Double), CType(heightinches.Text, Double), CType(weight.Text, Double), CType(chest.Text, Double), CType(waist.Text, Double), CType(hips.Text, Double), CType(forearm.Text, Double), CType(wrist.Text, Double))
            heightfeet.ReadOnly = True
            heightinches.ReadOnly = True
            weight.ReadOnly = True
            chest.ReadOnly = True
            waist.ReadOnly = True
            hips.ReadOnly = True
            forearm.ReadOnly = True
            wrist.ReadOnly = True
        Else
            If Not Label17.Enabled And Not Label18.Enabled And Not heightfeet.Value <> 0 Then
                MessageBox.Show("Please enter valid numeric values for your body measurements!")
            End If
        End If

        If (heightfeet.Value > 0) And (IsNumeric(wrist.Text) And wrist.Text.Length <> 0) And (IsNumeric(weight.Text) And weight.Text.Length <> 0) And (IsNumeric(waist.Text) And waist.Text.Length <> 0) And (IsNumeric(hips.Text) And hips.Text.Length <> 0) And (IsNumeric(forearm.Text) And forearm.Text.Length <> 0) And (IsNumeric(chest.Text) And chest.Text.Length <> 0) And (IsNumeric(zipcode.Text) And zipcode.Text.Length = 5) And fName.Text.Length <> 0 And lName.Text.Length <> 0 Then
            isSaved = True
        End If
        If weight.Visible = True Then
            continuebutton.Visible = True
        End If

    End Sub

    Private Sub Continue_Click(sender As Object, e As EventArgs) Handles continuebutton.Click
        If isSaved Then
            Dim oForm As GoalSelectionModule
            oForm = New GoalSelectionModule()
            oForm.Show()
        Else
            MessageBox.Show("Please Save your information before proceeding!")
        End If
    End Sub

    Private Sub IsZipCodeNumeric(sender As Object, e As EventArgs) Handles zipcode.TextChanged
        If Not IsNumeric(zipcode.Text) Then
            MessageBox.Show("Please make sure to use only numeric values for your zip code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub IsBodyInputNumeric(sender As Object, e As EventArgs) Handles wrist.TextChanged, weight.TextChanged, waist.TextChanged, hips.TextChanged, forearm.TextChanged, chest.TextChanged
        If (Not IsNumeric(wrist.Text) And wrist.Text.Length <> 0) Or (Not IsNumeric(weight.Text) And weight.Text.Length <> 0) Or (Not IsNumeric(waist.Text) And waist.Text.Length <> 0) Or (Not IsNumeric(hips.Text) And hips.Text.Length <> 0) Or (Not IsNumeric(forearm.Text) And forearm.Text.Length <> 0) Or (Not IsNumeric(chest.Text) And chest.Text.Length <> 0) Then
            MessageBox.Show("Please make sure to use only numeric values for your measurements!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ALBox.SelectionChangeCommitted
        Dim i As Double = 1.0
        If ALBox.SelectedItem.Equals("Sedentary Active") Then
            i = 1.2
            User.setActivityLevel(i)
            ActivityLevelDescription.Text = ("*If you’re sedentary, your daily activities include: " & vbCrLf & vbTab &
                "*Activities of daily living only, such as shopping, cleaning, watering plants, taking out the trash, walking the dog, mowing the lawn and gardening. " & vbCrLf & vbTab &
                "*No moderate of vigorous activities. " & vbCrLf & vbTab &
                "*Unless you do at least 30 minutes per day of intentional exercise, you are considered sedentary. " & vbCrLf & vbTab &
                "*Spending most of the day sitting (e.g. bank teller, desk job) " & vbCrLf &
                "*The majority of people will be considered sedentary. " & vbCrLf)

        ElseIf ALBox.SelectedItem.Equals("Lightly Active") Then
            i = 1.375
            User.setActivityLevel(i)
            ActivityLevelDescription.Text = ("*If you’re lightly active, your daily activities include: " & vbCrLf & vbTab &
                "*Activities of daily living only, such as shopping, cleaning, watering plants, taking out the trash, walking the dog, mowing the lawn and gardening. " & vbCrLf & vbTab &
                "*Daily exercise that is equal to walking for 30 minutes at 4mph.  For an adult of average weight, this amount of exercise will burn about 130-160 additional calories. " & vbCrLf & vbTab &
                "*More intense exercise can be performed for less time to achieve the same goal.  For example, 15-20 minutes of vigorous activity, such as aerobics, skiing or jogging on a daily basis would put you in this category. " & vbCrLf & vbTab &
                "*Spending a good part of the day on your feet (e.g. teacher, salesman) ")

        ElseIf ALBox.SelectedItem.Equals("Moderately Active") Then
            i = 1.55
            User.setActivityLevel(i)
            ActivityLevelDescription.Text = "*If you’re active, your daily activities include: " & vbCrLf & vbTab &
                "*Activities of daily living only, such as shopping, cleaning, watering plants, taking out the trash, walking the dog, mowing the lawn and gardening. " & vbCrLf & vbTab &
                "*Daily exercise that is equal to walking for 1 hour and 45 minutes at 4mph.  For an adult of average weight, this amount of exercise will burn about 470-580 additional calories. " & vbCrLf & vbTab &
                "*More intense exercise can be performed for less time.  For example, jogging for 50 minutes per day. " & vbCrLf & vbTab &
                "*Spending a good part of the day doing some physical activity (e.g. waitress, mailman)"

        ElseIf ALBox.SelectedItem.Equals("Very Active") Then
            i = 1.725
            User.setActivityLevel(i)
            ActivityLevelDescription.Text = ("*If you’re very active, your daily activities include:" & vbCrLf & vbTab &
                "*Activities of daily living only, such as shopping, cleaning, watering plants, taking out the trash, walking the dog, mowing the lawn and gardening." & vbCrLf & vbTab &
                "*Daily exercise that is equal to walking for 4 hours and 15 minutes at 4mph.  For an adult of average weight, this amount of exercise will burn about 1,150-1400 additional calories." & vbCrLf & vbTab &
                "*More intense exercise can be performed for less time.  For example, jogging for 2 hours minutes per day." & vbCrLf & vbTab &
                "*Spending most of the day doing heavy physical activity (e.g. bike messenger, carpenter)")

        ElseIf ALBox.SelectedItem.Equals("Extra Active") Then
            i = 1.9
            User.setActivityLevel(i)
            ActivityLevelDescription.Text = "You do heavy manual labor."

        End If
    End Sub

    Private Sub UserInputModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load, lName.MouseHover, Label4.MouseHover, Label3.MouseHover, lnamelabel.MouseHover, fnamelabel.MouseHover, fName.MouseHover, Dsil.MouseHover, zipcode.MouseHover, street.MouseHover, state.MouseHover, Label9.MouseHover, Label17.MouseHover, Label11.MouseHover, Label10.MouseHover, city.MouseHover, wrist.MouseHover, weight.MouseHover, waist.MouseHover, Label8.MouseHover, Label7.MouseHover, Label6.MouseHover, Label5.MouseHover, Label16.MouseHover, Label15.MouseHover, Label14.MouseHover, hips.MouseHover, forearm.MouseHover, chest.MouseHover, SaveButton.MouseHover, continuebutton.MouseHover, ActivityLevelDescription.MouseHover, ALBox.MouseHover
        ToolTip1.SetToolTip(fName, "Enter your first name!")
        ToolTip1.SetToolTip(lName, "Enter your last name!")
        ToolTip1.SetToolTip(age, "Enter your age! (18+ only)")
        ToolTip1.SetToolTip(gender, "Enter your gender! " & vbCrLf & " (1 for male, 0 for female) ")
        ToolTip1.SetToolTip(dsi, "Enter your diabetic status! " & vbCrLf & "(0 for non diabetic, 1 for prediabetic, or 2 for diabetic) ")
        ToolTip1.SetToolTip(ALBox, "Select your activity level! ")

        ToolTip1.SetToolTip(street, "Enter your street address! ")
        ToolTip1.SetToolTip(city, "Enter your city! ")
        ToolTip1.SetToolTip(state, "Enter your state! ")
        ToolTip1.SetToolTip(zipcode, "Enter your zip code! ")

        ToolTip1.SetToolTip(heightfeet, "Enter your height in feet! ")
        ToolTip1.SetToolTip(heightinches, "Enter your height in inches! ")
        ToolTip1.SetToolTip(weight, "Enter your weight in pounds! ")
        ToolTip1.SetToolTip(chest, "Enter your chest measurement in inches! ")
        ToolTip1.SetToolTip(waist, "Enter your waist measurement in inches! ")
        ToolTip1.SetToolTip(hips, "Enter your hip measurement in inches! ")
        ToolTip1.SetToolTip(forearm, "Enter your forearm measurement in inches! ")
        ToolTip1.SetToolTip(wrist, "Enter your wrist measurement in inches! ")

        ToolTip1.SetToolTip(continuebutton, "Click to select fitness goal! ")
        ToolTip1.SetToolTip(SaveButton, "Click to save your information ")

    End Sub

    Private Sub gender_ValueChanged(sender As Object, e As EventArgs) Handles gender.ValueChanged

    End Sub
End Class