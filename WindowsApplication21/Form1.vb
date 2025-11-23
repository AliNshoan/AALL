Public Class Form1

    ' تعيين القيم داخل التكست بوكس عند تشغيل البرنامج
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "علي"
        TextBox2.Text = "نشوان"
        TextBox3.Text = "علي"
    End Sub

    ' الزر الأول: يعرض اسم الأب باستخدام Substring
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim father As String = TextBox2.Text.Trim()

        If father = "" Then
            TextBox4.Text = "اسم الأب غير موجود"
            Exit Sub
        End If

        ' استخدام Substring كما طلب الأستاذ
        Dim result As String = father.Substring(0, father.Length)

        TextBox4.Text = result
    End Sub

    ' الزر الثاني: إزالة اسم الجد باستخدام Remove
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim firstName As String = TextBox1.Text.Trim()
        Dim father As String = TextBox2.Text.Trim()
        Dim grand As String = TextBox3.Text.Trim()

        If grand = "" Then
            TextBox4.Text = "اسم الجد غير موجود"
            Exit Sub
        End If

        Dim fullName As String = firstName & " " & father & " " & grand

        Dim index As Integer = fullName.IndexOf(grand)

        If index <> -1 Then
            Dim result As String = fullName.Remove(index, grand.Length)
            TextBox4.Text = result.Trim()
        Else
            TextBox4.Text = "اسم الجد غير موجود داخل الاسم"
        End If
    End Sub

    ' الزر الثالث: إضافة اسم الابن باستخدام Insert
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim son As String = InputBox("أدخل اسم الابن:")
        If son.Trim() = "" Then Exit Sub

        Dim fullName As String = TextBox1.Text.Trim() & " " &
                                 TextBox2.Text.Trim() & " " &
                                 TextBox3.Text.Trim()

        Dim result As String = fullName.Insert(0, son & " ")

        TextBox4.Text = result
    End Sub

End Class


