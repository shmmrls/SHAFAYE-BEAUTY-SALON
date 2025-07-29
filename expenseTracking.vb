Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

'FOR ADDING EXPENSE RECORD
'Admins can log expenses such As supply purchases, staff salaries, rent, Or utilities With Date, amount,
'And description.
Public Class expenseTracking
    Private connectionString As String = "Server=localhost;Database=final_shafaye_salon;Uid=salon_admin;Pwd=AdminSalon2025!;"
    Private Sub expenseTracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadExistingExpenses()
    End Sub

    Private Sub LoadExistingExpenses()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query = "SELECT DISTINCT expense_type FROM expenses ORDER BY expense_type"
                Using command As New MySqlCommand(query, connection)
                    Using reader = command.ExecuteReader()
                        cmbExistingExpense.Items.Clear()
                        While reader.Read()
                            cmbExistingExpense.Items.Add(reader("expense_type").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading expenses: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(expenseTypetxt.Text) OrElse
           String.IsNullOrWhiteSpace(txtAmount.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        Try
            Dim amount As Decimal
            If Not Decimal.TryParse(txtAmount.Text, amount) Then
                MessageBox.Show("Please enter a valid amount.")
                Return
            End If

            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query = "INSERT INTO expenses (expense_type, amount, description) VALUES (@type, @amount, @desc)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@type", expenseTypetxt.Text.Trim())
                    command.Parameters.AddWithValue("@amount", amount)
                    command.Parameters.AddWithValue("@desc", txtDescription.Text.Trim())

                    command.ExecuteNonQuery()
                    MessageBox.Show("Expense added successfully!")

                    expenseTypetxt.Clear()
                    txtDescription.Clear()
                    txtAmount.Clear()

                    LoadExistingExpenses()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding expense: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbExistingExpense_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExistingExpense.SelectedIndexChanged
        If cmbExistingExpense.SelectedItem IsNot Nothing Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query = "SELECT amount, description FROM expenses WHERE expense_type = @type LIMIT 1"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@type", cmbExistingExpense.SelectedItem.ToString())
                        Using reader = command.ExecuteReader()
                            If reader.Read() Then
                                amtTxtNewExpense.Text = reader("amount").ToString()
                                descriptionExistingExpense.Text = reader("description").ToString()
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading expense details: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If cmbExistingExpense.SelectedItem Is Nothing OrElse
           String.IsNullOrWhiteSpace(amtTxtNewExpense.Text) Then
            MessageBox.Show("Please select an expense and enter a valid amount.")
            Return
        End If

        Try
            Dim amount As Decimal
            If Not Decimal.TryParse(amtTxtNewExpense.Text, amount) Then
                MessageBox.Show("Please enter a valid amount.")
                Return
            End If

            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query = "UPDATE expenses SET amount = @amount, description = @desc WHERE expense_type = @type"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@amount", amount)
                    command.Parameters.AddWithValue("@desc", descriptionExistingExpense.Text.Trim())
                    command.Parameters.AddWithValue("@type", cmbExistingExpense.SelectedItem.ToString())

                    Dim rowsAffected = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Expense updated successfully!")
                    Else
                        MessageBox.Show("No expense was updated.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating expense: " & ex.Message)
        End Try
    End Sub

    Private Sub btnReportMonth_Click(sender As Object, e As EventArgs) Handles btnReportMonth.Click
        Dim currentMonth = DateTime.Now.ToString("MMMM yyyy")
        Dim fileName = $"ShaFaye_Monthly_Expense_Report_{DateTime.Now:MMM_yyyy}.pdf"
        GenerateExpenseReport(fileName, "Monthly", currentMonth)
    End Sub

    Private Sub btnReportAnnual_Click(sender As Object, e As EventArgs) Handles btnReportAnnual.Click
        Dim currentYear = DateTime.Now.Year.ToString()
        Dim fileName = $"ShaFaye_Annual_Expense_Report_{currentYear}.pdf"
        GenerateExpenseReport(fileName, "Annual", currentYear)
    End Sub

    Private Sub GenerateExpenseReport(fileName As String, reportType As String, period As String)
        Try
            Dim document As New Document(PageSize.A4, 50, 50, 50, 50)
            Dim writer = PdfWriter.GetInstance(document, New FileStream(fileName, FileMode.Create))
            document.Open()

            Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD)
            Dim headerFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD)
            Dim normalFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10)

            Dim title As New Paragraph("SHAFAYE BEAUTY SALON", titleFont)
            title.Alignment = Element.ALIGN_CENTER
            document.Add(title)

            Dim subtitle As New Paragraph($"{reportType} Expense Report - {period}", headerFont)
            subtitle.Alignment = Element.ALIGN_CENTER
            subtitle.SpacingAfter = 20
            document.Add(subtitle)

            Dim reportInfo As New Paragraph($"Generated on: {DateTime.Now:MMMM dd, yyyy}", normalFont)
            reportInfo.Alignment = Element.ALIGN_RIGHT
            reportInfo.SpacingAfter = 20
            document.Add(reportInfo)

            Dim table As New PdfPTable(3)
            table.WidthPercentage = 100
            table.SetWidths({40, 40, 20})

            Dim headerCell1 As New PdfPCell(New Phrase("Expense Type", headerFont))
            Dim headerCell2 As New PdfPCell(New Phrase("Description", headerFont))
            Dim headerCell3 As New PdfPCell(New Phrase("Amount (₱)", headerFont))

            headerCell1.BackgroundColor = BaseColor.LIGHT_GRAY
            headerCell2.BackgroundColor = BaseColor.LIGHT_GRAY
            headerCell3.BackgroundColor = BaseColor.LIGHT_GRAY
            headerCell1.Padding = 8
            headerCell2.Padding = 8
            headerCell3.Padding = 8

            table.AddCell(headerCell1)
            table.AddCell(headerCell2)
            table.AddCell(headerCell3)

            Dim totalExpenses As Decimal = 0
            Dim multiplier As Integer = If(reportType = "Annual", 12, 1)

            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query = "SELECT expense_type, description, amount FROM expenses ORDER BY expense_type"
                Using command As New MySqlCommand(query, connection)
                    Using reader = command.ExecuteReader()
                        While reader.Read()
                            Dim expenseAmount = Convert.ToDecimal(reader("amount")) * multiplier
                            totalExpenses += expenseAmount

                            table.AddCell(New PdfPCell(New Phrase(reader("expense_type").ToString(), normalFont)) With {.Padding = 5})
                            table.AddCell(New PdfPCell(New Phrase(reader("description").ToString(), normalFont)) With {.Padding = 5})
                            table.AddCell(New PdfPCell(New Phrase(expenseAmount.ToString("N2"), normalFont)) With {.Padding = 5, .HorizontalAlignment = Element.ALIGN_RIGHT})
                        End While
                    End Using
                End Using

                Dim salaryQuery = "SELECT SUM(salary) as total_salary FROM staff WHERE status = 'Active'"
                Using salaryCommand As New MySqlCommand(salaryQuery, connection)
                    Dim totalSalary = Convert.ToDecimal(salaryCommand.ExecuteScalar()) * multiplier
                    totalExpenses += totalSalary

                    table.AddCell(New PdfPCell(New Phrase("Staff Salaries", normalFont)) With {.Padding = 5})
                    table.AddCell(New PdfPCell(New Phrase("Total salaries for all active staff members", normalFont)) With {.Padding = 5})
                    table.AddCell(New PdfPCell(New Phrase(totalSalary.ToString("N2"), normalFont)) With {.Padding = 5, .HorizontalAlignment = Element.ALIGN_RIGHT})
                End Using
            End Using

            document.Add(table)

            Dim totalTable As New PdfPTable(3)
            totalTable.WidthPercentage = 100
            totalTable.SetWidths({40, 40, 20})
            totalTable.SpacingBefore = 10

            totalTable.AddCell(New PdfPCell(New Phrase("", normalFont)) With {.Border = 0})
            totalTable.AddCell(New PdfPCell(New Phrase("TOTAL EXPENSES:", headerFont)) With {.Border = 0, .HorizontalAlignment = Element.ALIGN_RIGHT})
            totalTable.AddCell(New PdfPCell(New Phrase($"₱{totalExpenses:N2}", headerFont)) With {.Border = Rectangle.TOP_BORDER, .HorizontalAlignment = Element.ALIGN_RIGHT, .Padding = 5})

            document.Add(totalTable)

            Dim footer As New Paragraph($"This report was generated automatically by ShaFaye Salon Management System.", normalFont)
            footer.Alignment = Element.ALIGN_CENTER
            footer.SpacingBefore = 30
            document.Add(footer)

            document.Close()
            MessageBox.Show($"Report generated successfully: {fileName}")

            Process.Start(fileName)

        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If cmbExistingExpense.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an expense to delete.")
            Return
        End If

        Dim selectedType As String = cmbExistingExpense.SelectedItem.ToString()

        Dim confirm = MessageBox.Show(
            $"Delete all records with expense type '{selectedType}'?",
            "Confirm Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirm <> DialogResult.Yes Then Return

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query = "DELETE FROM expenses WHERE expense_type = @type"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@type", selectedType)

                    Dim rowsAffected = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Expense(s) deleted successfully!")
                    Else
                        MessageBox.Show("No expense was deleted (nothing matched).")
                    End If
                End Using
            End Using

            cmbExistingExpense.SelectedIndex = -1
            amtTxtNewExpense.Clear()
            descriptionExistingExpense.Clear()

            LoadExistingExpenses()

        Catch ex As Exception
            MessageBox.Show("Error deleting expense: " & ex.Message)
        End Try
    End Sub

End Class