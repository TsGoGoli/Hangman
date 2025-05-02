using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

IWordRepository mockWordRepository = new FileWordRepository();
HangmanGame game = new HangmanGame(mockWordRepository);
game.StartGame();

