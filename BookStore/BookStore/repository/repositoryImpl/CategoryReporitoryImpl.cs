using BookStore.Data;
using BookStore.dto;
using BookStore.Model;
using Microsoft.EntityFrameworkCore;

namespace BookStore.repository.repositoryImpl
{
    public class CategoryReporitoryImpl : CategoryRepository  
    {
        private readonly DataContext context;

        public CategoryReporitoryImpl(DataContext context)
        {
            this.context = context;
        }
        public CategoryDTO add(CategoryModel categoryModel)
        {
            Category category = new Category();
            category.name = categoryModel.name;
            category.image = categoryModel.image;
            this.context.Add(category);
            this.context.SaveChanges();
            return new CategoryDTO()
            {
                id = category.id,
                name = category.name,
                image = category.image
            };
        }

        public void delete(int id)
        {
            var category = this.context.categories.SingleOrDefault(c => c.id == id);
            if (category!= null)
            {
                this.context.Remove(category);
                this.context.SaveChanges();
            }
        }

        public List<CategoryDTO> GetAll()
        {
            var cates = this.context.categories.Select(c => new CategoryDTO
            {
                id = c.id,
                name = c.name,
                image = c.image
            });

            return cates.ToList();
        }

        public CategoryDTO getById(int id)
        {
            var category = this.context.categories.SingleOrDefault(c => c.id == id);
            if(category != null)
            {
                CategoryDTO cate = new CategoryDTO();
                cate.id = category.id;
                cate.name = category.name;
                return cate;
            }else
            {
                return null;
            }   

            
        }

        public void update(CategoryDTO categoryDTO)
        {
            var category = this.context.categories.SingleOrDefault(c => c.id == categoryDTO.id);
            if(category != null)
            {
                category.name = categoryDTO.name;
                this.context.Update(category);
                this.context.SaveChanges();
            }

        }
    }
}
