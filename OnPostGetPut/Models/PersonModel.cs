using Microsoft.AspNetCore.Mvc;

namespace OnPostGetPut.Models
{
    public class PersonModel
    {
        [BindProperty]
        public string FirstName { get; set; }

        [BindProperty]
        public string LastName { get; set; }
    }
}
