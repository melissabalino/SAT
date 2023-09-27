using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF.Models//.Metadata
{
    //internal class Metadata
    //{
    //}

    #region Course
    public class CourseMetadata
    {
        
        public int CourseId { get; set; }

        [Required(ErrorMessage = "*Course Name is Required.*")]
        [StringLength(50, ErrorMessage = "*Must be 50 characters or less.*")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; } = null!;

        [Required(ErrorMessage = "*Course Description is Required.*")]
        [StringLength(50)]
        [Display(Name = "Course Description")]
        [DataType(DataType.MultilineText)]
        public string CourseDescription { get; set; } = null!;

        [Required(ErrorMessage = "*Credit Hours are Required.*")]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }

        [StringLength(250, ErrorMessage = "*Must be 250 characters or less.*")]
        public string? Curriculum { get; set; }

        [StringLength(500, ErrorMessage = "*Must be 500 characters or less.*")]
        [DataType(DataType.MultilineText)]
        public string? Notes { get; set; }

        [Display(Name = "Active?")]
        public bool IsActive { get; set; }
    }
    #endregion

    #region Enrollment
    public class EnrollmentMetadata
    {
        public int EnrollmentId { get; set; }

        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Display(Name = "Scheduled Class ID")]
        public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "*Enrollment Date is Required.*")]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
    }
    #endregion

    #region ScheduledClass
    public class ScheduledClassMetadata
    {
        public int ScheduledClassesId { get; set; }

        [Display(Name = "Course ID")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "*Start Date is Required.*")]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "*End Date is Required.*")]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }


        [Required(ErrorMessage = "*Instructor Name is Required.*")]
        [StringLength(40, ErrorMessage = "*Must be less than 40 characters.*")]
        [Display(Name = "Instructor Name")]
        public string InstructorName { get; set; } = null!;

        [Required(ErrorMessage = "*Location is Required.*")]
        [StringLength(20, ErrorMessage = "*Must be less than 20 characters.*")]
        public string Location { get; set; } = null!;

        [Display(Name = "Scheduled Class Statuses ID")]
        public int Scsid { get; set; }
    }
    #endregion

    #region ScheduledClassStatus
    public class ScheduledClassStatusMetadata
    {
        public int Scsid { get; set; }

        [Required(ErrorMessage = "*Scheduled Class Status Name is Required.*")]
        [StringLength(50, ErrorMessage = "*Must be less than 50 characters.*")]
        public string Scsname { get; set; } = null!;
    }
    #endregion

    #region Student
    public class StudentMetadata
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "*First Name is Required.*")]
        [StringLength(20, ErrorMessage = "*Must be 20 characters or less.*")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "*Last Name is Required.*")]
        [StringLength(20, ErrorMessage = "*Must be 20 characters or less.*")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [StringLength(15, ErrorMessage = "*Must be 15 characters or less.*")]
        [Display(Name = "Major")]
        public string? Major { get; set; }

        [StringLength(50, ErrorMessage = "*Must be 50 characters or less.*")]
        [Display(Name = "Address")]
        public string? Address { get; set; }

        [StringLength(25, ErrorMessage = "*Must be 25 characters or less.*")]
        [Display(Name = "City")]
        public string? City { get; set; }

        [StringLength(2, ErrorMessage = "*Must be 2 characters or less.*")]
        [Display(Name = "State")]
        public string? State { get; set; }

        [StringLength(10, ErrorMessage = "*Must be 10 characters or less.*")]
        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode)]
        public string? ZipCode { get; set; }

        [StringLength(13, ErrorMessage = "*Must be 13 characters or less.*")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "*Email is Required.*")]
        [StringLength(60, ErrorMessage = "*Must be 60 characters or less.*")]
        public string Email { get; set; } = null!;

        [StringLength(100, ErrorMessage = "*Must be 100 characters or less.*")]
        public string? PhotoUrl { get; set; }

        [Display(Name = "Student Status ID")]
        public int Ssid { get; set; }
    }
    #endregion

    #region StudentStatus
    public class StudentStatusMetadata
    {
        public int Ssid { get; set; }

        [Required(ErrorMessage = "*Student Status is Required.*")]
        [Display(Name = "Student Status")]
        public string Ssname { get; set; } = null!;

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string? Ssdescription { get; set; }
    }
    #endregion
}
