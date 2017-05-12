namespace GS.module.entities.Primary
{
    public class StringFive: StringTwo
    {
        public string v03 { get; set; }
        public string v04 { get; set; }
        public string v05 { get; set; }

        public override void GetValue(string field, string value)
        {
            base.GetValue(field, value);
            switch (field)
            {
                case "v03": this.v03 = value; break;
                case "v04": this.v04 = value; break;
                case "v05": this.v05 = value; break;
            }
        }

        ~StringFive() { }
    }
}
