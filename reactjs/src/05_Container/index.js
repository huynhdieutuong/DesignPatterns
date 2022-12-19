import React from 'react';
import DogImagesContainer from './DogImagesContainer';

const AppContainer = () => {
  return (
    <div>
      <h1>
        Browse Dog Images{' '}
        <span role="img" aria-label="emoji">
          🐕
        </span>
      </h1>
      {/* Container/Presentational Pattern and Hooks:
      1. Container Components: fetching data (useDogImages) and pass data to presentational components
      2. Presentational Components: display data it receives without modifying that data (pure functions)
      */}
      <DogImagesContainer />
    </div>
  );
};

export default AppContainer;
