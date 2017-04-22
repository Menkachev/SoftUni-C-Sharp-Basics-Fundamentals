function solve(args) {
    let n = Number(args[0]);
    let x = Number(args[1]);

    if (n <= x){
        console.log(n * x);
    }
    else {
        console.log(n / x);
    }
}

solve([3, 2]);