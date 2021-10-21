using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string CatName { get; set; }

        //Category should be selected from a drop down list (which can be hard coded in your html view)
        //Alternatively, you can allow users to add new Content from the Category Details page.
        //Title, Body, and Author data will be entered into a text box by the user.
        //You can use the CreateById action to capture the appropriate CategoryId, eliminating the need for a Category drop down list.

        //public int ContentId { get; set; }
        
        public virtual List<Content> Contents { get; set; }

        //Seed your database with at least 3 examples of Categories.
        //Seed your database with at least 2-3 examples of Content for each Category.
    }


}
