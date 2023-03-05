clear, clc
k = [1 2 3 4 6 7 8 9 10]
a = input('a = ');
b = input('b = ');
istrue = 0
for i = 2:9
    if k(i) < k(i-1)
        istrue = 1
        break;
    end;
end;
if istrue == 0
    disp('Да');
else
    disp('Нет');
end;
kol = 0;
for i = a:(b-kol)
    k(i-kol) = [];
    kol = kol + 1;
end;
