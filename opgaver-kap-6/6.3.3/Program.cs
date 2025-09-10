int var = 2000000;
double price = 599.95;
double current_price = price;

//Determines the price during christmas
if(var < 31104000-86400*11*30 && var > 6*86400) {
    current_price=price*0.7;
}

Console.WriteLine("the current price is " + current_price);
