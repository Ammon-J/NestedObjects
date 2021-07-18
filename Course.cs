using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Course
    {
        /// <summary>
        /// Title of the course. Ex. >NET Programming
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The course catalog description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of the college credits awarded 
        /// for passing the course
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// The instructor that teached the course
        /// </summary>
        public Instructor CourseInstructor { get; set; }

        /// <summary>
        /// All the students currently enrolled in the course
        /// </summary>
        public List<Student> Roster { get; set; }
    }
}
