function threeIntegerSum(args) {

    args = args[0].split(' ').map(Number);

    console.log(
        checkForSum(args[0], args[1], args[2]) ||
        checkForSum(args[0], args[2], args[1]) ||
        checkForSum(args[2], args[1], args[0]) ||
            'No'
    );

function checkForSum(first, second, sum) {
    if (first + second !== sum)
        return false;

    if (first > second)
        [first, second] = [second, first];

    return first + ' + ' + second + ' = ' + sum;
}
}

threeIntegerSum (['8', '15', '7']);