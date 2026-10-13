using System.ComponentModel.DataAnnotations;

namespace Trainings_Logger.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(50)]
        public string? MuscleGroup { get; set; }
        public bool IsBodyweight { get; set; }
        public List<WorkoutSet> Sets { get; set; } = new List<WorkoutSet>();
    }
}
