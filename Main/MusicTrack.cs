using System;

namespace Main {
    public class MusicTrack {
        private readonly string _name;
        private readonly int _length;

        public MusicTrack(
            string name,
            int length
        ) {
            this._length = length;
            this._name = name;
        }

        public string Name => _name;
        public int Length => _length;
    }
}