using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace FlightAchievementTracker.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void CreditCardNumber_TooShort_DisplayErrorMessage()
        {
            app.Repl();
        }
        //[Test]
        //public void FirstScreenShouldDisplayEmptyListOfCharacters() {
        //    Func<AppQuery, AppQuery> character = c => c.Text("Odiryna");

        //    AppResult[] results = app.Query(character);

        //    Assert.IsFalse(results.Any(), "There should be no character at start of application");
        //}

        //[Test]
        //public void AddingACharacterFromFirstScreenShouldDisplayAForm() {

        //    Func<AppQuery, AppQuery> addButton = b => b.Button("Add");

        //    Assert.IsTrue(app.Query(addButton).Any(), "There should be an add button");

        //    app.Tap(addButton);

        //    Assert.IsTrue(app.Query(s => s.Text("Add character")).Any(),"There should be a title for character screen");
        //    Assert.IsTrue(app.Query(l => l.Text("Enter character name")).Any(), "There should be a title for character screen");
        //    Assert.IsTrue(app.Query(l => l.Text("Choose server")).Any(), "There should be a title for character screen");
        //}
    }
}
