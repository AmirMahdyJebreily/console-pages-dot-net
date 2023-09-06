using ConsolePages;

CApp cApp = new CApp();

Page main = new Page(cApp.Layout);

main.DefineDialog((a) =>
{
    a.Print("Wellcome to my Program", "\n", ("  Select Commands : ", a.SecondColor));

    a.GetCommand(cApp, new ConsoleCommand[]
    {
        a.MakeCommand('1', (a, c) => SayHelloHandler(a,c), "Say Hello")
    });

});


void SayHelloHandler(DialogStream a, CApp c)
{  
    c.ShowPage(() => {
        a.Print("Hello");
        a.End();
        
    });
}


cApp.SetMainPage(main);
cApp.ShowMainPage(true);