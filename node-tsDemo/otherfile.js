
console.log("hey hey world We are the ");

//when you create a file it is a module
// and file componenets must be exported 
//in order to bring it into the global scope
let myVar = 'Mark'

function myFunc(str, myInt)
{
    return `${str} are ${myInt} times likely to drop out`
}

exports.myVar = myVar;
exports.myFunc = myFunc;