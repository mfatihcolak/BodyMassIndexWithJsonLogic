using System;
using JsonLogic.Net;
using Newtonsoft.Json.Linq;


var person = @"{
    'weight':'Your weight',
    'height':'Your height'
}";

var rule = @"{
        '/':[
        {'var':'weight'},
        {
         '*': [
        {'var':'height'},
        {'var':'height'}
        ]}
]
}";


JToken jt = JToken.Parse(rule);
JToken jt2 = JToken.Parse(person);

JsonLogicEvaluator jsonLogic = new(EvaluateOperators.Default);

Object result = jsonLogic.Apply(jt, jt2);

Console.WriteLine("Your Body Mass Index: "+ result);

