Imports System.IO
Imports System.Text

Public Class DisplayResults
    Public Shared fs As New StreamWriter("D:\userInfo.txt")
    Private classifcation As String, addressinfo As String, bodyinfodes As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button1.Enabled = False
        WorkoutButton.Visible = True
        WorkoutButton.Enabled = True
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        BMItext.Visible = True
        WorkoutButton.Visible = True
    End Sub

    Private Sub IBWb_Click(sender As Object, e As EventArgs) Handles IBWb.Click
        calculated.Text = ("Your Ideal Body Weight is " & Math.Round(UserInputModule.User.getIBW()) & " lbs." & vbCrLf & vbCrLf &
                            "What is an Ideal Body Weight?" & vbCrLf & vbCrLf &
                            "Ideal Body Weight is a person's ideal body weight." & vbCrLf & vbCrLf &
                            "Ideal Body Weight takes into consideration, your height, age, and gender." & vbCrLf & vbCrLf &
                            "The Ideal Body Weight should be considered because it allows a person to see what their ideal body weight should be." & vbCrLf & vbCrLf &
                            "Be aware: the ideal body weight is not an exact number to how much you should weigh." & vbCrLf & vbCrLf &
                            "Ideal Body Weight can vary due to difference body masses and heights." & vbCrLf)
        IBWb.Enabled = False
    End Sub

    Private Sub BMRb_Click(sender As Object, e As EventArgs) Handles BMRb.Click
        calculated.Text = ("Your Basal Metabolic Rate is " & Math.Round(UserInputModule.User.getBMR()) & " calories a day." & vbCrLf & vbCrLf &
                            "What is Basal Metabolic Rate?" & vbCrLf & vbCrLf &
                            "Basal Metabolic rate is the energy required by an animal to stay alive with no activity." & vbCrLf & vbCrLf &
                            "Calculating BMR is a very useful first step in calculating your real metabolic rate." & vbCrLf & vbCrLf &
                            "Your Basal Metabolic Rate (BMR) is one of the main contributing components of energy expenditure (around 70%)." & vbCrLf & vbCrLf &
                            "Basal Metabolic Rate can be calculated knowing a few key variables, which are age, sex, weight, height, And fat-free body mass. " & vbCrLf & vbCrLf &
                            "Fat-free mass Is a very important variable. Weight And height are used in one formula to determine body surface area.")
        BMRb.Enabled = False
    End Sub

    Private Sub LBMb_Click(sender As Object, e As EventArgs) Handles LBMb.Click
        calculated.Text = "Your Lean Body Mass is " & String.Format("{0:n2}", UserInputModule.User.getLBM()) & " lbs." & vbCrLf & vbCrLf &
            "Your Lean Body Mass is the amount of weight you carry on your body that isn't fat. " & vbCrLf & vbCrLf &
            "The goal of any bodybuilder or fitness enthusiast is to drop weight while keeping your lean body mass the same, in other words, dropping your body fat percentage. " & vbCrLf & vbCrLf &
            "To find your Lean Body Mass, you must first know your body fat percentage." & vbCrLf & vbCrLf &
            "Lean Body Nass does NOT necessarily indicate fat free mass." & vbCrLf & vbCrLf &
            "Lean Body Mass contains a small percentage of fat (roughly 3%) within the central nervous system (brain And spinal cord), marrow of bones, and internal organs. It is measured in terms of density." & vbCrLf
        LBMb.Enabled = False
    End Sub

    Private Sub BFPb_Click(sender As Object, e As EventArgs) Handles BFPb.Click
        calculated.Text = "Your Body Fat Percentage is " & String.Format("{0:n2}", UserInputModule.User.getBodyFat()) & "%. " & vbCrLf & vbCrLf &
            "Here's a basic rundown: A body fat test is an attempt to separate every pound of your body into one of two categories: your fat mass and everything else. " & vbCrLf & vbCrLf &
            "What isn't fat mass is considered ''lean body mass'' which consists of your bones, muscles, hair, water, and miscellaneous stuff. So no, it's not just muscle!" & vbCrLf & vbCrLf &
            "This ratio can be deceiving in a number of ways. For instance small, slender people who don't weigh much may actually have a greater percentage of body fat than larger, more muscular people who weigh more. " & vbCrLf & vbCrLf &
            "That's just one reason why your weight on the scale doesn't necessarily measure the level of your health."
        BFPb.Enabled = False
    End Sub

    Private Sub DCIb_Click(sender As Object, e As EventArgs) Handles DCIb.Click
        calculated.Text = "Your recommended daily caloric intake is " & Math.Round(UserInputModule.User.getCalorieRecommendedCalculation()) & " calories per day." & vbCrLf & vbCrLf &
                            "How many calories are needed each day can vary greatly depending on lifestyle and other factors. " & vbCrLf &
                            "Factors that affect your personal daily calorie needs include your age, height and weight, your basic level of daily activity, and your body composition. " & vbCrLf & vbCrLf &
                            "In order to lose weight you need to eat less calories per day than your body needs. To lose 1lb a week you need a negative calorie balance of 500 calories per day. " & vbCrLf & vbCrLf &
                            "To lose weight at 2lb a week you need to reduce your calorie intake by 1000 calories a day. "
        DCIb.Enabled = False
        Carbsb.Visible = True
        PROTEINb.Visible = True
        FATSb.Visible = True
    End Sub

    Private Sub Carbsb_Click(sender As Object, e As EventArgs) Handles Carbsb.Click
        calculated.Text = "Your recommended carb calories intake is " & Math.Round(UserInputModule.User.getCarbsCaloriesBasedOnGoal()) &
                            " calories per day OR " & Math.Round(UserInputModule.User.getCarbsCaloriesBasedOnGoal() / 4) & " grams per day." & vbCrLf & vbCrLf &
                            "Carbohydrates are the sugars, starches and fibers found in fruits, grains, vegetables and milk products." & vbCrLf & vbCrLf &
                            "Though often maligned in trendy diets, carbohydrates — one of the basic food groups — are important to a healthy life."
        Carbsb.Enabled = False
    End Sub

    Private Sub PROTEINb_Click(sender As Object, e As EventArgs) Handles PROTEINb.Click
        calculated.Text = "Your recommended protein calories intake is " & Math.Round(UserInputModule.User.getProteinCaloriesBasedOnGoal()) &
                            " calories per day Or " & Math.Round(UserInputModule.User.getProteinCaloriesBasedOnGoal() / 4) & " grams per day." & vbCrLf & vbCrLf &
                            "Protein is a macronutrient that is essential to building muscle mass." & vbCrLf & vbCrLf &
                            "It Is commonly found in animal products, though is also present in other sources, such as nuts And legumes. "
        PROTEINb.Enabled = False
    End Sub

    Private Sub FATSb_Click(sender As Object, e As EventArgs) Handles FATSb.Click
        calculated.Text = "Your recommended fat calories intake is " & Math.Round(UserInputModule.User.getFatsCaloriesBasedOnGoal()) &
                            " calories per day Or " & Math.Round(UserInputModule.User.getFatsCaloriesBasedOnGoal() / 9) & " grams per day." & vbCrLf & vbCrLf &
                            "Though it gets a bad rap, fat is an important nutrient that the body needs in order to function." & vbCrLf & vbCrLf &
                            "Eating the right amount — and the right form — of dietary fat is key to maintaining good health, experts say. " & vbCrLf & vbCrLf &
                            "However, consuming too much fat or too little may cause health problems."
        FATSb.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fs.WriteLine(calculated.Text)
        fs.WriteLine()
        fs.WriteLine("***************************************************************************************************")
        fs.WriteLine()
    End Sub


    Private Sub WorkoutButton_Click(sender As Object, e As EventArgs) Handles WorkoutButton.Click
        Button2.Enabled = False
        Button2.Visible = False
        fs.Close()
        Dim oForm As WorkoutDisplayer
        oForm = New WorkoutDisplayer()
        oForm.BringToFront()
        oForm.Show()
    End Sub

    Private Sub DisplayResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        classifcation = ("Hello, " & UserInputModule.User.getFName & " " & UserInputModule.User.getLName & "." & vbCrLf & vbCrLf &
                                "You self-classified as a " & UserInputModule.User.getDSI() & ", " & UserInputModule.User.getAge & " year old " & UserInputModule.User.getGender() & "." & vbCrLf & vbCrLf)

        addressinfo = ("According to the information you input, you live on " & UserInputModule.User.getStreet & " in " & UserInputModule.User.getCity & ", " & UserInputModule.User.getState & " " & UserInputModule.User.getZip & "." & vbCrLf & vbCrLf)


        If UserInputModule.User.getGender = "female" Then
            bodyinfodes = ("You are " & UserInputModule.User.gethft & " feet And " & UserInputModule.User.gethin & " inches tall and you only weigh " & UserInputModule.User.getWeight() & " pounds." & vbCrLf & vbCrLf &
                       "Your waist measurement is " & UserInputModule.User.getWaist() & " inches. " & vbCrLf & vbCrLf &
                       "Your chest measurement is " & UserInputModule.User.getChest() & " inches. " & vbCrLf & vbCrLf &
                       "Your hips measurement is " & UserInputModule.User.getHips() & " inches. " & vbCrLf & vbCrLf &
                       "Your forearm measurement is " & UserInputModule.User.getForearm() & " inches. " & vbCrLf & vbCrLf &
                       "Your wrist measurement is " & UserInputModule.User.getWrist() & " inches.")
        Else
            bodyinfodes = ("You are " & UserInputModule.User.gethft & " feet And " & UserInputModule.User.gethin & " inches tall and you only weigh " & UserInputModule.User.getWeight() & " pounds." & vbCrLf & vbCrLf &
                       "Your waist measurement is " & UserInputModule.User.getWaist() & " inches. " & vbCrLf & vbCrLf &
                       "Your chest measurement is " & UserInputModule.User.getChest() & " inches.")
        End If


        UserInfoMessage.Text = (classifcation & addressinfo & bodyinfodes)
        BMItext.Text = ("Your calculated Body Mass Index is " & String.Format("{0:n2}", UserInputModule.User.getBMI()) & ", which classifies you as " & UserInputModule.User.getBMItext() & "!" & vbCrLf &
            "Your calculated Body Fat Percentage is " & String.Format("{0:n2}", UserInputModule.User.getBodyFat()) & ", which classifies you as " & UserInputModule.User.getBodyFattext() & "!")

        fs.WriteLine(UserInfoMessage.Text)
        fs.WriteLine(BMItext.Text)
    End Sub
End Class