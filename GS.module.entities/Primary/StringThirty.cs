namespace GS.module.entities.Primary
{
    public class StringThirty: StringTwenty
    {
        public string v21 { get; set; }
        public string v22 { get; set; }
        public string v23 { get; set; }
        public string v24 { get; set; }
        public string v25 { get; set; }
        public string v26 { get; set; }
        public string v27 { get; set; }
        public string v28 { get; set; }
        public string v29 { get; set; }
        public string v30 { get; set; }

        public override void GetValue(string field, string value)
        {
            base.GetValue(field, value);
            switch (field)
            {
                case "v21": this.v21 = value; break;
                case "v22": this.v22 = value; break;
                case "v23": this.v23 = value; break;
                case "v24": this.v24 = value; break;
                case "v25": this.v25 = value; break;
                case "v26": this.v26 = value; break;
                case "v27": this.v27 = value; break;
                case "v28": this.v28 = value; break;
                case "v29": this.v29 = value; break;
                case "v30": this.v10 = value; break;
            }

        }

        ~StringThirty() { }

    }
}
