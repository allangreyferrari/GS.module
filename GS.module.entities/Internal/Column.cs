namespace GS.module.entities.Internal
{
    public class Column
    {
        public string campo { get; set; } 
        public string key { get; set; }
        public int index { get; set; }
        public int cryp { get; set; } // 0[None] - 1[Encryp] - 2[Decryp]
        ~Column() { }
    }
}
