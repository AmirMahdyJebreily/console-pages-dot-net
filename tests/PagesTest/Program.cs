using ConsolePages;

CApp cApp = new CApp();

cApp.ShowPage(new Page(cApp.Layout, (a) =>
{
    a.Print(("[Error]", a.ErrorColor), ("An error occurred in the code...", a.PrimeColor));
    a.Print(("[Success]", a.SuccessColor), ("Download Successfully completed...", a.PrimeColor));
    a.Print(("[Info]", a.InfoColor), ("App version is 0.0.1 ...", a.PrimeColor));
    a.Print(("You have", a.PrimeColor), ("12$", a.InfoColor), ("in your wallet",a.PrimeColor));
}));
