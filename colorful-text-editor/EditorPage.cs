using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace colorfultexteditor
{
    public class EditorPage : ContentPage
    {
		Label label;
        Picker SizePicker;
        Picker FontPicker;

		Dictionary<string, Color> nameToColor = new Dictionary<string, Color>
		{
			{ "Aqua", Color.Aqua }, { "Black", Color.Black },
            { "Blue", Color.Blue }, { "Pink", Color.Pink },
			{ "Gray", Color.Gray }, { "Green", Color.Green },
			{ "Lime", Color.Lime }, { "Maroon", Color.Maroon },
			{ "Navy", Color.Navy }, { "Olive", Color.Olive },
			{ "Purple", Color.Purple }, { "Red", Color.Red },
			{ "Silver", Color.Silver }, { "Teal", Color.Teal },
			{ "White", Color.White }, { "Yellow", Color.Yellow }
		};

        Dictionary<string, FontAttributes> nameToFont = new Dictionary<string, FontAttributes> { 
        
            {"Bold", FontAttributes.Bold},
            {"Italic", FontAttributes.Italic},
			{"None", FontAttributes.None}
	};

        Dictionary<string, NamedSize> nameToNamedSize = new Dictionary<string, NamedSize> {
            {"Micro", NamedSize.Micro},
            {"Default", NamedSize.Default},
            {"Small", NamedSize.Small},
            {"Medium", NamedSize.Medium},
            {"Large", NamedSize.Large},
	};

		public EditorPage()
        {
			var layout = new StackLayout {
				VerticalOptions = LayoutOptions.Center
			};

			SizePicker = new Picker {
				Title = "Size Options",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			FontPicker = new Picker
			{
				Title = "Font Options",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

            foreach (string font in nameToFont.Keys)
			{
                FontPicker.Items.Add(font);
			}

            foreach (string namedSize  in nameToNamedSize.Keys)
            {
                SizePicker.Items.Add(namedSize);
            }


            var buttonLayout = new StackLayout {
				Padding = new Thickness(0, 25, 0, 10),
				Spacing = 10,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			var ColorText = new Entry();
			label = new Label() { FontSize = 24 };

			BoxView boxView = new BoxView
			{
				WidthRequest = 150,
				HeightRequest = 150,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};


			var RedColorButton = new Button()
			{
				Text = "RED",
				BackgroundColor = Color.DarkRed,
				TextColor = Color.White,
				BorderWidth = 1,
				BorderRadius = 20
			};

			var BlueColorButton = new Button() { Text = "BLUE", BackgroundColor = Color.Blue, TextColor = Color.White };
			var GreenColorButton = new Button() { Text = "GREEN", BackgroundColor = Color.Green, TextColor = Color.White };

			RedColorButton.Clicked += OnButtonClicked;
			//BlueColorButton.Clicked += OnButtonClicked;
			//GreenColorButton.Clicked += OnButtonClicked;
			

			ColorText.TextChanged += (sender, e) =>
			{
				label.Text = ColorText.Text;
			};

            var fs = new FormattedString();

            layout.Children.Add(SizePicker);
            layout.Children.Add(FontPicker);
			layout.Children.Add(ColorText);
			buttonLayout.Children.Add(RedColorButton);
			buttonLayout.Children.Add(BlueColorButton);
			buttonLayout.Children.Add(GreenColorButton);
			layout.Children.Add(buttonLayout);
			layout.Children.Add(label);

			this.Content = layout;
        }

        public void ApplyFormatToText(){}
        public void AddIntoLabelFormatted(){}

		void OnButtonClicked(object sender, EventArgs e)
		{
			var button = (Button)sender;
			

		}
    }
}

