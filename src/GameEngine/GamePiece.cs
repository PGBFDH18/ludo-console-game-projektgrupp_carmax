using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class GamePiece
    {
        int StepsToGoal = 40;

        public string RemoveStepsToGoal(int steps)
        {
            var remainingSteps = StepsToGoal - steps;
            return remainingSteps.ToString();
        }
    }
}
