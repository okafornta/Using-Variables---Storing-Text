/* TASK: 
 * 
 *  Creating a variable named message. Afterward, I will store some text in it. Finally,
    I will display the value of the variable to the user.
 */

// Declaration of a variable to store text
string message;

// Storing a value in prepared variable(assignment statement)
message = "Hello! Hillary How are you Today";

// Another variable (initialized with some value)
string anotherMessage = @"Hillary, I forgot to ask you yesterday
Where do you work now?";

// Output of the variables
Console.WriteLine(message);
Console.WriteLine(anotherMessage);

// Waiting for Enter
Console.ReadLine();

/* DISCUSSION: Now let’s discuss the solution.
 * 
 * VARIABLE DECLARATION:
 * 
    If you want to use a variable, you need to declare (create) it first.
    The general syntax of a variable declaration statement is as follows:
    typeName[space]variableName[semicolon].
    In this case, it reads as follows:
    string message;
    The type denotes the category of values that you want to store in the variable. In this
    case, you want to store text, which is why you used the type called string.
    
    ALTERNATIVE:

    There is an alternative way to write a variable declaration statement. In front of the
    semicolon, you can use an equal sign and the initial value of the variable.
    Here is an example of this syntax:
    string anotherMessage = @"Hillary, I forgot to ask you yesterday
                            Where do you work now?";
    
    ASSIGNMENT STATEMENT: 

    There is one more thing in the code that needs to be explained. The second statement is
    as follows:
    message = "Hello! Hillary How are you Today"

    This stores a value (the text "Hello! Hillary How are you Today") in the prepared variable (message),
    and it is called an assignment statement. You use it whenever you want to store something.
    The general syntax of the assignment statement is as follows:
    WHERE (TO STORE) = WHAT (TO STORE);
 */ 