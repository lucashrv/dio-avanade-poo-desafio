namespace Cell.Models
{
    public class Iphone : Smartphone
    {

        private List<string> aplicativos = new List<string>();

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void ExibirListaDeApps()
        {
            string resultado = string.Join(", ", aplicativos);
            Console.WriteLine($"Lista de apps: {resultado}");
        }


        public override void InstalarAplicativo(string nome)
        {
            aplicativos.Add(nome);
            Console.WriteLine($"Aplicativo {nome} foi instalado no Iphone");
        }
    }
}