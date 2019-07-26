namespace TestProj
{
    internal class Money
    {
        public int Bank50 { get; internal set; }
        public int Coin5 { get; internal set; }
        public int Bank20 { get; internal set; }
        public int Bank100 { get; internal set; }
        public int Coin10 { get; internal set; }
        public int Coin2 { get; internal set; }
        public int Bank500 { get; internal set; }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5}", 
                this.Bank100, this.Bank50, this.Bank20, this.Coin10,this.Coin5, this.Coin2);
        }
    }
}