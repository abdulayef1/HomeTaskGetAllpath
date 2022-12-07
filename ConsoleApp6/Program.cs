
Directory.CreateDirectory(@"C:\Users\ClassTime\Desktop\NewDC");
File.Create(@"C:\Users\ClassTime\Desktop\NewDC\text.txt");

Directory.CreateDirectory(@"C:\Users\ClassTime\Desktop\NewDC\File1");
Directory.CreateDirectory(@"C:\Users\ClassTime\Desktop\NewDC\File2");
Directory.CreateDirectory(@"C:\Users\ClassTime\Desktop\NewDC\File2\NestedFile");

var allPaths=Directory.GetDirectories(@"C:\Users\ClassTime\Desktop\NewDC");

foreach (var path in allPaths)
{
    Console.WriteLine(path);
}
