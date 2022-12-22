import React from 'react';
import FlyOutMenu from './FlyOutMenu';

const Image = ({ source }) => {
  return (
    <div className="image-item">
      <img src={source} alt="Squirrel" />
      <FlyOutMenu />
    </div>
  );
};

export default Image;
