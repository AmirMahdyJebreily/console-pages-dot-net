using ConsolePages;

CApp cApp = new CApp();

Page p = new Page(cApp.Layout);

p.DefineDialog((args) =>
{
    args.Print(("[Error]",args.ErrorColor), ("an error occurred in code...", args.PrimeryColor));
});

p.Show();