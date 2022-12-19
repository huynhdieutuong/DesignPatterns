import React from 'react';

const DogImages = ({ dogs }) => {
  return dogs.map((dog, i) => <img src={dog} key={i} alt="Dog" />);
};

export default DogImages;
