using UnityEngine;

public interface IFeedable
{
    void Feed(Food food);
}

public abstract class Food
{
    protected Food(int nutrition)
    {
        Nutrition = nutrition;
    }
    
    public int Nutrition;
    
    
}

public class Apple : Food
{
    public Apple(string color) : base(30)
    {
        Color = color;
    }

    public string Color;
}

public abstract class Animal
{
    public int Hunger = 100;

    public abstract void MakeSounds();
    public void Feed(Food food)
    {
        Hunger -= food.Nutrition;
    }
}

public class Dog : Animal
{
    public void KopegeOzgu()
    {
        
    }
    
    public override void MakeSounds()
    {
        Debug.Log("Dog is Barking.");
    }
}

public class Cat : Animal
{
    public override void MakeSounds()
    {
        Debug.Log("Cat is meowing.");
    }
}

public interface IClickable
{
    bool Clicked { get; set; }
}

public class Mouse : IClickable
{
    public Mouse()
    {
        Clicked = false;
    }
    
    public bool Clicked { get; set; }
}

public class SpecialButton : IClickable
{
    public bool Clicked { get; set; } = true;
}

public class Test
{
    public void TestTest2(IClickable clickable)
    {
        
    }
    public void TestTest()
    {
        Mouse mouse = new Mouse();
        SpecialButton button = new SpecialButton();
        
        TestTest2(mouse);
        TestTest2(button);
    }
}






















public class Keyboard
{
    public Keyboard(string model, string marka)
    {
        Model = model;
        Marka = marka;
    }
    /// <summary>
    /// null
    /// </summary>
    //public string Marka;
    public string Model { get; }
    public string Marka { get; }

    public static bool HasEscKey = true;
    
    public void Yaz(string bastigimizTus, PcScreen screen)
    {
        screen.EkrandaYazanYazi = screen.EkrandaYazanYazi + bastigimizTus;

        bastigimizTus = "y";
    }
}

public class PcScreen
{
    public int Brightness;


    private string ozelString = "ozell";
    
    //
    public string EkrandaYazanYazi = "";
}

public static class MainClass
{
    public static void Main(string[] args)
    {
        bool test8 = Keyboard.HasEscKey;
        
        Keyboard logitech = new Keyboard("12533", "Logitech");
        
        PcScreen screen = new PcScreen();
        screen.Brightness = 50;

        string basilacakTus = "m";
        logitech.Yaz(basilacakTus, screen);
        
        //""
        
        string test = "Bu klavyenin markası : " + logitech.Marka + "'dır";
        string test2 = "Ekranda şu an: " + screen.EkrandaYazanYazi + " yazıyor";
        
        //System.out.println(test);
        //System.Console.WriteLine(test);
        Debug.Log(test);
    }
    
    
}