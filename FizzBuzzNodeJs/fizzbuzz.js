const readline = require("readline");
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question(">>> ", (number) => {
    for (let i = 1; i <= number; i++) {
        let buffer = "";
        if (i % 3 == 0) buffer += "Fizz";
        if (i % 5 == 0) buffer += "Buzz";
        console.info(buffer || i);
    }
    rl.close();
});