namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void FlipButton_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            int sorteio = random.Next(2);
            //Animação();
            if (sorteio == 0)
            {
                MoedaImage.Source = "cara.png";
            }
            else
            {
                MoedaImage.Source = "coroa.png";
            }

            if (SelecaoPicker.SelectedIndex == sorteio)
            {
                DisplayAlert("Parabéns", "Você venceu!", "Ok");
            }
            else
            {
                DisplayAlert("Se ferrou", "Você perdeu!", "Ok");
            }
        }
    }

}
