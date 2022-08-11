using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTestProject_1
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void log_whenCalled_SetTheLastErrorProperty()
        {
            var loggerr = new ErrorLogger();
            loggerr.Log("a");
            Assert.That(loggerr.LastError,Is.EqualTo("a"));
            
        }

        [Test]
        [TestCase(null)]
        [TestCase(" ")]
        [TestCase("")]
        public void Log_InvalidError_ThrowsArgumentNullException(string error)
        {
            var logger = new ErrorLogger();
            //logger.Log(error);
            Assert.That(()=>logger.Log(error),Throws.ArgumentNullException);
            //Assert.That(()=>logger.Log(error),Throws.Exception.TypeOf<DivideByZeroException>());
            
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();
            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args;};
            logger.Log("a");
            
            Assert.That(id,Is.Not.EqualTo(Guid.Empty));
            
        }

    }
}