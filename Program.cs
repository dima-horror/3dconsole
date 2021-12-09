using _3dconsole;
Console.CursorVisible = false;

char[,] screen = new char[Ratios.height, Ratios.width];
var cursor = new Pixel(0, 1);
bool order = false;

InitializeScreen();

do 
{
    while (!Console.KeyAvailable) 
    {
        cursor.Set(screen, ' ');
        cursor = order 
            ? cursor + new Pixel(0, 1) 
            : cursor - new Pixel(0, 1);

        cursor.Set(screen, '@');
        
        if (cursor.X == Ratios.width - 1) order = false;
        if (cursor.X == 0) order = true;

        DrawScreen();
        //if (i > 0 && i < Ratios.width) screen[0, i + (order ? -1 : 1)] = ' ';

    }       
}
while (Console.ReadKey(true).Key != ConsoleKey.Escape);

Console.ReadKey();


void InitializeScreen()
{
    for (int y = 0; y < Ratios.height; y++)
        for (int x = 0; x < Ratios.width; x++)
            screen[y, x] = 'x';


    cursor.Set(screen, '@');
}
void DrawScreen()
{
    for (int y = 0; y < Ratios.height; y++)
        for (int x = 0; x < Ratios.width; x++)
            Console.Write(screen[y, x]);
    Console.SetCursorPosition(0, 0);
    //Thread.Sleep(10);
}