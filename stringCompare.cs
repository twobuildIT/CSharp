using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class stringCompare
{
	public stringCompare()
	{
	}

        private string oneStr, twoStr;


    private string getString()
    {
        string userString;
        Console.WriteLine("Please enter text");
        userString = Convert.ToString(Console.ReadLine());
        return userString;

    }

    private void setStrings()
    {
        oneStr = getString();
        twoStr = getString();

    }

    public void strCompare()
    {
        if (String.Compare(oneStr, twoStr) == 0)
        {
            Console.WriteLine("Values entered are the same");
        }
        else
        {
            Console.WriteLine("String values are not the same");
        }
    }

    public void strExecute()
    {
        setStrings();
        strCompare();
    }


}







