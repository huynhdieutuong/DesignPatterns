import { useEffect, useState } from 'react';

const useDogImages = (url) => {
  const [dogs, setDogs] = useState([]);

  useEffect(() => {
    fetch(url)
      .then((res) => res.json())
      .then((data) => setDogs(data.message));
  }, [url]);

  return dogs;
};

export default useDogImages;
