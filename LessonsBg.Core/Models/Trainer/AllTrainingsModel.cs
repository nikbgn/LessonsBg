namespace LessonsBg.Core.Models.Trainer
{
    public class AllTrainingsModel
    {
        public string TrainingTypeName { get; set; } = null!;

        public List<string> TrainingsOfTrainingTypeName { get; set; } = new List<string>();
    }
}
