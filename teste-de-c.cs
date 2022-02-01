using System;

class Bhaskara{
    public double a,b,c,delta,x1,x2;
    
    public void ler(){
        string linha;
        string[] valores;
        linha = Console.ReadLine();
        valores = linha.Split(' ');
        a = Convert.ToDouble(valores[0]);
        b = Convert.ToDouble(valores[1]);
        c = Convert.ToDouble(valores[2]);
        delta = b*b-(4*a*c);
     
    }

    public double raiz1(){
       x1 = (-b + Math.Sqrt(delta))/(2*a);
       return x1;
    }
        
    public double raiz2(){
       x2 = (-b - Math.Sqrt(delta))/(2*a);
       return x2;
    }

}


class principal{

    public static void Main(string []args) { 
        Bhaskara B = new Bhaskara();
        B.ler();
        if (B.delta <0)
        Console.WriteLine("Impossivel calcular");
        else {
        Console.WriteLine("R1 = {0:F5}",B.raiz1());
        Console.WriteLine("R2 = {0:F5}",B.raiz2());
        }
    }

}