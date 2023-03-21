using WorkoutGenerator.Data;
using WorkoutGenerator.Interfaces;
using WorkoutGeneratorApp.Data;

namespace WorkoutGenerator.Services
{
    public class BcFitWorkoutApp : IWorkoutApp
    {
        private readonly WorkoutDatabase workoutDatabase;

        public BcFitWorkoutApp()
        {
            workoutDatabase = new WorkoutDatabase();
        }

        public string GetRandomWorkout()
        {
            var workoutList = workoutDatabase.GetWorkouts();
            Random ran = new();
            var randomInt = ran.Next(workoutList.Count);
            return workoutList[randomInt].Description ;
        }
    }
}
