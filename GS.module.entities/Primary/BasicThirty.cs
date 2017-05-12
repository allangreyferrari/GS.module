namespace GS.module.entities.Primary
{
    public class BasicThirty: BasicTwenty
    {
        public object v21 { get; set; }
        public object v22 { get; set; }
        public object v23 { get; set; }
        public object v24 { get; set; }
        public object v25 { get; set; }
        public object v26 { get; set; }
        public object v27 { get; set; }
        public object v28 { get; set; }
        public object v29 { get; set; }
        public object v30 { get; set; }

        public override void GetValue(string field, object value)
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

        ~BasicThirty() { }
    }
}
