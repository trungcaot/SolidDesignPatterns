using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class TranslatorAdapter : IVietnameseTarget
    {
        private readonly JapaneseAdaptee japaneseAdaptee;

        public TranslatorAdapter(JapaneseAdaptee japaneseAdaptee)
        {
            this.japaneseAdaptee = japaneseAdaptee;
        }

        public void Send(string words)
        {
            string japaneseWords = TranslateToJapanese(words);
            this.japaneseAdaptee.Receive(japaneseWords);
        }

        private string TranslateToJapanese(string vnWords)
        {
            return "This is a text which translated from TranslatorAdapter!";
        }
    }
}
