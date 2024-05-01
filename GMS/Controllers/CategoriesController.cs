using GMS.Mapper;
using GMS_BusinessLogic.Categories;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly Category _categoryRepo = new();

        public IActionResult Index(string categoryName)
        {
            List<Category> categories = MapProfile.dtToCategories(_categoryRepo.get());
            return View(categories);
        }

        // Add
        public IActionResult add() => View(new Category());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult add(string name)
        {
            Category categoryToChcek = Category.find(name);

            if (categoryToChcek is not null)
                return BadRequest($"The Category With Name {name} already exist");

            Category category = new()
            {
                Name = name
            };

            int createdId = _categoryRepo.add(category);

            if (createdId > 0)
                return RedirectToAction(nameof(Index));
            else
                return BadRequest($"Error in Adding Category: {name}");
        }

        //Edit
        public IActionResult edit(int id)
        {
            Category category = Category.find(id);
            if (category is null)
                return NotFound($"Invalid Category Id: {id}");

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Category categoryToUpdate)
        {
            if (categoryToUpdate is null)
                return NotFound($"Empty Category");

            Category category = Category.find(categoryToUpdate.Id);

            if (categoryToUpdate.Name.ToLower() == category.Name.ToLower())
                return BadRequest($"The Category With Name {categoryToUpdate.Name} already exist");

            try
            {

                _categoryRepo.update(categoryToUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //Delete
        public async Task<IActionResult> Delete(int id)
        {
            Category category = Category.find(id);

            if (category is null)
                return NotFound($"Invalid Category Id: {id}");

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Category category)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Category");

            _categoryRepo.delete(category.Id);
            return RedirectToAction(nameof(Index));
        }
    }
}