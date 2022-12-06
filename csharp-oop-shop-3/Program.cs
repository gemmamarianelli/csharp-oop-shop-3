using csharp_oop_shop_3;

try
{
    Acqua bevanda1 = new Acqua("anna", "dzfgdf", 23, 12, 34, 11, "dfgf");
    bevanda1.Stampa();
    bevanda1.BeviAcqua(89);

    bevanda1.Stampa();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}