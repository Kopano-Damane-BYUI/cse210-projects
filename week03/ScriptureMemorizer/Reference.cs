public class Reference
{
    public string Book { get; set; }
    public string Chapter { get; set; }
    public string Verse { get; set; }
    public string VerseRange { get; set; }

    // Constructor for single verse (e.g., "John 3:16")
    public Reference(string reference)
    {
        var parts = reference.Split(' ');
        Book = parts[0];
        var chapterVerse = parts[1].Split(':');
        Chapter = chapterVerse[0];
        Verse = chapterVerse[1];
        VerseRange = null;
    }

    // Constructor for verse range (e.g., "Proverbs 3:5-6")
    public Reference(string book, string chapter, string verseRange)
    {
        Book = book;
        Chapter = chapter;
        VerseRange = verseRange;
        var verses = verseRange.Split('-');
        Verse = verses[0];
    }

    public override string ToString()
    {
        if (string.IsNullOrEmpty(VerseRange))
            return $"{Book} {Chapter}:{Verse}";
        else
            return $"{Book} {Chapter}:{VerseRange}";
    }
}
