using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_repo_testi
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
// Testin testin testi
public class Calculator : ICalculator
{
    public int Add(int numero1, int numero2)
    {
        return numero1 + numero2;
    }
    public int Multiply(int numero1, int numero2)
    {
        return numero1 * numero2;
    }
}

class TestiPeti
{
    static void Main(string[]args)
        {
        //kokeillaan luokkaa calculator
        }
    public void DivideTest()
    {
        //arrange = alustus, valmistelu
        Calculator calc = new Calculator();
        int n1 = 21;
        int n2 = 0;
        int expected = 4;
        // act=toimi
        int actual = calc.Divide(n1, n2);
        // assert=tarkistus
        Assert.AreEqual(expected, actual1);
    }
}
class dice
    {
    static void Dice()
    {
        Dice = new kylki();
        int s1 = 1;
        int s2 = 2;
        int s3 = 3;
        int s4 = 4;
        int s5 = 5;
        int s6 = 6;
    }
    }