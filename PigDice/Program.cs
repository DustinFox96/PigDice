using System;

// keep on running till you get a score greater than what ever value we put in.
namespace PigDice {
    class Program {
        static int RollDie() {
            var rnd = new Random();
            return rnd.Next(1, 7);
        }
        static int PlayPigDice() {
            var score = 0;
            var roll = RollDie();
            while (roll != 1) {
                score += roll;
                roll = RollDie();
            }
            return score;
        }
        static void Main(string[] args) {
            var highScore = 300;  // here is where you would change the highScore, it would keep running till it beats that score.
            long counter = 0;
            var score = PlayPigDice();
            while (score < highScore) {
                score = PlayPigDice();
                counter++;
            }
               
            Console.WriteLine($"High score is {score} in {counter} games");
            
                

            

            




        }
    }
}



// complex version to play muliple games at once and then display the highest score 
//namespace PigDice {
//    class Program {
//        static int RollDie() {
//            var rnd = new Random();
//            return rnd.Next(1, 7);
//        }
//        static int PlayPigDice() {
//            var score = 0;
//            var roll = RollDie();
//            while (roll != 1) {
//                score += roll;
//                roll = RollDie();
//            }
//            return score;
//        }
//        static void Main(string[] args) {
//            var highScore = 0;
//            for (var idx = 0; idx < 100000; idx++) {  // where idx is < a value is where we can choose how many games are played.
//                var score = PlayPigDice();
//                if (score > highScore) {
//                    highScore = score;
//                }

//            }
//            Console.WriteLine($"High score is {highScore}");




//        }
//    }
//}












// simple version 

//namespace PigDice {
//    class Program {
//        static int RollDie() {
//            var rnd = new Random();
//            return rnd.Next(1, 7);
//        }
//        static int PlayPigDice() {
//            var score = 0;
//            var roll = RollDie();
//            while (roll != 1) {
//                score += roll;
//                roll = RollDie();
//            }
//            return score;
//        }
//        static void Main(string[] args) {
//            var score = PlayPigDice();
//            Console.WriteLine($"score is {score}");




//        }
//    }
//}
