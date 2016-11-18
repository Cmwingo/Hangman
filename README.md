If the player guesses all the letters in the word, they win.

If the player has had 6 incorrect guesses then they lose.

The computer can generate the words from a pre-set list you provide.

The user can make a Guess by entering a letter into a form, and the app should tell them if it's right or wrong, and keep track of how many guesses they have left.

After the user has made a guess, take them to the /hangman page. If the user has one wrong guess, show the first image. If they have 2 wrong guesses, show the second image etc.

On the /hangman page, display the letters they have right so far, just like above: b _ b b _ _

Also on the /hangman page, display the letters they have wrong so far, and how many guesses they have left.

Again, on the /hangman page, you should also include a link back to the /new_guess page.

One more thing on the /hangman page - display a message saying "Yay! You guessed right!" or "Oh no! You guessed wrong!" at the top of the page. Display a different message saying "Game over!" in the same place on the page if they are out of guesses.

Don't allow duplicate guesses. If the user tries to guess the same letter twice, they should be told to try again.

Try to change the color of an element on your /hangman page based on whether the guess was right or wrong. Play around with changing the layout of your template file based on whether a guess is right or wrong, and whether or not the game is over.

For a bonus: Make it 2 player! Create a new form page where one user can choose a word for the other user to guess.

Objects:
Word list
Game state (guesses, letters already guessed/prevent duplicate guesses, word to guess/answer, etc)


for each char in answer string
  if guessedLetters.Inclues(char)
  {

  }
  else
  {
    answer.Replace(charAt(index), _ )
  }














string Answer;
string displayedAnswer;

string GuessedLetters = "";

foreach letter in displayedAnswer {
  if (!GuessedLetters.Contains(letter))
}
