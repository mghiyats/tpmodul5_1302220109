using System;

class HaloGeneric
{
    public static void SapaUser(string nama)
    {
        Console.WriteLine("Halo user {0}", nama);
    }
}

class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

class MainClass
{
    static void Main(string[] args)
    {

        HaloGeneric.SapaUser("Fatih");


        DataGeneric<int> dataNIM = new DataGeneric<int>(1302220109);
        dataNIM.PrintData();
    }
}
