using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimCoreApi.Models
{
    /// <summary>
    /// represents an instance of a person
    /// </summary>
    public class Person
    {

        /// <summary>
        /// ID from SQL
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// Users first name
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// Users last name
        /// </summary>
        public string LastName { get; set; } = "";
    }
}