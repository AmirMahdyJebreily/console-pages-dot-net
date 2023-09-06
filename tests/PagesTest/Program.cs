using ConsolePages;

CApp cApp = new CApp();

Page main = new Page(cApp.Layout);

main.DefineDialog((a) =>
{
    a.Print("Wellcome to my Program", "\n", ("  Select Commands : ", a.SecondColor));
    a.Print(("\t[1]", a.InfoColor), "Get System Date and time");
    a.Print(("\t[2]", a.InfoColor), "Say Hello");
    char command = a.GetCommand();
    switch (command)
    {
        case '1':
            cApp.ShowPage(new Page(cApp.Layout, (s) =>
            {
                s.Print("The date is :", (DateTime.Now.ToString("MM/dd/yyyy dddd"), s.InfoColor));
                s.Print(("\t[Any Key]", a.InfoColor), "Return");
                 s.GetCommand();
      

            }));
            break;
    }
});


cApp.SetMainPage(main);
cApp.ShowMainPage();