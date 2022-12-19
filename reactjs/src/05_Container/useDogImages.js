import { useEffect, useState } from 'react';

const useDogImages = (url) => {
  const [dogs, setDogs] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    fetch(url)
      .then((res) => res.json())
      .then((data) => {
        setDogs(data.message);
        setLoading(false);
      });
  }, [url]);

  return [loading, dogs];
};

export default useDogImages;
