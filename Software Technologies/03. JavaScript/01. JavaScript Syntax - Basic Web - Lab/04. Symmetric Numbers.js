/**
 * Created by Admin on 29.3.2017 г..
 */

function symmetricNumbers(arr) {

    let n = Number(arr[0]);
    let result = '';

    for (let i = 1; i <= n; i++) {
        if (isSymmetric(i))
            result += ` ${i}`;
    }

console.log(result);

function isSymmetric(num) {
    num = num.toString();
    for (let i = 0; i < num.length / 2; i++) {
        if (num[i] !== num[num.length - i - 1])
            return false;
    }

    return true;
 }
}

symmetricNumbers(['1000']);