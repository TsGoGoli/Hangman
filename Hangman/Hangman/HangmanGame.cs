using System;
using System.Collections.Generic;

public class HangmanGame
{
    private readonly List<string> _wordsList;
    private string _secretWord;
    private HashSet<char> lettersGuessed = new HashSet<char>();
    private int maxGuesses = 6;
    private int _guessesRemaining;

    public HangmanGame(IWordRepository wordsList)
    {
        _wordsList = wordsList.GetWords();
        _guessesRemaining = maxGuesses;
        _secretWord = CollectionExtensions.RandomElement(_wordsList).ToUpper();
    }

    public void StartGame()
    {
        while (_guessesRemaining > 0)
        {
            PrintWord(_secretWord, lettersGuessed);
            Console.WriteLine($"Guesses remaining: {_guessesRemaining}");

            Console.Write("Guess a letter: ");

            if (!char.TryParse(Console.ReadLine().ToUpper(), out char guess))
            {
                Console.WriteLine("Invalid input. Please enter a single character.");
                continue;
            }

            if (lettersGuessed.Contains(guess))
            {
                Console.WriteLine("You already guessed that letter.");
                continue;
            }

            lettersGuessed.Add(guess);

            if (!_secretWord.Contains(guess))
            {
                _guessesRemaining--;
                Console.WriteLine("Incorrect guess.");
            }

            if (IsWordGuessed(_secretWord, lettersGuessed))
            {
                Console.WriteLine($"Congratulations! You win! The word was: {_secretWord}");
                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine($"You lose. The word was: {_secretWord}. Better luck next time!");
        Console.ReadKey();
    }

    static bool IsWordGuessed(string word, HashSet<char> guessedLetters)
    {
        foreach (char c in word)
        {
            if (!guessedLetters.Contains(c))
            {
                return false;
            }
        }
        return true;
    }

    static void PrintWord(string word, HashSet<char> guessedLetters)
    {
        foreach (char c in word)
        {
            if (guessedLetters.Contains(c))
            {
                Console.Write(c);
            }
            else
            {
                Console.Write("_");
            }
        }
        Console.WriteLine();
    }
}
