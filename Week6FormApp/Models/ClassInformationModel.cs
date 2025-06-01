using System.ComponentModel.DataAnnotations;

namespace Week5FormApp.Models
{
    public class ClassInformationModel
    {
        private static int _idCounter = 1;

        public ClassInformationModel()
        {
            Id = _idCounter++;
        }

        public int Id { get; private set; }

        [Required]
        public string? ClassName { get; set; }

        [Required]
        [Range(1, 1000)]
        public int StudentCount { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
