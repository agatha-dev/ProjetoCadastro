using System;


public class Class1
{
	public Class1 Aluno
	{
		public int Id {get, set; }
		public string LastName { get, set; }
		public string FirstMidName { get, set; }
		[DataType(DataType.Date)]
		[DataFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true )]
		public DataTime EnrollmentDate { get, set; }

	}
}
