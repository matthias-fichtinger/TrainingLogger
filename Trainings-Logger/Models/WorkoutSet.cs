using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Trainings_Logger.Models
{
    public class WorkoutSet
    {
        public int Id { get; set; }
        [Range(1,100)]
        public int Reps { get; set; }
        [Precision(6,2)]
        public decimal Weight { get; set; }
        public int WorkoutId { get; set; }
        public Workout? Workout { get; set; }
        public int ExerciseId { get; set; }
        public Exercise? Exercise { get; set; }
    }
}
