# Usar a imagem base oficial do Node.js (versão LTS recomendada)
FROM node:18-alpine AS build

# Definir o diretório de trabalho dentro do contêiner
WORKDIR /app

# Copiar o arquivo package.json e o package-lock.json para o contêiner
COPY package*.json ./

# Instalar as dependências do projeto
RUN npm install

# Copiar o código da aplicação para o contêiner
COPY . .

# Construir a aplicação para produção
RUN npm run build

# Usar o nginx como servidor web para servir os arquivos estáticos
FROM nginx:alpine AS production

# Copiar os arquivos de build para o diretório do Nginx
COPY --from=build /app/dist /usr/share/nginx/html

# Expor a porta 5173 (ou a porta que você definir)
EXPOSE 5173

# Iniciar o Nginx
CMD ["nginx", "-g", "daemon off;"]
