var array = [5, 1, 4, 2, 44, 15, 2, 9, 87, 45];

selectionSort(array);

function selectionSort (array)
{
    var i, j, tmp, tmp2;
    for (i = 0; i < array.length - 1; i++)
    {
        tmp = i;
        for (j = i + 1; j < array.length; j++){
            if (array[j] < array[tmp]){
                tmp = j;
            }
        }
        if(tmp!=i){
            tmp2 = array[tmp];
            array[tmp] = array[i];
            array[i] = tmp2;
        }
    }
    console.log("Selection sort:")
    console.log(array);
}