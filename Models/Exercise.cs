using System.ComponentModel.DataAnnotations;

namespace Gym.Models
{
    public class Exercise
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength (30)]
        public string MuscleGroup { get; set; }
        [Required]
        [MaxLength(30)]
        public string ExerciseName { get; set; } 
    }
}
