namespace Elaimet {
    public class Cat {
        private int _age;
        private string _name;
        
        public Cat() {}

        public Cat(int age = 0, string name = "Miuku") {
            this._age = age;
            this._name = name;
        }

        public int GetAge() {
            return this._age;
        }

        public bool SetAge(int age) {
            if (age <= 0) { return false; }

            this._age = age;
            return true;
        }

        public string GetName() {
            return this._name;
        }

        public bool SetName(string name) {
            if (name.ToLower() == "hilda") { return false; }

            this._name = name;
            return true;
        }
    }
}