FROM registry.redhat.io/rhel8/nodejs-12
USER root
WORKDIR /app
COPY . .
RUN npm install
RUN npm run clean
RUN npm run build
ENTRYPOINT ["npm", "start"]
