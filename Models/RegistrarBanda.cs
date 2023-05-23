namespace Models;

public class RegistrarBandas
{
    public List<string> ListaBandas = new List<string> { "U2", "The Beatles", "LinkinPark" };

    public void RegistrarBanda()
    {
        Console.Clear();
        Console.WriteLine("Registro de bandas");
        Console.Write("Digite o nome da banda que deseja registrar:");
        var nomeBanda = Console.ReadLine()!;
        ListaBandas.Add(nomeBanda);
        Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso");
        Thread.Sleep(2000);
        Console.Clear();
    }
}