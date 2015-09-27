/*
 ### Problem 4. Parse tags
 *	You are given a text. Write a function that changes the text in all regions:
 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <mixcase>text</mixcase> to mix casing(random)
 _Example:_ We are `<mixcase>living</mixcase>` in a `<upcase>yellow submarine</upcase>`. We `<mixcase>don't</mixcase>` have `<lowcase>anything</lowcase>` else.
 _The expected result:_
 We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.
 */
//My Idea is 1.Find the name of the tag  2.Capture the text between tag and convert it. 3.Delete tags
//ands so on for each i++.When there is no more tags comes the return to spare loop cycles.


var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>." +
    " We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

formatTextRemoveAllTags(text);

function formatTextRemoveAllTags(text) {
    var indexStart, indexEnd, indexEndBetweenTags, tagName, wholeOpenTag, string, textBetweenTags,
        letter,
        wholeCloseTag, i, k;
    for (i = 0; i < text.length; i += 1) {
        indexStart = text.indexOf('>');
        indexEnd = text.indexOf('<');
        indexEndBetweenTags = text.indexOf('</');
        tagName = text.substring(indexStart, indexEnd + 1);
        wholeOpenTag = text.substring(indexEnd, indexStart + 1);
        string = '';
        textBetweenTags = text.substring(indexStart + 1, indexEndBetweenTags);
        if (tagName === 'mixcase') {
            letter = ''; toLowerCase = false;
            for (k = 0; k < textBetweenTags.length; k += 1) {
                toLowerCase = Math.round(Math.random());
                letter = textBetweenTags.charAt(k);
                string += (toLowerCase ? letter.toUpperCase() : letter.toLowerCase());
            }
        }
        else if (tagName === 'upcase') {
            string = textBetweenTags.toUpperCase();
        }
        else if (tagName === 'lowcase') {
            string = textBetweenTags.toLowerCase();
        }
        text = text.replace(textBetweenTags, string);
        text = text.replace(wholeOpenTag, '');
        wholeCloseTag = text.substring(text.indexOf('<'), text.indexOf('>') + 1);
        text = text.replace(wholeCloseTag, '');
        indexStart = 0;
        indexEnd = 0;
        indexEndBetweenTags = 0;
        if (text.indexOf('<') < 0) {
            return console.log(text);
        }
    }
}
