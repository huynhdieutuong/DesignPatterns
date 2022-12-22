import React from 'react';
import Image from './Image';

const sources = [
  'https://images.pexels.com/photos/939478/pexels-photo-939478.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260',
  'https://images.pexels.com/photos/1692984/pexels-photo-1692984.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260',
  'https://images.pexels.com/photos/162829/squirrel-sciurus-vulgaris-major-mammal-mindfulness-162829.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260',
];

const ImageList = () => {
  return (
    <div className="image-list">
      {sources.map((source, i) => (
        <Image key={i} source={source} />
      ))}
    </div>
  );
};

export default ImageList;
