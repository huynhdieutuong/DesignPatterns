import React from 'react';
import DogImages from './DogImages';
import useDogImages from './useDogImages';

const DogImagesContainer = () => {
  const dogs = useDogImages(
    'https://dog.ceo/api/breed/labrador/images/random/6'
  );

  return <DogImages dogs={dogs} />;
};

export default DogImagesContainer;
