<<<<<<< HEAD
namespace composicao.Entities;

class HourContract
{
    public DateTime Date { get; set; }
    public double ValuePerHour { get; set; }
    public int Hours { get; set; }

    public HourContract(DateTime date, double valuePerHour, int hours)
    {
        Date = date;
        ValuePerHour = valuePerHour;
        Hours = hours;
    }

    public double TotalValue()
    {
        return ValuePerHour * Hours;
    }
=======
namespace composicao.Entities;

class HourContract
{
    public DateTime Date { get; set; }
    public double ValuePerHour { get; set; }
    public int Hours { get; set; }

    public HourContract(DateTime date, double valuePerHour, int hours)
    {
        Date = date;
        ValuePerHour = valuePerHour;
        Hours = hours;
    }

    public double TotalValue()
    {
        return ValuePerHour * Hours;
    }
>>>>>>> 2f54776591db587008f28ed6e6b0c338db6e9ded
}