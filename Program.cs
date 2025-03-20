
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
}
public class Program
{
    public class PemrosesData
    {
        public dynamic DapatkanNilaiTerbesar<T>(T x1, T x2, T x3)
        {
            dynamic bilangan1 = x1;
            dynamic bilangan2 = x2;
            dynamic bilangan3 = x3;
            if (bilangan1 > bilangan2 && bilangan1 > bilangan3)
            {
                return bilangan1;
            }
            else if (bilangan3 > bilangan2 && bilangan2 > bilangan3)
            {
                return bilangan2;
            }
            else
            {
                return bilangan3;
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
      
        PemrosesData pemrosesData = new PemrosesData();
        Console.WriteLine("Nilai Terbesar dari adalah : " + pemrosesData.DapatkanNilaiTerbesar<int>(10, 30, 22));
    }
}


