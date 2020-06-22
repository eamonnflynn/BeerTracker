using BeerTracker.Application.Common.Mappings;
using BeerTracker.Domain.Entities;

namespace BeerTracker.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
