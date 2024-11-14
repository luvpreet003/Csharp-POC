namespace classes
{
        public class Post
        {
            public int _vote;
            public string _title;
            public string _description;
            public DateTime _dateCreated;
            private bool _postCreated;

            public void CreatePost(string title, string description)
            {
                if(!_postCreated)
                {
                    _title = title;
                    _description = description;
                    _dateCreated = DateTime.Now;
                    Console.WriteLine("Post created!");
                    _postCreated = true;
                }
                else
                {
                    Console.WriteLine("Post creation in progress!");
                }
            }

            public Post ShowPost()
            {
                if (_postCreated)
                {
                    return new Post()
                    {
                        _vote = _vote,
                        _title = _title,
                        _description = _description,
                        _dateCreated = _dateCreated
                    };
                }
                else
                {
                    return null;
                }
            }

            public void UpVote()
            {
                if(_postCreated)
                {
                    _vote++;
                    Console.WriteLine("up voted!");
                }
                else
                {
                    Console.WriteLine("Create a post first!");
                }

            }

            public void DownVote()
            {
                if (_postCreated)
                {
                    _vote--;
                    Console.WriteLine("down voted!");
                }
                else
                {
                    Console.WriteLine("Create a post first!");
                }
            }

            public void DeletePost()
            {
                if (_postCreated)
                {
                    _postCreated = false;
                    Console.WriteLine("Post Deleted!");
                }
                else
                {
                    Console.WriteLine("No post to delete!");
                }
            }
        }
}