using BeerTracker.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace BeerTracker.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
