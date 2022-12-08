
//Directory.CreateDirectory(@"C:\Users\Мухаммед\Desktop\Test");
//File.Create(@"C:\Users\Мухаммед\Desktop\Test\text.txt");
//Directory.CreateDirectory(@"C:\Users\Мухаммед\Desktop\Test\File1");
//Directory.CreateDirectory(@"C:\Users\Мухаммед\Desktop\Test\File2");
//Directory.CreateDirectory(@"C:\Users\Мухаммед\Desktop\Test\File2\NestedFile");


ShowAllPath(@"C:\Users\Мухаммед\Desktop\Test");

void ShowAllPath(string directory)
{
    string[] directories = Directory.GetDirectories(directory);
    foreach (var path in directories)
    {
        Console.WriteLine(path);
        ShowAllFiles(path); 
        if (Directory.GetDirectories(path).Length != 0)
        {
            ShowAllPath((string)path);
        }
    }
}

void ShowAllFiles(string directory)
{
    string[] files = Directory.GetFiles(directory);
    if (files.Length != 0)
    {
        foreach (var file in files)
        {
            Console.WriteLine(file);
        }
    }
}
