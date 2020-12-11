using Microsoft.AspNetCore.Mvc;
using Scrabble.Models;


namespace Scrabble.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Input() { return View(); }  

        [Route("/output")]
        public ActionResult Output(string userInput, int score)
        {
            Word wordToScore = new Word(userInput);
            wordToScore.UserInput = userInput;
            wordToScore.Score = score;
            wordToScore.ScoreWord();
            return View(wordToScore);
        }   
    }
}