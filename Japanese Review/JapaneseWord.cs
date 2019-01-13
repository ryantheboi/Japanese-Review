using System;

namespace Japanese_Review
{
    /*
     * The Japanese Word class holds the following information:
     * japanese - the word written in japanese
     * romaji - conversion of the japanese word to latin
     * english - a list of english definitions of the word
     * writing - the syllabic writing for the word (hiragana or katakana)
     * kanji - 0 if not kanji, 1 if it is kanji
     */
    public class JapaneseWord
    {
        private String japanese;
        private String romaji;
        private String[] english;
        private String writing;
        private int kanji;

        public JapaneseWord(String japanese, String romaji, String[] english, String writing, int kanji)
        {
            this.japanese = japanese;
            this.romaji = romaji;
            this.english = english;
            this.writing = writing;
            this.kanji = kanji;
        }

    }
    
}