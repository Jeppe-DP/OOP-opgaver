double a = 3;
double b = 2;
double c = 0;

double d = Discriminant(a, b, c);
double[] roots = Roots(a, b, c, d);


double Discriminant(double a,double b,double c){
    return b*b-4*a*c;
}

double[] Roots(double a,double b,double c, double d){
    if(d > 0) {
        double root_1 = ((-b + Math.Sqrt(d))/(2*a));
        double root_2 = ((-b - Math.Sqrt(d))/(2*a));
        return new double[] { root_1, root_2};
    }
    else if(d == 0) {
        double root = -b / (2 * a);
        return new double[] {root};
    }
    else{
        Console.WriteLine("no real roots");
        return null;
    }
}
Console.WriteLine("The discriminant is " + d);
Console.WriteLine("The root(s) are " + string.Join(", ", roots));
