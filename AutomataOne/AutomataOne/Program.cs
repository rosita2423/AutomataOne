// See https://aka.ms/new-console-template for more information
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");

string word = "";
string alphabet = "abc";
string currentState = "s0";
bool wordValidation = false;


Console.WriteLine("Insert the word for this automata.");

word = Console.ReadLine();
if (word == null)
{
    word = " ";
}

wordCheck(word);

for(int i= 0;i < word.Length; i++)
{
    if (currentState == "s0")
    {
        if (word[i] == 'a')
        {
            currentState = "s1";
            wordValidation = false;
        } else if (word[i] == 'b' || word[i] == 'c')
        {
            currentState = "s3";
            wordValidation = false;
        }


    } else if (currentState == "s1")
    {
        if (word[i] == 'c')
        {
            currentState = "s2";
            wordValidation = true;
        }
        else if (word[i] == 'a')
        {
            currentState = "s3";
            wordValidation = false;
        } else if (word[i] == 'b')
        {
            currentState = "s6";
            wordValidation = true;
        }
        
    } else if (currentState == "s2")
    {
        break;
    }else if(currentState == "s3")
    {
        if (word[i] == 'a')
        {
            currentState = "s5";
            
        }
        else if (word[i] == 'b' || word[i] == 'c')
        {
            currentState = "s3";
            
        }
        wordValidation = false;
    }else if (currentState == "s5")
    {
        if (word[i] == 'b')
        {
            currentState = "s6";
            wordValidation = true;
        }
        else if ( word[i] == 'c')
        {
            currentState = "s3";
            wordValidation = false;
        } else if (word[i] == 'a')
        {
            currentState = "s5";
            wordValidation = false;
        }
        
    }else if (currentState == "s6")
    {
        if (word[i] == 'a')
        {
            currentState = "s5";
            
        }
        else if (word[i] == 'b' || word[i] == 'c')
        {
            currentState = "s3";
            
        }
        wordValidation = false;
    }
}

if (wordValidation)
{
    Console.WriteLine("Your word is valid. Nice work :)");
}
else
{
    Console.WriteLine("Your word is not valid :(");
}


Console.WriteLine("Nice");

void wordCheck(string word){
    for(int i = 0; i < word.Length; i++) {
        if (!alphabet.Contains(word[i])){
            Console.WriteLine("The word is invalid. It has one or more symbols that doesn't belong to the alphabet.");
            Environment.Exit(0);
        }
        
    }

}