namespace projeto
{
    public partial class MainPage : ContentPage
    {
        string vez = "0";

        public MainPage()
        {
            InitializeComponent();
        }

   

        private void btn10_Clicked(object sender, EventArgs e)
        {
            Button disparador= (Button)sender; 
            disparador.IsEnabled = false;
            if(vez == "0") 
            {
                disparador.Text = "0";
                vez = "x";
            }
            else 
            {
                disparador.Text = "x";
                vez = "0";

            }

        }
    }

}
