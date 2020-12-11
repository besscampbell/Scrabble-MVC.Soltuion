using System.Collections.Generic;

namespace Scrabble.Models
{
    public class Word
    {
        public string UserInput { get; set; }
        public int Score { get; set; }
        public Word(string userInput)
        {
            UserInput = userInput;
            Score = 0;
        }

        public void ScoreWord()
        {
            var alphaScore = new Dictionary<string, int>(){
                {"a", 1},
                {"b", 3},
                {"c", 3},
                {"d", 2},
                {"e", 1},
                {"f", 4},
                {"g", 2},
                {"h", 4},
                {"i", 1},
                {"j", 8},
                {"k", 5},
                {"l", 1},
                {"m", 3},
                {"n", 1},
                {"o", 1},
                {"p", 3},
                {"q", 10},
                {"r", 1},
                {"s", 1},
                {"t", 1},
                {"u", 1},
                {"v", 4},
                {"w", 4},
                {"x", 8},
                {"y", 4},
                {"z", 10}
            };                                  

            for(int i = 0; i < UserInput.Length; i++) {
                char letter = UserInput[i];
                string stringLetter = letter.ToString();
                int returnedScore = alphaScore[stringLetter];
                Score += returnedScore;
            } 
        }
    }
}