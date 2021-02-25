using System.Collections.Generic;

namespace Normalization.Utilis
{
    public static class NumbersSimilarToWords
    {
        public static Dictionary<char, char> dic { get; } = new Dictionary<char, char>()
        {
            {'D','0' },
            {'A','4' },
            {' ',' ' },
            {'R','5'},
            {'Z','2' },
            {'G','6' },
            {'L','1' },
            {'O','0' },
            {'T','5' },
            {'C','6' }
        };
        
    }
}
