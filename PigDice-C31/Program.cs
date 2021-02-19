using System;

namespace PigDice_C31 {

    class Program {
    
        static int RollDie() {
            var rnd = new Random();
            return rnd.Next(1, 7);
        }
        static int PlayPigDice() {
            var score = 0;
            var roll = RollDie();
            while(roll != 1) {
                score += roll;
                roll = RollDie();
            }
            return score;
        }
        static void Main(string[] args) {
            var highScore = 400;
            long counter = 1;
            var score = PlayPigDice();
            while(score <= highScore) {
                score = PlayPigDice();
                counter++;
            }
            Console.WriteLine($"High score is {score} in {counter} games");
        }
    }
}
