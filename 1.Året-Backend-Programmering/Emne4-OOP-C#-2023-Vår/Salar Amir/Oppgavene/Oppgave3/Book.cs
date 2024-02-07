namespace Oppgave3;

public class Book
{
    // Fields
    private Author _author;
    private int _publicationYear;
    private string _title;
    
    
    // Properties
    public Author Author => _author;
    public int PublicationYear => _publicationYear;
    public string Title => _title;
    
    
    // Constructors
    public Book(string title, Author author, int publicationYear)
    {
        _title = title;
        _author = author;
        _publicationYear = publicationYear;
    }
    
    
    // Methods
    public string GetBookInfo()
    {
        return $"{Title} av {Author}, publisert i {PublicationYear}";
    }
    
    public override string ToString()
    {
        return $"{Title}, {Author}, {PublicationYear}";
    }
}