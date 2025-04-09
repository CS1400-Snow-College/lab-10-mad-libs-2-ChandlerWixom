// See https://aka.ms/new-console-template for more information
Console.Clear();
Random rand = new Random();


// past tence verb
List<string> tenceVerb = new List<string>() { "verbpast1", "verbpast2", "verbpast3", "verbpast4", "verbpast5", "verbpast6", "verbpast7", "verbpast8" };

//plural noun
List<string> pluralnoun = new List<string>() { "nouns1", "nouns2", "nouns3", "nouns4", "nouns5", "nouns6", "nouns7", "nouns8" };


//verb
List<string> verb = new List<string>() { "verb1", "verb2", "verb3", "verb4", "verb5", "verb6", "verb7", "verb8" };


// nouns  pick 10
List<string> noun = new List<string>() { "noun1", "noun2", "noun3", "noun4", "noun5", "noun6", "noun7", "noun8" };

// adjective
List<string> adjective = new List<string>() { "BALLS"};

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
    
    {
        
    }
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
            Console.WriteLine(type[1]);
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
  }






string LookUpReplace(string type)
{
   string replace = wordTypes[type][rand.Next(0,wordTypes[type].Count)];
   return replace;

}





