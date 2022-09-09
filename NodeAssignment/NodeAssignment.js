const req = require('./NA2.js');
const fs = require('fs-extra');

fs.writeFileSync('./createdFile.txt', 'This is a file waiting for appending stuff\n');
fs.appendFileSync('./createdFile.txt', `This is the int variable ${req.myVar}\n`);
fs.appendFileSync('./createdFile.txt', `${req.myFunc('Now we append again with a func that holds a string\n')}`);
fs.readFile('./createdFile.txt',(error,data) =>
{
    if(error)
    {
        throw error;
    }
    console.log(data.toString());
});
