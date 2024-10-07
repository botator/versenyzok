using System.Text;
using verseny;

List<Versenyzők> lista = [];
using StreamReader sr = new(path: "C:\\Users\\bastyai.botond\\Desktop\\verseny\\verseny\\src\\forras.txt",
    encoding: Encoding.UTF8);
while (!sr.EndOfStream)
{
    lista.Add(new(sr.ReadLine()));
}
Console.WriteLine($"ennyi van {lista[1].ToString()}");

Console.WriteLine("elit versenyzők");
var linqelit = lista.Where(p => p.category == "elit");
Console.WriteLine($"{linqelit.Count()}");

var linqnoelet = lista.Where(p => p.sex =="n").Average(d =>DateTime.Now.Year - d.age)+" év";
Console.WriteLine("nok atlag eletkora " + linqnoelet);
Console.WriteLine($"osszes id bicikli órában {Math.Round(TimeSpan.FromSeconds(lista.Sum(p =>p.biketime.TotalSeconds)).TotalHours,2)}");
Console.WriteLine($"átlagos elit junior úszás idő {Math.Round(TimeSpan.FromSeconds(lista.Average(p => p.swimtime.TotalSeconds)).TotalHours, 2)}");
var linquszasatlag = TimeSpan.FromSeconds(lista.Average(d => d.swimtime.TotalSeconds)).TotalHours;
Console.WriteLine($" elit junior atlag "+linquszasatlag);
var gyoztes = 0;
for (int i = 0; i < lista.Count; i++)
{
    if(lista[i].sex == "f")
    {
        gyoztes += Convert.ToInt16(lista[i].swimtime.TotalSeconds);
        gyoztes += Convert.ToInt16(lista[i].runtime.TotalSeconds);
        gyoztes += Convert.ToInt16(lista[i].biketime.TotalSeconds);
        gyoztes += Convert.ToInt16(lista[i].firstrest.TotalSeconds);
        gyoztes += Convert.ToInt16(lista[i].secondrest.TotalSeconds);

    }
}
Console.WriteLine(gyoztes);
