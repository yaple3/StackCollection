namespace StackCollection
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            // Creates the cards Stack
            Stack<string> cards = new();
            //adding cards
            cards.Push("Ace of Spades");
            cards.Push("King of Hearts");
            cards.Push("2 of Diamonds");
            cards.Push("Jack of Clubs");
            cards.Push("Queen of Diamonds");
            cards.Push("8 of Hearts");
            // adding more cards
            Console.WriteLine("How many cards would you like to add to the deck of cards?");
            int num = int.Parse(Console.ReadLine());
            // adds data to the cards Stack
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("name of card: ");
                cards.Push(Console.ReadLine());
            }
            // Check for an item in the Stack
            Console.WriteLine("Would you like to look for a card? (yes or no)");
            string answer = Console.ReadLine();
            while (answer == "yes")
            {
                Console.WriteLine("Enter the name of the card you would like to search for");
                string cardName = Console.ReadLine();
                if (cards.Contains(cardName))
                {
                    Console.WriteLine("That card is part of the deck.");
                }
                else
                {
                    Console.WriteLine("I am sorry, that card is not part of the deck");
                }
                Console.WriteLine("Would you like to look for another card? (yes or no)");
                answer = Console.ReadLine();
            }
            // counts the cards in the Stack
            Console.WriteLine($"Here are your {cards.Count()} cards");
            // displays the Stack contents without removing anything
            foreach (string c in cards)
            {
                Console.WriteLine(c);
            }
            string firstCard = cards.Peek();   // retrieves the LAST item
            Console.WriteLine($"Would you like to remove {firstCard} from the top of the deck? (yes or no)");
            answer = Console.ReadLine();
            while (answer == "yes")
            {
                _ = cards.Pop();  // Removes the LAST item
                firstCard = cards.Peek();
                Console.WriteLine($"Would you like to remove {firstCard} from the top of the deck? (yes or no)");
                answer = Console.ReadLine();
            }

            if (cards.Peek() == null)
            {
                Console.WriteLine("The deck is empty");
            }
            else
            {
                Console.WriteLine($"You have {cards.Count} left in the deck");
            }
        }
    }
}
