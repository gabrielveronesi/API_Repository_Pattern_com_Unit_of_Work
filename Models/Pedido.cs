namespace LojaUnit.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public int ClienteId { get; set; } //Pedido pertence a um cliente
        public Cliente Cliente { get; set; }
    }
}