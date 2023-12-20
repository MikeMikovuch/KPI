using EventsLibrary.model;
using EventsLibrary.repository;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            EventCategory a = new EventCategory("A", "Some description about category 1");
            EventCategory g = new EventCategory("G", "Some description about category 2");
            EventCategory z = new EventCategory("Z", "Some description about category 2");
            EventCategoryRepository.AddCategory(a);
            EventCategoryRepository.AddCategory(g);
            EventCategoryRepository.AddCategory(z);

            EventsRepository.AddEvent(new Event("Event af", "Some place", a));
            EventsRepository.AddEvent(new Event("Event ab", "Some place", a));
            EventsRepository.AddEvent(new Event("Event f", "Some place", g));
            EventsRepository.AddEvent(new Event("Event c", "Some place", z));
            EventsRepository.AddEvent(new Event("Event zzf", "Some place", a));

            foreach (var eevent in EventsRepository.GetEventsByCategory("A"))
            {
                Console.WriteLine(eevent.ToString());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
