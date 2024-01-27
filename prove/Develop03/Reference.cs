public class Reference {
    private string _book;
    private int _chapter;
    private int _verseOne;
    private int _verseTwo;

    public Reference(string book, int chapter, int verseOne)
    {
        _book = book;
        _chapter = chapter;
        _verseOne = verseOne;
    }
    //TWO VERSES
    public Reference(string book, int chapter, int verseOne, int verseTwo)
    {
        _book = book;
        _chapter = chapter;
        _verseOne = verseOne;
        _verseTwo = verseTwo;
    }
    public string GetReference()
    {
        if (_verseTwo == 0)
        {
            return ($"{_book} {_chapter}:{_verseOne} ");
        }
        else
        {
            return ($"{_book} {_chapter}:{_verseOne}-{_verseTwo}");
        }
        
    }
    
}