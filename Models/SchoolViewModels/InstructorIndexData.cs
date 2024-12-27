using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models.SchoolViewModels
{
	public class InstructorIndexData
	{
		public IEnumerable<Instructor> Instructors { get; set; }
		public IEnumerable<Course> Courses { get; set; }
		public IEnumerable<Enrollment> Enrollments { get; set; }
	}
}


// trang dùng để thu thập dữ liệu của 3 bảng thành 1 bảng ảo 
