#stage 1
FROM node:latest as node
WORKDIR /app
COPY . .
RUN npm install
RUN npm run build --prod
# RUN npm start tak tez moge odpalic


#stage 2
FROM nginx:alpine
COPY --from=node /app/dist/animal-shelter /usr/share/nginx/html

