<<<<<<< HEAD
using aula124.Entities.Enums;

namespace aula124.Entities;

class Order
{
    public int Id { get; set; }
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }

    override public string ToString()
    {
        return string.Format("{0}, {1}, {2}", Id, Moment, Status);
    }
=======
using aula124.Entities.Enums;

namespace aula124.Entities;

class Order
{
    public int Id { get; set; }
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }

    override public string ToString()
    {
        return string.Format("{0}, {1}, {2}", Id, Moment, Status);
    }
>>>>>>> 2f54776591db587008f28ed6e6b0c338db6e9ded
}