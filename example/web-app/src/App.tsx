import * as React from 'react';
import { useEffect, useState } from 'react';

export default () => {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    loadProducts();
  }, []);

  async function loadProducts() {
    const response = await fetch(`${process.env.PRODUCTS_API_URL}/api/values`);
    const data = await response.json();
    setProducts(data);
  }

  return (
    <>
      <h1>Web-App Example (FETCH API)</h1>
      <pre>{JSON.stringify(products, null, 2)}</pre>
    </>
  );
};
