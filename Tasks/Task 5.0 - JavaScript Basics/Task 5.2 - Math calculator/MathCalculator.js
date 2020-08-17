let string = "3.5 +4 * 10 - 5.3 / 5 = ";

function Сalculator(string) {

    let action;
    let endInput = false
    let numbers = new Array();
    let outputFlag = false;
    let result;

    function CheckOnCorrectCharacter(character) {

    let characters = ['+', '-', '*', '/', '=']

    if (characters.includes(character)) {
        return true;
    }
    return false;
}

function IsNumber(character) {
    if (character.match(/\d/) || character == '.') {
        return true;
    }
    return false;
}

    for (let i in string) {
        if (i == string.length - 1) {
            endInput = true;

            if (IsNumber(string[i])) {
                numbers.push(string[i]);
            }
        }
        if (outputFlag) {
            break;
        }
        else if (IsNumber(string[i]) && !endInput) {
            numbers.push(string[i]);
        }
        else if (CheckOnCorrectCharacter(string[i]) || endInput) {
            if (numbers.length != 0) {
                if (result == undefined) {
                    result = parseFloat(numbers.join(''));
                    action = string[i];
                    numbers = new Array();
                }
                else {
                    switch (action) {
                        case "*":
                            result *= parseFloat(numbers.join(''));
                            break;
                        case "+":
                            result += parseFloat(numbers.join(''));
                            break;
                        case "-":
                            result -= parseFloat(numbers.join(''));
                            break;
                        case "/":
                            result /= parseFloat(numbers.join(''));
                            break;
                    }

                    if (string[i] == '=') {
                        outputFlag = true;
                    }
                    else {
                        action = string[i];
                        numbers = new Array(0);
                    }
                }
            }
            else if (parseInt(i) + 1 < string.length && IsNumber(string[parseInt(i) + 1])) {
                numbers.push(string[i]);
            }
            else {
                console.log("Input is wrong!")
                result = undefined;
                break;
            }
        }
        else if (string[i].charCodeAt(0) != 32) {
            console.log(string[i], " - wrong character!")
            result = undefined;
            break;
        }
    }

    if (result != undefined) {
        console.log("Input:", string);
        console.log("Output:", result.toFixed(2));
    }
}

Сalculator(string);
