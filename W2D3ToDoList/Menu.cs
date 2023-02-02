using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D3ToDoList
{
    internal class Menu
    {
        List<ToDoItem> todoList = new();

   
        public Menu()
        {
            FakeData();
            while (true)
            {
                MainMenu();
            }
        }

        private void FakeData()
        {
            for (int i = 0; i < 5; i++)
            {
                ToDoItem tdi = new ToDoItem() { Created = DateTime.Now, Deadline = DateTime.Now.AddDays(1), Todo = "Something"  };
                
            }
                
           
        }

        //Start menu
        public void MainMenu()
        {
            Console.WriteLine("Main Menu\n\n(1) Add new\n(2) Show List");

            var v = Console.ReadKey(true);
            switch (v.KeyChar)
            {
                case '1':
                    CreateItem();
                    break;
                case '2':
                    ShowList();
                    break;
                default:
                    break;
            }
        }

        //Show TodoList shows TodoItems
        void ShowList()
        {
            foreach (ToDoItem item in todoList)
            {
                ShowItem(item);
            }
        }

        //Create Item
        private void CreateItem()
        {
            ToDoItem newItem = new ToDoItem();
            newItem.Created = DateTime.Now;

            Console.WriteLine("What to do?");
            newItem.Todo = Console.ReadLine();

            Console.WriteLine("When to do it?");
            string dl = Console.ReadLine();
            //TODO Get different input regarding dates and times
            newItem.Deadline = DateTime.Parse(dl);
            newItem.IsDone = false;

            Console.WriteLine("Is it important?");
            newItem.IsFavorite = Console.ReadKey(true).Key == ConsoleKey.Y ? true : false;

            todoList.Add(newItem);
        }

        //Read TodoItem
        private void ShowItem(ToDoItem toDoItem)
        {
            int i = todoList.IndexOf(toDoItem);
            Console.WriteLine($"What: {toDoItem.Todo} When: {toDoItem.Deadline} isDone: {toDoItem.IsDone}");
          
        }


     




    }
}