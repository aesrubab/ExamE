using ConsoleApp1.Entities.Concrate;
using ConsoleApp1.Insta.Project.DAL.Context;
using ConsoleApp1.Insta.Project.DAL.Repository.Concrate;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new InstaDbContext())
        {
            // Repositoryleri yaratmaq ucun
            var userRepository = new BaseRepository<User>(context);
            var userDetailsRepository = new BaseRepository<UserDetail>(context);
            var postRepository = new BaseRepository<Post>(context);
            var commentRepository = new BaseRepository<Comment>(context);



            // melumat daxil edey
            var userDetails = new UserDetail
            {
                Name = "Rubab",
                Surname = "Huseynova",
                Birthday = new DateTime(2004, 2, 22),
                Role = Role.User
            };
            var userDetails1 = new UserDetail
            {
                Name = "Aygun ",
                Surname = "Bayramova",
                Birthday = new DateTime(2004, 2, 22),
                Role = Role.User
            };
            //userDetailsRepository.Add(userDetails);
            userDetailsRepository.Add(userDetails1);
            userDetailsRepository.SaveChanges();

            Console.WriteLine("userDetails daxil edildi");


            var newUser = new User
            {
                UserDetails = userDetails
            };
            //userRepository.Add(newUser);
            userRepository.SaveChanges();


            var newUser1 = new User
            {
                UserDetails = userDetails1
            };
            userRepository.Add(newUser1);
            userRepository.SaveChanges();

            Console.WriteLine("User elave olundu");


            var users = userRepository.GetAll();
            foreach (var user in users)
            {
                Console.WriteLine($"User ID: {user.Id}, Name: {user.UserDetails.Name}, Role: {user.UserDetails.Role}");
            }


            var userToUpdate = userRepository.GetById(newUser.Id);
            if (userToUpdate != null)
            {
                userToUpdate.UserDetails.Name = "rubka";
                userToUpdate.UserDetails.Surname = "Huseynova";
                userRepository.Update(userToUpdate.Id);
                Console.WriteLine("Update olduuuu");
            }



            var newPost = new Post
            {
                Text = "Fenerbahce Sampion olduuuuuu",
                LikeCount = 99999999,
                CreatedDate = DateTime.Now
            };
            postRepository.Add(newPost);
            Console.WriteLine("Postumuz elave olundu");


            var posts = postRepository.GetAll();
            foreach (var post in posts)
            {
                Console.WriteLine($"Post ID: {post.Id}, Text: {post.Text}, Likes: {post.LikeCount}");
            }



            var newComment = new Comment
            {
                Text = "FB<3",
                LikeCount = 999,
                PostId = newPost.Id,
                CreatedDate = DateTime.Now
            };
            commentRepository.Add(newComment);
            Console.WriteLine("komment elave olundu");

            var comments = commentRepository.GetAll();
            foreach (var comment in comments)
            {
                Console.WriteLine($"Comment ID: {comment.Id}, Text: {comment.Text}, Likes: {comment.LikeCount}");
            }

        }
    }
}
