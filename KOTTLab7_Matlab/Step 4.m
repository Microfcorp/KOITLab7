clear, clc
sum = 1;
i = 1;
while i < 25
    a = i^2/(i^2 + 2*i + 3);
    sum = sum * a;
    i = i + 1;
end;
disp(sum);