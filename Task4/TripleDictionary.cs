using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class TripleDictionary : IEnumerable<KeyValuePair<string, Tuple<string, string>>>
    {
        private Dictionary<string, Tuple<string, string>> _dictionary;

        public TripleDictionary()
        {
            _dictionary = new Dictionary<string, Tuple<string, string>>();
        }
        public TripleDictionary(string mainLanguage, string firstTranslateLanguage, string secondTranslateLanguage)
        {
            _dictionary = new Dictionary<string, Tuple<string, string>>();
            AddWord(mainLanguage, firstTranslateLanguage, secondTranslateLanguage);
        }
        public void AddWord(string mainLanguageWord, string firstLanguageTranslate, string secondLanguageTranslate)
        {
            _dictionary.Add(mainLanguageWord, new Tuple<string, string>(firstLanguageTranslate, secondLanguageTranslate));
        }
        public string GetLanguage1Translate(string ukrainianWord)
        {
            return _dictionary[ukrainianWord].Item1;
        }
        public string GetLanguage2Translate(string ukrainianWord)
        {
            return _dictionary[ukrainianWord].Item2;
        }

        //sorting by main language words
        public void Sort()
        {

        }

        public IEnumerator<KeyValuePair<string, Tuple<string, string>>> GetEnumerator()
        {
            foreach (var item in _dictionary)
            {
                yield return new KeyValuePair<string, Tuple<string, string>>(item.Key, new Tuple<string, string>(item.Value.Item1, item.Value.Item2));
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            GetEnumerator();
            yield break;
        }

    }
}
