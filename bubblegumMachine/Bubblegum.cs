namespace bubblegumMachine
{
    class Bubblegum
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string color;

		public string Color
		{
			get { return color; }
			set { color = value; }
		}


        public Bubblegum(string name, string color)
        {
            this.Color = color;
            this.name = name;
        }
    }
}