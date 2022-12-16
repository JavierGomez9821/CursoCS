using System.Collections;
using Newtonsoft.Json;
// using System;
// See https://aka.ms/new-console-template for more information
// string nombre = "Jose ";
// Console.WriteLine($"Mi nombre es {nombre} desde el Main");
// Saludo(nombre);
// TipoDatos();
// Console.WriteLine($"Despues del saludo ");
// InvertirPalabra();
// Arreglos();
LoadJson();

void LoadJson()
{
    using (StreamReader r = new StreamReader("customers.json"))
    {
        string json = r.ReadToEnd();
        List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(json);
        var LookByCountry = customers.FindAll(it => it.city == "Spain");
        var LookByCity = customers.FindAll(it => it.city == "London");
        ListarEmpresas(customers);
        // BuscarEmpresa(LookByCity);
        // BuscarEmpresa(LookByCountry);
    }
}

void BuscarEmpresa(Customer emp)
{

}
void ListarEmpresas(List<Customer> datos)
{
    foreach (Customer item in datos)
    {
        Console.WriteLine($"Empresa   : {item.companyName} ");
        Console.WriteLine($"Contacto  : {item.contactName} ");
        Console.WriteLine($"Direccion : {item.address} ");
        Console.WriteLine($"Pais      : {item.country} ");
        Console.WriteLine($"Ciudad    : {item.city} ");
        Console.WriteLine("---------------------------------");
    }
}
public class Customer
{
    public string id { get; set; }
    public string companyName { get; set; }
    public string contactName { get; set; }
    public string contactTitle { get; set; }
    public string address { get; set; }
    public string city { get; set; }
    public string postalCode { get; set; }
    public string country { get; set; }
    public string phone { get; set; }
    public string fax { get; set; }
}


// void Arreglos()
// {
//     ushort size=15;
//     var vocales = new char[]{'a','e','i','o','u'};
//     var consonantes = new char[]{ 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
//     var digitos = new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
//     var alfabeto = vocales.Union(consonantes).ToArray();
//     string res="";
//     for (ushort i=0; i < size; i++)
//     {
//         bool letra = new Random().Next(0,100) <= 50 ? true:false;
//         if (letra){
//             int k = new Random().Next(0,alfabeto.Length - 1);
//             bool lower = new Random().Next(0,100) <= 50 ? true:false;
//             res+=lower ? alfabeto[k]:alfabeto[k].ToString().ToUpper();
//         }else{
//             int n = new Random().Next(0,9);
//             res+=digitos[n].ToString();
//         }   
//     }
//     Console.WriteLine($"El string aleatorio es {res}");
//     ArrayList caracteres = new ArrayList();
//     caracteres.Add(size);
//     caracteres.Add(vocales);
//     caracteres.Add(consonantes);
//     caracteres.Add(alfabeto);
//     foreach (var item in caracteres){
//         Console.WriteLine($"Valor {item}");
//     }
// }
// void InvertirPalabra()
// {
//     Console.Write($"Ingrese la palabra a invertir: ");
//     string? palabra = Console.ReadLine();
//     if (palabra is not null)
//     {
//         string palabraInvertida = "";
//         for(int i = palabra.Length - 1 ; i >= 0 ; i--)
//         {
//             palabraInvertida += palabra[i];
//         }
//         string res = palabraInvertida.ToLower() == palabra.ToLower() ? "Es Palindroma" : "No es Palindroma";
//         Console.WriteLine($"Palabra Invertida es: {palabraInvertida}");
//         Console.WriteLine($"La palabra: {res}");
//     }



// }
// void TipoDatos()
// {
//     ushort minUshort = ushort.MinValue;
//     ushort maxUshort = ushort.MaxValue;
//     Console.WriteLine($"Rango del ushort: {minUshort} to {maxUshort}");
//     short minShort = short.MinValue;
//     short maxShort = short.MaxValue;
//     Console.WriteLine($"Rango del short: {minShort} to {maxShort}");
//     ulong minLong = ulong.MinValue;
//     ulong maxLong = ulong.MaxValue;
//     Console.WriteLine($"Rango del short: {minLong} to {maxLong}");
//  }
// void Saludo(string nombre)
// {
//     string apellido ="Gomez";
//     Console.WriteLine($"Saludo desde metodo, soy {nombre}{apellido}");
// }