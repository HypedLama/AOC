
def checknearby(number:str,lines,l:int,i:int):
    if l >0: #check above
        startindex = i - len(number)-1 if i - len(number)-1 >=0 else i-len(number)
        endindex = i if i < len(lines[l]) else i-1
        for char in lines[l-1][startindex:endindex+1]:
            if not char.isdigit() and char != "." and char != "\n":
                return True
    if l<len(lines)-1:  #check below
        startindex = i - len(number)-1 if i - len(number)-1 >=0 else i-len(number)
        endindex = i if i < len(lines[l]) else i-1
        for char in lines[l+1][startindex:endindex+1]:
            if not char.isdigit() and char != "." and char != "\n":
                return True
    if i<=len(lines[l]):#check right
        if not lines[l][i].isdigit() and lines[l][i] != "." and lines[l][i] != "\n":
            return True
    if i>0: #check left
        char = lines[l][i-len(number)-1]
        if not char.isdigit() and char != "." and char != "\n":
            return True

sum=0
with open("input.txt") as file:
    lines = file.readlines()
    for l in range(len(lines)):
        number = ""
        for i in range(len(lines[l])):
            if lines[l][i].isdigit():
                number+= lines[l][i]
            elif not lines[l][i].isdigit():
                if number != "" and checknearby(number,lines,l,i):
                    print(number)
                    sum+= int(number)
                number = ""      
print(sum)