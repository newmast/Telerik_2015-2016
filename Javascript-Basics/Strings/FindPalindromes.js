//### Problem 10. Find palindromes
//*	Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".


var text = 'poli abba sdef  wqqes peep BeeReeB qwertytrewq ds er @@dfsfsdf  ddf';


function polindromes(text) {
    var array, isPolindrome, arrayOfPolindromes, i;
    text = text.toLowerCase();
    array = text.split(' ');
    isPolindrome = false;
    arrayOfPolindromes = '';
    for (i = 0; i < array.length; i += 1) {
        if (array[i].charAt(0) === array[i].charAt(array[i].length - 1)) {
            for (j = 0; j < array[i].length; j += 1) {
                for (k = array.length - 1; k >= 0; k -= 1) {
                    if (array[j] === array[k]) {
                        isPolindrome = true;
                    }
                }
            }
        }
        if (isPolindrome === true) {
            arrayOfPolindromes += array[i] + ' ';
            isPolindrome = false;
        }
    }
    return arrayOfPolindromes;
}
console.log(polindromes(text));