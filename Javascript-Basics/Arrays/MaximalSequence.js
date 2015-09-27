//Problem 3. Maximal sequence
//
//Write a script that finds the maximal sequence of equal elements in an array.
var sequence = [1, 2, 2, 2, 3, 3, 3, 1, 1, 1, 1, 4, 4, 4, 4, 4, 4];

console.log(getMaxEqualSequence(sequence).join(', '));

function getMaxEqualSequence(arr){
    var best = [arr[0]];
    var tmp = [arr[0]];

    for(var ind = 1; ind < arr.length; ind++){
        if(arr[ind] !== tmp[0]){
            tmp = [arr[ind]];
        }
        else{
            tmp.push(arr[ind]);
        }

        if(tmp.length > best.length){
            best = tmp;
        }
    }

    return best;
}