
def checknearby(number:str,lines,l:int,i:int):
    if l >0:
        startindex = i - len(number)-1 if i - len(number)-1 >=0 else i-len(number)
        endindex = i if i < len(lines[l]) else i-1
        for x,char in enumerate(lines[l-1][startindex:endindex+1]):
            if char == "*":
                return l,x,number
    if l<len(lines)-1:
        startindex = i - len(number)-1 if i - len(number)-1 >=0 else i-len(number)
        endindex = i if i < len(lines[l]) else i-1
        for x,char in enumerate(lines[l+1][startindex:endindex+1]):
            if char == "*":
                return l,x,number
    if i<=len(lines[l]):
        if lines[l][i] == "*":
            return l,i,number
    if i>0:
        if lines[l][i-len(number)-1] == "*":
            return l,i-len(number)-1,number
    return -1,-1,"-1"

sum=0
with open("example.txt") as file:
    lines = file.readlines()
    cogs = []
    for l in range(len(lines)):
        number = ""
        for i in range(len(lines[l])):
            if lines[l][i].isdigit():
                number+= lines[l][i]
            elif not lines[l][i].isdigit():
                if number != "" and checknearby(number,lines,l,i)[0] !=-1:
                    cogs.append(checknearby(number,lines,l,i))
                number = ""
    print(cogs)


                
print(sum)