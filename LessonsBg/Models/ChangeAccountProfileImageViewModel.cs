namespace LessonsBg.Models
{
	using System.ComponentModel.DataAnnotations;


	public class ChangeAccountProfileImageViewModel
	{
		[Required(ErrorMessage = "Попълването на това поле е задължително!")]
		[Url(ErrorMessage = "Моля въведете валиден URL адрес!")]
		[DataType(DataType.Url)]
		[Display(Name = "URL адрес на новата Ви профилна снимка.")]
		public string NewImage { get; set; }
	}
}
