namespace GS.module.entities.Base
{
    public class Transaction
    {
        public TypeTransaction Type { get; set; }
        public string Message { get; set; }

        ~Transaction() { }
    }

    public enum TypeTransaction
    {
        OK, ERR
    }   
}
