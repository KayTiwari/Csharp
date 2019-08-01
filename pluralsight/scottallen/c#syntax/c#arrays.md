creating an array:

double[] numbers = new double[3] <- explicitly declaring a new data struct with the size in the brackets
numbers[0] = 12.7;
numbers[1] = 5.3;
numbers[2] = 2.1;

var result = numbers[0] + numbers[1] + numbers[2];


Short hand Array declaration: 

var numbers = new[] { 12.7, 5.3, 2.1 };


Array looping

foreach (double number in numbers){ 
    var results += number;
}