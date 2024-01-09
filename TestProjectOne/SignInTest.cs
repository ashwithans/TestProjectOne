using SignInLib;

namespace TestProjectOne
{
    [TestClass]
    public class SignInTest
    {     
        [TestMethod]
        public void SuccessMethod()
        {
            string expRes = "valid user";
            Assert.AreEqual(expRes,SignIn.Authenticate("sam","sam@1256"));
        }

        [TestMethod]
        public void FailMethod()
        {
            string expRes = "invalid user credential";
            Assert.AreEqual(expRes, SignIn.Authenticate("ravi", "ravi@123"));
        }

        [TestMethod]
        public void AnonymousMethod()
        {
            string expRes = "You must provide username and password";
            Assert.AreEqual(expRes, SignIn.Authenticate(null, null));
        }
    }
}