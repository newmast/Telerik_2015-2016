/*
 ### Problem 3. Sub-string in text
 *	Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
 _Example:_
 The target sub-string is `in`
 The text is as follows:
 We are liv**in**g **in** an yellow submar**in**e. We don't have anyth**in**g else. **in**side the submar**in**e is very tight. So we are dr**in**k**in**g all the day. We will move out of it **in** 5 days.
 The result is: `9`
 */

var text = 'Wein IN are living iner an yellow submarine. We don\'t have anythinerg else. ' +
    'Inside the  submarine is very tight. So we are drinking all the day. ' +
    'We will move out of it in 5 days.';

var pattern = 'in';

console.log('The word ' + '\'in\'' + ' is found ' + countStringOccuranceInText(text, pattern) + ' times in the text');

function countStringOccuranceInText(text, pattern) {
    text = text.toLowerCase();
    var count = 0;
    for (var i = 0; i < text.length; i += 1) {
        text = text.replace(pattern, "*");
        if (text[i] === '*') {
            count++;
        }
    }
    return count;
}