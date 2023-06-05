﻿namespace PomoTimer001;

public partial class MainPage : ContentPage
{
	int count = 0;
	List<String> tomatoList = new();
    Random rnd = new();

    public MainPage()
	{
		tomatoList.Add("tomato_1.jpg");
        tomatoList.Add("tomato_2.jpg");
        tomatoList.Add("tomato_3.jpg");

		InitializeComponent();

    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void OneMoreTimeBtn_Clicked(object sender, EventArgs e)
    {
		CounterBtn.Text = "I seem to have been reset...";
		MainImage.Source = tomatoList[rnd.Next(tomatoList.Count)];
		count = 0;
    }
}

