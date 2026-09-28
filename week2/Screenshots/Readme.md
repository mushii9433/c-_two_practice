![Clrearing textbox](<Clearing textbox.jpeg>)


# Clear TextBox Project

## Description
This project demonstrates how to clear multiple TextBox controls in a C# Windows Forms application.

The program contains TextBox controls for:
- Day of the Week
- Name of the Month
- Numeric of the Month
- Year

A Clear button is used to remove all entered data from the TextBoxes.

## Code

```csharp
txtdayoftheweek.Clear();
txtnameofthemonth.Clear();
txtnumericof themonth.Clear();
txtyear.Clear();


![Explict convertion](<Explict convertion.jpeg>)

Explicit Conversion (Type Casting) using Parse Method
 
When you need to perform mathematical operations (like calculating dates or numbers), you must convert the text input into an integer. This is called Explicit Conversion or Type Casting.
 
Code Implementation
// Explicit conversion - type casting - using Parse method
numericofthmonth = int.Parse(txtnumericofthmonth.Text);
year = int.Parse(txtyear.Text);
 
Explanation
• int.Parse(txtnumericofthmonth.Text);: Takes the text from the month number TextBox and converts it into an integer, storing it in the variable numericofthmonth.
• int.Parse(txtyear.Text);: Takes the text from the year TextBox and converts it into an integer, storing it in the variable year. 
Why is this important?
 
Text (string) cannot be used for math. For example, "10" + "5" results in "105" (text concatenation), but 10 + 5 results in 15 (mathematical addition). Using int.Parse() ensures your data is treated as a number.⚠️ Warning: If the user types non-numeric characters (like "abc" or leaves the box empty), int.Parse() will throw a FormatException and crash the program. To prevent this, use int.TryParse() for safe conversion. 
 
🧹 Part 3: Clearing TextBox Controls (Bonus)
 
To clear all input fields and reset the form, you can use the .Clear() method on each TextBox.
 
Code Implementation
// Clear all TextBox controls
txtdayoftheweek.Clear();
txtnameofthemonth.Clear();
txtnumericofthmonth.Clear();
txtyear.Clear();
 
 
🛠️ Prerequisites
• Visual Studio (2019 or later recommended).
• .NET Framework or .NET Core/5/6+.
• Basic understanding of C# and Windows Forms. 
🚀 How to Use
1. Clone or download this repository.
2. Open the solution file (.sln) in Visual Studio.
3. Design your form with the required TextBoxes and a Button.
4. Double-click the Button to open the code-behind file.
5. Paste the code snippets provided above into the appropriate event handlers (e.g., btnSubmit_Click or btnClear_Click).
6. Run the application (Press F5).
7. Test entering data, converting it, and clearing it.



![Creating variable](<Creating variable.jpeg>) 
  
🧩 Part 1: Creating Variables to Store User Input
 
When working with Windows Forms, data entered into a TextBox is treated as a string (text). To use this data later in the program, we declare variables and assign the .Text property of the TextBoxes to them.
 
Code Implementation
// Creating variables to store user input
string firstname, secondname, thirdname, fullname;

firstname = txtfname.Text;
secondname = txtsname.Text;
thirdname = txtthirdname.Text;
 
Explanation
• string firstname, secondname, thirdname, fullname;: Declares four string variables.
• firstname = txtfname.Text;: Reads the text from txtfname and stores it in the firstname variable.
• secondname = txtsname.Text;: Reads the text from txtsname and stores it in the secondname variable.
• thirdname = txtthirdname.Text;: Reads the text from txtthirdname and stores it in the thirdname variable.‌💡 Note: The variable fullname is declared but not yet used. It could be used later to combine the three names, for example: fullname = firstname + " " + secondname + " " + thirdname;











