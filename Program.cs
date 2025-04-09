// See https://aka.ms/new-console-template for more information
Console.Clear();
Random rand = new Random();


// past tence verb
List<string> tenceVerb = new List<string>() { "ran", "swam", "drove", "ate", "walked", "cried", "climbed", "cleaned" };

//plural noun
List<string> pluralnoun = new List<string>() { "dogs", "cars", "cats", "pools", "apples", "eggs", "mountains", "hills" };


//verb
List<string> verb = new List<string>() { "eating", "cleaning", "scamming", "typing", "watering", "drinknig", "washing", "walking" };


// nouns  pick 10
List<string> noun = new List<string>() { "house", "walls", "pool", "cat", "watermelon", "computer", "ice", "snow" };

// adjective
List<string> adjective = new List<string>() { "wet", "dirty", "slimy", "smelly", "blue", "hot", "yummy", "warm"};

// Makes the dictionary of list
Dictionary<string, List<string>> wordTypes = new Dictionary<string, List<string>>();
wordTypes.Add("noun", noun);
wordTypes.Add("verb", verb);
wordTypes.Add("past-tense-verb", tenceVerb);
wordTypes.Add("plural-noun", pluralnoun);
wordTypes.Add("adjective" , adjective);


    foreach (string filename in args)
    {

        Console.WriteLine(filename);
        loadWords(Words(filename));
    
    
    }

    

    // reads the filename given and turns it into a array of words
string[] Words(string filename)
{
    string text = File.ReadAllText($"../../../{filename}");
    string[] words = text.Split(" ");
    return words;
}

 void loadWords(string[] wordsList)
{
    string final = null;
    foreach (string w in wordsList)
    {
        
        string word = w.Trim();
        if (word.Contains(':'))
        {

            //Console.WriteLine($"{word}");
            string[] type = word.Split("::");
           
            // run replacement thing

            final = final + type[0] + " ";

            final = final + LookUpReplace(type[1]) + " "; 
            // replace this with the returned vallue later by looking in dictionary and picking one
        }
        else
        {
            final = final + word + " ";
        }
        
    }
    Console.WriteLine(final);
    Console.WriteLine();
  }






string LookUpReplace(string type)
{
   string replace = wordTypes[type][rand.Next(0,wordTypes[type].Count)];
   return replace;

}





