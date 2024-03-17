public class Scripture {

private List<string> _words = new List<string>();

public Scripture(string verse) {

    /* Parse the string of words into multiple , storing them individually in the list _words */
    string[] words = verse.Split(" ");
    
    foreach (string word in words)
    {
        _words.Add(word);
    }
    
}

public List<string> GetWords(){
    return _words;
}

public void Display(){
    

    foreach (string word in _words)
    {
    Console.Write($"{word} ");
    }
}   

public void HideWords() {
    Random rnd = new Random();
    
    _words[rnd.Next(0, _words.Count)] = "____";
    _words[rnd.Next(0, _words.Count)] = "____";
    _words[rnd.Next(0, _words.Count)] = "____";
    
}

}