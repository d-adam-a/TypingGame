namespace TypingGame.Models
{
    public class Stats
    {
        public int Correct { get; set; }
        public int Missed { get; set; }
        public int Total { get; set; }
        public int Accuracy { get; set; }

        /*public int Total
        {
            get
            {
                return Correct + Missed;
            }
            set { }
        }
        public int Accuracy
        {
            get
            {
                return Correct * 100 / (Correct + Missed);
            }
            set { }
        }*/

        public void CountTotal()
        {
            Total = Correct + Missed;
        }

        public void CountAccuracy()
        {
            Accuracy = Correct * 100 / (Correct + Missed);
        }
    }
}
