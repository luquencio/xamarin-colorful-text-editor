using System;

using Xamarin.Forms;

namespace colorfultexteditor
{
    public class EditorPage : ContentPage
    {
        public EditorPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

