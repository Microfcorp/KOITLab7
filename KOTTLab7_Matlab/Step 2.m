clear, clc
a = input('a = ');
b = input('b = ');
x = input('x = ');
y = input('y = ');
z = input('z = ');
if abs(x)^y < z
    h = x*x*x + abs(a)*sin(y)
else
    if and(z <= abs(x)^y, abs(x)^y <= z + 10)
        h = max(x, max(y, z))
    else
        h = min(x^0.33, min(b*y, sqrt(abs(z))))
    end;
end;