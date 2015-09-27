function Problem1 (arg) {
	var last = arg % 10;
	switch(last)
	{
		case 0: return 'Zero';
		case 1: return 'One';
		case 2: return 'Two';
		case 3: return 'Three';
		case 4: return 'Four';
		case 5: return 'Five';
		case 6: return 'Six';
		case 7: return 'Seven';
		case 8: return 'Eight';
		case 9: return 'Nine';
	}
}

function Problem2 (number) {
	var isNegative = number < 0,
		number = number.toString().replace('-', '').split(''),
		reversed = [];
		
		if (isNegative) {
			reversed.push('-');
		}
		
		Array.prototype.push.apply(reversed, number.reverse());
	
	return +(reversed.join(''));
}

// Write a function that finds all the occurrences of
// word in a text
// ? The search can case sensitive or case insensitive
// ? Use function overloading

function Problem3(text, word, isCaseSensitive){
	var regexString = '\\b' + word + '\\b',
		modifier = isCaseSensitive ? 'g' : 'gi',
		regex = new RegExp(regexString, modifier);
		
	return text.match(regex).length;
}

function Problem4()
{
	var count = document.getElementsByTagName('div').length;
	return count;
}

function Problem5 (arr, value) {
	var count = 0;
	for(i = 0; i < arr.length; i+=1) {
		if (value == arr[i]) {
			count+=1;
		}
	}
	return count;
}

function Problem6 (arr, index) {
	var isBigger = true;

    for (var ind = index - 1; ind <= index + 1; ind += 2) {
        if (ind >= 0 && ind < arr.length) {
            if (arr[ind] >= arr[index]) {
                isBigger = false;
                break;
            }
        }
    }

    return isBigger;
}

function Problem7 (arr) {
    for (var ind in arr) {
        if (Problem6(arr, ind)) {
			return ind;
		}
    }
	
    return -1;
}
