namespace OldPhonePadTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Test_SingleLetter()
        {
            string output = OldPhone.OldPhonePad("33#");
            Assert.AreEqual("E", output);
        }

        [TestMethod]
        public void Test_DeleteAndLetter()
        {
            string output = OldPhone.OldPhonePad("227*#");
            Assert.AreEqual("B", output);
        }

        [TestMethod]
        public void Test_Hello()
        {
            string output = OldPhone.OldPhonePad("4433555 555666#");
            Assert.AreEqual("HELLO", output);
        }


        [TestMethod]
        public void Test_Challange()
        {
            string output = OldPhone.OldPhonePad("8 88777444666*664#");
            Assert.AreEqual("TURING", output);
        }
    }
}
