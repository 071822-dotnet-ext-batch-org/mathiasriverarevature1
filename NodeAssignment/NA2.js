const fs = require('fs-extra');

let myVar = 20;
function myFunc(str1)
{
    return `${str1}`
}

exports.myVar = myVar;
exports.myFunc = myFunc;