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

# Clear Explict convertion  Project

## Description
 explicit conversion-type casting-using parse method: This is a comment explaining that the code is performing an explicit conversion (also known as type casting) using the Parse method.
 numericofthmonth = int.Parse(txtnumericofthmonth.Text);:
	• txtnumericofthmonth.Text reads the text from the textbox where the user typed the month number.
	• int.Parse(...) takes that text and converts it into an integer (whole number). For example, if the user types "10", int.Parse turns it into the number 10 so it can be used for math.
	• The result is stored in the variable numericofthmonth.
   year = int.Parse(txtyear.Text);:
	• This does the same thing for the year. It reads the text from txtyear, converts it to an integer using int.Parse, and stores it in the variable year.



![Creating variable](<Creating variable.jpeg>) 
  
# Clear  Creating variableProject

## Description

creating variables to store using input: This is a comment explaining the purpose of the code below it.

string firstname, secondname, thirdname, fullname;: This declares four string variables to hold text. Note that fullname is declared but never used in the visible code.

 firstname = txtfname.Text;: It reads the text from the textbox named txtfname and stores it in the firstname variable.

secondname = txtsname.Text;: It reads the text from the textbox named txtsname and stores it in the secondname variable.

 thirdname = txtthirdname.Text;: It reads the text from the textbox named txtthirdname and stores it in the thirdname variable.













