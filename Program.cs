
// // domashka 3

// // zadanye 1

// int[] ar = new int[10];
// Random random = new Random();
// for (int j = 0; j < ar.Length; j++){
//     ar[j] = random.Next(0,100);
// }

// static void ArPrint(int[] array){
//     for (int o = 0; o < array.Length; o++){
//         Console.Write(array[o] + " ");
//     }
// }

// ArPrint(ar);

// Console.WriteLine();

// for (int i = 0; i < ar.Length; i++){
    
//     if (ar[i] > 20 && ar[i] < 80){
//         Console.Write(ar[i] + " ");
//     }
// }

// // zadanye 2

// int[] numbers = new int[10];
// Random random = new Random();

// for (int random_number = 0; random_number < numbers.Length; random_number++){
//     numbers[random_number] = random.Next(1,9);
// }
// void PrintArray(int[] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }
// Console.Write("Tsifry: ");
// PrintArray(numbers);
// Console.WriteLine();
// Console.Write("Chetnye tsifry: ");
// for (int chet = 0; chet < numbers.Length; chet++){
//     if (numbers[chet] % 2 == 0){
//         Console.Write(numbers[chet] + " ");
//     }
// }
// Console.WriteLine();
// Console.Write("Nechetnye tsifry: ");
// for (int nechet = 0; nechet < numbers.Length; nechet++){
//     if (numbers[nechet] % 2 != 0){
//         Console.Write(numbers[nechet] + " ");
//     }
// }

//zadanye 3

double[] numbers = { 3.14, 2.71, 5.55, 1.23, 4.89 };

double min = numbers[0];
double max = numbers[0];

for (int i = 1; i < numbers.Length; i++){
    if (numbers[i] < min){
        min = numbers[i];
    }
    if (numbers[i] > max){
        max = numbers[i];
}
}

double difference = max - min;
 
Console.WriteLine("Massiv: " + string.Join(", ", numbers));
Console.WriteLine("Minimalniy element: " + min);
Console.WriteLine("Maksimalniy element: " + max);
Console.WriteLine("Raznitsa mejdu min i maks: : " + difference);
    
