namespace Elaimet {
    public class Cat {
        private int _age;
        public string _name;
        
        public Cat() {}

        public Cat(int age, string name) {
            this._age = age;
            this._name = name;
        }

        public int Age {
            get => this._age;
        }

        public string Name {
            get => this._name;
            set => this._name = value;
        }
    }
}