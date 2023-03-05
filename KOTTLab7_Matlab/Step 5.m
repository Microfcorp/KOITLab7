clear, clc
e = 0.0001;
s = 0;
i = 1;
while (0.75 - s) > e
    k = 1/(i *(i+2));
    s = s + k;
    i = i + 1;  
end;
disp(s);
disp(0.75);