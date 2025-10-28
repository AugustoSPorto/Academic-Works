def main():
    filter = input().lower()
    format_used = input()
    dim = [int(i) for i in input().split()]
    collums = dim[0]
    rows = dim[1]
    max_pmg_value = int(input())
    new_matrix = []
    original_matrix = matrix(rows)
    new_matrix = modify_matrix(original_matrix,filter,max_pmg_value)
    print_matrix(new_matrix,max_pmg_value)

def matrix(num_r):
    res = []
    for i in range(num_r):
        res.append([int(i) for i in input().split()])
    return res

def print_matrix(matrix,max_pmg_value):
    print(f'P2\n{len(matrix[0])} {len(matrix)}\n{max_pmg_value}')
    for i in range(len(matrix)):
        for j in range(len(matrix[0])):
            if j == len(matrix[0])-1:
                print(matrix[i][j])
            else:
                print(matrix[i][j], end = " ")

def modify_matrix(matrix,filter,max_pmg_value):
    if filter == "negativo":
        matrix = negative_inverted_filter(matrix,max_pmg_value)
    elif filter == "edge-detect":
        matrix = edge_detect_filter(matrix,max_pmg_value)
    elif filter == "blur":
        matrix = blur_filter(matrix,max_pmg_value)
    elif filter == "sharpen":
        matrix = sharpen_filter(matrix,max_pmg_value)
    else:
        matrix = median_filter(matrix)
    return matrix
    
def negative_inverted_filter(matrix,max_pmg_value):
    for i in range(len(matrix)):
        for j in range(len(matrix[0])):
            matrix [i][j] = max_pmg_value - matrix[i][j]
    return matrix

def convolution(matrix,max_pmg_value,a,b,c,d,e,f,g,h,i,D):
    convoluted_matrix = [[] for x in range(len(matrix)-2)]

    for x in range(1,len(matrix)-1):
        for j in range(1,len(matrix[0])-1):
            l1 = a*matrix[x-1][j-1] + b*matrix[x-1][j] + c*matrix[x-1][j+1]
            l2 = d*matrix[x][j-1] + e*matrix[x][j] + f*matrix[x][j+1]
            l3 = g*matrix[x+1][j-1] + h*matrix[x+1][j] + i*matrix[x+1][j+1]
            if (l1+l2+l3)//D > max_pmg_value:
                convoluted_matrix[x-1].append(max_pmg_value)
            elif (l1+l2+l3)//D < 0:
                convoluted_matrix[x-1].append(0)
            else:
                convoluted_matrix[x-1].append((l1+l2+l3)//D)
    return convoluted_matrix

def edge_detect_filter(matrix,max_pmg_value):
    matrix = convolution(matrix,max_pmg_value,a=-1,b=-1,c=-1,d=-1,e=8,f=-1,g=-1,h=-1,i=-1,D=1)
    return matrix

def blur_filter(matrix,max_pmg_value):
    matrix = convolution(matrix,max_pmg_value,a=1,b=1,c=1,d=1,e=1,f=1,g=1,h=1,i=1,D=9)
    return matrix

def sharpen_filter(matrix,max_pmg_value):
    matrix = convolution(matrix,max_pmg_value,a=0,b=-1,c=0,d=-1,e=5,f=-1,g=0,h=-1,i=0,D=1)
    return matrix

def median_filter(matrix):
    median_matrix = [[] for x in range(len(matrix))]
    for i in range(len(matrix)):
        for j in range(len(matrix[0])):
            median_matrix[i].append(69)

    for i in range(len(matrix)):
        for j in range(len(matrix[0])):
            if (i == 0) and (j == 0):
                arr = []
                arr.append(matrix[i][j])
                arr.append(matrix[i][j+1])
                arr.append(matrix[i+1][j])
                arr.append(matrix[i+1][j+1])
                arr.sort()
                #print(arr)
                median_matrix[i][j] = median_value(arr)

            elif (i == 0) and (j == (len(matrix[0])-1)):
                arr = []
                arr.append(matrix[i][j-1])
                arr.append(matrix[i][j])
                arr.append(matrix[i+1][j-1])
                arr.append(matrix[i+1][j])
                arr.sort()
                #print(arr)
                median_matrix[i][j] = median_value(arr)

            elif (i == (len(matrix)-1)) and (j == 0):
                arr = []
                arr.append(matrix[i-1][j])
                arr.append(matrix[i-1][j+1])
                arr.append(matrix[i][j])
                arr.append(matrix[i][j+1])
                arr.sort()
                #print(arr)
                median_matrix[i][j] = median_value(arr)

            elif (i == (len(matrix)-1)) and (j == (len(matrix[0])-1)):
                arr = []
                arr.append(matrix[i-1][j-1])
                arr.append(matrix[i-1][j])
                arr.append(matrix[i][j-1])
                arr.append(matrix[i][j])
                arr.sort()
                #print(arr)
                median_matrix[i][j] = median_value(arr)

            elif (i == 0 and (j > 0)) and (j < (len(matrix[0])-1)):
                arr = []
                arr.append(matrix[i][j-1])
                arr.append(matrix[i][j])
                arr.append(matrix[i][j+1])
                arr.append(matrix[i+1][j-1])
                arr.append(matrix[i+1][j])
                arr.append(matrix[i+1][j+1])
                arr.sort()
                #print(arr)
                median_matrix[i][j] = median_value(arr)

            elif (i == (len(matrix)-1)) and (j > 0) and (j < (len(matrix[0])-1)):
                arr = []
                arr.append(matrix[i-1][j-1])
                arr.append(matrix[i-1][j])
                arr.append(matrix[i-1][j+1])
                arr.append(matrix[i][j-1])
                arr.append(matrix[i][j])
                arr.append(matrix[i][j+1])
                arr.sort()
                #print(arr)
                median_matrix[i][j] = median_value(arr)

            elif (j == 0) and (i > 0) and (i < (len(matrix[0]))):
                arr = []
                arr.append(matrix[i-1][j])
                arr.append(matrix[i-1][j+1])
                arr.append(matrix[i][j])
                arr.append(matrix[i][j+1])
                arr.append(matrix[i+1][j])
                arr.append(matrix[i+1][j+1])
                arr.sort()
                #print(arr)
                median_matrix[i][j] = median_value(arr)

            elif (j == (len(matrix[0])-1)) and (i > 0) and (i < (len(matrix)-1)):
                arr = []
                arr.append(matrix[i-1][j-1])
                arr.append(matrix[i-1][j])
                arr.append(matrix[i][j-1])
                arr.append(matrix[i][j])
                arr.append(matrix[i+1][j-1])
                arr.append(matrix[i+1][j])
                arr.sort()
                #print(arr)
                median_matrix[i][j] = median_value(arr)

            elif (i > 0) and (i < (len(matrix)-1)) and (j > 0) and (j < (len(matrix[0])-1)):
                arr = []
                arr.append(matrix[i-1][j-1])
                arr.append(matrix[i-1][j])
                arr.append(matrix[i-1][j+1])
                arr.append(matrix[i][j-1])
                arr.append(matrix[i][j])
                arr.append(matrix[i][j+1])
                arr.append(matrix[i+1][j-1])
                arr.append(matrix[i+1][j])
                arr.append(matrix[i+1][j+1])
                arr.sort()
                #print(arr)
                median_matrix[i][j] = median_value(arr)

    return median_matrix

def median_value(arr):
    res = 0
    if (len(arr)%2) == 0:
        res = (arr[(len(arr)-1)//2]+arr[((len(arr)-1)//2)+1])/2
    else:
        res = (arr[((len(arr)-1)//2)])
    return int(res)


main()