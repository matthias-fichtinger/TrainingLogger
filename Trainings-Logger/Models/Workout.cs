using System.ComponentModel.DataAnnotations;

namespace Trainings_Logger.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Today;
        [MaxLength(200)]
        public string? Note { get; set; }
        public List<WorkoutSet> Sets { get; set; } = new List<WorkoutSet>();
    }
}
