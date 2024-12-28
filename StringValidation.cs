public class BracketValidator
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach(char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            { stack.Push(c); }
        }
        else
        {
            if(stack.count==0) { return false; }
            char top = stack.Pop();

            if((char==')'&& top!='(')||(char=='}'&&top!='{')||(c==']'&&top!='['))
            {
                return false;
            }
        }
    }
    return stackalloc.count==0;
}


public class Program
{
    public static void Main(string[] args)
    {
        BracketValidator validator = new BracketValidator();
        string s = "(){}[]";
        Console.Writeline(validator.IsValid(s));
    }
}


//Algorithm
/*step 1 : Initialize an empty stack

step 2 : Loop through each character in the string

step 3 : if the character is an opening bracket (,{,[ push it onto the stack

step 4 : if the character is an closing bracket ),},] 
         check if the stack is empty,if yes return false(invalid)
         if the stack is not empty,pop top of the element and 
         check if it matches the expecting opening bracket

step 5 : After the loop,if the stack is empty,return true(valid). otherwise,return false(invalid).
*/