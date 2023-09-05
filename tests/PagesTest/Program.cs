using ConsolePages;

CApp cApp = new CApp();

cApp.ShowPage(new Page(cApp.Layout, (a) =>
{
    a.Print(("[Error]", a.ErrorColor), "An error occurred in the code...");
    a.Print(("[Success]", a.SuccessColor), "Download Successfully completed...");
    a.Print(("[Info]", a.InfoColor), "App version is", ("0.0.1", a.WarningColor), "...");
    string txt = a.Input("Enter your",("age",a.InfoColor),": ");
    a.Print("Your age is", (txt, a.InfoColor));
}));
