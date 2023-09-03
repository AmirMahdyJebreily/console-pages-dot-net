using ConsolePages;

CApp cApp = new CApp();

Page p = new Page(cApp.Layout);

p.DefineDialog((args) =>
{
    args.Print("Hello World");
    args.PrintLn("Hello World", "Fuck");
});

p.Show();