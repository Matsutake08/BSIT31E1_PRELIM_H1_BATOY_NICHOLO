using System;

class Student
{
    public string Name;
    public double Grade1;
    public double Grade2;
    public double Grade3;

    public double Average()
    {
        return (Grade1 + Grade2 + Grade3) / 3;
    }
}