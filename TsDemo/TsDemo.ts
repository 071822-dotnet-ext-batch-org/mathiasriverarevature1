import {myClass} from './otherfile';

console.log('HelloWorld');
let myClass1 = new myClass('Richard the Lionheart is coming',
(a:string) =>
{
    return `This ${a} is better than our kingdoms.`
}
);
console.log(myClass1.name, myClass1.sound('pair of warthogs'));