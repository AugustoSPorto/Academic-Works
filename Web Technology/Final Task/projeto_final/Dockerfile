# 1. Imagem base com Node
FROM node:20-alpine

# 2. Define o diretório de trabalho
WORKDIR /app

# 3. Copia package.json e package-lock.json para instalar dependências
COPY package*.json ./

# 4. Instala dependências
RUN npm install

# 5. Copia o restante do código
COPY . .

# 6. Expõe a porta que o Vite usa
EXPOSE 5173

# 7. Comando para rodar o servidor de desenvolvimento
CMD ["npm", "run", "dev", "--", "--host"]

