clear, clc
x = input('x = ');
y = input('y = ');
if  or(or(x > 1, x < -2), abs(y) > 1)
    disp('не принадлежит');
else
    if or(and(y>=x, and(y <=1, y >=0)), (x+1)^2 + y^2 <= 1)
        disp('принадлежит');
    else
        disp('не принадлежит');
    end;
end;