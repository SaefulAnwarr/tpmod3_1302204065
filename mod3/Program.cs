// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] arg)
    {
        KodePos table_Kodepos = new KodePos();
        Console.WriteLine(" ====== DAPATKAN KODE POS KEBONWARU =======");
        table_Kodepos.getKodePos("Kebonwaru");
        Console.WriteLine("==== DAPATKAN ALL KODE POS ======");
        table_Kodepos.getAllkodepos();
        ////////////////////////
        Console.WriteLine("========= KUNCI PINTU =========");
        DoorMachine pintu = new DoorMachine();
        pintu.kunci();
    }

}

class KodePos
{
    Dictionary<string, string> dic = new Dictionary<string, string>()
    {
            {"Batununggal"  ,"40266"},
            {"Kujangsari"   ,"40287"},
            {"Mengger"      ,"40267"},
            {"Wates"        ,"40256"},
            {"Cijaura"      ,"40287"},
            {"Jatisari"     ,"40286"},
            {"Margasari"    ,"40286"},
            {"Sekejati"     ,"40286"},
            {"Kebonwaru"    ,"40272"},
            {"Maleer"       ,"40274"},
            {"Samoja"       ,"40273"}
    }
}
class DoorMachine
{
    enum State { TERKUNCI, TERBUKA };
    public void kunci()
    {
        State state = State.TERKUNCI;

        String[] screenName = { "TERKUNCI", "TERBUKA" };
        do
        {
            Console.WriteLine("PINTU " + screenName[(int)state]);
            Console.Write("Enter Command : ");
            String command = Console.ReadLine();
            switch (state)
            {
                case State.TERKUNCI:
                    if (command == "Buka Pintu")
                    {
                        state = State.TERBUKA;
                    }
                    break;
                case State.TERBUKA:
                    if (command == "Kunci Pintu")
                    {
                        state = State.TERKUNCI;
                    }
                    break;


            }
        } while (state != State.TERKUNCI);
    }
}