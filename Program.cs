// See https://aka.ms/new-console-template for more information

public class Program
{
    public class SimpleDataBase<T>
    {
        private List<T>StoredDataBase;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            StoredDataBase = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            StoredDataBase.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < StoredDataBase.Count; i++)
            {
                Console.WriteLine("Data: " + (i+1)  + "berisi: " + StoredDataBase[i] + " yang disimpan pada waktu UTC: " + inputDates[i]);
            }
        }

    }
    public static void Main(string[] args)
    {
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(10);
        db.AddNewData(30);
        db.AddNewData(22);
        db.PrintAllData();
    }
}