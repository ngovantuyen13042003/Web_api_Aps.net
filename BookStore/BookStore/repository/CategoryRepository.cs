using BookStore.dto;

namespace BookStore.repository
{
    public interface CategoryRepository
    {
        List<CategoryDTO> GetAll();
        CategoryDTO getById(int id);
        CategoryDTO add(CategoryModel category);
        void update(CategoryDTO categoryDTO);
        void delete(int id);
    }
}
