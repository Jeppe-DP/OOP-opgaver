for (int num = 1000000 ; num >= 2 ; num--){
    bool is_prime = true;

    for (int i = 2; i <= Math.Sqrt(num); i++) {
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
