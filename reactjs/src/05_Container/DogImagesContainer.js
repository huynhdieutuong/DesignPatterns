import React from 'react';
import DogImages from './DogImages';
import useDogImages from './useDogImages';

const DogImagesContainer = () => {
  const [loading, dogs] = useDogImages(
    'https://dog.ceo/api/breed/labrador/images/random/6'
  );

  if (loading) return <div>Loading</div>;

  return <DogImages dogs={dogs} />;
};

export default DogImagesContainer;
