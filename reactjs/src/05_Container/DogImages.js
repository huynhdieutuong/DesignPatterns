import { Alert } from '@mui/material';
import React from 'react';
import withHover from './withHover';

const DogImages = ({ hovering, dogs, onMouseEnter, onMouseLeave }) => {
  return (
    <>
      {hovering && <Alert severity="info">Hovering</Alert>}
      {dogs.map((dog, i) => (
        <img
          src={dog}
          key={i}
          alt="Dog"
          onMouseEnter={onMouseEnter}
          onMouseLeave={onMouseLeave}
        />
      ))}
    </>
  );
};

export default withHover(DogImages);
