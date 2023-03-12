
Console.WriteLine("Ilk once ismini ve soy ismini ogrenebilirmiyim:");
Console.WriteLine("Ismin:");
string name = Console.ReadLine();
Console.WriteLine("Soyisim:");
string surname = Console.ReadLine();
double wallet = 0;
int remaningRight = 1;


menu:

Console.WriteLine("Bir menu seciniz:");
Console.WriteLine("1-Oyun\n2-Hesap bilgileri\n3-Magaza\n4-Uygulamma hakkinda");

int coose1 = int.Parse(Console.ReadLine());

if (coose1 == 1)
{
start:
    Console.WriteLine("Yapmak istediginiz islemi seciniz:");


    Console.WriteLine("1-Toplama\n2-Cikarma\n3-Carpma\n4-Bolme\n5-Menuye donus");

    int coose2 = int.Parse(Console.ReadLine());

    if (coose2 == 1)
    {

        Random total1 = new Random();
        int number1 = total1.Next(-100, 100);
        Console.WriteLine($"Birinci sayi: {number1}");

        Random total2 = new Random();
        int number2 = total2.Next(-100, 100);
        Console.WriteLine($"Ikinci sayi: {number2}");

        Console.WriteLine("Hadi bil bakalim.");

    guess:

        Console.WriteLine($"{number1} + {number2}");

        int guess = int.Parse(Console.ReadLine());

        int total = number1 + number2;

        if (guess == total)
        {

            Console.WriteLine("Wow bildin.");
            Thread.Sleep(500);
            Console.WriteLine("Kazandigin tutar: 100");
            Thread.Sleep(500);
            wallet = wallet + 100;
            Console.WriteLine($"Bakiyen: {wallet}");
            Thread.Sleep(500);
            goto start;
        }

        else
        {
            
            Console.WriteLine("Yanlis bidin bidaha dene.");
            remaningRight = remaningRight - 1;
            if (remaningRight < 0)
            {
                Console.WriteLine("Extra hakkin yok.Uygulamadan cikiliyor!");
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            Console.WriteLine($"Kalan extra hak: {remaningRight}");
            Thread.Sleep(500);
            goto guess;
        }


    }

    else if (coose2 == 2)
    {

        Random remove1 = new Random();
        int number1 = remove1.Next(-100, 100);
        Console.WriteLine($"Birinci sayi: {number1}");

        Random remove2 = new Random();
        int number2 = remove2.Next(-100, 100);
        Console.WriteLine($"Ikinci sayi: {number2}");

        Console.WriteLine("Hadi bil bakalim.");



    guess:

        Console.WriteLine($"{number1} - {number2}");

        int guess = int.Parse(Console.ReadLine());

        int remove = number1 - number2;

        if (guess == remove)
        {

            Console.WriteLine("Wow bildin.");
            Thread.Sleep(500);
            Console.WriteLine("Kazandigin tutar: 100");
            Thread.Sleep(500);
            wallet = wallet + 100;
            Console.WriteLine($"Bakiyen: {wallet}");
            Thread.Sleep(500);
            goto start;
        }

        else
        {

            Console.WriteLine("Yanlis bidin bidaha dene.");
            remaningRight = remaningRight - 1;
            if (remaningRight < 0)
            {
                Console.WriteLine("Extra hakkin yok.Uygulamadan cikiliyor!");
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            Console.WriteLine($"Kalan extra hak: {remaningRight}");
            Thread.Sleep(500);
            goto guess;
        }

    }


    else if (coose2 == 3)
    {

        Random impact1 = new Random();
        int number1 = impact1.Next(-10, 10);
        Console.WriteLine($"Birinci sayi: {number1}");

        Random impact2 = new Random();
        int number2 = impact2.Next(-10, 10);
        Console.WriteLine($"Ikinci sayi: {number2}");

        Console.WriteLine("Hadi bil bakalim.");



    guess:

        Console.WriteLine($"{number1} x {number2}");

        int guess = int.Parse(Console.ReadLine());

        int impact = number1 * number2;

        if (guess == impact)
        {

            Console.WriteLine("Wow bildin.");
            Thread.Sleep(500);
            Console.WriteLine("Kazandigin tutar: 100");
            Thread.Sleep(500);
            wallet = wallet + 100;
            Console.WriteLine($"Bakiyen: {wallet}");
            Thread.Sleep(500);
            goto start;
        }

        else
        {

            Console.WriteLine("Yanlis bidin bidaha dene.");
            remaningRight = remaningRight - 1;
            if (remaningRight < 0)
            {
                Console.WriteLine("Extra hakkin yok.Uygulamadan cikiliyor!");
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            Console.WriteLine($"Kalan extra hak: {remaningRight}");
            Thread.Sleep(500);
            goto guess;
        }

    }


    else if (coose2 == 4)
    {
        Random division1 = new Random();
        double number1 = division1.Next(-10, 10);
        Console.WriteLine($"Birinci sayi: {number1}");

        Random division2 = new Random();
        double number2 = division2.Next(-10, 10);
        Console.WriteLine($"Ikinci sayi: {number2}");

        Console.WriteLine("Hadi bil bakalim.");



    guess:

        Console.WriteLine($"{number1} / {number2}");

        double guess = Convert.ToDouble(Console.ReadLine());

        double division = number1 / number2;

        if (guess == division)
        {

            Console.WriteLine("Wow bildin.");
            Thread.Sleep(500);
            Console.WriteLine("Kazandigin tutar: 100");
            Thread.Sleep(500);
            wallet = wallet + 100;
            Console.WriteLine($"Bakiyen: {wallet}");
            Thread.Sleep(500);
            goto start;
        }

        else
        {

            Console.WriteLine("Yanlis bidin bidaha dene.");
            remaningRight = remaningRight - 1;
            if (remaningRight < 0)
            {
                Console.WriteLine("Extra hakkin yok.Uygulamadan cikiliyor!");
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            Console.WriteLine($"Kalan extra hak: {remaningRight}");
            Thread.Sleep(500);
            goto guess;
        }



    }

    else if (coose2 >= 6 || coose2 <= 0)
    {
        Console.WriteLine("Yanlis tus tekrar deneyin!");
        Thread.Sleep(800);
        goto start;
    }  

    else if (coose2 == 5)
    {

        Console.WriteLine("Yonlendiriliyorsunuz...");
        Thread.Sleep(800);
        goto menu;



    }



    






}


else if (coose1 == 2)
{

    Console.WriteLine($"Ismin: {name}");
    Console.WriteLine($"Soyismin: {surname}");
    Console.WriteLine($"Bakiye: {wallet}");
    again1:
    Console.WriteLine("Menuye donmek icin 1'e basiniz:");
    int returnMenu = int.Parse(Console.ReadLine());

    if (returnMenu == 1)
    {
        goto menu;
    }

    else
    {
        Console.WriteLine("Gecersiz tus!");
        Thread.Sleep(500);
        goto again1;
    }




}

else if (coose1 == 3)
{
    market:
    Console.WriteLine("Almak istediginiz seyi seciniz:");
    Console.WriteLine("1-Extra hak = 500 Coin\n2-Isim-Soyisim yenileme = 1000 Coin");
    Thread.Sleep(500);

    int coose2 = int.Parse(Console.ReadLine());

    if (coose2 == 1)
    {


        if (wallet < 500)
        {

            Console.WriteLine("Yetersiz bakiye!");
            Thread.Sleep(2000);
            goto menu;

        }




        remaningRight = remaningRight + 1;
        Console.WriteLine($" Guncel Extra hak sayisi: {remaningRight}");
        wallet = wallet - 500;
        Console.WriteLine($"Kalan bakiye: {wallet}");
        Thread.Sleep(1000);
        goto menu;

    }









    else if (coose2 == 2)
    {


        if (wallet < 1000)
        {

            Console.WriteLine("Yetersiz bakiye!");
            Thread.Sleep(2000);
            goto menu;

        }




        else
        {

            Console.WriteLine("Yeni isim:");
            name = Console.ReadLine();
            Console.WriteLine($"Yeni isim: {name}");
            Thread.Sleep(1000);

            Console.WriteLine("Yeni soyisim:");
            surname = Console.ReadLine();
            Console.WriteLine($"Yeni soyisim: {surname}");
            wallet = wallet - 1000;
            Console.WriteLine($"Kalan bakiye: {wallet}");
            Thread.Sleep(1000);
            goto menu;

        }

    }

    else
    {
        Console.WriteLine("Yanlis tus tekrar dene!");
        Thread.Sleep(1000);
        goto market;
    }


}


else if (coose1 == 4)
{

   
    
    Console.WriteLine("Uygulama islem yaparak para kazanabileceginiz ve kazandigin parayi markette harcayabilecegin bir oyun");
    Console.WriteLine("ilk basta bakiyeniz 0 olacak siz soru bildikce para kazanacaksiniz.Her soru basina 100 coin kazanacaksiniz");
    Thread.Sleep(4000);
about:
    Console.WriteLine("1-Menuye donus\n2-Cikis");
    int coose3 = int.Parse(Console.ReadLine());

    if (coose3 == 1)
    {
        Console.WriteLine("Menuye donuluyor...");
        Thread.Sleep(1000);
        goto menu;
    }

    else if(coose3 == 2)
    {
        Console.WriteLine("Cikis yapiliyor...");
        Thread.Sleep(1000);
        Environment.Exit(0);

    }

    else
    {
        Console.WriteLine("Yanlis tus tekrar dene!");
        Thread.Sleep(1000);
        goto about;

    }

}


else if (coose1 >= 5 || coose1 <= 0)
{
    Console.WriteLine("Yanlis tus tekrar deneyin!");
    Thread.Sleep(1000);
    goto menu;

}















































