using System;

namespace InheritanceDemo2
{
    class ImagePost:Post
    {
        public string ImageUrl { get; set; }

        public ImagePost()
        {
            Console.WriteLine($"👶👶👶👶 ImagePost default constructor called \"{Title.Substring(0,5) + "..."}\"👶👶👶");
        }

        public ImagePost(string title, string sendByUserName, string imageUrL, bool isPublic)
        {
            // We get access to all member fields & methods defined in the base class
            this.ID = GetNextID(); // A protected method defined inside the base class - Post
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;

            // Property defined in the ImagePost class
            this.ImageUrl = imageUrL;
        }

        public override string ToString()
        {
            return  String.Format($"Id: {this.ID}\tBy: {this.SendByUserName}\t Post: \"{this.Title}\"\tImageUrl : {ImageUrl}");
        }
    }
}