﻿using System.Globalization;
class Employees
{
    public int Id { get; set; }

    public string Nome {  get; set; }   
    public double Salario { get; private set; } 
     public Employees(int id, string nome, double salario)
    {
        Id = id;
        Nome = nome;
        Salario = salario;
     }

    public void AumentoSalrio(double porcentagem)
    {
        Salario += Salario * porcentagem / 100.0;
    }

    public override string ToString()
    {
        return Id + "," + Nome + "," + Salario.ToString("F2", CultureInfo.InvariantCulture);
    }
}

