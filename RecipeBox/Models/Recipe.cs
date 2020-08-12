using System.Collections.Generic;

namespace RecipeBox.Models
{
    public class Recipe
    {
        public Recipe()
        {
            this.Categories = new HashSet<CategoryRecipe>();
        }

        public int RecipeId { get; set; }
        public string Description { get; set; }
        public virtual ApplicationUser User { get; set; } //new line

        public ICollection<CategoryRecipe> Categories { get;}
    }
}