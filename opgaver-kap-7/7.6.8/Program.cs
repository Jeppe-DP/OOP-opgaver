double [] radii = {1, 3, 5};
double area = 0;
double r = 0;
for ( int i = 0; i < radii.Length; i++){
    area = radii[i]*radii[i]*3.14;
    r = radii[i];
    Console.WriteLine("radius_" + r +" has the area " + area);
}
