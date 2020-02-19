# Products API

## GET

```
curl http://localhost:8080/api/products
```

```
curl http://localhost:8080/api/products/1
```

## POST

```
curl -XPOST http://localhost:8080/api/products \
  -H 'Content-Type: application/json' \
  -d '{"price": 1.1, "description": "Product A" }'
```
