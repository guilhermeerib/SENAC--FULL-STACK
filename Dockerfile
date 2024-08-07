FROM node:20 AS builder
WORKDIR /app
COPY . .
RUN npm install
# RUN npm run build
CMD [ "ng","serve" ]
EXPOSE 80

# FROM nginx:alpine
# COPY --from=builder app/dist/Frontend/browser /usr/share/nginx/html
# COPY nginx.conf /etc/nginx/nginx.conf
# COPY mime.types /etc/nginx/mime.types
# EXPOSE 80
# CMD ["nginx", "-g", "daemon off;"]
