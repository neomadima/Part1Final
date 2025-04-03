
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Part1EG3
{
    class Program
    {

        class CyberSecurityAssistant
        {
            class Program
            {
                static void Main()
                {
                    // Set the console  title and rext color 
                    Console.Title = "CyberSecurity Assistant";
                    Console.ForegroundColor = ConsoleColor.White;

                    // Display ASCII art banner
                    DisplayAsciiArt();

                    //Playing the voice greeting 
                    Console.WriteLine("Intiating the chatBot");


                    // Ask the user for their name  
                    Console.Write("Please enter your name: ");
                    string userName = Console.ReadLine();

                    // Default to user if the user didn't enter the name
                    if (string.IsNullOrEmpty(userName))
                    {
                        userName = "User";
                    }

                    // Clear the screen and display the welcome message
                    Console.Clear();
                    WelcomeMessage(userName);

                    // Chat loop: keep asking questions until the user type 
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("\nAsk questions or 'exit' to quit: ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        string userInput = Console.ReadLine();

                        if (string.IsNullOrEmpty(userInput))
                        {
                            DisplayResponse("Please enter a valid question.");
                            continue;
                        }
                        if (userInput.ToLower() == "exit")
                        {
                            DisplayResponse("Goodbye! Stay safe.");
                            break;
                        }

                        ProcessUserInput(userInput.ToLower(), userName);
                    }
                }

                //  Method to play a greeting sound
                static void PlayVoiceGreeting()
                {
                    try
                    {
                        using (SoundPlayer player = new SoundPlayer("Greeting.wav"))
                        {
                            player.PlaySync(); // play the greeting sound
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro playing greeting:  " + ex.Message);
                    }
                }


                // Method to display the chatbot's ASCII logo
                static void DisplayAsciiArt()
                {
                    Console.WriteLine("########################");
                    Console.WriteLine("   Cyber Security Bot  ");
                    Console.WriteLine("########################");
                    Console.WriteLine("\nWelcome to the CyberSecurity ChatBot!");
                }

                // Method to welcome the user and introduce chatbot capabilities  
                static void WelcomeMessage(string userName)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine($"Hello {userName}! I'm your assistant. Let's start with a few questions.");

                    // Ask the user how they are feeling
                    Console.WriteLine("How are you today?");
                    string userMood = Console.ReadLine();
                    Console.WriteLine($"You said you're feeling: {userMood}. That's great! I'm here to help.");

                    // Ask the user what they want to learn about
                    Console.WriteLine("What's your purpose today? (e.g., Learn about cybersecurity, Ask a question, etc.)");
                    string userPurpose = Console.ReadLine();
                    Console.WriteLine($"Got it! Your purpose today is: {userPurpose}. I'll do my best to assist you with that.");

                    //Ask the user what they want to learn about
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Hello {userName}! I am ready to assistant with.");
                    Console.WriteLine("I can help you with cybersecurity tips like: ");
                    Console.WriteLine("-- Password Security");
                    Console.WriteLine("-- Phishing Attacks");
                    Console.WriteLine("-- Safe Browsing");
                    Console.WriteLine(" _______________________");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                // Method to process user input and respond accordingly
                static void ProcessUserInput(string input, string userName)
                {
                    switch (input)
                    {
                        case "how are you":
                            DisplayResponse($"I am just a bot, {userName}, but I'm always ready to help you stay safe.");
                            break;

                        case "what's your purpose":
                            DisplayResponse("My purpose is to make sure that you are safe and assist you with cybersecurity practices.");
                            break;

                        case "what can i ask you about":
                            DisplayResponse("You can ask me about:\n" +
                                "- Password security\n" +
                                "- Phishing Attacks\n" +
                                "- Safe browsing");
                            break;

                        case "password security":
                            DisplayResponse("Password security Tips: \n" +
                                "- Use long, complex passwords (8+ characters)\n" +
                                "- Enable Two-Factor Authentication\n" +
                                "- Use a password manager\n" +
                                "- Never reuse passwords across different sites.");
                            break;

                        case "phishing attacks":
                            DisplayResponse("Phishing Awareness: \n" +
                                "- Be cautious of emails you receive without requesting them.\n" +
                                "- Never click on suspicious links.\n" +
                                "- Verify sender details before sharing.\n" +
                                "- Use software or built-in email features to sort, block, or manage emails automatically.");
                            break;

                        case "safe browsing":
                            DisplayResponse("Safe Browsing Tips:\n" +
                                "- Always check the website URL for HTTPS.\n" +
                                "- Avoid clicking unknown pop-ups.\n" +
                                "- Use an ad-blocker and antivirus software.\n" +
                                "- Keep your browser updated.");
                            break;

                        default:
                            DisplayResponse("I didn't quite understand that. Could you rephrase?");
                            break;
                    }
                }
                //  // Method to display chatbot responses with typing effect
                static void DisplayResponse(string message)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\n--");
                    foreach (char c in message)
                    {
                        Console.Write(c);
                        Thread.Sleep(20);
                    }
                    Console.WriteLine("\n-------------------n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}

