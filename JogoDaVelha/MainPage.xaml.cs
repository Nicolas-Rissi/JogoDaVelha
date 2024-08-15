namespace JogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        int contador = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Boolean old_woman = true;

            btn.IsEnabled = false;

            contador++;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "⭕";
            }
            else
            {
                btn.Text = "⭕";
                vez = "X";
            }

            // x ganhou a 1 linha
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns 🎉", "O X ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            // x ganhou a 2 linha
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("Parabéns 🎉", "O X ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            // x ganhou a 3 linha
            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns 🎉", "O X ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            // x ganhou a 1 coluna
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns 🎉", "O X ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            // x ganhou a 2 coluna
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlert("Parabéns 🎉", "O X ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            // x ganhou a 3 coluna
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns 🎉", "O X ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            // x ganhou a diagonal \
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns 🎉", "O X ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            // x ganhou diagonal /
            if (btn30.Text == "X" && btn21.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns 🎉", "O X ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            // bolinha

            // ⭕ ganhou a 1 linha
            if (btn10.Text == "⭕" && btn11.Text == "⭕" && btn12.Text == "⭕")
            {
                DisplayAlert("Parabéns 🎉", "O ⭕ ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            // ⭕ ganhou a 2 linha
            if (btn20.Text == "⭕" && btn21.Text == "⭕" && btn22.Text == "⭕")
            {
                DisplayAlert("Parabéns 🎉", "O ⭕ ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            // ⭕ ganhou a 3 linha
            if (btn30.Text == "⭕" && btn31.Text == "⭕" && btn32.Text == "⭕")
            {
                DisplayAlert("Parabéns 🎉", "O ⭕ ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            // ⭕ ganhou a 1 coluna
            if (btn10.Text == "⭕" && btn20.Text == "⭕" && btn30.Text == "⭕")
            {
                DisplayAlert("Parabéns 🎉", "O ⭕ ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            // ⭕ ganhou a 2 coluna
            if (btn11.Text == "⭕" && btn21.Text == "⭕" && btn31.Text == "⭕")
            {
                DisplayAlert("Parabéns 🎉", "O ⭕ ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            // ⭕ ganhou a 3 coluna
            if (btn12.Text == "⭕" && btn22.Text == "⭕" && btn32.Text == "⭕")
            {
                DisplayAlert("Parabéns 🎉", "O ⭕ ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            // ⭕ ganhou a diagonal \
            if (btn10.Text == "⭕" && btn21.Text == "⭕" && btn32.Text == "⭕")
            {
                DisplayAlert("Parabéns 🎉", "O ⭕ ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            // ⭕ ganhou diagonal /
            if (btn30.Text == "⭕" && btn21.Text == "⭕" && btn12.Text == "⭕")
            {
                DisplayAlert("Parabéns 🎉", "O ⭕ ganhou", "Zerar");
                limpar();
                old_woman = false;
            }

            if (old_woman && contador == 9)
            {
                DisplayAlert("Xiiiiiii", "Deu velha", "Zerar");
                limpar();
            }
        }

        void limpar()
        {
            vez = "X";

            contador = 0;

            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";

            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";

            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;

            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;

            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;
        }
    }

}
