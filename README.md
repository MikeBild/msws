# MicroServices with OpenShift and DotNet-Core

## Example

### Docker-Compose

#### Local

```
docker-compose up
```

#### Publish

```
docker-compose build
docker-compose push
```

#### OpenShift Image Stream updates

```bash
oc tag mikebild/products-api products-api:latest --scheduled
oc tag mikebild/web-app web-app:latest --scheduled
```

### OpenShift

**Convert Docker-Compose to OpenShift**

`kompose convert -f docker-compose.yml --provider=OpenShift`

**Update OpenShift**

```bash
oc apply -f ./deployments/redis-deploymentconfig.yaml
oc apply -f ./deployments/redis-imagestream.yaml
oc apply -f ./deployments/redis-service.yaml
```

```bash
oc apply -f ./deployments/products-api-deploymentconfig.yaml
oc apply -f ./deployments/products-api-imagestream.yaml
oc apply -f ./deployments/products-api-service.yaml
```

```bash
oc apply -f ./deployments/web-app-deploymentconfig.yaml
oc apply -f ./deployments/web-app-imagestream.yaml
oc apply -f ./deployments/web-app-service.yaml
```

**Expose Service**

```bash
oc expose svc/products-api
oc expose svc/web-app
```

**Delete OpenShift Deployments**

```bash
oc delete all -l io.kompose.service=redis
oc delete all -l io.kompose.service=products-api
oc delete all -l io.kompose.service=web-app
```

## Links

### Docker

### Docker Compose

https://docs.docker.com/compose/

### OpenShift und Docker

https://torstenwalter.de/minishift/openshift/docker/registry/2017/07/25/build-docker-image-and-upload-to-openshift-registry.html

https://access.redhat.com/documentation/en-us/net_core/2.2/html-single/getting_started_guide/index
