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

        public void initGenki()
        {
            var chapter1 = new JapaneseWord[]
            {
                new JapaneseWord("ano", new String[] {"um..."}, "hiragana", ""),
                new JapaneseWord("ima", new String[] {"now"}, "hiragana", ""),
                new JapaneseWord("eego", new String[] {"English"}, "hiragana", ""),
                new JapaneseWord("ee", new String[] {"yes"}, "hiragana", ""),
                new JapaneseWord("gakusee", new String[] {"student"}, "hiragana", ""),
                new JapaneseWord("~go", new String[] {"language"}, "hiragana", ""),
                new JapaneseWord("kookoo", new String[] {"high school"}, "hiragana", ""),
                new JapaneseWord("gogo", new String[] {"P.M."}, "hiragana", ""),
                new JapaneseWord("gozen", new String[] {"A.M"}, "hiragana", ""),
                new JapaneseWord("~sai", new String[] {"~years old"}, "hiragana", ""),
                new JapaneseWord("~san", new String[] {"Mr.", "Mrs."}, "hiragana", ""),
                new JapaneseWord("~ji", new String[] {"o'clock"}, "hiragana", ""),
                new JapaneseWord("~jin", new String[] {"~people"}, "hiragana", ""),
                new JapaneseWord("senkoo", new String[] {"major"}, "hiragana", ""),
                new JapaneseWord("sensee", new String[] {"teacher", "professor"}, "hiragana", ""),
                new JapaneseWord("soo desu", new String[] {"that's right"}, "hiragana", ""),
                new JapaneseWord("soo desu ka", new String[] {"I see", "is that so?"}, "hiragana", ""),
                new JapaneseWord("daigaku", new String[] {"college", "university"}, "hiragana", ""),
                new JapaneseWord("denwa", new String[] {"telephone"}, "hiragana", ""),
                new JapaneseWord("tomodachi", new String[] {"friend"}, "hiragana", ""),
                new JapaneseWord("namae", new String[] {"name"}, "hiragana", ""),
                new JapaneseWord("nihon", new String[] {"Japan"}, "hiragana", ""),
                new JapaneseWord("~nensee", new String[] {"~year student"}, "hiragana", ""),
                new JapaneseWord("hai", new String[] {"yes"}, "hiragana", ""),
                new JapaneseWord("han", new String[] {"half"}, "hiragana", ""),
                new JapaneseWord("bangoo", new String[] {"number"}, "hiragana", ""),
                new JapaneseWord("ryuugakusee", new String[] {"international student"}, "hiragana", ""),
                new JapaneseWord("watashi", new String[] {"I"}, "hiragana", ""),
                new JapaneseWord("Chuugoku", new String[] {"China"}, "hiragana", ""),
                new JapaneseWord("Kankoku", new String[] {"Korea"}, "hiragana", ""),
                new JapaneseWord("kagaku", new String[] {"science"}, "hiragana", ""),
                new JapaneseWord("keezai", new String[] {"economics"}, "hiragana", ""),
                new JapaneseWord("kokusaikankee", new String[] {"international relations"}, "hiragana", ""),
                new JapaneseWord("jinruigaku", new String[] {"anthropology"}, "hiragana", ""),
                new JapaneseWord("seeji", new String[] {"politics"}, "hiragana", ""),
                new JapaneseWord("bungaku", new String[] {"literature"}, "hiragana", ""),
                new JapaneseWord("rekishi", new String[] {"history"}, "hiragana", ""),
                new JapaneseWord("shigoto", new String[] {"job", "work", "occupation"}, "hiragana", ""),
                new JapaneseWord("isha", new String[] {"doctor"}, "hiragana", ""),
                new JapaneseWord("kaishain", new String[] {"office worker"}, "hiragana", ""),
                new JapaneseWord("kookoosei", new String[] {"high school student"}, "hiragana", ""),
                new JapaneseWord("shufu", new String[] {"housewife"}, "hiragana", ""),
                new JapaneseWord("daigakuinsee", new String[] {"graduate student"}, "hiragana", ""),
                new JapaneseWord("daigakusee", new String[] {"college student"}, "hiragana", ""),
                new JapaneseWord("bengoshi", new String[] {"lawyer"}, "hiragana", ""),
                new JapaneseWord("okaasan", new String[] {"mother"}, "hiragana", ""),
                new JapaneseWord("otoosan", new String[] {"father"}, "hiragana", ""),
                new JapaneseWord("oneesan", new String[] {"older sister"}, "hiragana", ""),
                new JapaneseWord("oniisan", new String[] {"older brother"}, "hiragana", ""),
                new JapaneseWord("imooto", new String[] {"younger sister"}, "hiragana", ""),
                new JapaneseWord("otooto", new String[] {"younger brother"}, "hiragana", ""),
                new JapaneseWord("Amerika", new String[] {"U.S.A."}, "katakana", ""),
                new JapaneseWord("Igirisu", new String[] {"Britain"}, "katakana", ""),
                new JapaneseWord("Oosutoraria", new String[] {"Australia"}, "katakana", ""),
                new JapaneseWord("Suweeden", new String[] {"Sweden"}, "katakana", ""),
                new JapaneseWord("konpyuutaa", new String[] {"computer"}, "katakana", ""),
                new JapaneseWord("bijinesu", new String[] {"business"}, "katakana", "")
            };

            var chapter2 = new JapaneseWord[]
            {
                new JapaneseWord("kore", new String[]{"this one"}, "hiragana", ""), 
                new JapaneseWord("sore", new String[]{"that one"}, "hiragana", ""), 
                new JapaneseWord("are", new String[]{"that one over there"}, "hiragana", ""), 
                new JapaneseWord("dore", new String[]{"which one"}, "hiragana", ""), 
                new JapaneseWord("kono", new String[]{"this..."}, "hiragana", ""), 
                new JapaneseWord("sono", new String[]{"that..."}, "hiragana", ""), 
                new JapaneseWord("ano", new String[]{"that... over there"}, "hiragana", ""), 
                new JapaneseWord("dono", new String[]{"which..."}, "hiragana", ""), 
                new JapaneseWord("koko", new String[]{"here"}, "hiragana", ""), 
                new JapaneseWord("soko", new String[]{"there"}, "hiragana", ""), 
                new JapaneseWord("asoko", new String[]{"over there"}, "hiragana", ""), 
                new JapaneseWord("doko", new String[]{"where"}, "hiragana", ""), 
                new JapaneseWord("dare", new String[]{"who"}, "hiragana", ""), 
                new JapaneseWord("oishii", new String[]{"delicious"}, "hiragana", ""), 
                new JapaneseWord("sakana", new String[]{"fish"}, "hiragana", ""), 
                new JapaneseWord("tonkatsu", new String[]{"pork cutlet"}, "hiragana", ""), 
                new JapaneseWord("niku", new String[]{"meat"}, "hiragana", ""), 
                new JapaneseWord("yasai", new String[]{"vegetable"}, "hiragana", ""), 
                new JapaneseWord("enpitsu", new String[]{"pencil"}, "hiragana", ""), 
                new JapaneseWord("kasa", new String[]{"umbrella"}, "hiragana", ""), 
                new JapaneseWord("kaban", new String[]{"bag"}, "hiragana", ""), 
                new JapaneseWord("kutsu", new String[]{"shoes"}, "hiragana", ""), 
                new JapaneseWord("saifu", new String[]{"wallet"}, "hiragana", ""), 
                new JapaneseWord("jisho", new String[]{"dictionary"}, "hiragana", ""), 
                new JapaneseWord("jitensha", new String[]{"bicycle"}, "hiragana", ""), 
                new JapaneseWord("shinbun", new String[]{"newspaper"}, "hiragana", ""), 
                new JapaneseWord("tokee", new String[]{"watch", "clock"}, "hiragana", ""), 
                new JapaneseWord("booshi", new String[]{"hat", "cap"}, "hiragana", ""), 
                new JapaneseWord("hon", new String[]{"book"}, "hiragana", ""), 
                new JapaneseWord("kissaten", new String[]{"cafe"}, "hiragana", ""), 
                new JapaneseWord("ginkoo", new String[]{"bank"}, "hiragana", ""), 
                new JapaneseWord("toshokan", new String[]{"library"}, "hiragana", ""), 
                new JapaneseWord("yuubinkyoku", new String[]{"post office"}, "hiragana", ""), 
                new JapaneseWord("ikura", new String[]{"how much"}, "hiragana", ""), 
                new JapaneseWord("~en", new String[]{"~yen"}, "hiragana", ""), 
                new JapaneseWord("takai", new String[]{"expensive", "high"}, "hiragana", ""), 
                new JapaneseWord("menyuu", new String[]{"menu"}, "katakana", ""), 
                new JapaneseWord("jiinzu", new String[]{"jeans"}, "katakana", ""), 
                new JapaneseWord("tiishatsu", new String[]{"T-shirt"}, "katakana", ""), 
                new JapaneseWord("nooto", new String[]{"notebook"}, "katakana", ""), 
                new JapaneseWord("pen", new String[]{"pen"}, "katakana", ""), 
                new JapaneseWord("toire", new String[]{"toilet", "restroom"}, "katakana", "")
            };

            var chapter3 = new JapaneseWord[]
            {
                new JapaneseWord("eiga", new String[]{"movie"}, "hiragana", ""), 
                new JapaneseWord("ongaku", new String[]{"music"}, "hiragana", ""), 
                new JapaneseWord("zasshi", new String[]{"magazine"}, "hiragana", ""), 
                new JapaneseWord("asagohan", new String[]{"breakfast"}, "hiragana", ""), 
                new JapaneseWord("osake", new String[]{"sake", "alcohol"}, "hiragana", ""), 
                new JapaneseWord("ochya", new String[]{"tea"}, "hiragana", ""), 
                new JapaneseWord("bangohan", new String[]{"dinner"}, "hiragana", ""), 
                new JapaneseWord("hirugohan", new String[]{"lunch"}, "hiragana", ""), 
                new JapaneseWord("mizu", new String[]{"water"}, "hiragana", ""), 
                new JapaneseWord("ie", new String[]{"home", "house"}, "hiragana", ""), 
                new JapaneseWord("uchi", new String[]{"home", "house", "my place"}, "hiragana", ""), 
                new JapaneseWord("gakkou", new String[]{"school"}, "hiragana", ""), 
                new JapaneseWord("asa", new String[]{"morning"}, "hiragana", ""), 
                new JapaneseWord("ashita", new String[]{"tomorrow"}, "hiragana", ""), 
                new JapaneseWord("itsu", new String[]{"when"}, "hiragana", ""), 
                new JapaneseWord("kyou", new String[]{"today"}, "hiragana", ""), 
                new JapaneseWord("~goro", new String[]{"at about..."}, "hiragana", ""), 
                new JapaneseWord("konban", new String[]{"tonight"}, "hiragana", ""), 
                new JapaneseWord("shuumatsu", new String[]{"weekend"}, "hiragana", ""), 
                new JapaneseWord("doyoubi", new String[]{"Saturday"}, "hiragana", ""), 
                new JapaneseWord("nichiyoubi", new String[]{"Sunday"}, "hiragana", ""), 
                new JapaneseWord("mainichi", new String[]{"every day"}, "hiragana", ""), 
                new JapaneseWord("maiban", new String[]{"every night"}, "hiragana", ""), 
                new JapaneseWord("iku", new String[]{"to go"}, "hiragana", ""), 
                new JapaneseWord("kaeru", new String[]{"to go back", "to return"}, "hiragana", ""), 
                new JapaneseWord("kiku", new String[]{"to listen", "to hear"}, "hiragana", ""), 
                new JapaneseWord("nomu", new String[]{"to drink"}, "hiragana", ""), 
                new JapaneseWord("hanasu", new String[]{"to speak", "to talk"}, "hiragana", ""), 
                new JapaneseWord("yomu", new String[]{"to read"}, "hiragana", ""), 
                new JapaneseWord("okiru", new String[]{"to get up"}, "hiragana", ""), 
                new JapaneseWord("taberu", new String[]{"to eat"}, "hiragana", ""), 
                new JapaneseWord("neru", new String[]{"to sleep", "to go to sleep"}, "hiragana", ""), 
                new JapaneseWord("miru", new String[]{"to see", "to look at", "to watch"}, "hiragana", ""), 
                new JapaneseWord("kuru", new String[]{"to come"}, "hiragana", ""), 
                new JapaneseWord("suru", new String[]{"to do"}, "hiragana", ""), 
                new JapaneseWord("benkyousuru", new String[]{"to study"}, "hiragana", ""), 
                new JapaneseWord("ii", new String[]{"good"}, "hiragana", ""), 
                new JapaneseWord("hayai", new String[]{"early"}, "hiragana", ""), 
                new JapaneseWord("amari", new String[]{"not much"}, "hiragana", ""), 
                new JapaneseWord("zenzen", new String[]{"not at all"}, "hiragana", ""), 
                new JapaneseWord("taitei", new String[]{"usually"}, "hiragana", ""), 
                new JapaneseWord("chotto", new String[]{"a little"}, "hiragana", ""), 
                new JapaneseWord("tokidoki", new String[]{"sometimes"}, "hiragana", ""), 
                new JapaneseWord("yoku", new String[]{"often", "much"}, "hiragana", ""), 
                new JapaneseWord("supotsu", new String[]{"sports"}, "katakana", ""), 
                new JapaneseWord("deeto", new String[]{"date"}, "katakana", ""), 
                new JapaneseWord("tenisu", new String[]{"tennis"}, "katakana", ""), 
                new JapaneseWord("terebi", new String[]{"TV"}, "katakana", ""), 
                new JapaneseWord("aisukureemu", new String[]{"ice cream"}, "katakana", ""), 
                new JapaneseWord("koohii", new String[]{"coffee"}, "katakana", ""), 
                new JapaneseWord("hanbaagaa", new String[]{"hamburger"}, "katakana", ""), 
            };
        }
    

}
    
}