using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [Required]
        [Display(Name ="Last Name")]   // lenh doi ten hien thi tren trinh duyet
        public string LastName { get; set; }

        [StringLength(50)]
        [Column("FirstName")]  // lenh doi ten cot trong csdl
        [Display(Name = "First Name")]
        [Required]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName   // lenh ghep giua lastname&Firstname => chi hien thi tren browser
                                 // nhung khong them vao csdl because chi co method GET
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public ICollection<Enrollment> Enrollments { get; set; }  // lệnh ánh xạ từ bảng cha xuống bản con
    }
}