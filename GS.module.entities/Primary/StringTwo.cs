namespace GS.module.entities.Primary
{
    public class StringTwo
    {
        public string v01 { get; set; }
        public string v02 { get; set; }

        public virtual void GetValue(string field, string value)
        {
            switch (field)
            {
                case "v01": this.v01 = value; break;
                case "v02": this.v02 = value; break;
            }
        }

        ~StringTwo() { }
    }
}
