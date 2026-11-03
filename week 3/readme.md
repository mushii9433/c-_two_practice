Table of Contents
 4.1 Decision Structures and the if Statement
 4.2 The if_else Statement
 4.3 Nested Decision Structures
 4.4 Logical Operators
 4.5 bool Variables and Flags
 4.6 Comparing Strings
 4.7 Preventing Data Conversion Exceptions with the tryparse Method
 4.8 Input Validation
 4.9 Radio Buttons and Check Boxes
 4.10 The switch Statement
 4.11 Introduction to List Boxes
4.1 Decision Structures and the if Statement
 Control Structure: A logical design that controls the order in which statements execute in a program.
 Sequence Structure: A set of statements that execute in the exact order in which they appear, one after another.
 Decision Structure: Executes statements only under specific circumstances (also known as a Selection Structure).
 Single-Alternative Decision Structure: Provides only one alternative path of execution. If the expression is  true, the path is executed; if it is false,  the path is skipped.
Relational Operators
Relational operators determine whether a specific relationship exists between two values, returning a true or falseBoolean result:
 >: Greater than
 <: Less than
 >=: Greater than or equal to
 <= : Less than or equal to
 ==: Equal to
 != : Not equal to
4.2 The ⁠if-else⁠ Statement
 Dual-Alternative Execution: Provides two separate branches or execution paths.
 If the Boolean expression evaluates to ⁠true⁠, the statements in the ⁠if⁠ block are executed.
 If the Boolean expression evaluates to ⁠false⁠, the statements in the ⁠else⁠ block are executed.
4.3 Nested Decision Structures
 Nested Structures: Occurs when an ⁠if⁠ statement is written inside another ⁠if⁠ or ⁠else⁠ clause. It is used to test multiple conditions sequentially.
 ⁠if-else-if⁠ Statement: Used to test a series of conditions in a cleaner, more readable format when evaluating multiple alternatives.
4.4 Logical Operators
Logical operators are used to combine multiple Boolean expressions or reverse truth values:
 ⁠&&⁠ (Logical AND): Both expressions must be ⁠true⁠ for the compound expression to evaluate to ⁠true⁠.
 ⁠||⁠ (Logical OR): At least one of the expressions must be ⁠true⁠ for the compound expression to evaluate to ⁠true⁠.
 ⁠!⁠ (Logical NOT): Negates (reverses) the truth value of a Boolean expression.
4.5 ⁠bool⁠ Variables and Flags
 ⁠bool⁠ Data Type: Holds one of two binary values: ⁠true⁠ or ⁠false⁠.
 Flag: A ⁠bool⁠ variable used to signal or indicate whether a specific condition exists within a program.
4.6 Comparing Strings
String comparison can be performed using the following approaches:
1. Relational Operators: Used to check for exact equality (⁠==⁠) or inequality (⁠!=⁠) between strings or string literals.
2. ⁠String.Compare⁠ Method: Compares two strings based on their alphabetical sorting order.
4.7 Preventing Data Conversion Exceptions with the ⁠TryParse⁠ Method
When reading text from user inputs like a ⁠TextBox⁠, data is retrieved as a string. Converting string inputs directly to numbers can cause runtime exceptions if invalid characters are entered.
The ⁠TryParse⁠ family of methods prevents these exceptions:
 Checks whether the input string can be successfully converted to the target numeric data type.
 Returns ⁠true⁠ if the conversion succeeds and assigns the parsed value to an output variable.
 Returns ⁠false⁠ if the conversion fails, allowing the program to handle errors gracefully without crashing.
4.8 Input Validation
Input Validation: The process of inspecting input data to ensure it is valid, reasonable, and correct before it is processed or used in calculations.
It combines methods like ⁠TryParse⁠ with decision structures to inspect inputs and maintain logical data integrity (such as verifying range bounds).
4.9 Radio Buttons and Check Boxes
 Radio Buttons (⁠RadioButton⁠):
 Used for mutually exclusive selections where the user can pick only one option from a group.
 Check Boxes (⁠CheckBox⁠):
 Used for independent options where the user can select zero, one, or multiple items.
 ⁠Checked⁠ Property: A Boolean property present on both controls that reflects whether the item is currently selected (⁠true⁠) or deselected (⁠false⁠).
4.10 The ⁠switch⁠ Statement
A multiple-alternative decision structure that evaluates the value of a single variable or expression against multiple matching cases, serving as a cleaner alternative to a long ⁠if-else-if⁠ chain.
4.11 Introduction to List Boxes
ListBox Control: Displays a scrollable list of items from which a user can select one or more entries.
Key Properties and Methods:
 ⁠Items.Add⁠: Appends a new item to the ListBox collection.
 ⁠SelectedIndex⁠: Gets or sets the zero-based index of the selected item. Returns ⁠-1⁠ if no item is selected.
 ⁠SelectedItem⁠: Gets or sets the currently selected item object from the list.
 ⁠Items.Clear⁠: Removes all items currently stored in the ListBox.