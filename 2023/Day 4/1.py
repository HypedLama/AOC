
sumofpoints = 0
with open("input.txt") as f:
    lines = f.readlines()
for line in lines:
    line = line.split(':')[1].split('|')
    winningnumbers = [int(x) for x in line[0].split()]
    mycards = [int(x) for x in line[1].split()]
    wins = 0
    for winnum in winningnumbers:
        if winnum in mycards:
            wins +=1
    sumofpoints += pow(2,wins-1) if wins-1 >=0 else 0
print(sumofpoints)