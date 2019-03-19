Imports System.IO

Public Class WorkoutDisplayer
    '

    Public Shared workout As New StreamWriter("D:\userWorkout.txt")

    Private Sub WorkoutDisplayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UserInputModule.User.getGoal() = "Lose Weight" Then
            TextBox1.Text = "Since your desired fitness goal is to lose weight, the system has taken into consideration all of your body information " & vbCrLf &
                "And all of your unique body calculations to develop a simple workout plan to help you achieve your fitness goals." & vbCrLf &
                "Since you are desiring weight loss, the system recommends you to do more body weight workouts first And to run often to lose weight." & vbCrLf &
                "The system has already given you your recommended daily caloric intake numbers, please use these numbers to develop a healthy meal plan, as " & vbCrLf &
                "we know by basic knowledge that diet Is a major key for reaching your fitness goals. Stray away from food with high concentrations of fats And carbs." & vbCrLf &
                "The system recommends you to begin your workouts with a warmup run to get your blood flowing And have your body ready for a good workout." & vbCrLf & vbCrLf &
                "*****************************************************************************************************************************************************" & vbCrLf & vbCrLf

            If (UserInputModule.User.getBFP() = "Underfat") Then
                TextBox1.Text += "The system has noticed that you are already considered to have a Body Fat Percetange classifying you as Underfat." & vbCrLf &
                    "The system recommends for you to select another goal for you to have a higher chance to succeed in your fitness goals." & vbCrLf &
                    "Please do no take this in a negative manner, as many people struggle in the process to lower their body fat percentages." & vbCrLf &
                    "With that being said we recommend you to reconsider your selected goal"
                Dim oForm As GoalSelectionModule
                oForm = New GoalSelectionModule()
                'Me.Hide()
                oForm.LoseWeightGoal.Enabled = False
                oForm.Show()

            ElseIf (UserInputModule.User.getAgeLevel() = "Young" And UserInputModule.User.getBFP() = "Healthy" And UserInputModule.User.getGender = "male") Then
                TextBox1.Text += "NOTICE: You are already classified as a young " & UserInputModule.User.getGender() & " whose Body Fat % classifaction is healthy." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       5 sets of 12 or 15 reps. " & vbCrLf & vbTab &
                    "Situps:        6 sets of 12 or 15 reps." & vbCrLf & vbTab &
                    "Squats:        5 sets of 10 or 15 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 5 sets of 12 or 15 reps." & vbCrLf & vbTab &
                    "Daily Run:     30 or 40 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  20 or 35 minutes." & vbCrLf & vbTab &
                    "Daily Swim:    25 or 40 minutes." & vbCrLf & vbTab &
                    "Ultimate frisbee:  Multiple games."

            ElseIf (UserInputModule.User.getAgeLevel() = "Young" And UserInputModule.User.getBFP() = "Healthy" And UserInputModule.User.getGender = "female") Then
                TextBox1.Text += "NOTICE: You are already classified as a young " & UserInputModule.User.getGender & " whose Body Fat % classifaction is healthy." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       5 sets of 10 or 12 reps. " & vbCrLf & vbTab &
                    "Situps:        6 sets of 10 or 15 reps." & vbCrLf & vbTab &
                    "Squats:        5 sets of 15 or 20 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 5 sets of 10 or 12 reps." & vbCrLf & vbTab &
                    "Daily Run:     20 or 30 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  25 or 40 minutes." & vbCrLf & vbTab &
                    "Daily Swim:    20 or 35 minutes." & vbCrLf & vbTab &
                    "Ultimate frisbee:  Multiple games."

            ElseIf (UserInputModule.User.getAgeLevel() = "Young" And UserInputModule.User.getBFP = "Overfat") Then
                TextBox1.Text += "NOTICE: You are already classified as a young " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       3 sets of 8 or 10 reps. " & vbCrLf & vbTab &
                    "Situps:        3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                    "Squats:        3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 5 sets of 10 or 12 reps." & vbCrLf & vbTab &
                    "Daily Run:     20 or 30 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  20 or 35 minutes." & vbCrLf & vbTab &
                    "Daily Swim:    20 or 40 minutes." & vbCrLf & vbTab &
                    "Ultimate frisbee:  A couple of games."

            ElseIf (UserInputModule.User.getAgeLevel() = "Young" And UserInputModule.User.getBFP = "Obese") Then
                TextBox1.Text += "NOTICE: You are already classified as a young " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       3 sets of 8 or 10 reps. " & vbCrLf & vbTab &
                    "Situps:        3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                    "Squats:        5 sets of 6 or 8 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 5 sets of 10 or 12 reps." & vbCrLf & vbTab &
                    "Daily Run:     20 or 30 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  20 or 35 minutes." & vbCrLf & vbTab &
                    "Daily Swim:    25 or 40 minutes."

            ElseIf (UserInputModule.User.getAgeLevel = "MidAge" And UserInputModule.User.getBFP = "Healthy") Then
                TextBox1.Text += "NOTICE: You are already classified as a middle aged " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       5 sets of 8 or 10 reps. " & vbCrLf & vbTab &
                    "Situps:        6 sets of 8 or 10 reps." & vbCrLf & vbTab &
                    "Squats:        5 sets of 6 or 8 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 5 sets of 10 or 12 reps." & vbCrLf & vbTab &
                    "Daily Run:     20 or 30 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  20 or 35 minutes." & vbCrLf & vbTab &
                    "Daily Swim:    25 or 40 minutes." & vbCrLf & vbTab &
                    "Ultimate frisbee:  Multiple games."

            ElseIf (UserInputModule.User.getAgeLevel = "MidAge" And (UserInputModule.User.getBFP = "Overfat" Or UserInputModule.User.getBFP = "Obese")) Then
                TextBox1.Text += "NOTICE: You are already classified as a middle aged " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       3 sets of 8 or 10 reps. " & vbCrLf & vbTab &
                    "Situps:        4 sets of 8 or 10 reps." & vbCrLf & vbTab &
                    "Squats:        3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                    "Daily Jog:     10 or 20 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  10 or 20 minutes." & vbCrLf & vbTab &
                    "Swim:          15 or 25 minutes." & vbCrLf & vbTab &
                    "Ultimate frisbee:  A couple of games."

            ElseIf (UserInputModule.User.getAgeLevel = "OlderAge" And UserInputModule.User.getBFP = "Healthy") Then
                TextBox1.Text += "NOTICE: You are already classified as a older aged " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       5 sets of 8 or 10 reps. " & vbCrLf & vbTab &
                    "Situps:        6 sets of 8 or 10 reps." & vbCrLf & vbTab &
                    "Squats:        5 sets of 6 or 8 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 5 sets of 10 or 12 reps." & vbCrLf & vbTab &
                    "Daily Run:     20 or 30 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  20 or 35 minutes." & vbCrLf & vbTab &
                    "Daily Swim:    25 or 40 minutes." & vbCrLf & vbTab &
                    "Ultimate frisbee:  Multiple games."

            ElseIf (UserInputModule.User.getAgeLevel = "OlderAge" And (UserInputModule.User.getBFP = "Overfat" Or UserInputModule.User.getBFP = "Obese")) Then
                TextBox1.Text += "NOTICE: You are already classified as a older aged " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       3 sets of 6 or 8 reps. " & vbCrLf & vbTab &
                    "Situps:        3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                    "Squats:        3 sets of 5 or 7 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                    "Daily Jog:     10 or 15 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  10 or 20 minutes." & vbCrLf & vbTab &
                    "Daily Swim:    15 or 30 minutes." & vbCrLf & vbTab &
                    "Ultimate frisbee:  A couple of games."

            End If
        ElseIf UserInputModule.User.getGoal() = "Gain Muscle" Then
            If (UserInputModule.User.getBFP() = "Obese" Or (UserInputModule.User.getBFP = "OVerfat" And UserInputModule.User.getAgeLevel = "OlderAge")) Then
                TextBox1.Text += "The system has recognized that you are classfied as an " & UserInputModule.User.getBFP & " " & UserInputModule.User.getGender & "." & vbCrLf &
                    "We recommend you select another goal more sutiable to your body classfication." & vbCrLf &
                    "In order for you to be able to notice the muscle gains, you are recommended to follow lose " & vbCrLf &
                    "weight option first and then return to use this application to see what muscle gain plan the system will recommend to you."
                Dim oForm As GoalSelectionModule
                oForm = New GoalSelectionModule()
                Me.Hide()
                oForm.GainMuscleGoal.Enabled = False
                oForm.Show()

            ElseIf (UserInputModule.User.getAgeLevel() = "Young" And UserInputModule.User.getBFP() = "Healthy" And UserInputModule.User.getGender = "male") Then
                TextBox1.Text += "NOTICE: You are already classified as a young " & UserInputModule.User.getGender() & " whose Body Fat % classifaction is healthy." & vbCrLf &
                        "We recommend these following workouts to help with muscle gain:" & vbCrLf &
                        "*****Chest and Triceps:" & vbCrLf & vbTab &
                        "Pushups:       5 sets of 12 or 15 reps. " & vbCrLf & vbTab &
                        "Regular Bench Press:   3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Incline Bench Press:   4 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Decline Bench Press:   3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Regular Chest Fly:     3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Incline Chest Fly:     4 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Decline Chest Fly:     3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Skullcrushers:         3 sets of 8 or 10 reps." & vbCrLf & vbCrLf &
                        "*****Back And Biceps:" & vbCrLf & vbTab &
                        "Chin Pullups:              3 sets of 12 or 15 reps. " & vbCrLf & vbTab &
                        "Wide grip Pullups:         3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Weighted Curl:             3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Weighted Preacher's Curl:  3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Lat Machine Pull downs:    3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Machine Rows:              3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Bent Over Rows:            3 sets of 8 or 10 reps." & vbCrLf & vbCrLf &
                        "*****Legs and abs:" & vbCrLf & vbTab &
                        "Weighted Squats:           3 sets of 12 or 15 reps. " & vbCrLf & vbTab &
                        "Smith Machine Calf Press:  4 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Smith Machine Squats:      3 sets of 10 or 15 reps." & vbCrLf & vbTab &
                        "Smith Machine Lunges:      3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Weghted Crunches Machine:  3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Russian Twists:            3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Weighted Decline Situps:   3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "W Leg Lifts:               3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Daily Run:                 30 or 40 minutes." & vbCrLf & vbTab &
                        "Stairclimber:              20 or 35 minutes." & vbCrLf & vbTab &
                        "Daily Swim:                25 or 40 minutes." & vbCrLf & vbTab &
                        "Ultimate Frisbee with Doc: Multiple games."

            ElseIf (UserInputModule.User.getAgeLevel() = "Young" And UserInputModule.User.getBFP() = "Healthy" And UserInputModule.User.getGender = "female") Then
                TextBox1.Text += "NOTICE: You are already classified as a young " & UserInputModule.User.getGender & " whose Body Fat % classifaction is healthy." & vbCrLf &
                        "We recommend these following workouts to help with muscle gain:" & vbCrLf &
                        "*****Chest and Triceps:" & vbCrLf & vbTab &
                        "Pushups:       5 sets of 12 or 15 reps. " & vbCrLf & vbTab &
                        "Regular Bench Press:   3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Incline Bench Press:   4 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Decline Bench Press:   3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Regular Chest Fly:     3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Incline Chest Fly:     4 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Decline Chest Fly:     3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Skullcrushers:         3 sets of 8 or 10 reps." & vbCrLf & vbCrLf &
                        "*****Back And Biceps:" & vbCrLf & vbTab &
                        "Chin Pullups:              3 sets of 12 or 15 reps. " & vbCrLf & vbTab &
                        "Weighted Curl:             3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Lat Machine Pull downs:    3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Machine Rows:              3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Bent Over Rows:            3 sets of 8 or 10 reps." & vbCrLf & vbCrLf &
                        "*****Legs and abs:" & vbCrLf & vbTab &
                        "Weighted Squats:           5 sets of 12 or 15 reps. " & vbCrLf & vbTab &
                        "Smith Machine Calf Press:  5 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Smith Machine Squats:      5 sets of 10 or 15 reps." & vbCrLf & vbTab &
                        "Smith Machine Lunges:      5 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Weghted Crunches Machine:  4 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Russian Twists:            4 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Weighted Decline Situps:   3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "W Leg Lifts:               3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Daily Run:                 30 or 40 minutes." & vbCrLf & vbTab &
                        "Stairclimber:              30 or 45 minutes." & vbCrLf & vbTab &
                        "Daily Swim:                25 or 40 minutes." & vbCrLf & vbTab &
                        "Ultimate Frisbee with Doc: Multiple games."

            ElseIf (UserInputModule.User.getAgeLevel() = "Young" And UserInputModule.User.getBFP = "Overfat") Then
                TextBox1.Text += "NOTICE: You are already classified as a young " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                        "We recommend these following workouts to help with muscle gain:" & vbCrLf & vbTab &
                        "Pushups:       3 sets of 8 or 10 reps. " & vbCrLf & vbTab &
                        "Situps:        3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Squats:        3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Jumping jacks: 5 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Daily Run:     20 or 30 minutes." & vbCrLf & vbTab &
                        "Stairclimber:  20 or 35 minutes." & vbCrLf & vbTab &
                        "Daily Swim:    20 or 40 minutes." & vbCrLf & vbTab &
                        "Ultimate frisbee:  A couple of games."

            ElseIf (UserInputModule.User.getAgeLevel() = "Young" And UserInputModule.User.getBFP = "Underfat") Then
                TextBox1.Text += "NOTICE: You are already classified as a young " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                        "*****Chest and Triceps:" & vbCrLf & vbTab &
                        "Pushups:       5 sets of 12 or 15 reps. " & vbCrLf & vbTab &
                        "Regular Bench Press:   4 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Incline Bench Press:   4 sets of 5 or 6 reps." & vbCrLf & vbTab &
                        "Decline Bench Press:   4 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Regular Chest Fly:     4 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Incline Chest Fly:     4 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Decline Chest Fly:     4 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Skullcrushers:         4 sets of 8 or 10 reps." & vbCrLf & vbCrLf &
                        "*****Back And Biceps:" & vbCrLf & vbTab &
                        "Chin Pullups:              4 sets of 15 or 20 reps. " & vbCrLf & vbTab &
                        "Wide grip Pullups:         5 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Weighted Curl:             4 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Weighted Preacher's Curl:  4 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Lat Machine Pull downs:    4 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Machine Rows:              4 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Bent Over Rows:            4 sets of 8 or 10 reps." & vbCrLf & vbCrLf &
                        "*****Legs and abs:" & vbCrLf & vbTab &
                        "Weighted Squats:           3 sets of 12 or 15 reps. " & vbCrLf & vbTab &
                        "Smith Machine Calf Press:  4 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Smith Machine Squats:      3 sets of 10 or 15 reps." & vbCrLf & vbTab &
                        "Smith Machine Lunges:      3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Weghted Crunches Machine:  3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Russian Twists:            3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Weighted Decline Situps:   3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "W Leg Lifts:               3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Stairclimber:              20 or 35 minutes." & vbCrLf & vbCrLf &
                        "Ultimate Frisbee with Doc: Multiple games."

            ElseIf (UserInputModule.User.getAgeLevel = "MidAge" And UserInputModule.User.getBFP = "Healthy") Then
                TextBox1.Text += "NOTICE: You are already classified as a middle aged " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                        "We recommend these following workouts to help with muscle gain:" & vbCrLf &
                         "*****Chest and Triceps:" & vbCrLf & vbTab &
                        "Pushups:       5 sets of 12 or 15 reps. " & vbCrLf & vbTab &
                        "Regular Bench Press:   3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Incline Bench Press:   3 sets of 5 or 6 reps." & vbCrLf & vbTab &
                        "Decline Bench Press:   3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Regular Chest Fly:     3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Incline Chest Fly:     3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Decline Chest Fly:     3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Skullcrushers:         3 sets of 8 or 10 reps." & vbCrLf & vbCrLf &
                        "*****Back And Biceps:" & vbCrLf & vbTab &
                        "Chin Pullups:              3 sets of 10 or 12 reps. " & vbCrLf & vbTab &
                        "Wide grip Pullups:         3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Weighted Curl:             3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Weighted Preacher's Curl:  3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Lat Machine Pull downs:    3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Machine Rows:              3 sets of 8 or 10 reps." & vbCrLf & vbCrLf &
                        "*****Legs and abs:" & vbCrLf & vbTab &
                        "Weighted Squats:           3 sets of 10 or 12 reps. " & vbCrLf & vbTab &
                        "Smith Machine Calf Press:  3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Smith Machine Squats:      3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Smith Machine Lunges:      3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Russian Twists:            3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "W Leg Lifts:               3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Daily Run:                 30 or 40 minutes." & vbCrLf & vbTab &
                        "Stairclimber:              20 or 35 minutes." & vbCrLf & vbTab &
                        "Daily Swim:                25 or 40 minutes." & vbCrLf & vbTab &
                        "Ultimate Frisbee with Doc: Multiple games."

            ElseIf (UserInputModule.User.getAgeLevel = "MidAge" And UserInputModule.User.getBFP = "Underfat") Then
                TextBox1.Text += "NOTICE: You are already classified as a middle aged " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                        "*****Chest and Triceps:" & vbCrLf & vbTab &
                        "Pushups:       5 sets of 12 or 15 reps. " & vbCrLf & vbTab &
                        "Regular Bench Press:   3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Incline Bench Press:   3 sets of 5 or 6 reps." & vbCrLf & vbTab &
                        "Decline Bench Press:   3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Regular Chest Fly:     3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Incline Chest Fly:     3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Decline Chest Fly:     3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Skullcrushers:         3 sets of 8 or 10 reps." & vbCrLf & vbCrLf &
                        "*****Back And Biceps:" & vbCrLf & vbTab &
                        "Chin Pullups:              3 sets of 15 or 20 reps. " & vbCrLf & vbTab &
                        "Wide grip Pullups:         3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Weighted Curl:             3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Weighted Preacher's Curl:  3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Lat Machine Pull downs:    3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Machine Rows:              3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Bent Over Rows:            3 sets of 8 or 10 reps." & vbCrLf & vbCrLf &
                        "*****Legs and abs:" & vbCrLf & vbTab &
                        "Smith Machine Calf Press:  3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Smith Machine Squats:      3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Smith Machine Lunges:      3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Weghted Crunches Machine:  3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Russian Twists:            3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Weighted Decline Situps:   3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "W Leg Lifts:               3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Stairclimber:              20 or 35 minutes." & vbCrLf & vbTab &
                        "Ultimate Frisbee with Doc: Multiple games."


            ElseIf (UserInputModule.User.getAgeLevel = "MidAge" And UserInputModule.User.getBFP = "Overfat") Then
                TextBox1.Text += "NOTICE: You are already classified as a middle aged " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                        "*****Chest and Triceps:" & vbCrLf & vbTab &
                        "Pushups:               4 sets of 6 or 8 reps. " & vbCrLf & vbTab &
                        "Regular Bench Press:   3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Regular Chest Fly:     3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Incline Chest Fly:     3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Skullcrushers:         3 sets of 6 or 8 reps." & vbCrLf & vbCrLf &
                        "*****Back And Biceps:" & vbCrLf & vbTab &
                        "Chin Pullups:              3 sets of 15 or 20 reps. " & vbCrLf & vbTab &
                        "Wide grip Pullups:         3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Weighted Curl:             3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Weighted Preacher's Curl:  3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Lat Machine Pull downs:    3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Machine Rows:              3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Bent Over Rows:            3 sets of 8 or 10 reps." & vbCrLf & vbCrLf &
                        "*****Legs and abs:" & vbCrLf & vbTab &
                        "Smith Machine Calf Press:  3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Smith Machine Squats:      3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Smith Machine Lunges:      3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Weghted Crunches Machine:  3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Russian Twists:            3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Weighted Decline Situps:   3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "W Leg Lifts:               3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Stairclimber:              20 or 35 minutes." & vbCrLf & vbTab &
                        "Ultimate Frisbee with Doc: Multiple games."


            ElseIf (UserInputModule.User.getAgeLevel = "OlderAge" And UserInputModule.User.getBFP = "Healthy") Then
                TextBox1.Text += "NOTICE: You are already classified as a older aged " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                        "*****Chest and Triceps:" & vbCrLf & vbTab &
                        "Pushups:               4 sets of 6 or 8 reps. " & vbCrLf & vbTab &
                        "Regular Bench Press:   3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Regular Chest Fly:     3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Incline Chest Fly:     3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Skullcrushers:         3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "*****Back And Biceps:" & vbCrLf & vbTab &
                        "Chin Pullups:              3 sets of 8 or 10 reps. " & vbCrLf & vbTab &
                        "Wide grip Pullups:         3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Weighted Curl:             3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Weighted Preacher's Curl:  3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Lat Machine Pull downs:    3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Machine Rows:              3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Bent Over Rows:            3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "*****Legs and abs:" & vbCrLf & vbTab &
                        "Smith Machine Calf Press:  3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Smith Machine Squats:      3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Smith Machine Lunges:      3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Weghted Crunches Machine:  3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Russian Twists:            3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "W Leg Lifts:               3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Stairclimber:              20 or 35 minutes." & vbCrLf & vbTab &
                        "Ultimate Frisbee with Doc: Multiple games."

            ElseIf (UserInputModule.User.getAgeLevel = "OlderAge" And UserInputModule.User.getBFP = "Underfat") Then
                TextBox1.Text += "NOTICE: You are already classified as a older aged " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                        "*****Chest and Triceps:" & vbCrLf & vbTab &
                        "Pushups:               4 sets of 6 or 8 reps. " & vbCrLf & vbTab &
                        "Regular Bench Press:   3 sets of 6 or 7 reps." & vbCrLf & vbTab &
                        "Regular Chest Fly:     3 sets of 6 or 7 reps." & vbCrLf & vbTab &
                        "Skullcrushers:         3 sets of 6 or 7 reps." & vbCrLf & vbTab &
                        "*****Back And Biceps:" & vbCrLf & vbTab &
                        "Weighted Curl:             3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Weighted Preacher's Curl:  3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                        "Lat Machine Pull downs:    3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "Machine Rows:              3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                        "*****Legs and abs:" & vbCrLf & vbTab &
                        "Smith Machine Calf Press:  3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Smith Machine Squats:      3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Smith Machine Lunges:      3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "Weghted Crunches Machine:  3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                        "W Leg Lifts:               3 sets of 12 or 15 reps." & vbCrLf & vbTab &
                        "Stairclimber:              10 or 15 minutes." & vbCrLf & vbTab &
                        "Ultimate Frisbee with Doc: A couple games."

            End If
        ElseIf UserInputModule.User.getGoal() = "Olympic Endurance" Then
            TextBox1.Text = "Since your desired fitness goal is to maintain endurance, the system has taken into consideration all of your body information " & vbCrLf &
                    "And all of your unique body calculations to develop a simple workout plan to help you achieve your fitness goals." & vbCrLf &
                    "Since you are desiring to maintain endurance, the system recommends you to run often to be able to increase or maintain endurance" & vbCrLf &
                    "The system has already given you your recommended daily caloric intake numbers, please use these numbers to develop a healthy meal plan, as " & vbCrLf &
                    "we know by basic knowledge that diet is a major key for reaching your fitness goals. Stray away from food with high concentrations of fats And carbs." & vbCrLf &
                    "The system recommends you to begin your workouts with a warmup run to get your blood flowing And have your body ready for a good workout." & vbCrLf & vbCrLf &
                "*****************************************************************************************************************************************************" & vbCrLf & vbCrLf


            If (UserInputModule.User.getBFP() = "Underfat") Then
                TextBox1.Text += "The system has noticed that you are already considered to have a Body Fat Percetange classifying you as Underfat." & vbCrLf &
                    "The system recommends for you to select another goal for you to have a higher chance to succeed in your fitness goals." & vbCrLf &
                    "Please do no take this in a negative manner, as many people struggle in the process to lower their body fat percentages." & vbCrLf &
                    "With that being said we recommend you to reconsider your selected goal"
                Dim oForm As GoalSelectionModule
                oForm = New GoalSelectionModule()
                'Me.Hide()
                oForm.LoseWeightGoal.Enabled = False
                oForm.Show()

            ElseIf (UserInputModule.User.getAgeLevel() = "Young" And UserInputModule.User.getBFP() = "Healthy" And UserInputModule.User.getGender = "male") Then
                TextBox1.Text += "NOTICE: You are already classified as a young " & UserInputModule.User.getGender() & " whose Body Fat % classifaction is healthy." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       5 sets of 12 or 15 reps. " & vbCrLf & vbTab &
                    "Situps:        6 sets of 12 or 15 reps." & vbCrLf & vbTab &
                    "Squats:        5 sets of 10 or 15 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 5 sets of 12 or 15 reps." & vbCrLf & vbTab &
                    "Daily Run:     30 or 40 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  20 or 35 minutes." & vbCrLf & vbTab &
                    "Daily Swim:    25 or 40 minutes." & vbCrLf & vbTab &
                    "Ultimate frisbee:  Multiple games."

            ElseIf (UserInputModule.User.getAgeLevel() = "Young" And UserInputModule.User.getBFP() = "Healthy" And UserInputModule.User.getGender = "female") Then
                TextBox1.Text += "NOTICE: You are already classified as a young " & UserInputModule.User.getGender & " whose Body Fat % classifaction is healthy." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       5 sets of 10 or 12 reps. " & vbCrLf & vbTab &
                    "Situps:        6 sets of 10 or 15 reps." & vbCrLf & vbTab &
                    "Squats:        5 sets of 15 or 20 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 5 sets of 10 or 12 reps." & vbCrLf & vbTab &
                    "Daily Run:     20 or 30 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  25 or 40 minutes." & vbCrLf & vbTab &
                    "Daily Swim:    20 or 35 minutes." & vbCrLf & vbTab &
                    "Ultimate frisbee:  Multiple games."

            ElseIf (UserInputModule.User.getAgeLevel() = "Young" And UserInputModule.User.getBFP = "Overfat") Then
                TextBox1.Text += "NOTICE: You are already classified as a young " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       3 sets of 8 or 10 reps. " & vbCrLf & vbTab &
                    "Situps:        3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                    "Squats:        3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 5 sets of 10 or 12 reps." & vbCrLf & vbTab &
                    "Daily Run:     20 or 30 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  20 or 35 minutes." & vbCrLf & vbTab &
                    "Daily Swim:    20 or 40 minutes." & vbCrLf & vbTab &
                    "Ultimate frisbee:  A couple of games."

            ElseIf (UserInputModule.User.getAgeLevel() = "Young" And UserInputModule.User.getBFP = "Obese") Then
                TextBox1.Text += "NOTICE: You are already classified as a young " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       3 sets of 8 or 10 reps. " & vbCrLf & vbTab &
                    "Situps:        3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                    "Squats:        5 sets of 6 or 8 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 5 sets of 10 or 12 reps." & vbCrLf & vbTab &
                    "Daily Run:     20 or 30 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  20 or 35 minutes." & vbCrLf & vbTab &
                    "Daily Swim:    25 or 40 minutes."

            ElseIf (UserInputModule.User.getAgeLevel = "MidAge" And UserInputModule.User.getBFP = "Healthy") Then
                TextBox1.Text += "NOTICE: You are already classified as a middle aged " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       5 sets of 8 or 10 reps. " & vbCrLf & vbTab &
                    "Situps:        6 sets of 8 or 10 reps." & vbCrLf & vbTab &
                    "Squats:        5 sets of 6 or 8 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 5 sets of 10 or 12 reps." & vbCrLf & vbTab &
                    "Daily Run:     20 or 30 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  20 or 35 minutes." & vbCrLf & vbTab &
                    "Daily Swim:    25 or 40 minutes." & vbCrLf & vbTab &
                    "Ultimate frisbee:  Multiple games."

            ElseIf (UserInputModule.User.getAgeLevel = "MidAge" And (UserInputModule.User.getBFP = "Overfat" Or UserInputModule.User.getBFP = "Obese")) Then
                TextBox1.Text += "NOTICE: You are already classified as a middle aged " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       3 sets of 8 or 10 reps. " & vbCrLf & vbTab &
                    "Situps:        4 sets of 8 or 10 reps." & vbCrLf & vbTab &
                    "Squats:        3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 3 sets of 10 or 12 reps." & vbCrLf & vbTab &
                    "Daily Jog:     10 or 20 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  10 or 20 minutes." & vbCrLf & vbTab &
                    "Swim:          15 or 25 minutes." & vbCrLf & vbTab &
                    "Ultimate frisbee:  A couple of games."

            ElseIf (UserInputModule.User.getAgeLevel = "OlderAge" And UserInputModule.User.getBFP = "Healthy") Then
                TextBox1.Text += "NOTICE:You are already classified as a older aged " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       5 sets of 8 or 10 reps. " & vbCrLf & vbTab &
                    "Situps:        6 sets of 8 or 10 reps." & vbCrLf & vbTab &
                    "Squats:        5 sets of 6 or 8 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 5 sets of 10 or 12 reps." & vbCrLf & vbTab &
                    "Daily Run:     20 or 30 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  20 or 35 minutes." & vbCrLf & vbTab &
                    "Daily Swim:    25 or 40 minutes." & vbCrLf & vbTab &
                    "Ultimate frisbee:  Multiple games."

            ElseIf (UserInputModule.User.getAgeLevel = "OlderAge" And (UserInputModule.User.getBFP = "Overfat" Or UserInputModule.User.getBFP = "Obese")) Then
                TextBox1.Text += "NOTICE: You are already classified as a older aged " & UserInputModule.User.getGender & " whose Body Fat % classifaction is " & UserInputModule.User.getBFP & "." & vbCrLf &
                    "We recommend these following workouts to help with weight loss:" & vbCrLf & vbTab &
                    "Pushups:       3 sets of 6 or 8 reps. " & vbCrLf & vbTab &
                    "Situps:        3 sets of 6 or 8 reps." & vbCrLf & vbTab &
                    "Squats:        3 sets of 5 or 7 reps." & vbCrLf & vbTab &
                    "Jumping jacks: 3 sets of 8 or 10 reps." & vbCrLf & vbTab &
                    "Daily Jog:     10 or 15 minutes." & vbCrLf & vbTab &
                    "Stairclimber:  10 or 20 minutes." & vbCrLf & vbTab &
                    "Daily Swim:    15 or 30 minutes." & vbCrLf & vbTab &
                    "Ultimate frisbee:  A couple of games."

            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Pushups.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/pushups")
    End Sub
    Private Sub Situps_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Situps.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/frog-sit-ups")
    End Sub
    Private Sub Skullcrushers_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Skullcrushers.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/ez-bar-skullcrusher")
    End Sub
    Private Sub WeightedSitups_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles WeightedSitups.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/weighted-sit-ups-with-bands")
    End Sub
    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Pullups.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/pullups")
    End Sub

    Private Sub assistedpullups_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles assistedpullups.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/machine-assisted-pull-up")
    End Sub

    Private Sub Widegrip_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Widegrip.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/wide-grip-pull-up")
    End Sub

    Private Sub bentoverrow_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles bentoverrow.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/smith-machine-bent-over-row")
    End Sub

    Private Sub benchpress_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles benchpress.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/wide-grip-barbell-bench-press")
    End Sub

    Private Sub chestflyes_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles chestflyes.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/dumbbell-flyes")
    End Sub

    Private Sub inclineflyes_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles inclineflyes.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/incline-dumbbell-flyes")
    End Sub

    Private Sub LinkLabel1_LinkClicked_2(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles bentoverdumbbell.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/bent-over-two-dumbbell-row")
    End Sub

    Private Sub LinkLabel1_LinkClicked_3(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/barbell-incline-bench-press-medium-grip")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/smith-machine-incline-bench-press")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/barbell-full-squat")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/front-squat-bodybuilder")
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/chin-up")
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/ez-bar-curl")
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/reverse-barbell-preacher-curls")
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/wide-grip-lat-pulldown")
    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/smith-machine-calf-raise")
    End Sub

    Private Sub LinkLabel10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/bodyweight-lunge")
    End Sub

    Private Sub LinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/russian-twist")
    End Sub

    Private Sub LinkLabel12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/bodyweight-squat")
    End Sub

    Private Sub LinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/flat-bench-lying-leg-raise")
    End Sub

    Private Sub LinkLabel14_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel14.LinkClicked
        Process.Start("http://www.bodybuilding.com/exercises/detail/view/name/hammer-curls")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        workout.WriteLine(TextBox1.Text)
        workout.Close()
    End Sub
 
End Class