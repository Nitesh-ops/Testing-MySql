using firstWebApi.Entity;

namespace firstWebApi.Repositories
{
    public class studentRepository : ImemRepo
    {
        private readonly List<Items> items = new()
        {
            new Items{studentId=1,name="Nitesh",address="Gurgaon"},
            new Items{studentId=2,name="Mohit",address="Delhi"},
            new Items{studentId=3,name="Nitesh",address="Noida"},
            new Items{studentId=4,name="Satyam",address="Faridabad"},
        };

        public IEnumerable<Items> getItems()
        {
            return items;
        }

        public Items getItem(int studentId)
        {
            return items.Where(item => item.studentId == studentId).SingleOrDefault();
        }

        public String postItem(Items item)
        {
            items.Add(item);
            return "Item Added Succesfully";
        }
        public List<Items> postItems(List<Items> itemsList)
        {
            items.AddRange(itemsList);
            return items;
        }

        public List<Items> deleteItem(int id)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].studentId == id)
                {
                    items.RemoveAt(i);
                }
            }
            return items;
        }

        public List<Items> updateItem(int id, Items item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].studentId == id)
                {
                    Items item1 = new Items() { studentId = item.studentId, name = item.name, address = item.address };
                    items[i] = item1;
                }
            }
            return items;
        }

        public void updateItem(Items item)
        {
            var Index = items.FindIndex(existingItem => existingItem.studentId == item.studentId);
            items[Index] = item;
        }

        public Object findByName(String uname)
        {
            List<Items> item1 = new();
            for (int i = 0; i < items.Count; i++)
            {
                if (String.Equals(items[i].name, uname))
                {
                    item1.Add(items[i]);
                }
            }
            return item1 != null ? item1 : "No Item Found";

        }

    };
}