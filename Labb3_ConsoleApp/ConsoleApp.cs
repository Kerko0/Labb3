using System.Diagnostics.Contracts;
using System.Diagnostics.Tracing;

namespace Labb3
{
    class ConsoleApp
    {
        static string helpMessage = "Use any of the following parameters:\r\n-lists\r\n-new <list name> <language 1> <language 2> .. <langauge n>\r\n-add <list name>\r\n-remove <list name> <language> <word 1> <word 2> .. <word n>\r\n-words <listname> <sortByLanguage>\r\n-count <listname>\r\n-practice <listname> \r\n-close\r\n";
        static bool appRunning = true;
        static void Main()
        {
            Console.Write(helpMessage);

            while (appRunning)
            {

                List<string> args = new List<string>();
                string userInput = Console.ReadLine();
                args = userInput.Split(' ').ToList();

                WordList wordList;
                if (args[0] == string.Empty)
                {
                    Console.Write(helpMessage);
                }
                else
                {
                    switch (args[0])
                    {
                        case "-lists":
                            string[] lists = WordList.GetLists();
                            foreach (string s in lists)
                            {
                                Console.WriteLine(s);
                            }
                            break;

                        case "-new":
                            string[] langs = args.Skip(2).ToArray();
                            wordList = new WordList(args[1], langs.ToArray());
                            wordList.Save();
                            break;

                        case "-add":
                            wordList = WordList.LoadList(args[1]);
                            List<string> translations = new List<string>();
                            string input;
                            bool adding = true;

                            while (adding)
                            {
                                foreach (string lang in wordList.Languages)
                                {
                                    Console.WriteLine($"Please write a word in {lang}");
                                    input = Console.ReadLine();

                                    if (input == string.Empty)
                                    {
                                        adding = false;
                                        break;
                                    }
                                    else
                                    {
                                        translations.Add(input);
                                    }

                                }

                                if (translations.Count > 0)
                                {
                                    wordList.Add(translations.ToArray());
                                    wordList.Save();
                                    translations.Clear();
                                }
                            }

                            break;

                        case "-remove":
                            wordList = WordList.LoadList(args[1]);
                            int selectedLanguage = Array.IndexOf(wordList.Languages, args[2]);
                            string[] wordsToRemove = args.Skip(3).ToArray();

                            foreach (string w in wordsToRemove)
                            {
                                if (wordList.Remove(selectedLanguage, w))
                                {
                                    Console.WriteLine("Word successfully removed.");
                                    wordList.Save();
                                }
                                else
                                {
                                    Console.WriteLine("Unable to remove word. Word may already be removed.");
                                }

                            }
                            break;

                        case "-count":
                            wordList = WordList.LoadList(args[1]);
                            Console.WriteLine(wordList.Count());
                            break;

                        case "-words":
                            wordList = WordList.LoadList(args[1]);
                            Action<string[]> print = x => x.ToList().ForEach(i => Console.WriteLine(i.ToString()));
                            int sortByLang;

                            try
                            {
                                sortByLang = Array.IndexOf(wordList.Languages, args[2]);
                            }
                            catch
                            {
                                sortByLang = 0;
                            }

                            wordList.List(sortByLang, print);
                            break;

                        case "-practice":

                            wordList = WordList.LoadList(args[1]);
                            Word word;
                            bool practicing = true;
                            bool correctAnswer;
                            string answer;

                            while (practicing)
                            {
                                correctAnswer = false;
                                word = wordList.GetWordToPractice();
                                Console.WriteLine($"Translate '{word.Translations[word.FromLanguage]}' from {wordList.Languages[word.FromLanguage]} to {wordList.Languages[word.ToLanguage]} ");
                                while (!correctAnswer)
                                {
                                    answer = Console.ReadLine().ToLower();

                                    if (answer == word.Translations[word.ToLanguage].ToLower())
                                    {
                                        Console.WriteLine("Correct!");
                                        correctAnswer = true;
                                    }
                                    else if (answer == string.Empty)
                                    {
                                        practicing = false;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Wrong answer. Try again.");
                                    }
                                }
                            }

                            break;

                        case "-close":
                            appRunning = false;
                            break;
                    }


                }
            }
        }


    }
}