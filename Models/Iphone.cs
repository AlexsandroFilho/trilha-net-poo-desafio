namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string nome, string modelo, string imei, int memoria) : base(nome, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone");
        }
    }
}