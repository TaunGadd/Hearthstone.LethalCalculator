namespace Hearthstone.LethalCalculator.Models.Domain
{
    public abstract class Card
    {
        public abstract void Play();

        public void Discard()
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }
    }
}
