using ConsolePages;

CApp cApp = new CApp();

Page main = new Page(cApp.Layout);

main.DefineDialog((a) =>
{
    a.Print("Wellcome to my Program", "\n", ("  Select Commands : ", a.SecondColor));

    a.GetCommand(new ConsoleCommand[]
    {
        a.MakeCommand('1', () => SayHelloHandler(cApp), "Say Hello")
    });

});

void SayHelloHandler(CApp c)
{  
    c.ShowPage((a) => {
        a.Print("Hello");
        a.End();
    });
}

cApp.SetMainPage(main);
cApp.ShowMainPage(true);