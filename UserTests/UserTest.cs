using UserNamespace;
namespace UserTests


{
    public class UserTest
    {
        [Fact]
        public void IsCreated()
        {
            var user1 = new User("Alex", "joeschmo@gmail.com");
            Assert.Equal("Alex", user1.Name);
            Assert.Equal("joeschmo@gmail.com", user1.Email);
            Assert.False(user1.IsLoggedIn); // used the suggestion from VS
        }
        [Fact]

        public void User_IsSetupComplete_SetupCompletionChecked()
        {
            var user1 = new User("Alex", "joeschmo@gmail.com");
            user1.IsSetupComplete();
            Assert.False(user1.IsSetupComplete());
        }
        [Fact]

        public void User_CreatePassword_PasswordAssigned()
        {
            var user1 = new User("Alex", "joeschmo@gmail.com");
            user1.CreatePassword("joeschmo@gmail.com", "1234");
            Assert.Equal("Password Created", user1.confirmation);
        }
        [Fact]
        public void User_LogIn_PasswordChecked()
        {
            
        }
        [Fact]
        public void User_LogOut_LogInChangedToFalse()
        {
            var user1 = new User("Alex", "joeschmo@gmail.com");
            user1.CreatePassword("joeschmo@gmail.com", "1234");
            user1.LogIn("1234");
            user1.LogOut();
            Assert.False(user1.IsLoggedIn);
        }


    }
}