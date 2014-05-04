using RunTextNormalizer.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTextNormalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            GhoraanContext context = new GhoraanContext();
            var q = context.Keywords.Where(x => x.NormalizedKeyword == null).Take(1);
            foreach (Keyword keyword in q)
            {
                keyword.NormalizedKeyword = RemoveDiacritics(keyword.Keyword1);
            }
            context.SaveChanges();

        }
        static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();
            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
                
            }
            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);

        }
    }
}
