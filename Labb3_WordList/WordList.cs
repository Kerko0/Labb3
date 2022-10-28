using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Labb3
{
    public class WordList
    {
        public string Name { get; }
        public string[] Languages { get; }

        private List<Word> words = new List<Word>();
        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }

        public static string[] GetLists()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string[] files = Directory.GetFiles(filePath).Where(x => x.Contains(".dat")).ToArray();
            List<string> fileNameNoExtension = new List<string>();

            foreach (string file in files)
            {
                fileNameNoExtension.Add(Path.GetFileName(file.Replace(".dat", "")));
            }

            return fileNameNoExtension.ToArray();

        }

        public Word[] GetWords()
        {
            return words.ToArray();
        }

        public static WordList LoadList(string name)
        {
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), name + ".dat");
            var lines = File.ReadLines(fileName);
            string[] loadedLanguages = lines.First().ToString().Split(';').Where(x => x != string.Empty).ToArray();
            string[] loadedWords = lines.Skip(1).ToArray();

            WordList wordList = new WordList(name, loadedLanguages);

            foreach (string word in loadedWords)
            {
                wordList.Add(word.Split(';'));
            }

            return wordList;
        }

        public static void DeleteList(string name)
        {
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), name + ".dat");

            File.Delete(fileName);
        }
        public void Save()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Name + ".dat");
            using StreamWriter file = new(path, append: false);

            foreach (string lang in Languages)
            {
                if (lang != string.Empty)
                {
                    file.Write(lang.ToLower() + ";");
                }

            }

            file.WriteLine("");

            foreach (Word word in words)
            {
                for (int i = 0; i < Languages.Length; i++)
                {
                    file.Write(word.Translations[i] + ";");
                }

                file.WriteLine("");
            }

        }

        public void Add(params string[] translations)
        {
            if (translations == null)
            {
                return;
            }

            string[] fixedTranslations = translations.Where(x => x != string.Empty).ToArray();
            if (fixedTranslations.Length != Languages.Length)
            {
                throw new ArgumentException("Not enough translations.");
            }
            else
            {
                words.Add(new Word(fixedTranslations));
            }

        }

        public bool Remove(int translation, string word)
        {
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Translations[translation] == word)
                {
                    words.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public int Count()
        {
            return words.Count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            List<string> sortedDisplayList = new List<string>();

            int[] langIndex = new int[Languages.Length];
            for (int i = 0; i < Languages.Length; i++)
            {
                langIndex[i] = i;
            }

            int newIndexSpot = Array.IndexOf(langIndex, sortByTranslation);
            langIndex[0] = Array.IndexOf(langIndex, sortByTranslation);
            langIndex[newIndexSpot] = 0;

            for (int i = 0; i < langIndex.Length; i++)
            {
                for (int j = 0; j < words.Count; j++)
                {
                    sortedDisplayList.Add(words[j].Translations[langIndex[i]]);
                }

                sortedDisplayList.Add(" ");
            }

            showTranslations(sortedDisplayList.ToArray());
        }

        public Word GetWordToPractice()
        {
            Random rand = new Random();
            int fromLanguage = rand.Next(0, Languages.Length);
            int toLanguage = rand.Next(0, Languages.Length);
            int randomWord = rand.Next(0, words.Count);

            while (fromLanguage == toLanguage)
            {
                fromLanguage = rand.Next(0, Languages.Length);
            }

            string[] wordsToPractice = new string[Languages.Length];
            wordsToPractice[fromLanguage] = words[randomWord].Translations[fromLanguage];
            wordsToPractice[toLanguage] = words[randomWord].Translations[toLanguage];

            return new Word(fromLanguage, toLanguage, wordsToPractice);
        }


    }


}
