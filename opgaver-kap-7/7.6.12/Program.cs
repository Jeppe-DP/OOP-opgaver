int [] month = [12];

int [] days_in_month = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

int [] days_in_month_leap = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
int [] pointer = [];

for (int i = 2000; i < 2021; i++){
    if (i%4 == 0){
        pointer = days_in_month_leap;
    }
    else {
        pointer = days_in_month;
    }
    foreach (int day in pointer){
    Console.WriteLine(day);
    }
}
