import matplotlib.pyplot as plt

# Dados extraídos da sua imagem
threads = [1, 2, 4, 8]

# Grupo 1 (N = 100)
y_100 = [0.08, 0.03, 0.04, 0.05]

# Grupo 2 (N = 1.000)
y_1000 = [0.28, 0.25, 0.40, 0.61]

# Grupo 3 (N = 10.000)
y_10000 = [0.55, 0.66, 0.79, 1.50]

# Configuração da plotagem (3 gráficos lado a lado)
fig, (ax1, ax2, ax3) = plt.subplots(1, 3, figsize=(15, 5))

# Gráfico 1 - N=100
ax1.plot(threads, y_100, marker='o', color='red', linestyle='None')
ax1.set_title('Speedup (N=100)')
ax1.set_xlabel('Threads')
ax1.set_ylabel('Speedup (x)')
ax1.grid(True, linestyle='--', alpha=0.7)
ax1.set_xticks(threads)

# Gráfico 2 - N=1.000
ax2.plot(threads, y_1000, marker='o', color='blue', linestyle='None')
ax2.set_title('Speedup (N=1.000)')
ax2.set_xlabel('Threads')
ax2.set_ylabel('Speedup (x)')
ax2.grid(True, linestyle='--', alpha=0.7)
ax2.set_xticks(threads)

# Gráfico 3 - N=10.000
ax3.plot(threads, y_10000, marker='o', color='green', linestyle='None')
ax3.set_title('Speedup (N=10.000)')
ax3.set_xlabel('Threads')
ax3.set_ylabel('Speedup (x)')
ax3.grid(True, linestyle='--', alpha=0.7)
ax3.set_xticks(threads)

# Ajusta o layout e salva
plt.tight_layout()
plt.savefig('graficos_speedup.png')
plt.show()