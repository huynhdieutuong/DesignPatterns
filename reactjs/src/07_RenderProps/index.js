import React from 'react';
import Fahrenheit from './Fahrenheit';
import Input from './Input';
import Kelvin from './Kelvin';
import './styles.css';

const AppRenderProps = () => {
  // value control by Input that can pass to Kelvin and Fahrenheit through Render Props
  // With Render Props pattern, we can change the content (Kelvin and Fahrenheit) without change Input (Open-Close principle)
  // Key: renderProps is a function, so we can pass value from Input (renderProps(value)) and get this value in App (No need to move value and setValue from Input to App)

  return (
    <div className="App">
      <h1>☃️ Temperature Converter 🌞</h1>
      <Input
        renderProps={(value) => (
          <>
            <Kelvin value={value} />
            <Fahrenheit value={value} />
          </>
        )}
      />
    </div>
  );
};

export default AppRenderProps;
