  List<string> insults = new List<string>() {
    "You look like what morning breath smells like.",
    "If you tried to give me cpr I would probably throw myself back under water",
    "I am not a fan of you",
    "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
    "I'd rather walk than be on the same plane as you",
    "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
    "Do you have to be so...like that?"
  };

  //No duplicates - 3 insults - random number



  List<int> indexes = new List<int>();

//going through the list length and selecting a random number then adding it to the indexes List
  while(indexes.Count < 3){
  int randomNumber = new Random().Next(0, insults.Count - 1);  
    if(!indexes.Contains(randomNumber))
    {
        indexes.Add(randomNumber);
    }
  }

//looping through indexes to get a random number and calling that specific insult from the insults list based on sub i
  foreach(int i in indexes){
    Console.WriteLine(insults[i]);
  }