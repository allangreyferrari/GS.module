namespace GS.module.entities.Primary
{
    public class BasicFive: BasicTwo
    {
        public object v03 { get; set; }
        public object v04 { get; set; }
        public object v05 { get; set; }

        public override void GetValue(string field, object value)
        {
            base.GetValue(field, value);
            switch (field)
            {
                case "v03": this.v03 = value; break;
                case "v04": this.v04 = value; break;
                case "v05": this.v05 = value; break;
            }
        }

        ~BasicFive() { }
    }
}
