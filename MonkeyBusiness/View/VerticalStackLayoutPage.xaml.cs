using MonkeyBusiness.ViewModel;

namespace MonkeyBusiness.View
{
    public partial class VerticalStackLayoutPage : ContentPage
    {
        public VerticalStackLayoutPage(VerticalStackLayoutViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
        }

        private void btnCollapse_Clicked(object sender, EventArgs e)
        {
            lblCollapsable.IsVisible = !lblCollapsable.IsVisible;

            if (lblCollapsable.IsVisible)
                btnCollapse.Text = "Collapse content";
            else
                btnCollapse.Text = "Expand content";
        }
    }
}