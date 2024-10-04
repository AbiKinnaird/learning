using System;

class BowlingScore
{
    public static int CalculateBowlingScore(string score)
    {
        //Set initial values 
        int totalScore = 0; 
        int round = 1; 

        for (int i = 0; i < score.Length && round <= 10; i++)
        {
            char current = score[i];
            
            if (current == 'X')  //Strike
            {
                totalScore += 10 + (score[i + 1] - '0') + (score[i + 2] - '0');
                round++; 
            }
            
            else if (current == '/') //Spare
            {
                totalScore += 10 - (score[i - 1] - '0') + (score[i + 1] - '0');
                round++; 
            }
           
            else  //Normal 
            {
                totalScore += (score[i] - '0');
                
                if (i + 1 < score.Length && score[i + 1] != '/')
                    round++; 
            }
        }
        return totalScore;
    }

    static void Main(string[] args)
    {
        string inputScore = "1/0025X345";
        int totalScore = CalculateBowlingScore(inputScore);
        Console.WriteLine($"Total score is {totalScore}");
    }
}




