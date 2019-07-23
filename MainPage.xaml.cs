using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _101
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public class proverka
        {
            public string check(string input)
            {
                if (input == "")
                {
                    input = "0";
                }
                return (input);
            }
        }
        public MainPage()
        {
            this.InitializeComponent();
        }
        public class Chitalka
        {
            public virtual async void Chit(string a)
            {

                MediaElement mediaElement = new MediaElement();
                var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(a);
                mediaElement.SetSource(stream, stream.ContentType);
                mediaElement.Play();
            }
        }
        public class Bolshe202 : Chitalka
        {
            public override void Chit(string a)
            {
                a = "Внимание, товарищь" + a + " проиграл";
                base.Chit(a);
            }
        }
        public class Bolshe180 : Chitalka
        {
            public override void Chit(string a)
            {
                a = "Внимание, товарищь" + a + " скоро проиграет";
                base.Chit(a);
            }
        }
        public class Sbras : Chitalka
        {
            public override void Chit(string a)
            {
                a = a + "Вам повезло, Вы пока не проигали";
                base.Chit(a);
            }

        }
        class Neskolko180 : Chitalka
        {

            public void Chit1(params string[] args)
            {
                //int j = args.Length;
                string a = args[0];
                for (int i = 1; i < args.Length; i++)
                {
                    a = a + " и " + args[i];
                }
                a = a + "скоро проиграют";
                base.Chit(a);
            }
        }
        public class Provnesk180
        {
            public int check(int a, int b, int c, int d)
            {
                int res = 0;
                if (a > 180)
                {
                    res = res + 1;
                }
                if (b > 180)
                {
                    res = res + 10;
                }
                if (c > 180)
                {
                    res = res + 100;
                }
                if (d > 180)
                {
                    res = res + 1000;
                }
                if (a >= 200 || b >= 200 || c >= 200 || d >= 200)
                {
                    res = 0;
                }
                return (res);
            }
        }
        public class Check
        {
            public int check(string name, int b)
            {
                Sbras sbras = new Sbras();
                Bolshe202 bolshe202 = new Bolshe202();
                Bolshe180 bolshe180 = new Bolshe180();
                if (b == 200)
                {
                    b = 100;
                    sbras.Chit(name);
                 
                }
                else
                {
                    if (b == 201 || b == 202)
                    {
                        b = 0;
                        sbras.Chit(name);
                    
                    }
                    else
                    {
                        if (b > 202)
                        {
                            bolshe202.Chit(name);
                           
                        }
                     
                    }
                }
                return (b);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _11.Text = Convert.ToString(0);
            _12.Text = Convert.ToString(0);
            _21.Text = Convert.ToString(0);
            _22.Text = Convert.ToString(0);
            _31.Text = Convert.ToString(0);
            _32.Text = Convert.ToString(0);
            _41.Text = Convert.ToString(0);
            _42.Text = Convert.ToString(0);
        }
        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Check check = new Check();
            Sbras sbras = new Sbras();
            Provnesk180 provnesk180 = new Provnesk180();
            proverka proverka = new proverka();
            Bolshe180 bolshe180 = new Bolshe180();
            Neskolko180 neskolko180 = new Neskolko180();
            _12.Text = proverka.check(_12.Text);
            _22.Text = proverka.check(_22.Text);
            _32.Text = proverka.check(_32.Text);
            _42.Text = proverka.check(_42.Text);


            _11.Text = Convert.ToString(Convert.ToInt16(_11.Text) + Convert.ToInt16(_12.Text)); //я
            _12.Text = Convert.ToString(0);

            _21.Text = Convert.ToString(Convert.ToInt16(_21.Text) + Convert.ToInt16(_22.Text)); //линар
            _22.Text = Convert.ToString(0);

            _31.Text = Convert.ToString(Convert.ToInt16(_31.Text) + Convert.ToInt16(_32.Text)); //сергей
            _32.Text = Convert.ToString(0);

            _41.Text = Convert.ToString(Convert.ToInt16(_41.Text) + Convert.ToInt16(_42.Text)); //дмитрий
            _42.Text = Convert.ToString(0);
            int ca = 0;
            ca = provnesk180.check(Convert.ToInt16(_11.Text), Convert.ToInt16(_21.Text), Convert.ToInt16(_31.Text), Convert.ToInt16(_41.Text));
            switch (ca)
            {
                case 1:
                    bolshe180.Chit(_10.Text);
                    break;
                case 10:
                    bolshe180.Chit(_20.Text);
                    break;
                case 100:
                    bolshe180.Chit(_30.Text);
                    break;
                case 1000:
                    bolshe180.Chit(_40.Text);
                    break;
                case 11:
                    neskolko180.Chit1(_10.Text, _20.Text);
                    break;
                case 101:
                    neskolko180.Chit1(_10.Text, _30.Text);
                    break;
                case 1001:
                    neskolko180.Chit1(_10.Text, _40.Text);
                    break;
                case 1010:
                    neskolko180.Chit1(_20.Text, _40.Text);
                    break;
                case 1100:
                    neskolko180.Chit1(_30.Text, _40.Text);
                    break;
                case 110:
                    neskolko180.Chit1(_20.Text, _30.Text);
                    break;
                case 111:
                    neskolko180.Chit1(_10.Text, _20.Text, _30.Text);
                    break;
                case 1110:
                    neskolko180.Chit1(_20.Text, _30.Text, _40.Text);
                    break;
                case 1101:
                    neskolko180.Chit1(_10.Text, _20.Text, _40.Text);
                    break;
                case 1011:
                    neskolko180.Chit1(_10.Text, _20.Text, _40.Text);
                    break;
                case 1111:
                    neskolko180.Chit1(_10.Text, _20.Text, _30.Text, _40.Text);
                    break;
            }
            if (ca == 0)
            {
                _11.Text = Convert.ToString(check.check(_10.Text, Convert.ToInt16(_11.Text)));
                _21.Text = Convert.ToString(check.check(_20.Text, Convert.ToInt16(_21.Text)));
                _31.Text = Convert.ToString(check.check(_30.Text, Convert.ToInt16(_31.Text)));
                _41.Text = Convert.ToString(check.check(_40.Text, Convert.ToInt16(_41.Text)));
            }
        }
        class Izmena
        {
            public bool ize(string a)
            {
                if (a == "0")
                {
                    return (false);
                }
                else
                {
                    return (true);
                }
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Izmena izmena = new Izmena();
            proverka proverka = new proverka();
            _12.Text = proverka.check(_12.Text);
            _22.Text = proverka.check(_22.Text);
            _32.Text = proverka.check(_32.Text);
            _42.Text = proverka.check(_42.Text);
            if (izmena.ize(_12.Text))
            {
                _10.Text = _12.Text;
                _12.Text = "0";
            }
            if (izmena.ize(_22.Text))
            {
                _20.Text = _22.Text;
                _22.Text = "0";
            }
            if (izmena.ize(_32.Text))
            {
                _30.Text = _32.Text;
                _32.Text = "0";
            }
            if (izmena.ize(_42.Text))
            {
                _40.Text = _42.Text;
                _42.Text = "0";
            }
        }
    }
}
