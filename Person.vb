Public Class Person
    Private FN As String = "", LN As String = ""
    Private age As Double = 0.0, gender As Double = 0, DSI As Double = 0
    Private street As String = "", city As String = "", state As String = "", zipcode As Double = 0000
    Private height As Double = 0.0, weight As Double = 0.0, hft As Double = 0.0, hin As Double = 0.0
    Private chest As Double = 0.0, waist As Double = 0.0, hips As Double = 0.0, forearm As Double = 0.0, wrist As Double = 0.0
    Private IBW As Double = 0.0, BMI As Double = 0.0, BMR As Double = 0.0, LBM As Double = 0.0, BodyFat As Double = 0.0
    Private weightClassifcation As String = "", BodyMassIndexed As String = "", activityLevel As Double = 0.0
    Private CaloriesRecommended As Double, ProteinCaloriesRecommended As Double, CarbCaloriesRecommended As Double, FatCaloriesRecommended As Double
    Private carbs As Double, proteins As Double, fats As Double, creatine As Double
    Private maxHPM As Double, UBHPM As Double, LBHPM As Double
    Private goalselected As String, AgeLevel As String
    Private WorkoutText As String = ""
    Private BFP As String = ""

    Public Sub setUserInfo(ByVal F As String, ByVal L As String, ByVal A As Double, ByVal G As Double, ByVal D As Double)
        FN = F
        LN = L
        age = A
        gender = G
        DSI = D
        maxHPM = 220 - age
        LBHPM = maxHPM * 0.7
        UBHPM = maxHPM * 0.85
        If 18 <= A <= 30 Then
            AgeLevel = "Young"
        ElseIf 31 <= A <= 50 Then
            AgeLevel = "MidAge"
        ElseIf 51 <= A Then
            AgeLevel = "OlderAge"
        End If
    End Sub
    Public Sub setUserAddress(ByVal S As String, ByVal C As String, ByVal ST As String, ByVal Z As Double)
        street = S
        city = C
        state = ST
        zipcode = Z
    End Sub
    Public Sub setUserBodyInfo(ByVal Hf As Double, ByVal Hi As Double, ByVal We As Double, ByVal Ch As Double, ByVal Wa As Double, ByVal H As Double, ByVal F As Double, ByVal Wr As Double)
        hft = Hf
        hin = Hi
        height = ((Hf * 12) + Hi)
        weight = We
        chest = Ch
        waist = Wa
        hips = H
        forearm = F
        wrist = Wr
    End Sub
    Public Function gethft() As Double
        Return hft
    End Function
    Public Function gethin() As Double
        Return hin
    End Function
    Public Function getFName() As String
        Return FN
    End Function
    Public Function getLName() As String
        Return LN
    End Function
    Public Function getAge() As Double
        Return age
    End Function
    Public Function getStreet() As String
        Return street
    End Function
    Public Function getCity() As String
        Return city
    End Function
    Public Function getState() As String
        Return state
    End Function
    Public Function getZip() As Double
        Return zipcode
    End Function
    Public Function getHeight() As Double
        Return height
    End Function
    Public Function getWeight() As Double
        Return weight
    End Function
    Public Function getIBW() As Double
        If gender = 1 Then
            IBW = 106 + (6 * (height - 60))
        ElseIf gender = 0 Then
            IBW = 100 + (5 * (height - 60))
        End If
        Return IBW
    End Function
    Public Function getBMI() As Double
        BMI = (weight * 703) / Math.Pow(height, 2)
        Return BMI
    End Function
    Public Function getBMItext() As String
        If getBMI() < 18.5 Then
            BodyMassIndexed = "Under weight"
        ElseIf (18.5 <= getBMI() <= 24.9) Then
            BodyMassIndexed = "Normal weight"
        ElseIf (25.0 <= getBMI() <= 29.9) Then
            BodyMassIndexed = "Over weight"
        ElseIf 30 <= getBMI() <= 39.99 Then
            BodyMassIndexed = "Obese"
        ElseIf getBMI() >= 40 Then
            BodyMassIndexed = "Morbidly Obese"
        End If

        Return BodyMassIndexed
    End Function
    Public Function getBMR() As Double
        If gender = 0 Then
            BMR = 655 + (4.35 * weight) + (4.7 * height) - (4.68 * age)
        ElseIf gender = 1 Then
            BMR = 66 + (6.23 * weight) + (12.7 * height) - (6.76 * age)
        End If
        Return BMR
    End Function
    Public Function getLBM() As Double
        If gender = 1 Then
            LBM = ((1.082 * weight) + 94.42) - (4.15 * waist)
        ElseIf gender = 0 Then
            LBM = ((0.732 * weight) + 8.987) + (wrist / 3.14) - (0.157 * waist) - (0.249 * hips) + (0.434 * forearm)
        End If
        Return LBM
    End Function
    Public Function getBodyFat() As Double
        BodyFat = ((weight - getLBM()) * 100) / weight
        Return BodyFat
    End Function
    Public Function getBodyFattext() As String
        If gender = 1 Then
            If 18 <= age <= 39 Then
                If getBodyFat() <= 0.08 Then
                    BFP = "Underfat"
                ElseIf (0.08 < getBodyFat() <= 0.19) Then
                    BFP = "Healthy"
                ElseIf (0.19 < getBodyFat() <= 0.25) Then
                    BFP = "Overfat"
                ElseIf 0.25 < getBodyFat() Then
                    BFP = "Obese"
                End If
            End If
            If 40 <= age <= 59 Then
                If getBodyFat() <= 0.11 Then
                    BFP = "Underfat"
                ElseIf (0.11 < getBodyFat() <= 0.22) Then
                    BFP = "Healthy"
                ElseIf (0.22 < getBodyFat() <= 0.28) Then
                    BFP = "Overfat"
                ElseIf 0.28 < getBodyFat() Then
                    BFP = "Obese"
                End If
            End If
            If 60 <= age <= 79 Then
                If getBodyFat() <= 0.13 Then
                    BFP = "Underfat"
                ElseIf (0.13 < getBodyFat() <= 0.25) Then
                    BFP = "Healthy"
                ElseIf (0.25 < getBodyFat() <= 0.3) Then
                    BFP = "Overfat"
                ElseIf 0.3 < getBodyFat() Then
                    BFP = "Obese"
                End If
            End If

        ElseIf gender = 0 Then
            If 18 <= age <= 39 Then
                If getBodyFat() <= 0.21 Then
                    BFP = "Underfat"
                ElseIf (0.21 < getBodyFat() <= 0.33) Then
                    BFP = "Healthy"
                ElseIf (0.33 < getBodyFat() <= 0.39) Then
                    BFP = "Overfat"
                ElseIf 0.39 < getBodyFat() Then
                    BFP = "Obese"
                End If
            End If
            If 40 <= age <= 59 Then
                If getBodyFat() <= 0.23 Then
                    BFP = "Underfat"
                ElseIf (0.23 < getBodyFat() <= 0.35) Then
                    BFP = "Healthy"
                ElseIf (0.35 < getBodyFat() <= 0.4) Then
                    BFP = "Overfat"
                ElseIf 0.4 < getBodyFat() Then
                    BFP = "Obese"
                End If
            End If
            If 60 <= age <= 79 Then
                If getBodyFat() <= 0.24 Then
                    BFP = "Underfat"
                ElseIf (0.24 < getBodyFat() <= 0.36) Then
                    BFP = "Healthy"
                ElseIf (0.36 < getBodyFat() <= 0.42) Then
                    BFP = "Overfat"
                ElseIf 0.42 < getBodyFat() Then
                    BFP = "Obese"
                End If
            End If
        End If
        Return BFP
    End Function
    Public Sub setActivityLevel(ByVal AL As Double)
        activityLevel = AL
    End Sub
    Public Function getActivityLevel() As Double
        If activityLevel <> 0 Then
            Return activityLevel
        Else
            Return 1
        End If
    End Function
    Public Function getCalorieRecommendedCalculation() As Double
        CaloriesRecommended = getBMR() * getActivityLevel()
        Return CaloriesRecommended
    End Function
    Public Sub setCaloricRatio(ByVal c As Double, ByVal p As Double, ByVal f As Double)
        carbs = c
        proteins = p
        fats = f
    End Sub
    Public Function getCarbsCaloriesBasedOnGoal() As Double
        CarbCaloriesRecommended = (carbs * getCalorieRecommendedCalculation())
        Return CarbCaloriesRecommended
    End Function
    Public Function getProteinCaloriesBasedOnGoal() As Double
        ProteinCaloriesRecommended = (proteins * getCalorieRecommendedCalculation())
        Return ProteinCaloriesRecommended
    End Function
    Public Function getFatsCaloriesBasedOnGoal() As Double
        FatCaloriesRecommended = (fats * getCalorieRecommendedCalculation())
        Return FatCaloriesRecommended
    End Function
    Public Function getCreatine() As Double
        'calculate creatine intake
        If DSI <> 2 Then
            creatine = 5
        ElseIf DSI = 2 Then
            creatine = 3
        End If
        Return creatine
    End Function
    'calculate maximum heart rate, HPMtargetzone
    Public Function getLowerBoundHPM() As Double
        Return LBHPM
    End Function
    Public Function getUpperBoundHPM() As Double
        Return UBHPM
    End Function
    'calculate water intake
    Public Function getWaterIntake() As Double
        Return (weight * 0.67)
    End Function
    Public Function getGender() As String
        Dim g As String
        If gender = 0 Then
            g = "female"
        Else
            g = "male"
        End If
        Return g
    End Function

    Public Function getDSI() As String
        Dim r As String
        If DSI = 0 Then
            r = "non-diabetic"
        ElseIf DSI = 1 Then
            r = "pre-diabetic"
        Else
            r = "diabetic"
        End If
        Return r
    End Function

    Public Function getChest() As Double
        Return chest
    End Function
    Public Function getWaist() As Double
        Return waist
    End Function
    Public Function getHips() As Double
        Return hips
    End Function
    Public Function getForearm() As Double
        Return forearm
    End Function
    Public Function getWrist() As Double
        Return wrist
    End Function
    Public Sub setGoal(ByVal G As String)
        goalselected = G
    End Sub
    Public Function getGoal() As String
        Return goalselected
    End Function
    Public Function getBFP() As String
        Return BFP
    End Function
    Public Function getAgeLevel() As String
        Return AgeLevel
    End Function
End Class