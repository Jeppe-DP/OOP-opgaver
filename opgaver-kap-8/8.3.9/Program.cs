const double PI = 3.14;

double area(double r){
    return PI*r*r;
}
double circumfrence(double r){
    return PI*r*2;
}


Console.WriteLine("circle_radius 1  The area is " + area(1) + "  the circumfrence is " + circumfrence(1));
Console.WriteLine("circle_radius 3  The area is " + area(3) + "  the circumfrence is " + circumfrence(3));
Console.WriteLine("circle_radius 5  The area is " + area(5) + "  the circumfrence is " + circumfrence(5));
