namespace bubblegumMachine
{
    class Bubblegum
    {
		private char name;

		public char Name
		{
			get { return name; }
			set { name = value; }
		}

		private char color;

		public char Color
		{
			get { return color; }
			set { color = value; }
		}

		private char flavor;

		public char Flavor
		{
			get { return flavor; }
			set { flavor = value; }
		}

        public Bubblegum(char name, char color, char flavor)
        {
            this.Color = color;
            this.flavor = flavor;
            this.name = name;
        }
    }
}