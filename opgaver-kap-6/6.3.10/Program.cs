

for (int num=2 ; num < 1000000 ; num++){
    bool is_prime = true;

    for (int i = 2 ; i < 1000000 ; i++){
        if (num % i == 0) {
            is_prime = false;
        }
    }
    if (is_prime = true)
        Console.WriteLine(num);
}
