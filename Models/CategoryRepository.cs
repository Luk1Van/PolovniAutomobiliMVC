﻿namespace PolovniAutomobiliMVC.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _db;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public IEnumerable<Category> AllCategories => _db.Categories;
    }
}
