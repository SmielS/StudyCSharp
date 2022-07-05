// Console.WriteLine("2 Hello, World!");


// директории без рекрсии

// string path = "D:/!учёба/GB/1 четверть/c#/Examples/Example001_HelloConsole";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }



// директории через рекурсию

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         System.Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }

//     FileInfo[] files = catalog.GetFiles();

//     for (int i = 0; i < files.Length; i++)
//     {
//         System.Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }

// string path = "D:/!учёба/GB/1 четверть/c#/Examples";
// CatalogInfo(path);



// пирамидки

void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
{
    if (count > 1) Towers(with, some, on, count - 1);
    System.Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();