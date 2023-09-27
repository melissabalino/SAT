using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF.Models//.Metadata
{
    //internal class Partials
    //{
    //}

    #region Course Partial
    [ModelMetadataType(typeof(CourseMetadata))]
    public partial class Course { }
    #endregion

    #region Enrollment Partial
    [ModelMetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment { }
    #endregion

    #region ScheduledClass Partial
    [ModelMetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass { }
    #endregion

    #region ScheduledClassStatus Partial
    [ModelMetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus { }
    #endregion

    #region Student Partial
    [ModelMetadataType(typeof(StudentMetadata))]
    public partial class Student { }
    #endregion

    #region StudentStatus Partial
    [ModelMetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus { }
    #endregion

}
