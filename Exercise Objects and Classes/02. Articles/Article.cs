class Article
{
    //характеристики -> автоматични пропъртита
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    //constructor
    public Article (string title, string content, string author)
    {
        //Нов празен обект
        Title = title;
        Content = content;
        Author = author;
    }

    //действия -> methods
    public void Edit (string newContent)
    {
        Content = newContent;
    }

    public void ChangeAuthor (string newAuthor)
    {
        Author = newAuthor;
    }

    public void Rename (string newTitle)
    {
        Title = newTitle;
    }

    //default methods -> ToString() -> "име на класа"
    //пренапиша метода, за да работи както аз искам 

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}"; 
    }

}

