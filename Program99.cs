internal class Program
{
    private static void Main(string[] args)
    {
        string tag_country = "";
        string str = "950501234567899A033456129C01005F2A0212139F02061234567890129F03060934561287009F100256245F280206439F33034567899F3403123456";
        
        Console.WriteLine("Iniciando validação");
        if (str.Contains("5F28"))
        {
            int idx = str.IndexOf("5F28");
            tag_country = str.Substring(idx, 10);
            string country = tag_country.Substring(6,4);

            Console.WriteLine("1) DE55: {0}", str);
            Console.WriteLine("2) Posição do índice 5F28: {0}", idx);
            Console.WriteLine("3) TAG 5F28: {0}", tag_country);
            Console.WriteLine("4) ISO Country Code: {0}", country);
            Console.WriteLine("5) DE55 sem tag 5F28: {0}", str.Remove(idx, 10));
            switch (country) 
            {
                case "0643":
                    Console.WriteLine("9) País: Russia");
                    break;

                case "0112":
                    Console.WriteLine("9) País: Bielorussia");
                    break;            

                case "0760":
                    Console.WriteLine("9) País: Siria");
                    break;
            }
        }
        Console.WriteLine("Fim validação");
        
        //if (country.Substring(6,4).Equals("0643"))
        //{
        //    Console.WriteLine("9)     Russia");
        //    return;
        //}
    }
}