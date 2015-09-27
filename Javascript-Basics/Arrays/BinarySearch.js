//Problem 7. Binary search

//Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
var array = [1, 2, 4, 6, 8, 19, 25, 27, 28, 30, 31, 33, 40, 50, 100, 1024];

console.log('Binary search:');
console.log(binarySearch(array, 19));

function binarySearch(a, value) {
    lo = 0;
    hi = a.length - 1;
    while (lo <= hi) {
        var mid = Math.floor((lo+hi)/2);
        if (a[mid] > value)
            hi = mid - 1;
        else if (a[mid] < value)
            lo = mid + 1;
        else
            return mid;
    }
    return null;
}