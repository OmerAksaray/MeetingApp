namespace MeetingApp.Models{

    public static class Repository{
        private static List<UserInfo> _users=new();
        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }
        static Repository(){
            _users.Add(new UserInfo(){Id=1,Name="Ali",Email="abc@gmail.com",Phone="55555",WillAttend=true});
            _users.Add(new UserInfo(){Id=2,Name="Ahmet",Email="abc@gmail.com",Phone="222222",WillAttend=true});
            _users.Add(new UserInfo(){Id=3,Name="Yılmaz",Email="abc@gmail.com",Phone="33333",WillAttend=false});
        }
        public static void CreateUser(UserInfo user){
            user.Id=Users.Count+1;
            _users.Add(user);
        }
        public static UserInfo GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}