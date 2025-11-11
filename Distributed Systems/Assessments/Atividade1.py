import threading 
import numpy as np

def increment(): 
    global counter 
    for _ in range(10000): 
        # Lê o valor
        temp = counter
        
        # Força um "context switch" contornando o GIL (Global Interpreter Lock)
        _ = np.zeros(130)
        # Escreve o valor
        counter = temp + 1
        
for _ in range(10):
    counter = 0
    threads = []
    
    for _ in range(10):
        thread = threading.Thread(target=increment)
        threads.append(thread)
        thread.start()
        
    for thread in threads:
        thread.join()
        
    print(f"Resultado: {counter}")