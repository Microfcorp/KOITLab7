clear, clc
n = input('n = ');
a = [];
maxind = -100;
x = [];
k = 1;
for i = 1:n
    b = [];
    for j = 1:n
        b(j) = input('');
        if i == j
            x(k) = b(j);
            if maxind < x(k)
                maxind = x(k);
            end;
            k = k + 1;
        end;
    end;
    a = vertcat(a, b);
end;
a
x
y = [];
for i = 1:n
    y(end + 1) = x(i) / maxind;
end;
