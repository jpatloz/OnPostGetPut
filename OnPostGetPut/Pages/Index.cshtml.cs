using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnPostGetPut.Models;

namespace OnPostGetPut.Pages
{
    public class IndexModel : PageModel
    {
        public string Name { get; set; }

        public void OnGet()
        {

        }

        public void OnPostSubmit(PersonModel person)
        {
            this.Name = String.Format("Name: {0} {1}", person.FirstName, person.LastName);
        }
    }
}