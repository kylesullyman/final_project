using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace Cpsc370Final;

public class Start
{
    private string[] args;

    public bool isStartPhaseComplete = false;
    
    public string playerName;

    private ArrayList classList = new ArrayList();

    public string classInput; 

    private void StartScriptInit()
    {
        classList.Add("Warrior");
        classList.Add("Barbarian");
        classList.Add("Wizard");
        classList.Add("Assassin");
    }

    private string options = "abcd";
    
    public void BeginStartPhase()
    {
        StartScriptInit();
        
        //args = inputArgs;

        while (!isStartPhaseComplete)
        {
            Console.WriteLine("Welcome to the start phase of the game!");
            GetNameInput();
            GetClassInput();
            isStartPhaseComplete = true;
        }
    }

    private void GetClassInput()
    {
        while (true)
        {
            Console.WriteLine("Your options are: ");
            foreach(string s in classList)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Please select a class: ");
            string input = Console.ReadLine();
            
            // Capitalize first letter of input and lowercase the rest
            input = input.ToLower();
            char[] inputArray = input.ToCharArray();
            inputArray[0] = char.ToUpper(inputArray[0]);
            input = new string(inputArray);
            
            
            if (classList.Contains(input))
            {
                Console.WriteLine("You have selected: " + input);
                classInput = input;
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid class.");
                continue;
            }
        }
    }

    public void GetNameInput()
    {
        while (true)
        {   
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            if (name.Length < 1)
            {
                Console.WriteLine("Please enter a valid name.");
                continue;
            }
            
            playerName = name;
            
            break;
        }
    }
}