using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter14
{
    class FriendList
    {
        private List<string> list = new List<string>();

        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach (var s in list) Console.WriteLine(s);
        }

        public FriendList() => Console.WriteLine("FriendList");
        ~FriendList() => Console.WriteLine("FriendList Bye");

        public int Capacity
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }

        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }
    internal class ExpressionBodiedMember
    {
    }
}
