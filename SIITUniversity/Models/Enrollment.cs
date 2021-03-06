using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIITUniversity.Models
{
	public class Enrollment
	{
		public int EnrollmentID { get; set; }
		public int StudentId { get; set; }
		public int CourseId { get; set; }
		public Grade? Grade { get; set; }

		public virtual Student Student { get; set; }
		public virtual Course Course { get; set; }
	}

	public enum Grade 
	{
		A,B,C,D,F
	}
}