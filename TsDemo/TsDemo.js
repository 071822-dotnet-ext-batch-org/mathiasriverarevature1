"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const otherfile_1 = require("./otherfile.js");
console.log('HelloWorld');
let myClass1 = new otherfile_1.myClass('Richard the Lionheart is coming', (a) => {
    return `This ${a} is better than our kingdoms.`;
});
console.log(myClass1.name, myClass1.sound('pair of warthogs'));
