using Kurs;
using System.Data.Common;
using Kurs.Connection;

namespace TestProject1

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestShifrovanit()
        {
            ClassEncode ccode = new ClassEncode();
            string input = "awar";
            string keyWord = "qw";
            string output = "qmqh";
            string c = ccode.Encode(input, keyWord);
            Assert.AreEqual(output, c);
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestRashifrovanit()
        {
            ClassEncode ccode = new ClassEncode();
            string input = "qmqh";
            string keyWord = "qw";
            string output = "awar";
            string c = ccode.Decode(input, keyWord);
            Assert.AreEqual(output, c);
        }
    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestDBt()
        {
            bool Auth = true;
            string loginUser="1";
            string passwordUser = "1";
            DataBase database = new DataBase();
            database.openConnection();
            bool result = database.AuthUser(loginUser, passwordUser);
            Assert.AreEqual(Auth, result);
        }
    }
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestDBt2()
        {
            bool Auth = true;
            string loginUser = "2";
            string passwordUser = "2";
            DataBase database = new DataBase();
            database.openConnection();
            bool result = database.AuthUser(loginUser, passwordUser);
            Assert.AreNotEqual(Auth, result);
        }
    }
}