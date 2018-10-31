using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Number_Wars
{
	class Program
	{
		const int MaxCounter = 1_000_000;

		static void Main(string[] args)
		{
			Queue<string> firstAllCards = new Queue<string>(Console.ReadLine().Split());
			Queue<string> secondAllCards = new Queue<string>(Console.ReadLine().Split());
			int turnsCounter = 0;
			bool gameOver = false;

			while (turnsCounter < MaxCounter && firstAllCards.Count > 0 && secondAllCards.Count > 0 && !gameOver)
			{
				turnsCounter++;
				string firstCard = firstAllCards.Dequeue();
				string secondCard = secondAllCards.Dequeue();

				if (GetNumber(firstCard) > GetNumber(secondCard))
				{
					firstAllCards.Enqueue(firstCard);
					firstAllCards.Enqueue(secondCard);
				}
				else if (GetNumber(firstCard) < GetNumber(secondCard))
				{
					secondAllCards.Enqueue(secondCard);
					secondAllCards.Enqueue(firstCard);
				}			
				else
				{
					List<string> cardsHand = new List<string> { firstCard, secondCard };

					while (!gameOver)
					{
						if (firstAllCards.Count >= 3 && secondAllCards.Count >= 3)
						{
							int firstSum = 0;
							int secondSum = 0;

							for (int counter = 0; counter < 3; counter++)
							{
								var firstHandCard = firstAllCards.Dequeue();
								var secondHandCard = secondAllCards.Dequeue();
								firstSum += GetChar(firstHandCard);
								secondSum += GetChar(secondHandCard);
								cardsHand.Add(firstHandCard);
								cardsHand.Add(secondHandCard);
							}

							if (firstSum > secondSum)
							{
								AddCardsToWinner(cardsHand, firstAllCards);
								break;
							}
							else if (firstSum < secondSum)
							{
								AddCardsToWinner(cardsHand, secondAllCards);
								break;
							}
						}
						else
							gameOver = true;
					}
				}
			}

			var result = "";

			if (firstAllCards.Count == secondAllCards.Count)
				result = "Draw";
			else if (firstAllCards.Count > secondAllCards.Count)
				result = "First player wins";
			else
				result = "Second player wins";

			Console.WriteLine($"{result} after {turnsCounter} turns");
		}

		private static void AddCardsToWinner(List<string> cardsHand, Queue<string> firstAllCard)
		{
			foreach (var card in cardsHand.OrderByDescending(c => GetNumber(c)).ThenByDescending(c => GetChar(c)))
				firstAllCard.Enqueue(card);
		}

		static int GetNumber(string card)
		{
			return int.Parse(card.Substring(0, card.Length - 1));
		}

		static int GetChar(string card)
		{
			return card[card.Length - 1];
		}
	}
}