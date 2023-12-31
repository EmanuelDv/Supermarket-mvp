﻿using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Presenters
{

    internal class CategoryPresenter
    {
        private ICategoryView view;
        private ICategoryRepository repository;
        private BindingSource categoryBindingSource;
        private IEnumerable<CategoryModel> categoryList;
        public CategoryPresenter(ICategoryView view, ICategoryRepository repository)
        {
            this.categoryBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategory;
            this.view.AddNewEvent += AddNewCategory;
            this.view.EditEvent += LoadSelectCategoryToEdit;
            this.view.DeleteEvent += DeleteSelectedCategory;
            this.view.SaveEvent += SaveCategory;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoryListBildingSource(categoryBindingSource);
            LoadAllCategoryList();
            this.view.Show();
        }

        private void LoadAllCategoryList()
        {
            categoryList = repository.GetAll();
            categoryBindingSource.DataSource = categoryList;
        }
        private void CleanViewFields()
        {
            view.CategoryId = "0";
            view.CategoryName = "";
            view.CategoryObservation = "";
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategory(object? sender, EventArgs e)
        {
            var category = new CategoryModel();
            category.Id = Convert.ToInt32(view.CategoryId);
            category.Name = view.CategoryName;
            category.Observation = view.CategoryObservation;

            try
            {
                new Common.ModelDataValidation().Validate(category);
                if (view.IsEdit)
                {
                    repository.Edit(category);
                    view.Message = "Category edited succesfuly";
                }
                else
                {
                    repository.Add(category);
                    view.Message = "Category added succesfuly";
                }
                view.IsSuccessful = true;
                LoadAllCategoryList();
                CleanViewFields();
            }

            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error Ocurred, Could not delete categorie";
            }
        }

        private void DeleteSelectedCategory(object? sender, EventArgs e)
        {

            try
            {
                var category = (CategoryModel)categoryBindingSource.Current;
                repository.Delete(category.Id);
                view.IsSuccessful = true;
                view.Message = "Category deleted succesfuly";
                LoadAllCategoryList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "A error ocurred, could not delete category";
            }
        }

        private void LoadSelectCategoryToEdit(object? sender, EventArgs e)
        {
            var category = (CategoryModel)categoryBindingSource.Current;

            view.CategoryId = category.Id.ToString();
            view.CategoryName = category.Name.ToString();
            view.CategoryObservation = category.Observation.ToString();
            view.IsEdit = true;
        }

        private void AddNewCategory(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategory(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categoryList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoryList = repository.GetAll();
            }
            categoryBindingSource.DataSource = categoryList;
        }
    }
}
