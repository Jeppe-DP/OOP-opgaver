//make is_prime = true for each number between 2 and 1000000
for (int num = 1000000 ; num >= 2 ; num--){
    bool is_prime = true;

    //Check if there is any remainder from sqrt(num). If so make is_prime = false
    for (int i = 2; i <= 1000000; i++) {
        if (num % i == 0) {
            is_prime = false;
            break;
        }
    }
    if (is_prime){
        Console.WriteLine(num);
        break;
    }
}
