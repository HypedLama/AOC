times = []
distances = []
solution = 1

with open("example.txt") as f:
    for substr in f.readline().split():
        if(substr.isdigit()):
            times.append(int(substr))
    for substr in f.readline().split():
        if(substr.isdigit()):
            distances.append(int(substr))

for dindex,time in enumerate(times):
    distance = distances[dindex]
    wins = 0
    for ms in range(time):
        if(ms*(time-ms) > distance):
            wins+=1
    solution = solution*wins if wins>0 else solution

print(solution) ## remove spaces between numbers for part 2
