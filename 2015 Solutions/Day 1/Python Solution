count = 0
pos = 0
posList = []

def FloorCount(x):
    global count
    global pos
    if x == "(":
        count += 1
    elif x == ")":
        count -= 1
    else:
        pass
    pos += 1
    
with open("input.txt",'r') as f:
    lines = f.readline()
    for i in lines:
        FloorCount(i)
        if count == -1:
            posList.append(pos)
    f.close()

print("Part 1: {0}\nPart 2: {1}".format(count,min(posList)))


