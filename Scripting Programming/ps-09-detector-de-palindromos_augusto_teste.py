def main():
    n = int(input())
    ans = {}
    for i in range(n):
        phrase = [j for j in input().split()]
        for word in phrase:
            word = word.lower().strip(".,:;!?")
            if palin(list(word)):
                if word in ans:
                    ans[word] += 1
                else:
                    ans[word] = 1
    #print(ans)
    prtdict(ans)

def palin(str):
    for i in range(len(str)-1):
        if str[i] != str[len(str)-1-i]:
            return False
    return True

def prtdict(dict):
    words = list(dict.keys())
    values = list(dict.values())
    for i in range(len(words)):
        print(f'{words[i]} {values[i]}')

main()