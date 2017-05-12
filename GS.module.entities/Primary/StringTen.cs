namespace GS.module.entities.Primary
{
    public class StringTen: StringFive
    {
        public string v06 { get; set; }
        public string v07 { get; set; }
        public string v08 { get; set; }
        public string v09 { get; set; }
        public string v10 { get; set; }

        public override void GetValue(string field, string value)
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

        ~StringTen() { }
    }
}
