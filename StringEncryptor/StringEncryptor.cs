using System;
using System.IO;
using System.Linq;
using System.Text;

namespace StringEncryptor
{
    public interface IEncryptor
    {
        string Convert(string s);
    }

    public class Encryptor : IEncryptor
    {
        private string CharToInt(string s)
        {
            return string.Join("_", s.ToCharArray().Select(a => (a == ' ' ? '\0' : (a - 'a' + 1))).ToList());
        }

        private string IntToChar(string s)
        {
            var result = new StringBuilder();
            var list = s.Split('_').ToList();
            list.ForEach(x => result.Append((char) (int.Parse(x) - 1 + 'a')));

            return result.ToString();
        }

        public string Convert(string s)
        {
            return CharToInt(s);
        }
    }
}
