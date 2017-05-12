namespace GS.module.entities.Primary
{
    public class StringTwenty: StringTen
    {
        public string v11 { get; set; }
        public string v12 { get; set; }
        public string v13 { get; set; }
        public string v14 { get; set; }
        public string v15 { get; set; }
        public string v16 { get; set; }
        public string v17 { get; set; }
        public string v18 { get; set; }
        public string v19 { get; set; }
        public string v20 { get; set; }

        public override void GetValue(string field, string value)
        {
            base.GetValue(field, value);
            switch (field)
            {
                case "v11": this.v11 = value; break;
                case "v12": this.v12 = value; break;
                case "v13": this.v13 = value; break;
                case "v14": this.v14 = value; break;
                case "v15": this.v15 = value; break;
                case "v16": this.v16 = value; break;
                case "v17": this.v17 = value; break;
                case "v18": this.v18 = value; break;
                case "v19": this.v19 = value; break;
                case "v20": this.v20 = value; break;
            }

        }
        ~StringTwenty() { }

    }
}
