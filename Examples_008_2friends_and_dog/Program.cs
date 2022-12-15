int friend1Speed=1,friend2Speed=2,dogSpeed=5,friend=2,count=0;
double time=0,distance=10000;
while (distance>10)
{
    if (friend==1)
    {
        time=distance/(friend1Speed+dogSpeed);
        friend=2;
    }
    else
    {
        time=distance/(dogSpeed+friend2Speed);
        friend=1;
    }
    distance=distance-(friend1Speed+friend2Speed)*time;
    count=count+1;
}
Console.WriteLine(count);