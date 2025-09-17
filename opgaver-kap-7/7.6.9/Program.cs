double [] temperature = [7];
string [] dayarray = ["monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday"];
temperature = [21.5, 23.7, 19.6, 22.5, 25.3, 21.7, 18.9];
double diff = 0;
string day = "monday";
for(int i=0; i < temperature.Length; i++){
    day = dayarray[i];
    if(i == 0){
    diff = 0;
    }
    else {
    diff = temperature[i]-temperature[i-1];
    }
Console.WriteLine("the temperature difference for " + day + " is " + diff);
}
