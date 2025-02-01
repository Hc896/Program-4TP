const bubbleSort = (arr) => {
    let isSorted;
    do{
        isSorted = false;
        for(let j=0; j < arr.length-1-1;j++){
            if(arr[j] > arr[j+1]){
                let temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
                swapped = true;
            }
        }
    }while(swapped);
}
const array = [8, 4, 3, 6];
bubbleSort(array);
console.log(array);