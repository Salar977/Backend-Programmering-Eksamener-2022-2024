using Oppgave3;

Author author = new Author("Jo", "Nesbø", 1960);
Author author2 = new Author("Tom", "Egeland", 1959);
Book book = new Book("Snømannen", author, 2007);
Book book2 = new Book("Sirkelens ende", author2, 2001);
			
Console.WriteLine(book.GetBookInfo());
Console.WriteLine(book2.GetBookInfo());