Public Class GoalSelectionModule
    'Carbs   - Contains 4 calories per gram
    'Protein - Contains 4 calories per gram
    'Fats    - Contains 9 calories per gram
    'The USDA recommends a macronutrient ratio of 53% carbs, 18% protein, and 29% fat
    'Fat intake should compromise 20-35% of caloric needs

    Private Sub LoseWeight_CheckedChanged(sender As Object, e As EventArgs) Handles LoseWeightGoal.MouseClick
        'protein is about 0.75-1g per pound
        'High bodyfat:  1-2g fat/ Kg LEAN weight [between 0.4 - 1g LEAN weight/ pounds]
        'Low calorie dieting - you can decrease further, but As a minimum, 
        'I would Not suggest LESS than about 0.30g/ pound.
        'C%+P%+F%
        'macros for fat loss    = 25%+50+25%
        'userInfo.setProteinPerPoundBasedOnGoal(0.5)
        UserInputModule.User.setCaloricRatio(0.25, 0.5, 0.25)
        UserInputModule.User.setGoal("Lose Weight")
        Dim oForm As DisplayResults
        oForm = New DisplayResults()
        oForm.calculated.Text = ("Based off all of your different body measurements and inputs, the system has calculated several unique body information for you." & vbCrLf & vbCrLf &
                            "Your recommended daily water intake is " & Math.Round(UserInputModule.User.getWaterIntake()) & "." & vbCrLf & vbCrLf &
                            "Your heart beats per minute target zone is between " & Math.Round(UserInputModule.User.getLowerBoundHPM()) & " bpm and " & Math.Round(UserInputModule.User.getUpperBoundHPM()) & " bpm." & vbCrLf & vbCrLf)
        Me.Hide()
        oForm.Show()
    End Sub

    Private Sub GainMuscle_CheckedChanged(sender As Object, e As EventArgs) Handles GainMuscleGoal.MouseClick
        'Strength training protein is about 1-1.35g per pound
        'Average Or low bodyfat: 1 - 2g fat/ kg body weight 
        '[between 0.40 - 1g total weight/ pounds]
        'macros for muscle gain = 50%+30%%+20%
        'userInfo.setProteinPerPoundBasedOnGoal(1.35)
        UserInputModule.User.setCaloricRatio(0.5, 0.3, 0.2)
        UserInputModule.User.setGoal("Gain Muscle")
        Dim oForm As DisplayResults
        oForm = New DisplayResults()
        oForm.calculated.Text = ("Based off all of your different body measurements and inputs, the system has calculated several unique body information for you." & vbCrLf & vbCrLf &
                            "Your recommended creatine intake is " & Math.Round(UserInputModule.User.getCreatine()) & " grams per day." & vbCrLf & vbCrLf &
                            "Your recommended daily water intake is " & Math.Round(UserInputModule.User.getWaterIntake()) & " ounces a day." & vbCrLf & vbCrLf &
                            "Your heart beats per minute target zone is between " & Math.Round(UserInputModule.User.getLowerBoundHPM()) & " bpm and " & Math.Round(UserInputModule.User.getUpperBoundHPM()) & " bpm." & vbCrLf & vbCrLf)
        Me.Hide()
        oForm.Show()

    End Sub

    Private Sub OlympicEndurance_CheckedChanged(sender As Object, e As EventArgs) Handles OlympicEnduranceGoal.MouseClick
        'Endurance training protein is about 0.8-1.25g per pound
        'macros for endurance   = 40%+35%+25%
        'userInfo.setProteinPerPoundBasedOnGoal(1)
        UserInputModule.User.setCaloricRatio(0.4, 0.35, 0.25)
        UserInputModule.User.setGoal("Olympic Endurance")
        Dim oForm As DisplayResults
        oForm = New DisplayResults()
        oForm.calculated.Text = ("Based off all of your different body measurements and inputs, the system has calculated several unique body information for you." & vbCrLf & vbCrLf &
                            "Your recommended creatine grams intake is " & Math.Round(UserInputModule.User.getCreatine()) & " grams per day." & vbCrLf & vbCrLf &
                            "Your recommended daily water intake is " & Math.Round(UserInputModule.User.getWaterIntake()) & "." & vbCrLf & vbCrLf &
                            "Your heart beats per minute target zone is between " & Math.Round(UserInputModule.User.getLowerBoundHPM()) & " bpm and " & Math.Round(UserInputModule.User.getUpperBoundHPM()) & " bpm." & vbCrLf & vbCrLf)
        Me.Hide()
        oForm.Show()
    End Sub

End Class