using System.Collections.ObjectModel;

namespace ToDoApp.Models
{
    public class ToDoTaskManager
    {

        public static ObservableCollection<ToDoTask> Tasks;

        public static void AddNewTask(string name, string desc)
        {
            if (Tasks != null)
            {
                Tasks.Add(new ToDoTask()
                {
                    Name = name,
                    Desc = desc,
                    Id = Tasks.Max(x => x.Id) + 1
                });
            }
            else
            {
                Tasks = new ObservableCollection<ToDoTask>()
                {
                    new ToDoTask()
                    {
                        Name = name,
                        Desc = desc,
                        Id = 1
                    }
                };
            }
        }

        public static void AddTestData()
        {
            Tasks = new ObservableCollection<ToDoTask>()
            {
            new ToDoTask()
            {
                Id = 1,
                Name = "Kupienie karmy dla kota",
                Desc = "Zakupić ulubioną mokrą karmę Narkana w sklepie zoologicznym"
            },
            new ToDoTask()
            {
                Id = 2,
                Name = "Przygotowanie materiałów na zajęcia",
                Desc = "Zaktualizować slajdy do wykładu z ABAP – sekcja o komunikatach"
            },
            new ToDoTask()
            {
                Id = 3,
                Name = "Trening z Narkanem",
                Desc = "Ćwiczenia z przyciskami dźwiękowymi – powtórka komendy 'tulić'"
            },
            new ToDoTask()
            {
                Id = 4,
                Name = "Post na Instagram",
                Desc = "Stworzyć i opublikować nowy post na @purrfessors_adventures z weekendowej wycieczki"
            },
            new ToDoTask()
            {
                Id = 5,
                Name = "Planowanie wyjazdu wakacyjnego",
                Desc = "Sprawdzić miejsca przyjazne kotom i dostępne terminy w lipcu"
            }
            };
        }
    }
}
