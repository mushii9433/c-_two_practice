![Desision structure](<Desision structure.jpeg>)
Description
Graphical User Interface controls for user input choices:
 Radio Buttons (⁠RadioButton⁠): Allow users to select one option from a group. Selecting one choice automatically deselects all other radio buttons in the same group (mutually exclusive).
 Check Boxes (⁠CheckBox⁠): Allow users to make non-exclusive choices (selecting multiple options simultaneously or leaving them all unselected).
 ⁠Checked⁠ Property & ⁠CheckedChanged⁠ Event: Both controls use the Boolean ⁠Checked⁠ property to detect selection states and fire a ⁠CheckedChanged⁠ event whenever the selection state changes.
The Switch Statement
Description
A clean, multi-alternative selection structure:
 Execution Choice: Evaluates a single test expression (integer, string, or boolean) against multiple discrete ⁠case⁠ values.
 Structure: Executes matching statements until encountering a ⁠break⁠ statement. An optional ⁠default⁠ case executes when no case matches the test expression.
Introduction to List Boxes
Description
A ⁠ListBox⁠ control displays a selectable list of items to the user:
 Key Properties: ⁠Items⁠ (contains list items), ⁠Items.Count⁠ (total item count), ⁠SelectedItem⁠ (currently selected object), and ⁠SelectedIndex⁠ (zero-based index of selected item; returns ⁠-1⁠ if no item is selected).
 Key Methods: ⁠Items.Add()⁠ (appends items), ⁠Items.Remove()⁠ (removes a specific item value), ⁠Items.RemoveAt()⁠ (removes an item by index), and ⁠Items.Clear()⁠ (empties the list).


 ![simple](<simple.jpeg>)
The If-Else Statement
Description
An ⁠if-else⁠ statement provides a dual-alternative execution structure:
 Dual Paths: Executes one block of statements if its Boolean expression evaluates to ⁠true⁠, or an alternative block if the expression evaluates to ⁠false⁠.
 Clause Division: Contains two distinct sections—an ⁠if⁠ clause executed when the expression is true, and an ⁠else⁠ clause executed when the expression is false.
Nested Decision Structures & If-Else-If
Description
Multi-stage decision processes rely on nested logic or multi-alternative branches:
 Nested Structures: Formed when an ⁠if⁠ or ⁠else⁠ statement contains another inner decision structure to test multiple sequential conditions.
 If-Else-If Statement: Simplifies testing multiple mutually exclusive conditions in a cleaner, readable format compared to deeply nested ⁠if⁠ statements.
Logical Operators
Description
Logical operators combine or negate multiple Boolean expressions to build complex conditions:
 ⁠&&⁠ (Logical AND): Returns ⁠true⁠ only when both sub-expressions evaluate to ⁠true⁠.
 ⁠||⁠ (Logical OR): Returns ⁠true⁠ if at least one sub-expression evaluates to ⁠true⁠.
 ⁠!⁠ (Logical NOT): Negates or reverses the truth value of a Boolean expression (turns ⁠true⁠ into ⁠false⁠ and vice versa).
Bool Variables and Flags
Description
Boolean variables store truth values and serve as status indicators:
 ⁠bool⁠ Data Type: Holds only two binary states—⁠true⁠ or ⁠false⁠.
 Flags: A ⁠bool⁠ variable used as a signal within a program to indicate whether a specific state or condition exists (⁠true⁠ indicates presence, ⁠false⁠ indicates absence).
Comparing Strings
Description
Methods and operators used to evaluate text comparisons:
 Equality Operators: Operators ⁠==⁠ and ⁠!=⁠ compare string contents directly against other string variables or literals.
 ⁠String.Compare⁠ Method: Compares two strings based on alphabetical and lexicographical order, returning ⁠0⁠ when both strings are identical.
Preventing Data Conversion Exceptions with TryParse
Description
Safely converting string input into numeric types without runtime crashes:
 Exception Prevention: Avoids application failures caused by users entering non-numeric characters into text fields.
 ⁠TryParse⁠ Methods: Available for data types like ⁠int.TryParse⁠, ⁠double.TryParse⁠, and ⁠decimal.TryParse⁠. Returns ⁠true⁠ if parsing succeeds and ⁠false⁠ if it fails, outputting the converted value safely via an ⁠out⁠ variable parameter.
Input Validation
Description
Inspecting input data prior to program processing to ensure accuracy and logical integrity:
 Integrity vs Syntax: While ⁠TryParse⁠ checks whether an input is a valid number syntax, input validation checks if the numeric value lies within logical constraints (e.g., verifying test scores fall between 0 and 100).
 Validation Logic: Uses conditional statements (⁠if⁠) to prevent illogical data from entering computational logic.
Radio Buttons and Check