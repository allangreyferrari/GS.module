namespace GS.module.entities.Primary
{
    public class BasicTen: BasicFive
    {
        public object v06 { get; set; }
        public object v07 { get; set; }
        public object v08 { get; set; }
        public object v09 { get; set; }
        public object v10 { get; set; }

        public override void GetValue(string field, object value)
        {
            base.GetValue(field, value);
            switch (field)
            {
                case "v06": this.v06 = value; break;
                case "v07": this.v07 = value; break;
                case "v08": this.v08 = value; break;
                case "v09": this.v09 = value; break;
                case "v10": this.v10 = value; break;
            }
        }
        ~BasicTen() { }

    }
}
