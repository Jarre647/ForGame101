using _101.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml.Controls;

namespace _101.Services
{
    public static class PronounceService
    {
        delegate Task TextToPronounce(string name);


        private async static Task PronounceText(string text)
        {
            var mediaElement = new MediaElement();
            var synth = new SpeechSynthesizer();
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                VoiceInformation voiceInfo =
                    (from voice in SpeechSynthesizer.AllVoices
                     where voice.Gender == VoiceGender.Female && voice.Language == "ru-RU"
                     select voice
                    ).FirstOrDefault() ?? SpeechSynthesizer.DefaultVoice;

                synthesizer.Voice = voiceInfo;
                SpeechSynthesisStream stream = await synthesizer.SynthesizeTextToStreamAsync(text);
                mediaElement.SetSource(stream, stream.ContentType);
                mediaElement.Play();
            }
        }

        private static readonly Dictionary<Instance, TextToPronounce> _dictionaryForPreparingToPronounce = new Dictionary<Instance, TextToPronounce>
        {
            { Instance.CloseToTheLimit, async a => await PronounceText("Внимание, товарищь" + a + " скоро проиграет") },
            { Instance.ExceededLimit, async  a => await PronounceText("Внимание, товарищь" + a + " проиграл" ) },
            { Instance.Reset, async  a => await PronounceText(a + "Вам повезло, Вы пока не проигали" )},
            { Instance.HalfReset, async a => await PronounceText(a + "Вам повезло, Вы пока не проигали" )}
        };

        public static async Task RunPronounce(Instance op, string name)
        {
           await _dictionaryForPreparingToPronounce[op](name);
        }

        public static async Task RunPronounceExecption(string ex)
        {
            await PronounceText(ex);
        }
    }
}
