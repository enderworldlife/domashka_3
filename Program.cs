
// domashka 3

// zadanye 1

int[] ar = new int[10];
Random random = new Random();
for (int j = 0; j < ar.Length; j++){
    ar[j] = random.Next(0,100);
}

static void ArPrint(int[] array){
    for (int o = 0; o < array.Length; o++){
        Console.Write(array[o] + " ");
    }
}

ArPrint(ar);

Console.WriteLine();

for (int i = 0; i < ar.Length; i++){
    
    if (ar[i] > 20 && ar[i] < 80){
        Console.Write(ar[i] + " ");
    }
}

// zadanye 2







