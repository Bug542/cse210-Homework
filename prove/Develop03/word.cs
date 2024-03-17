public class Word {
    
    
    public void Hide(List<string> words) {
        Random rnd = new Random();
        words[rnd.Next(0, words.Count)] = "____";
        words[rnd.Next(0, words.Count)] = "____";
        words[rnd.Next(0, words.Count)] = "____";
        Console.WriteLine(words);
    }   
}