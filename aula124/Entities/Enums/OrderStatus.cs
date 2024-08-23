namespace aula124.Entities.Enums;

enum OrderStatus : int
{
    // Se não colocar nada começa do 0
    PendingPayment = 0,
    Processing = 1,
    Shipped = 2,
    Delivered = 3
}