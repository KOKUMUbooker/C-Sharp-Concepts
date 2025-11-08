using System;

namespace InheritanceDemo2
{
    class Post
    {
        private static int lastPostId;

        // properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        // Default constructor. 
        // If a derived class does invoke a base class constructor 
        // explicitly, the default constructor is called implicitly.
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUserName = "John Does";
            Console.WriteLine($"🧓🧓🧓🧓🧓 Post default constructor called on \"{Title.Substring(0,5) + "..."}\" 🧓🧓🧓🧓🧓");
        }

        // Instance constructor that has 3 parameters
        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.ID = 0;
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++lastPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        // All values are children of System.Object class which has 
        // the ToString() method defined
        // System.Object class marked ToString() method using virtual
        // keyword thus we can override it here using the override keyword
        public override string ToString()
        {
            return  String.Format($"Id: {this.ID}\tBy: {this.SendByUserName}\t Post: \"{this.Title}\"");
        }
    }
}