using ConsolePages;

CApp cApp = new CApp();

Page p = new Page(cApp.Layout);

p.DefineDialog((args) =>
{
    args.Print(args); // Incorrect format 
    // I'll fix it when I get back from going out for my mom's shopping!
});