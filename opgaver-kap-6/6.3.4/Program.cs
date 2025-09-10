int current_month = 7;
int days = 0;

//This is dogshit code. It applies a bunch of empty if statements. Ideally this would be rewritten as a switch. BUT it does work
if (current_month == 1);
    days = 31;
if (current_month == 2);
    days = 28;
if (current_month == 3);
    days = 31;
if (current_month == 4);
    days = 30;
if (current_month == 5);
    days = 31;
if (current_month == 6);
    days = 30;
if (current_month == 7);
    days = 31;
if (current_month == 8);
    days = 31;
if (current_month == 9);
    days = 30;
if (current_month == 10);
    days = 31;
if (current_month == 11);
    days = 30;
if (current_month == 12);
    days = 31;
Console.WriteLine("the current month is " + days + " long");
