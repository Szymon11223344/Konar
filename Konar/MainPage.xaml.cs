namespace Konar
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void DiceRoll(object sender, EventArgs e)
        {
            int[] dice = new int[5];

            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                dice[i] = r.Next(1, 7);
            }

            Dice0.Source = "k6_" + dice[0] + ".png";

            dice1.Source = "k6_" + dice[1] + ".png";

            dice2.Source = "k6_" + dice[2] + ".png";

            dice3.Source = "k6_" + dice[3] + ".png";

            dice4.Source = "k6_" + dice[4] + ".png";

            for (int dots = 1; dots <= 6; dots++)
            {
                int count = 0;


            }

        }

        private void ResetGame(object sender, EventArgs e)
        {
            Dice0.Source = "k6_0.png";

            dice1.Source = "k6_0.png";

            dice2.Source = "k6_0.png";

            dice3.Source = "k6_0.png";

            dice4.Source = "k6_0.png";
        }
    }

}