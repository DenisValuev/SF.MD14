namespace SF.MD14.U0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task4
            string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян", "Аккакий" };

            //Список, куда будем сохранять выборку
            var orderedList = new List<string>();

            //Пробежимся по массиву и добавим искомое в наш список
            foreach (var person in people)
            {
                if (person.ToUpper().StartsWith("А"))
                {
                    orderedList.Add(person);
                }
            }

            //Отсортируем список
            orderedList.Sort();
            foreach (string s in orderedList)
            {
                Console.WriteLine(s);
            }
        }
    }
}
