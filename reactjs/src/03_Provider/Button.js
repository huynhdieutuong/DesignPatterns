import React from 'react';
import useCountContext from './useCountContext';

const Button = () => {
  const { count, setCount } = useCountContext();

  return (
    <div>
      <button onClick={() => setCount(count + 1)}>Increment</button>
      <div>Current count: {count}</div>
    </div>
  );
};

export default Button;
