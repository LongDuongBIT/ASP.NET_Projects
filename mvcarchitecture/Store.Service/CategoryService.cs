﻿using Store.Data.Infrastructure;
using Store.Data.Repositories;
using Store.Model;
using System.Collections.Generic;
using System.Linq;

namespace Store.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categorysRepository;
        private readonly IUnitOfWork unitOfWork;

        public CategoryService(ICategoryRepository categorysRepository, IUnitOfWork unitOfWork)
        {
            this.categorysRepository = categorysRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateCategory(Category category)
        {
            categorysRepository.Add(category);
        }

        public IEnumerable<Category> GetCategories(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return categorysRepository.GetAll();
            else
                return categorysRepository.GetAll().Where(c => c.Name == name);
        }

        public Category GetCategory(int id)
        {
            var category = categorysRepository.GetById(id);
            return category;
        }

        public Category GetCategory(string name)
        {
            var category = categorysRepository.GetCategoryByName(name);
            return category;
        }

        public void SaveCategory()
        {
            unitOfWork.Commit();
        }
    }
}