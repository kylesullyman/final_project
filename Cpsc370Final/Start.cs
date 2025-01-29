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
    
    public void BeginStartPhase(string[] inputArgs)
    {
        StartScriptInit();
        
        args = inputArgs;

        while (!isStartPhaseComplete)
        {
            Console.WriteLine("Welcome to the start phase of the game!");
            GetNameInput();
            GetClassInput();
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
            playerName = name;
            if (playerName == null)
            {
                Console.WriteLine("Please enter a valid name.");
                continue;
            }
            break;
        }
    }
}