using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            var pack = new Pack();
            Console.WriteLine(pack.deck.Count);
            foreach (var card in pack.deck)
            {
                Console.WriteLine(card.Description());
            }
        }
    }
}
