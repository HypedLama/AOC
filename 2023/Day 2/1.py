def validgame(rounds:list[str])->bool:
    valid = True
    for round in rounds:
        cubes = round.split(',')
        for cube in cubes:
            if(cube.count("blue") and int(cube[1:3])>14):
                valid = False
            elif(cube.count("green") and int(cube[1:3])>13):
                valid = False
            elif(cube.count("red") and int(cube[1:3])>12):
                valid = False
    return valid

def powerofcubesingame(rounds:list[str])->int:
    minblue=0
    mingreen=0
    minred=0
    for round in rounds:
        cubes = round.split(',')
        for cube in cubes:
            if(cube.count("blue") and int(cube[1:3])>minblue):
                minblue = int(cube[1:3])
            elif(cube.count("green") and int(cube[1:3])>mingreen):
                mingreen = int(cube[1:3])
            elif(cube.count("red") and int(cube[1:3])>minred):
                minred = int(cube[1:3])
    return minred*minblue*mingreen

# main

sum=0
with open("input.txt","r") as f:
        lines = f.readlines()
        print(lines[1])
        for line in lines:
            game = int(line.split(' ')[1].removesuffix(':'))
            rounds = line.split(';')
            rounds[0] = rounds[0].split(':')[1]
            #sum+= game if validgame(rounds) else 0 #for part 1
            sum+=powerofcubesingame(rounds) #part 2
print(sum)