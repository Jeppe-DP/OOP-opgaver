int [] array = {4, 10, 50, 40, 3, 2, 1};
int maxint = 0;

for ( int i=0; i < array.Length; i++){
    if (array [i] > maxint){
        maxint = array[i];
    }
}
Console.WriteLine(maxint);
