namespace LessonsBg.Core.Models
{
	public class AllTrainingsModel
	{
        public string TrainingTypeName { get; set; } = null!;

        public List<string> TrainingsOfTrainingTypeName { get; set; } = new List<string>();
    }
}
