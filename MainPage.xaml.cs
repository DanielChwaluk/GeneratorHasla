namespace haslo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGenPasClicked(object sender, EventArgs e)
        {
            Random rdn = new Random();
            bool MaleLit = ChkMaleLit.IsChecked;
            bool DuzeLit = ChkDuzeLit.IsChecked;
            bool Cyfry = ChkCyfry.IsChecked;
            bool ZnakSpec = ChkCyfry.IsChecked;
            string haslo = "";
            if(MaleLit || DuzeLit || Cyfry || ZnakSpec)
            while (haslo.Length < 20)
            { 
                if (MaleLit) haslo += Convert.ToChar(rdn.Next(97, 122));
                if (DuzeLit) haslo += Convert.ToChar(rdn.Next(65, 90));
                if (Cyfry) haslo += Convert.ToChar(rdn.Next(48, 57));
                if (ZnakSpec) haslo += Convert.ToChar(rdn.Next(58, 64));
            }
            char[] characters = haslo.ToCharArray();
            characters.Reverse();   
            haslo = new string(characters);
            LblWynik.Text = haslo;
            SemanticScreenReader.Announce(LblWynik.Text);
        }
    }
}