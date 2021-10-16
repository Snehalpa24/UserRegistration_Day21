using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationUsingRegex
{
    public class UserRegistration
    {
        private string message;
        UserRegistrationRegex userRegistrationRegex = new UserRegistrationRegex();
        /// <summary>
        /// Default ConstructorInitializes a new instance of the <see cref="UserRegistration"/> class.
        /// </summary>
        public UserRegistration()
        {
        }
        /// <summary>
        /// Parameterized Constructor Initializes a new instance of the <see cref="UserRegistration"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public UserRegistration(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Checks for first name.
        /// </summary>
        /// <returns>Entry is successful or Entry is not successful it depends on condition</returns>
        public string checkForFirstName()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
}
}
