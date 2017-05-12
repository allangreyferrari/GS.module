namespace GS.module.entities.Primary
{
    public class BasicTwo
    {
        public object v01 { get; set; }
        public object v02 { get; set; }

        public virtual void GetValue(string field, object value)
        {
            switch (field)
            {
                case "v01": this.v01 = value; break;
                case "v02": this.v02 = value; break;
            }
        }
        ~BasicTwo() { }
    }
}
