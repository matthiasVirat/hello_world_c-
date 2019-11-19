using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloworldConsole;

namespace MessageTests
{
    [TestClass]
    public class MessageTests
    {
        int _t1 = 9;
        int _t2 = 13;
        int _t3 = 19;

        [TestMethod]
        public void HelloMessageSemaineMatinTest()
        {
            FakeUserName name = new FakeUserName();
            name.NameToReturn = "Tristan Tariv";

            FakeDayHour dayHour = new FakeDayHour();
            dayHour.DayToReturn = "lundi";
            dayHour.HourToReturn = 9;

            Message message = new Message(this._t1, this._t2, this._t3, name, dayHour);
            Assert.AreEqual("Bonjour Tristan Tariv", message.GetHelloMessage());
        }

        [TestMethod]
        public void HelloMessageSemaineApresMidiTest()
        {
            FakeUserName name = new FakeUserName();
            name.NameToReturn = "Toto Tata";

            FakeDayHour dayHour = new FakeDayHour();
            dayHour.DayToReturn = "mardi";
            dayHour.HourToReturn = 13;

            Message message = new Message(this._t1, this._t2, this._t3, name, dayHour);
            Assert.AreEqual("Bon après-midi Toto Tata", message.GetHelloMessage());
        }

        [TestMethod]
        public void HelloMessageSemaineSoirTest()
        {
            FakeUserName name = new FakeUserName();
            name.NameToReturn = "Tutu Toto";

            FakeDayHour dayHour = new FakeDayHour();
            dayHour.DayToReturn = "mercredi";
            dayHour.HourToReturn = 19;

            Message message = new Message(this._t1, this._t2, this._t3, name, dayHour);
            Assert.AreEqual("Bonsoir Tutu Toto", message.GetHelloMessage());
        }

        [TestMethod]
        public void HelloMessageVendrediSoirTest()
        {
            FakeUserName name = new FakeUserName();
            name.NameToReturn = "Titi Tutu";

            FakeDayHour dayHour = new FakeDayHour();
            dayHour.DayToReturn = "vendredi";
            dayHour.HourToReturn = 19;

            Message message = new Message(this._t1, this._t2, this._t3, name, dayHour);
            Assert.AreEqual("Bon week-end Titi Tutu", message.GetHelloMessage());
        }

        [TestMethod]
        public void HelloMessageWeekEndTest()
        {
            // Samedi 23 novembre 19, 19:00
            FakeUserName name = new FakeUserName();
            name.NameToReturn = "Tete Titi";

            FakeDayHour dayHour = new FakeDayHour();
            dayHour.DayToReturn = "samedi";
            dayHour.HourToReturn = 19;
            
            Message message = new Message(this._t1, this._t2, this._t3, name, dayHour);
            Assert.AreEqual("Bon week-end Tete Titi", message.GetHelloMessage());
        }
    }
}
