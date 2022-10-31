using AxeExercise;

namespace Tests
{
    
    public class Tests
    {
        [Test]
        public void CheckChangingDurability()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            axe.Attack(dummy);
            Assert.That(axe.DurabilityPoints,Is.EqualTo(9),"Axe Durability doesn't change after attack.");
        }
        [Test]
        public void TestSum()
        {
            StartUp st = new StartUp();

            int result=st.Sum(1, 2);

            Assert.AreEqual(3,result);

        }

        [Test]
        public void TestMultiply()
        {
            StartUp st = new StartUp();

            int result = st.Multiply(3, 2);

            Assert.AreEqual(6, result);

        }

        [Test]
      
        public void DummyLosesHealthIfAttacked()
        {
            Dummy dummy = new Dummy(15, 10);

            dummy.TakeAttack(6);

            Assert.That(dummy.Health, Is.EqualTo(9));
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            Dummy dummy = new Dummy(0, 10);

            Assert.That(dummy.GiveExperience(), Is.EqualTo(10));
            
        }

    }
}