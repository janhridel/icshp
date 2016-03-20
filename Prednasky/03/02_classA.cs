class A
{
    const int x = 10;
    readonly int y = 20;
    public A(int y)
    {
        this.y = y; // OK 
        x = 20; // Chyba 
    }
    public void Set(int y)
    {
        this.y = y; // Chyba 
    }
}