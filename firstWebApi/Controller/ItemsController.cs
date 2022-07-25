using Microsoft.AspNetCore.Mvc;
using firstWebApi.Repositories;
using firstWebApi.Entity;

namespace firstWebApi.Controller
{
    [ApiController]
    [Route("api")]
    public class ItemsController : ControllerBase
    {
        private readonly ImemRepo repository;

        public ItemsController(ImemRepo repo)
        {
            this.repository = repo;
        }

        [HttpGet]
        [Route("getItem")]
        public IEnumerable<Items> GetItems()
        {
            return repository.getItems();

        }

        [HttpGet]
        [Route("getItemById/{id}")]
        public Items GetItemById(int id)
        {
            return repository.getItem(id);

        }

        [HttpPost]
        [Route("postItem")]
        public String postItem(Items items)
        {
            return repository.postItem(items);
        }

        [HttpPost]
        [Route("postItems")]
        public List<Items> postItems(List<Items> items)
        {
            return repository.postItems(items);
        }

        [HttpDelete]
        [Route("deleteItem")]
        public List<Items> deleteItems(int id)
        {
            return repository.deleteItem(id);
        }

        // [HttpPut]
        // [Route("updateItem/{id}")]
        // public List<Items> updateItem(int id,Items item)
        // {
        //     return repository.updateItem(id,item);
        // }

        [HttpPut("{id}")]
        public Object updateItem(int id, Items item)
        {
            var existingItem = repository.getItem(id);
            if (existingItem is null)
            {
                return NotFound();
            }
            Items updateItems = existingItem with
            {
                studentId = item.studentId,
                name = item.name,
                address = item.address
            };
            repository.updateItem(updateItems);
            return "Updated Succesfully";
        }

        [HttpGet]
        [Route("findByName/{uname}")]
        public Object findByName(string uname)
        {
            return repository.findByName(uname);
        }

    }
}