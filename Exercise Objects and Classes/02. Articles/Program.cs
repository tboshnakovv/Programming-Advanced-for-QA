
string articleData = Console.ReadLine();
//articledata = Fight club, love story, Martin Scorsese

string title = articleData.Split(", ")[0];     // Fight club
string content  = articleData.Split(", ")[1]; // love story
string author  = articleData.Split(", ")[2]; // Martin Scorsese

Article article = new Article(title, content, author);

int countCommand = int.Parse(Console.ReadLine());
for (int i = 1; i <= countCommand; i++)
{
    string command = Console.ReadLine();
    
    string[] commandParts = command.Split(": ");
    string commandName = commandParts[0];
    string commandParameter = commandParts[1];

    switch(commandName)
    {
        case "Edit":
            article.Edit(commandParameter);
            break;

        case "ChangeAuthor":
            article.ChangeAuthor(commandParameter);
            break;
        
        case "Rename":
            article.Rename(commandParameter);
            break;

    }
    
}

//Принтираме статията
Console.WriteLine(article.ToString());
