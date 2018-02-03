Class UserManager{

     Class User {
         string name;
         string imagePath;
         string info;
         User(){

         }
         User(string name , string imagePath , string info) : name(name) , imagePath(imagePath) , info(info) {}
         User() : name("empty") , imagePath("empty") , info("empty") {}
         static User GetUserById(string id){
              // DB call
         }
     }

     Dictionary<string,User> Users;


     UserManager(){
          Users = new Dictionary<string,User>();
     }
     void AddUser(ref User user){
          Users.Add()
     }

}
