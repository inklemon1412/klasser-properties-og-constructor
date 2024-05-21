namespace klasser__properties_og_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            var bulbasaur = new Pokemon("Bulbasaur", 12, 30);
            var pikachu = new Pokemon("Pikachu", 18, 20);
            var charmander = new Pokemon("Charmander", 20, 45);

            Console.WriteLine($"Du har funnet {bulbasaur.Name} lvl{bulbasaur.Level}, en {pikachu.Name} lvl{pikachu.Level} samt en liten {charmander.Name} lvl{charmander.Level}");

        }
    }
}
