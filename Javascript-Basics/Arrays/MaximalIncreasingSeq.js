var sequence = [0,0,0,1,2,3,4,4,2,1,4,5, 1,2,3,4,5,6];

console.log('Max inc seq:');

console.log(getMaxIncSequence(sequence).join(', '));

function getMaxIncSequence(arr){
    var best = [arr[0]];
    var tmp = [arr[0]];

    for(var ind = 1; ind < arr.length; ind++){
        if(arr[ind] > arr[ind - 1]){
            tmp.push(arr[ind]);
        }
        else{
            tmp = [arr[ind]];
        }

        if(tmp.length > best.length){
            best = tmp;
        }
    }

    return best;
}