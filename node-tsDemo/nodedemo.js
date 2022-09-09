const otherfile = require('./otherfile.js');
const fs = require('fs-extra');

console.log(`${otherfile.myVar} is one of the monkeys`);

console.log(otherfile.myFunc('People who are not at 4th grade reading level by 10', 5))

fs.writeFileSync('./DeepThoughts.txt','Pengion napolean');

