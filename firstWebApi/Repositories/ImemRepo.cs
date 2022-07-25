using firstWebApi.Entity;

namespace firstWebApi.Repositories
{
    public interface ImemRepo
    {
        public IEnumerable<Items> getItems();

        public Items getItem(int studentId);

        public String postItem(Items item);

        public List<Items> postItems(List<Items> items);

        public List<Items> deleteItem(int id);

        //  public List<Items> updateItem(int id , Items item);

        public void updateItem(Items item);

        public Object findByName(String name);
    }
}