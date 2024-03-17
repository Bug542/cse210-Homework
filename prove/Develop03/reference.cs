public class Reference 
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;
    private string _words;

    public void SetBook(string book)
    {
        _book = book;
    }

        public void SetChapter(string chapter)
    {
        _chapter = chapter;
    }

        public void SetVerse(string verse)
    {
        _verse = verse;
    }

        public string GetWords() {
            return _words;
        }

    public Reference(string book, string chapter, string verse, string words) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _words = words;
    }

    public Reference(string book, string chapter, string verse, string endVerse, string words) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        _words = words;
    }

    public void Display()
    {
        Console.Write($"{_book} {_chapter}:{_verse}{_endVerse}");
    }
}