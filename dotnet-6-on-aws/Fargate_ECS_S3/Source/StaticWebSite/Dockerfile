# Use an official NGINX image as the base image
FROM nginx

# Copy the static files into the NGINX image
COPY ./www /usr/share/nginx/html

# Copy the NGINX configuration file into the NGINX image
COPY ./nginx.conf /etc/nginx/nginx.conf

# Expose port 80 for incoming traffic
EXPOSE 80

# Start NGINX when the container is run
CMD ["nginx", "-g", "daemon off;"]
