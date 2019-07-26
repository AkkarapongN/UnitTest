namespace TestProj
{
    internal class Calculate
    {
        internal Money Change(int changeMoney)
        {
            Money money = new Money();

            while (changeMoney >= 500)
            {
                changeMoney -= 500;
                money.Bank500++;
            }

            while (changeMoney >= 100)
            {
                changeMoney -= 100;
                money.Bank100++;
            }

            while (changeMoney >= 50)
            {
                changeMoney -= 50;
                money.Bank50++;
            }

            while (changeMoney >= 20)
            {
                changeMoney -= 20;
                money.Bank20++;
            }

            while (changeMoney >= 10)
            {
                changeMoney -= 10;
                money.Coin10++;
            }

            while (changeMoney >= 5)
            {
                changeMoney -= 5;
                money.Coin5++;
            }

            while (changeMoney >= 2)
            {
                changeMoney -= 2;
                money.Coin2++;
            }


            return money;
        }
    }

}