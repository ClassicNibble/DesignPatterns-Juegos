namespace JuegoDeCartas { 
    public class Card {
        string name;
        int atk;
        int def;
        string text;

        public Card(string name, int atk, int def, string text) {
            this.name = name;
            this.atk = atk;
            this.def = def;
            this.text = text;
        }

        public string toString() {
            string cadena;
            if (this == null) { cadena = "null";  }
            else cadena = "-CARD-\n Name:" + this.name + "\nATK: " + this.atk + "\nDEF: " + this.def + "\n '" + this.text + "'\n";
            return cadena;
        }
    }
}