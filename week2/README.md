## this readme demonstrates the explanation of the codes which are in the screenshots.

# ![creating variables](<creating variables to store using input.png>)

This section demonstrates how to create string variables in C# Windows Forms to store information entered by the user through text boxes.

In this example, four string variables are declared:

* firstname: Stores the user’s first name.
* secondname: Stores the user’s second name.
* thirdname: Stores the user’s third name.
* fullname: Intended to store the user’s complete name.

The .Text property is used to retrieve the text entered by the user in each TextBox control and assign it to the corresponding variable.

How It Works

1. The user enters their first name, second name, and third name into the text boxes.
2. The program retrieves the entered values using the .Text property.
3. Each value is assigned to its corresponding string variable.
4. The variables can then be used for further processing, such as displaying the user’s information or combining the names into a full name.


# ![process-concat](<process concatination.png>)

This section demonstrates how to combine multiple string variables into a single string using the string concatenation operator (+) in C#.

In this example, the program combines the user’s first name, second name, and third name to create a complete name.

The + operator is used to join the strings together, while the " " string adds spaces between the names to ensure that the full name is displayed correctly.

The resulting value is assigned to the fullname variable.

How It Works

1. The program retrieves the names previously stored in the string variables.
2. The concatenation operator (+) joins the names together.
3. Spaces are inserted between the names for proper formatting.
4. The combined result is stored in the fullname variable.

# ![diplay output using label](<display output using label.png>)


This section demonstrates how to display information in a C# Windows Forms application using the Text property of a Label control.

In this example, the program assigns the value stored in the fullname variable to the Text property of a Label control named lpdisplay.

The Label control is used to present information to the user without requiring them to enter or modify the displayed text.

How It Works

1. The program retrieves the full name stored in the fullname variable.
2. The .Text property of the Label control is accessed.
3. The full name is assigned to the Label.
4. The Label displays the user’s full name on the Windows Forms interface.

# ![alt text](<Clearing textboxes.png>)


This section demonstrates how to clear the contents of multiple TextBox controls in a C# Windows Forms application using the Clear() method.

In this example, the Clear() method is used to remove the text entered by the user from several TextBox controls.

Each TextBox is cleared individually by calling its Clear() method.

This functionality is useful when creating a Clear or Reset button that allows users to remove previously entered information and start again.

How It Works

1. The user enters information into the TextBox controls.
2. The program calls the Clear() method for each TextBox.
3. All existing text is removed from the specified controls.
4. The TextBoxes become empty and ready for new input.


# ![clearing label](<Clearing label control.png>)

> this section shows how to clear labepl control

note: when you want to clear label control you can not use clear() funtion in c#. but you can use other two ways of clearing. 
> assigning empty string or
> empty.string
you can use these two ways when you want to clear label control.


# ![explicit conversion](<Explicit conversion.png>)

> This section demonstrates how to convert text entered by the user into integer values using the int.Parse() method in a C# Windows Forms application.

In this example, the program retrieves numeric values from TextBox controls and converts them from strings into integers.

The Text property returns the input as a string, even when the user enters numeric characters.

The int.Parse() method converts a valid numeric string into an integer (int), allowing the program to perform mathematical operations using the values.

How It Works

1. The user enters numeric values into the TextBox controls.
2. The .Text property retrieves the entered values as strings.
3. The int.Parse() method converts the strings into integer values.
4. The converted values are assigned to their corresponding integer variables.
5. The integer variables can then be used in calculations and other operations.