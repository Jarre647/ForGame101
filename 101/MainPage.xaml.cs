using _101.Models;
using _101.Services;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace _101
{

    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _11.Text = "0";
            _12.Text = "0";
            _21.Text = "0";
            _22.Text = "0";
            _31.Text = "0";
            _32.Text = "0";
            _41.Text = "0";
            _42.Text = "0";
        }
        private async void button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var score = Convert.ToInt16(_11.Text) + Convert.ToInt16(_12.Text);

                var model = new ScorePlayerModel()
                {
                    Name = _10.Text,
                    Score = score
                };

                score = await CheckService.Check(model);
                _11.Text = score.ToString();
                _12.Text = "0";

                score = Convert.ToInt16(_21.Text) + Convert.ToInt16(_22.Text);

                model = new ScorePlayerModel()
                {
                    Name = _20.Text,
                    Score = score
                };

                score = await CheckService.Check(model);
                _21.Text = score.ToString();
                _22.Text = "0";

                score = Convert.ToInt16(_31.Text) + Convert.ToInt16(_32.Text);

                model = new ScorePlayerModel()
                {
                    Name = _30.Text,
                    Score = score
                };

                score = await CheckService.Check(model);
                _31.Text = score.ToString();
                _32.Text = "0";

                score = Convert.ToInt16(_41.Text) + Convert.ToInt16(_42.Text);

                model = new ScorePlayerModel()
                {
                    Name = _40.Text,
                    Score = score
                };

                score = await CheckService.Check(model);
                _41.Text = score.ToString();
                _42.Text = "0";

            }
            catch
            {
                await PronounceService.RunPronounceExecption("Неправильный ввод, перепроверь");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_12.Text != "0" & _12.Text != string.Empty)
                {
                    _10.Text = _12.Text;
                    _12.Text = "0";
                }
                if (_22.Text != "0" & _22.Text != string.Empty)
                {
                    _20.Text = _22.Text;
                    _22.Text = "0";
                }
                if (_32.Text != "0" & _32.Text != string.Empty)
                {
                    _30.Text = _32.Text;
                    _32.Text = "0";
                }
                if (_42.Text != "0" & _42.Text != string.Empty)
                {
                    _40.Text = _42.Text;
                    _42.Text = "0";
                }
            }
            catch
            {
               PronounceService.RunPronounceExecption("Неправильный ввод, перепроверь");
            }
        }
    }
}
