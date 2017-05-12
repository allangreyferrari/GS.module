namespace GS.module.entities.Internal
{
    public class Procedure
    {
        public int idsystem { get; set; }
        public int id { get; set; }
        public string method{ get; set; }
        public string description{ get; set; }
	    public string page{ get; set; }
        public bool state{ get; set; }
        ~Procedure() { }
    }
}
