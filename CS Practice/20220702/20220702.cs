// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using
using System;   //일종의 헤더파일 호출

//class
//개념의 표현
class Player
{

}

//namespace
//클래스 선언과 비슷함
//개념의 분류
namespace ProgA
{
    class Player    //ProA.Player
    {

    }
}

//멤버변수와 상수
namespace Prog
{
    class Player
    {
        int Gold = 0;
        int Exp;
        int Att;
        int Def;
        int HP;
        //c 그대로 사용
    }
}

//멤버함수와 지역변수
namespace Prog
{
    class Player
    {
        void move()
        {
            //함수내용
        }
        void func1()
    }
}

//클래스 접근제한 지정자
class Player
{
    int ATT;
    int HP;

    void printfight()
    {
        Console.WriteLine("fight");
    }
    //public int        외부에도 공개
    //protected int     자식에게만 공개
    //private int       내부에만 공개
}

class Program
{
    static void Main(string[] args)
    {
        Player New_Player = new Player();
        New_Player.printfight();
    }
}