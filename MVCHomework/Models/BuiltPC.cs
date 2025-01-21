namespace MVCHomework.Models
{
    /// <summary>
    /// Represents a user built PC item
    /// </summary>
    public class BuiltPC
    {
        /// <summary>
        /// Represents the title of the users build
        /// </summary>
        public string Title { get; set; }

        /// <summary>  
        /// The type of build the user is creating
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Represents the chosen CPU of the user's build
        /// </summary>
        public string CPU { get; set; }
        /// <summary>
        /// Represents the chosen GPU of the user's build
        /// </summary>
        public string GPU { get; set; }
        /// <summary>
        /// User inputted budget
        /// </summary>
        public double Budget { get; set; }



    }
}
