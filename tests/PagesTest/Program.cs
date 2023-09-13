using ConsolePages;

CApp cApp = new CApp((stream, app) =>
{
    stream.Print("Wellcome to my Program", "\n", ("  Select Commands : ", stream.SecondColor));

    stream.GetCommand(new ConsoleCommand[]
    {
        stream.MakeCommand('1', () => SayHelloHandler(app), "Say Hello"),
        stream.MakeCommand('2', () => PrintDate(new DialogStream()), "Print Date"),
        stream.MakeCommand('3', () => Beep(), "Beep")
    });

});

void SayHelloHandler(CApp c)
{  
    c.ShowPage((a) => {
        a.Print("Hello");
        a.End();
    });
}

void PrintDate(DialogStream a)
{
    a.Print(DateTime.Now.ToString("hh:mm:ss"));
    a.End();
}

void Beep()
{
    Console.Beep(880, 773);
}

cApp.ShowMainPage(true);